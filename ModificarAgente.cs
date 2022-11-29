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
    public partial class ModificarAgente : Form
    {
        ConsultarAgente consulta;
        public ModificarAgente(ConsultarAgente consult)
        {
            InitializeComponent();
            consulta = consult;
        }

        public void llenarDatos(entAgente Agente)
        {
            txtId.Enabled = false;
            chbHabilitado.Enabled = false;
            txtId.Text = Agente.AgenteID.ToString();
            txtNombreAgente.Text = Agente.nombre.ToString();
            txtApellidoAgente.Text = Agente.apellido.ToString();
            txtCelularAgente.Text = Agente.celular.ToString();
            txtDatosCorreoElectronica.Text = Agente.correo.ToString();
            txtContraseñaDatosCliente.Text = Agente.contraseña.ToString();
            chbHabilitado.Checked = Agente.estado;
        }

        public void limpiarVariableInterfazMod()
        {
            txtId.Clear();
            txtNombreAgente.Clear();
            txtApellidoAgente.Clear();
            txtCelularAgente.Clear();
            txtDatosCorreoElectronica.Clear();
            txtContraseñaDatosCliente.Clear();
        }

        private void ModificarAgente_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entAgente Age = new entAgente();
                Age.AgenteID = int.Parse(txtId.Text.Trim());
                Age.nombre = txtNombreAgente.Text.Trim();
                Age.apellido = txtApellidoAgente.Text.Trim();
                Age.celular = int.Parse(txtCelularAgente.Text.Trim());
                Age.correo = txtDatosCorreoElectronica.Text.Trim();
                Age.contraseña = txtContraseñaDatosCliente.Text.Trim();
                if (logAgente.Instancia.ExisteDatosAgenteCorreo(Age) && logAgente.Instancia.ExisteDatosAgenteCelular(Age))
                {
                    MessageBox.Show("Tanto el correo y celular ya se encuentran en uso.");
                }
                else if (logAgente.Instancia.ExisteDatosAgenteCorreo(Age))
                {
                    MessageBox.Show("El correo ya se encuentra en uso.");
                }
                else if (logAgente.Instancia.ExisteDatosAgenteCelular(Age))
                {
                    MessageBox.Show("El celular ya se encuentra en uso.");
                }
                else
                {
                    logAgente.Instancia.ModificarAgente(Age);
                    MessageBox.Show("Se editaron correctamente los datos del agente");
                    consulta.ListarAgente();
                    consulta.limpiarVariableConsultar();
                    limpiarVariableInterfazMod();
                    consulta.Show();
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
            consulta.ListarAgente();
            consulta.limpiarVariableConsultar();
            limpiarVariableInterfazMod();
            consulta.Show();
            this.Hide();
        }

        private void btDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entAgente A = new entAgente();
                A.AgenteID = int.Parse(txtId.Text.Trim());
                chbHabilitado.Checked = false;
                A.estado = chbHabilitado.Checked;
                logAgente.Instancia.DeshabilitarAgente(A);
                MessageBox.Show("El agente a sido deshabilitado correctamente");
                consulta.ListarAgente();
                consulta.limpiarVariableConsultar();
                limpiarVariableInterfazMod();
                consulta.Show();
                this.Hide();
            }
            catch (Exception exe)
            {
                throw exe;
            }
        }
    }
}
