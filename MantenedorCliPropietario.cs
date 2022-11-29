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
    public partial class MantenedorCliPropietario : Form
    {
        MenuPrincipal principal;
        RegistrarCliPropietario registroCliPropietario;
        ConsultarCliPropietario consultarCliPropietario;
        public MantenedorCliPropietario(MenuPrincipal menu)
        {
            InitializeComponent();
            principal = menu;
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            if (registroCliPropietario == null)
            {
                registroCliPropietario = new RegistrarCliPropietario(this);

            }
            registroCliPropietario.Show();
            this.Hide();
        }

        private void btLista_Click(object sender, EventArgs e)
        {
            if (consultarCliPropietario == null)
            {
                consultarCliPropietario = new ConsultarCliPropietario(this);
            }
            consultarCliPropietario.listarPropietario();
            consultarCliPropietario.Show();
            this.Hide();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Hide();
        }
    }
}
