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
    public partial class ModificarInhabilitarCliente : Form
    {
        ConsultarCliente clien;
        public ModificarInhabilitarCliente(ConsultarCliente cl)
        {
            InitializeComponent();
            clien = cl;
        }
        public void llenarDatos(entCliente Cliente)
        {
            txtidcliente.Enabled = false;
            txtDniCliente.Enabled = false;
            checkBoxHablitar.Enabled = false;
            txtidcliente.Text = Cliente.ClienteID.ToString();
            txtDniCliente.Text = Cliente.dnicliente.ToString();
            txtNombre.Text = Cliente.nombrecliente.ToString();
            txtApellido.Text = Cliente.apelcliente.ToString();
            txtCelular.Text = Cliente.celcliente.ToString();
            checkBoxHablitar.Checked = Cliente.estadocliente;
        }

        public void limpiarVariableInterfazMod()
        {
            txtDniCliente.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCelular.Clear();
        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente Cli = new entCliente();
                Cli.ClienteID = int.Parse(txtidcliente.Text.Trim());
                Cli.dnicliente = int.Parse(txtDniCliente.Text.Trim());
                Cli.nombrecliente = txtNombre.Text.Trim();
                Cli.apelcliente = txtApellido.Text.Trim();
                Cli.celcliente = int.Parse(txtCelular.Text.Trim());
                if (logCliente.Instancia.ExisteDatosClienteCelular(Cli))
                {
                    MessageBox.Show("El celular ya se encuentra en uso.");
                }
                else
                {
                    logCliente.Instancia.ModificarCliente(Cli);
                    MessageBox.Show("Se editaron correctamente los datos del Cliente.");
                    clien.ListarClientes();
                    clien.limpiarVariableConsultar();
                    limpiarVariableInterfazMod();
                    clien.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente Cliente = new entCliente();
                Cliente.ClienteID = int.Parse(txtidcliente.Text.Trim());
                checkBoxHablitar.Checked = false;
                Cliente.estadocliente = checkBoxHablitar.Checked;
                logCliente.Instancia.DeshabilitarCliente(Cliente);
                MessageBox.Show("El cliente a sido deshabilitado correctamente");
                clien.ListarClientes();
                clien.limpiarVariableConsultar();
                limpiarVariableInterfazMod();
                clien.Show();
                this.Hide();
            }
            catch (Exception exe)
            {
                throw exe;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clien.ListarClientes();
            clien.limpiarVariableConsultar();
            limpiarVariableInterfazMod();
            clien.Show();
            this.Hide();
        }
    }
}
