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

        private void btPropietario_Click(object sender, EventArgs e)
        {
            if (propietario == null)
            {
                propietario = new MantenedorCliPropietario(this);
            }
            propietario.Show();
            this.Hide();
        }

        private void btVenta_Click(object sender, EventArgs e)
        {
            if (venta == null)
            {
                venta = new MenuVentas(this);
            }
            venta.Show();
            this.Hide();
        }

        private void btBanco_Click(object sender, EventArgs e)
        {
            if (banco == null)
            {
                banco = new MantenedorBanco(this);
            }
            this.Hide();
            banco.Show();
        }

        private void btSitioInteres_Click(object sender, EventArgs e)
        {
            if (sitio == null)
            {
                sitio = new MantenedorSitiosInteres(this);
            }
            sitio.Show();
            this.Hide();
        }

        private void btInmueble_Click(object sender, EventArgs e)
        {
            if (inmueble == null)
            {
                inmueble = new Inmueble(this);
            }
            inmueble.Show();
            this.Hide();
        }

        private void btCita_Click(object sender, EventArgs e)
        {
            if (cita == null)
            {
                cita = new MCita(this);
            }
            cita.Show();
            this.Hide();
        }

        private void btSector_Click(object sender, EventArgs e)
        {
            if (sector == null)
            {
                sector = new MantenedorSector(this);
            }
            sector.Show();
            this.Hide();
        }
    }
}
