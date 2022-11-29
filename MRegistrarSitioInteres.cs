using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCoronado
{
    public partial class MRegistrarSitioInteres : Form
    {
        MantenedorSitiosInteres siti;
        public MRegistrarSitioInteres(MantenedorSitiosInteres si)
        {
            InitializeComponent();
            txtCodigoRegistrarSI.Enabled = false;
            siti = si;

        }
        public void limpiarVariableInterfazReg()
        {
            txtCodigoRegistrarSI.Clear();
            txtRegistrarDireccionSI.Clear();
            txtRegistrarNombreSI.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entSitioInteres Sitio = new entSitioInteres();
                Sitio.NombreSI = txtRegistrarNombreSI.Text.Trim();
                Sitio.DireccionSI = txtRegistrarDireccionSI.Text.Trim();
                Sitio.estadoSI = true;
                if (logSitioInteres.Instancia.ExisteDatosSitioInteresNombre(Sitio) && logSitioInteres.Instancia.ExisteDatosSitioInteresDireccion(Sitio))

                {
                    MessageBox.Show("Tanto el nombre como la dirección ya se encuentran en uso.");
                }
                else if (logSitioInteres.Instancia.ExisteDatosSitioInteresNombre(Sitio))
                {
                    MessageBox.Show("El Nombre ya se encuentra en uso.");
                }
                else if (logSitioInteres.Instancia.ExisteDatosSitioInteresDireccion(Sitio))
                {
                    MessageBox.Show("La Dirección ya se encuentra en uso.");
                }
                else
                {
                    logSitioInteres.Instancia.RegistrarSI(Sitio);
                    MessageBox.Show("El sitio de interes fue registrado.");
                    limpiarVariableInterfazReg();
                    siti.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarVariableInterfazReg();
            siti.Show();
            this.Hide();
        }
    }
}
