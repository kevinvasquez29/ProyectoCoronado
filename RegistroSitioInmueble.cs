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
    public partial class RegistroSitioInmueble : Form
    {
        MantenedorSitiosInteres mantSitioInteres;
        public RegistroSitioInmueble(MantenedorSitiosInteres mant)
        {
            InitializeComponent();
            mantSitioInteres = mant;
            ListarSitioInteres();
        }
        public void limpiarVariableInterfazReg()
        {
            txtDsitancia.Clear();
            txtIdInmuebleC.Clear();
            txtIdSitioInteress.Clear();
            comboBoxTipoInmueble.Text = "";
        }
        public void ListarSitioInteres()
        {
            SitioDeInteresVista.DataSource = logSitioInteres.Instancia.ListarSitioInteres();
        }

        private void BtRegistrarSiti_Click(object sender, EventArgs e)
        {
            try
            {
                entSitioInmueble sitioInmueble = new entSitioInmueble();
                sitioInmueble.InmuebleID = int.Parse(txtIdInmuebleC.Text);
                sitioInmueble.SitiodeinteresID = int.Parse(txtIdSitioInteress.Text);
                sitioInmueble.Distancia = int.Parse(txtDsitancia.Text);
                if (!logSitioInmueble.Instancia.ExisteSitioInmueble(sitioInmueble))
                {
                    logSitioInmueble.Instancia.RegistrarSitioInmueble(sitioInmueble);
                    MessageBox.Show("Se registro correctamente el sitio inmueble");
                    limpiarVariableInterfazReg();
                }
                else
                {
                    MessageBox.Show("El sitio inmueble ingresado ya está registrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error.." + ex);
            }
        }

        private void btnCancerlarModificarSI_Click(object sender, EventArgs e)
        {
            limpiarVariableInterfazReg();
            mantSitioInteres.Show();
            this.Hide();
        }

        private void comboBoxTipoInmueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipo;
            tipo = comboBoxTipoInmueble.SelectedIndex + 1;
            switch (tipo)
            {
                case 1:
                    InmueblesVista.DataSource = logInmueble.Instancia.ListarInmuebleCasa();
                    break;
                case 2:
                    InmueblesVista.DataSource = logInmueble.Instancia.ListarInmuebleDepartamento();
                    break;
                case 3:
                    InmueblesVista.DataSource = logInmueble.Instancia.ListarInmuebleTerreno();
                    break;
            }
        }
    }
}
