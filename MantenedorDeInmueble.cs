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
    public partial class MantenedorDeInmueble : Form
    {
        Inmueble inmueble;
        RegistrarTerreno registraTerreno;
        InmuebleMantenedorCasa registraCasa;
        RegistarDepartamento registraDepartamento;

        public MantenedorDeInmueble(Inmueble menuIn)
        {
            InitializeComponent();
            cboxInmuebles.SelectedIndex = 0;
            inmueble = menuIn;
        }

        private void AceptarRegisInmueble_Click(object sender, EventArgs e)
        {
            int inmueble;
            inmueble = cboxInmuebles.SelectedIndex + 1;

            switch (inmueble)
            {
                case 1:
                    if (registraCasa == null)
                    {
                        registraCasa = new InmuebleMantenedorCasa(this);
                    }
                    this.Hide();
                    registraCasa.Show();
                    break;
                case 2:
                    if (registraDepartamento == null)
                    {
                        registraDepartamento = new RegistarDepartamento(this);
                    }
                    this.Hide();
                    registraDepartamento.Show();
                    break;
                case 3:
                    if (registraTerreno == null)
                    {
                        registraTerreno = new RegistrarTerreno(this);
                    }
                    this.Hide();
                    registraTerreno.Show();
                    break;

            }
        }

        private void btRegresarInmueble_Click(object sender, EventArgs e)
        {
            inmueble.Show();
            this.Hide();
        }
    }
}
