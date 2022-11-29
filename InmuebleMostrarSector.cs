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
    public partial class InmuebleMostrarSector : Form
    {
        MantenedorSector mansector;
        MModificarSector modifisector;
        public InmuebleMostrarSector(MantenedorSector mantensector)
        {
            InitializeComponent();
            mansector = mantensector;
            ListarSectores();
        }

        public void ListarSectores()
        {
            DataGridMostrarSector.DataSource = logSector.Instancia.ListarSector();
        }

        private void btAceptarSector_Click(object sender, EventArgs e)
        {
            try
            {
                entSector sec = new entSector();
                sec.SectorID = int.Parse(txtCodigo.Text.Trim());
                if (logSector.Instancia.BuscaSector(sec))
                {
                    if (modifisector == null)
                    {
                        modifisector = new MModificarSector(this);

                    }
                    sec = logSector.Instancia.DatosSector(sec.SectorID);
                    modifisector.llenarDatos(sec);
                    modifisector.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se encontro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            txtCodigo.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            mansector.Show();
            this.Hide();
        }
    }
}
