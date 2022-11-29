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
    public partial class MantenedorCiudad : Form
    {
        MenuPrincipal principal;
        RegistrarCiudad registroCiudad;
        consultarCiudad consultarCiudad;
        public MantenedorCiudad(MenuPrincipal menu)
        {
            InitializeComponent();
            principal = menu;
        }

        private void btRegistrarCiudad_Click(object sender, EventArgs e)
        {
            if (registroCiudad == null)
            {
                registroCiudad = new RegistrarCiudad(this);
            }
            registroCiudad.Show();
            this.Hide();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Hide();
        }

        private void btListarCiudad_Click(object sender, EventArgs e)
        {
            if (consultarCiudad == null)
            {
                consultarCiudad = new consultarCiudad(this);
            }
            consultarCiudad.ListaCiudad();
            consultarCiudad.Show();
            this.Hide();
        }
    }
}
