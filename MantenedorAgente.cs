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
    public partial class MantenedorAgente : Form
    {
        MenuPrincipal principal;
        RegistrarAgente registrarAge;
        ConsultarAgente consultar;
        public MantenedorAgente(MenuPrincipal menu)
        {
            InitializeComponent();
            principal = menu;
        }

        private void MantenedorAgente_Load(object sender, EventArgs e)
        {

        }

        private void btRegistrarAgente_Click(object sender, EventArgs e)
        {
            if (registrarAge == null)
            {
                registrarAge = new RegistrarAgente(this);
            }
            registrarAge.Show();
            this.Hide();
        }

        private void btModificarAgente_Click(object sender, EventArgs e)
        {
            if (consultar == null)
            {
                consultar = new ConsultarAgente(this);
            }
            consultar.ListarAgente();
            consultar.Show();
            this.Hide();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Hide();
        }
    }
}
