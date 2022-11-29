using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace ProyectoCoronado
{
    public partial class ModificarInhabilitarCiudad : Form
    {
        consultarCiudad ciuda;
        public ModificarInhabilitarCiudad(consultarCiudad ciu)
        {
            InitializeComponent();
            ciuda = ciu;
        }

        public void llenarDatos(entCiudad Ciudad)
        {
            txtCodCiudad.Enabled = false;
            txtCodCiudad.Text = Ciudad.CiudadID.ToString();
            txtNombreCiudad.Text = Ciudad.nombrCiudad.ToString();
            textCódigoPostal.Text = Ciudad.postalCiudad.ToString();
            textReferenciasCiudad.Text = Ciudad.referenciasCiudad.ToString();
        }
        public void limpiarVariableInterfazMod()
        {
            txtNombreCiudad.Clear();
            textCódigoPostal.Clear();
            textReferenciasCiudad.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCiudad ciudad = new entCiudad();
                ciudad.CiudadID = int.Parse(txtCodCiudad.Text.Trim());
                ciudad.nombrCiudad = txtNombreCiudad.Text.Trim();
                ciudad.postalCiudad = int.Parse(textCódigoPostal.Text.Trim());
                ciudad.referenciasCiudad = textReferenciasCiudad.Text.Trim();
                if (logCiudad.Instancia.ExisteDatosCiudadNombre(ciudad))
                {
                    MessageBox.Show("El nombre de la ciudad ya está en uso.");
                }
                else
                {
                    logCiudad.Instancia.ModificarCiudad(ciudad);
                    MessageBox.Show("Se editaron correctamente la ciudad");
                    ciuda.ListaCiudad();
                    ciuda.limpiarVariableConsultar();
                    limpiarVariableInterfazMod();
                    ciuda.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ciuda.ListaCiudad();
            ciuda.limpiarVariableConsultar();
            limpiarVariableInterfazMod();
            ciuda.Show();
            this.Close();
        }
    }
}
