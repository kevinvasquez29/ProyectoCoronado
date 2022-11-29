using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace ProyectoCoronado
{
    public partial class MenuPrincipal : Form
    {
        Login log;
        entAgente Agente = new entAgente();
        MantenedorCliente cliente;
        MantenedorAgente agente;
        MantenedorBanco banco;
        MantenedorCiudad ciudad;
        MantenedorSitiosInteres sitio;
        MantenedorCliPropietario propietario;
        Inmueble inmueble;
        MenuVentas venta;
        MCita cita;
        MantenedorSector sector;
        public MenuPrincipal(Login login)
        {
            InitializeComponent();
            log = login;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btAgente_Click(object sender, EventArgs e)
        {
            if (agente == null)
            {
                agente = new MantenedorAgente(this);
            }
            this.Hide();
            agente.Show();
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                cliente = new MantenedorCliente(this);
            }
            this.Hide();
            cliente.Show();
        }

        private void btCiudad_Click(object sender, EventArgs e)
        {
            if (ciudad == null)
            {
                ciudad = new MantenedorCiudad(this);
            }
            this.Hide();
            ciudad.Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
