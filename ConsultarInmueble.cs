using CapaEntidad;
using CapaLogica;
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
    public partial class ConsultarInmueble : Form
    {
        Inmueble inm;
        MModificarCasa casa;
        MModificarDepartamento departamento;
        MModificarTerreno terreno;
        int tipo;
        int aux;
        public ConsultarInmueble(Inmueble inmu)
        {
            InitializeComponent();
            inm = inmu;
            comboBoxTipoInmueble.SelectedIndex = 0;
        }
        public void limpiarVariableConsultar()
        {
            txtCodigo.Clear();
            dataGridViewConsulInmuble.Columns.Clear();
            dtgTipoInmueble.Columns.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            entInmueble inmueble = new entInmueble();
            entCasa cas = new entCasa();
            entTerreno terre = new entTerreno();
            entDepartamento depart = new entDepartamento();
            aux = int.Parse(txtCodigo.Text.Trim());
            if (logInmueble.Instancia.BuscarInmueble(aux))
            {
                switch (tipo)
                {
                    case 1:
                        if (casa == null)
                        {
                            casa = new MModificarCasa(this);
                        }
                        inmueble = logInmueble.Instancia.DatosInmueble(aux);
                        cas = logCasa.Instancia.DatosCasa(aux);
                        casa.datosCasa(inmueble, cas);
                        this.Hide();
                        casa.Show();
                        break;
                    case 2:
                        if (departamento == null)
                        {
                            departamento = new MModificarDepartamento(this);
                        }
                        inmueble = logInmueble.Instancia.DatosInmueble(aux);
                        depart = logDepartamento.Instancia.DatosDepartamento(aux);
                        departamento.DatosDepartamento(inmueble, depart);
                        this.Hide();
                        departamento.Show();
                        break;
                    case 3:
                        if (terreno == null)
                        {
                            terreno = new MModificarTerreno(this);
                        }
                        inmueble = logInmueble.Instancia.DatosInmueble(aux);
                        terre = logTerreno.Instancia.DatosTerreno(aux);
                        terreno.DatosTerreno(inmueble, terre);
                        this.Hide();
                        terreno.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("No se encontro el inmueble a consultar.");
            }
        }

        private void comboBoxTipoInmueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo = comboBoxTipoInmueble.SelectedIndex + 1;
            switch (tipo)
            {
                case 1:
                    dataGridViewConsulInmuble.DataSource = logInmueble.Instancia.ListarInmuebleCasa();
                    dtgTipoInmueble.DataSource = logCasa.Instancia.ListarInmuebleCasa();
                    break;
                case 2:
                    dataGridViewConsulInmuble.DataSource = logInmueble.Instancia.ListarInmuebleDepartamento();
                    dtgTipoInmueble.DataSource = logDepartamento.Instancia.ListarInmuebleDepartamento();
                    break;
                case 3:
                    dataGridViewConsulInmuble.DataSource = logInmueble.Instancia.ListarInmuebleTerreno();
                    dtgTipoInmueble.DataSource = logTerreno.Instancia.ListarInmuebleTerreno();
                    break;
            }
        }

        private void btnSalirInmueble_Click(object sender, EventArgs e)
        {
            this.Hide();
            inm.Show();
        }
    }
}
