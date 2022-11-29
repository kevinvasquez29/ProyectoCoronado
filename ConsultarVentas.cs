using CapaLogica;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoCoronado
{
    public partial class ConsultarVentas : Form
    {
        MenuVentas menVentas;
        public ConsultarVentas(MenuVentas men)
        {
            InitializeComponent();
            menVentas = men;
            ListarVenta();
            ListarCita();
        }

        public void ListarVenta()
        {
            dataGridViewVenta.DataSource = logVenta.Instancia.ListarVenta();
        }
        public void ListarCita()
        {
            dataGridViewCita.DataSource = logCita.Instancia.ListarCitasVenta();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            menVentas.Show();
            this.Hide();
        }
    }
}
