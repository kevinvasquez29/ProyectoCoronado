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
    public partial class MModificarSector : Form
    {
        InmuebleMostrarSector secmostr;
        public MModificarSector(InmuebleMostrarSector sectmost)
        {
            InitializeComponent();
            secmostr = sectmost;
        }
        public void llenarDatos(entSector sec)
        {
            txtIngresoIDSector.Enabled = false;
            txtIngresoIDSector.Text = sec.SectorID.ToString();
            txtNombreSector.Text = sec.Nombresector.ToString();
            txtComentario.Text = sec.Comentario.ToString();
        }
        public void limpiarVariableInterfazMod()
        {
            txtIngresoIDSector.Clear();
            txtNombreSector.Clear();
            txtComentario.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                entSector sector = new entSector();
                sector.Nombresector = txtNombreSector.Text.Trim();
                if (!logSector.Instancia.ExisteDatosSector(sector.Nombresector))
                {
                    sector.SectorID = int.Parse(txtIngresoIDSector.Text.Trim());
                    sector.Comentario = txtComentario.Text.Trim();
                    logSector.Instancia.ModificarSector(sector);
                    MessageBox.Show("Se editaron correctamente los datos del sector.");
                    limpiarVariableInterfazMod();
                    secmostr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El nombre ya existe");
                }




                secmostr.ListarSectores();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            secmostr.Show();
            this.Hide();
        }
    }
}
