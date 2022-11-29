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
    public partial class MenuVentas : Form
    {
        MenuPrincipal principal;
        RegistrarVentaPropios regVentaPropio;
        ConsultarVentas consultaVenta;

        public MenuVentas(MenuPrincipal menu)
        {
            InitializeComponent();
            principal = menu;
        }

        private void btVentaPropio_Click(object sender, EventArgs e)
        {
            if (regVentaPropio == null)
            {
                regVentaPropio = new RegistrarVentaPropios(this);
            }
            regVentaPropio.ListarBancos();
            //regVentaPropio.ListarIDCita();
            regVentaPropio.Show();
            this.Hide();
        }

        private void btConsultarVenta_Click(object sender, EventArgs e)
        {
            if (consultaVenta == null)
            {
                consultaVenta = new ConsultarVentas(this);
            }
            consultaVenta.ListarCita();
            consultaVenta.ListarVenta();
            consultaVenta.Show();
            this.Hide();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Hide();
        }
    }
}
