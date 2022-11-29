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
    public partial class MantenedorSitiosInteres : Form
    {
        MenuPrincipal principal;
        MRegistrarSitioInteres RegistrarSI;
        ConsultarSitiosInteres consultaSI;
        RegistroSitioInmueble registrarSitioInmueble;
        ConsultarSitioInmueble consultaSitioInmueble;
        public MantenedorSitiosInteres(MenuPrincipal menu)
        {
            InitializeComponent();
            principal = menu;
        }

        private void lbSitioInteres_Click(object sender, EventArgs e)
        {

        }

        private void btRegistrarSitio_Click(object sender, EventArgs e)
        {
            if (RegistrarSI == null)
            {
                RegistrarSI = new MRegistrarSitioInteres(this);
            }

            RegistrarSI.Show();
            this.Hide();
        }

        private void btnListarSI_Click(object sender, EventArgs e)
        {
            if (consultaSI == null)
            {
                consultaSI = new ConsultarSitiosInteres(this);
            }
            consultaSI.listarSitioInteres();
            consultaSI.Show();
            this.Hide();
        }

        private void btnregistrarSitioInmueble_Click(object sender, EventArgs e)
        {
            if (registrarSitioInmueble == null)
            {
                registrarSitioInmueble = new RegistroSitioInmueble(this);
            }
            registrarSitioInmueble.ListarSitioInteres();
            this.Hide();
            registrarSitioInmueble.Show();
        }

        private void btnConsultarSitioInmueble_Click(object sender, EventArgs e)
        {
            if (consultaSitioInmueble == null)
            {
                consultaSitioInmueble = new ConsultarSitioInmueble(this);
            }
            consultaSitioInmueble.ListarInmueble();
            consultaSitioInmueble.Show();
            this.Hide();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Hide();
        }
    }
}
