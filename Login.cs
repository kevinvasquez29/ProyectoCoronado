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
    public partial class Login : Form
    {
        MenuPrincipal principal;
        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptarLogin_Click(object sender, EventArgs e)
        {
            try
            {
                entAgente agente = new entAgente();
                agente.correo = txtNombreDeUsuario.Text;
                agente.contraseña = txtContraseña.Text;
                if (logAgente.Instancia.IngresarAgente(agente))
                {
                    if (principal == null)
                    {
                        principal = new MenuPrincipal(this);
                    }
                    MessageBox.Show("Bienvenido");
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario incorrecto");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void btnCancelarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
