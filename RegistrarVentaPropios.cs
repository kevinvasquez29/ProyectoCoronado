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
    public partial class RegistrarVentaPropios : Form
    {
        MenuVentas menVentas;
        int idAux;
        public RegistrarVentaPropios(MenuVentas menu)
        {
            InitializeComponent();
            menVentas = menu;
            ListarBancos();
            btnAceptar.Enabled = false;
        }
        public void limpiarVariableInterfazReg()
        {
            txtEscrituraPublica.Clear();
            txtIDAgente.Clear();
            txtIDCita.Clear();
            txtIDCliente.Clear();
            txtIDInmueble.Clear();
            txtPrecio.Clear();
            dtpFecha.Text = "";
        }
        public void ListarBancos()
        {
            comboBoxBanco.DataSource = logBanco.Instancia.ListarBancos();
            comboBoxBanco.DisplayMember = "Nombre";
            comboBoxBanco.ValueMember = "BancoID";
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            entCita cita = new entCita();
            cita.CitaID = Convert.ToInt32(txtIDCita.Text.Trim());
            if (logCita.Instancia.BuscarCita(cita))
            {
                cita = logCita.Instancia.DatosCita(cita.CitaID);
                txtIDAgente.Text = cita.AgenteID.ToString();
                txtIDCliente.Text = cita.ClienteID.ToString();
                txtIDInmueble.Text = cita.InmuebleID.ToString();
                btnAceptar.Enabled = true;
            }
            else
            {
                MessageBox.Show("El ID de la cita no existe.");
                btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                entVenta venta = new entVenta();
                entCita cita = new entCita();
                entContrato contrato = new entContrato();

                venta.Fechaventa = DateTime.Parse(dtpFecha.Text.Trim());
                venta.BancoID = Convert.ToInt32(comboBoxBanco.SelectedValue);
                venta.CitaID = Convert.ToInt32(txtIDCita.Text.Trim());
                cita = logCita.Instancia.DatosCita(venta.CitaID);
                venta.Escriturapublica = Convert.ToInt32(txtEscrituraPublica.Text.Trim());
                venta.Precio = (float)Convert.ToDouble(txtPrecio.Text.Trim());
                contrato = logContrato.Instancia.DatosContrato();
                venta.ContratoID = contrato.ContratoID;
                if (!logVenta.Instancia.ExisteNEscritura(venta.Escriturapublica))
                {
                    logVenta.Instancia.RegistrarVenta(venta);
                    logInmueble.Instancia.VenderInmueble(cita.InmuebleID);
                    MessageBox.Show("La venta se a registrado correctamente");
                    logCita.Instancia.CitaRealizada(cita);
                    limpiarVariableInterfazReg();
                    menVentas.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El número de escritura pública ya ha sido registrada en otra venta.");
                }
                ListarBancos();
                btnAceptar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error.." + ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarVariableInterfazReg();
            menVentas.Show();
            this.Hide();
            ListarBancos();
        }
    }
}
