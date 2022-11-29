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
    public partial class RegistrarAgente : Form
    {
        MantenedorAgente MantenedorAgen;
        public RegistrarAgente(MantenedorAgente ag)
        {
            InitializeComponent();
            MantenedorAgen = ag;
            
        }
        public void limpiarVariableInterfazReg()
        {
            txtRegistraCorreoElectronicoAgente.Clear();
            txtRegistrarContraseñaAgente.Clear();
            txtApellidoAgente.Clear();
            txtCelularAgente.Clear();
            txtDniAgente.Clear();
            txtNombreAgente.Clear();
            dateTimePickerFechaNacimiento.Text = "";
        }

        private void RegistrarAgente_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarVariableInterfazReg();
            MantenedorAgen.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entAgente age = new entAgente();
                age.dni = int.Parse(txtDniAgente.Text.Trim());
                age.nombre = txtNombreAgente.Text.Trim();
                age.apellido = txtApellidoAgente.Text.Trim();
                age.Fechanacimiento = DateTime.Parse(dateTimePickerFechaNacimiento.Text.Trim());
                age.celular = int.Parse(txtCelularAgente.Text.Trim());
                age.correo = txtRegistraCorreoElectronicoAgente.Text.Trim();
                age.contraseña = txtRegistrarContraseñaAgente.Text.Trim();
                age.estado = true;

                if (logAgente.Instancia.ExisteDatosAgenteDNI(age) && logAgente.Instancia.ExisteDatosAgenteCorreo(age)
                    && logAgente.Instancia.ExisteDatosAgenteCelular(age))

                {
                    MessageBox.Show("Tanto el DNI, correo y celular ya se encuentran en uso.");
                }
                else if (logAgente.Instancia.ExisteDatosAgenteDNI(age))
                {
                    MessageBox.Show("El DNI ya se encuentra en uso.");
                }
                else if (logAgente.Instancia.ExisteDatosAgenteCorreo(age))
                {
                    MessageBox.Show("El correo ya se encuentra en uso.");
                }
                else if (logAgente.Instancia.ExisteDatosAgenteCelular(age))
                {
                    MessageBox.Show("El celular ya se encuentra en uso.");
                }
                else
                {
                    logAgente.Instancia.RegistrarAgente(age);
                    MessageBox.Show("El agente se a registrado correctamente");
                    limpiarVariableInterfazReg();
                    MantenedorAgen.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error.." + ex);
            }
        }
    }
}
