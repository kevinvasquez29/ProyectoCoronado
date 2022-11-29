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
    public partial class ConsultarSitiosInteres : Form
    {
        MantenedorSitiosInteres sitio;
        MModificarSitiosInteres modificar;
        public ConsultarSitiosInteres(MantenedorSitiosInteres sit)
        {
            InitializeComponent();
            listarSitioInteres();
            sitio = sit;
        }
        public void listarSitioInteres()
        {
            DataGridVerSitioInteres.DataSource = logSitioInteres.Instancia.ListarSitioInteres();
        }
        public void limpiarVariableConsultar()
        {
            txtCodigoSitio.Clear();
        }


        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                entSitioInteres Sitio = new entSitioInteres();
                Sitio.SitiodeinteresID = int.Parse(txtCodigoSitio.Text.Trim());
                if (logSitioInteres.Instancia.BuscarSitioInteres(Sitio))
                {
                    if (modificar == null)
                    {
                        modificar = new MModificarSitiosInteres(this);
                    }
                    Sitio = logSitioInteres.Instancia.DatosSitioInteres(Sitio.SitiodeinteresID);
                    modificar.llenarDatos(Sitio);
                    modificar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se encontró al sitio de interes.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            sitio.Show();
            this.Hide();
        }
    }
}
