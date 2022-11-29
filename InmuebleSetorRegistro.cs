using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCoronado
{
    public partial class InmuebleSetorRegistro : Form
    {
        MantenedorSector ManteSector;
        public InmuebleSetorRegistro(MantenedorSector ManteneSector)
        {

            InitializeComponent();
            ManteSector = ManteneSector;
            ListaCiudades();
        }
        public void ListaCiudades()
        {
            comboBoxCiudad.DataSource = logCiudad.Instancia.ListarCiudad();
            comboBoxCiudad.DisplayMember = "nombrCiudad";
            comboBoxCiudad.ValueMember = "CiudadID";
        }
        public void limpiarVariableInterfazReg()
        {
            txtComentarioSector.Clear();
            txtNombreSector.Clear();
            comboBoxCiudad.Text = "";
        }

        private void btnAgregarSector_Click(object sender, EventArgs e)
        {
            try
            {
                entSector sec = new entSector();
                sec.Nombresector = txtNombreSector.Text.Trim();
                if (!logSector.Instancia.ExisteDatosSector(sec.Nombresector))
                {
                    sec.CiudadID = Convert.ToInt32(comboBoxCiudad.SelectedValue);
                    sec.Nombresector = txtNombreSector.Text.Trim();
                    sec.Comentario = txtComentarioSector.Text.Trim();
                    logSector.Instancia.RegistrarSector(sec);
                    MessageBox.Show("Se registro correctamente el sector");
                    limpiarVariableInterfazReg();
                    ManteSector.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ya existe este sector");
                }

                ListaCiudades();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error..." + ex);
            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            limpiarVariableInterfazReg();
            ManteSector.Show();
            this.Hide();
        }
    }
}
