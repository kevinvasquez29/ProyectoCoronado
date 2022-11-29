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
    public partial class MCita : Form
    {
        MenuPrincipal principal;
        MRegistrarCita RegistroCita;
        MMostrarCita mostrarCita;
        public MCita(MenuPrincipal menu)
        {
            InitializeComponent();
            principal = menu;
        }

        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            if (RegistroCita == null)
            {
                RegistroCita = new MRegistrarCita(this);
            }

            RegistroCita.Show();
            this.Hide();
        }

        private void btnMostrarCita_Click(object sender, EventArgs e)
        {
            if (mostrarCita == null)
            {
                mostrarCita = new MMostrarCita(this);
            }
            mostrarCita.ListarCita();
            mostrarCita.Show();
            this.Hide();
        }

        private void btnRegresarCita_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Hide();
        }
    }
}
