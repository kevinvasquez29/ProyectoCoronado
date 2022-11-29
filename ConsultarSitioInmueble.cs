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
    public partial class ConsultarSitioInmueble : Form
    {
        MantenedorSitiosInteres mantSitiosInteres;
        public ConsultarSitioInmueble(MantenedorSitiosInteres mant)
        {
            InitializeComponent();
            mantSitiosInteres = mant;
            ListarInmueble();
        }

        public void ListarInmueble()
        {
            datagridSitioInmueble.DataSource = logSitioInmueble.Instancia.ListarSitiosInmuebles();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            mantSitiosInteres.Show();
            this.Hide();
        }
    }
}
