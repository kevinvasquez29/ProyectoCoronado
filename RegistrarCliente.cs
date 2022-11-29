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
    public partial class RegistrarCliente : Form
    {
        MantenedorCliente clie;
        public RegistrarCliente(MantenedorCliente cl)
        {
            InitializeComponent();
            clie = cl;
        }

        public void limpiarVariableInterfazReg()
        {
            txtApellidoCliente.Clear();
            txtCelularCliente.Clear();
            txtDniCliente.Clear();
            txtNombreCliente.Clear();
            dateTimePickerFechaNacimiento.Text = "";
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {

            try
            {
                entCliente cli = new entCliente();
                cli.dnicliente = int.Parse(txtDniCliente.Text.Trim());
                cli.nombrecliente = txtNombreCliente.Text.Trim();
                cli.apelcliente = txtApellidoCliente.Text.Trim();
                cli.Fechanacimiento = DateTime.Parse(dateTimePickerFechaNacimiento.Text.Trim());
                cli.celcliente = int.Parse(txtCelularCliente.Text.Trim());
                cli.estadocliente = true;

                if (logCliente.Instancia.ExisteDatosClienteDNI(cli) && logCliente.Instancia.ExisteDatosClienteCelular(cli))
                {
                    MessageBox.Show("Tanto el DNI como el celular ya se encuentra en uso.");
                }
                else if (logCliente.Instancia.ExisteDatosClienteDNI(cli))
                {
                    MessageBox.Show("El DNI ya se encuentra en uso.");
                }
                else if (logCliente.Instancia.ExisteDatosClienteCelular(cli))
                {
                    MessageBox.Show("El celular ya se encuentra en uso.");
                }
                else
                {
                    logCliente.Instancia.RegistrarCliente(cli);
                    MessageBox.Show("El cliente se a registrado correctamente");
                    limpiarVariableInterfazReg();
                    clie.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error.." + ex);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarVariableInterfazReg();
            clie.Show();
            this.Hide();
        }
    }
}
