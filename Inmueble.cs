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
    public partial class Inmueble : Form
    {
        MenuPrincipal menu;
        MantenedorDeInmueble inmueble;
        ConsultarInmueble consultar;
        public Inmueble(MenuPrincipal me)
        {
            InitializeComponent();
            menu = me;
        }


        private void btRegistrarInmueble_Click(object sender, EventArgs e)
        {
            if (inmueble == null)
            {
                inmueble = new MantenedorDeInmueble(this);
            }
            this.Hide();
            inmueble.Show();
        }

        private void MostrarInmueble_Click(object sender, EventArgs e)
        {
            if (consultar == null)
            {
                consultar = new ConsultarInmueble(this);
            }
            this.Hide();
            consultar.Show();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }
    }
}
