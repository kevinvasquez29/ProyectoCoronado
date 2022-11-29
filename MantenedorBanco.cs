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
    public partial class MantenedorBanco : Form
    {
        MenuPrincipal principal;
        RegistroBanco registrarBanco;
        MostrandoBanco muestraBanco;
        public MantenedorBanco(MenuPrincipal menu)
        {
            InitializeComponent();
            principal = menu;
        }

        private void bt2RegistarBanco_Click(object sender, EventArgs e)
        {
            if (registrarBanco == null)
            {
                registrarBanco = new RegistroBanco(this);
            }
            registrarBanco.Show();
            this.Hide();
        }

        private void bt3MostraBanco_Click(object sender, EventArgs e)
        {
            if (muestraBanco == null)
            {
                muestraBanco = new MostrandoBanco(this);
            }
            muestraBanco.ListarBanco();
            muestraBanco.Show();
            this.Hide();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Hide();
        }
    }
}
