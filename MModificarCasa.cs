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
    public partial class MModificarCasa : Form
    {
        ConsultarInmueble consultar;
        int idAux;
        public MModificarCasa(ConsultarInmueble consu)
        {
            InitializeComponent();
            consultar = consu;
        }

        public void datosCasa(entInmueble inmueble, entCasa casa)
        {
            checkboxHabilitar.Enabled = false;
            idAux = inmueble.InmuebleID;
            txtPrecio.Text = inmueble.precio.ToString();
            txtPrecioMinimo.Text = inmueble.precioMinimo.ToString();
            txtCantidadPiso.Text = casa.cantPisos.ToString();
            txtCantidadBaños.Text = casa.cantBaños.ToString();
            txtCantidadHabitaciones.Text = casa.cantHabitaciones.ToString();
            txtCantidadCostruida.Text = casa.areaM2.ToString();
            checkboxHabilitar.Checked = inmueble.habilitado;
        }
        public void limpiarVariableInterfazModCasa()
        {
            txtPrecio.Clear();
            txtPrecioMinimo.Clear();
            txtCantidadPiso.Clear();
            txtCantidadBaños.Clear();
            txtCantidadHabitaciones.Clear();
            txtCantidadCostruida.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                entCasa casa = new entCasa();
                entInmueble inmueble = new entInmueble();
                inmueble.InmuebleID = idAux;
                casa.InmuebleID1 = idAux;
                inmueble.precio = Convert.ToInt32(txtPrecio.Text.Trim());
                inmueble.precioMinimo = Convert.ToInt32(txtPrecioMinimo.Text.Trim());
                casa.cantPisos = Convert.ToInt32(txtCantidadPiso.Text.Trim());
                casa.cantBaños = Convert.ToInt32(txtCantidadBaños.Text.Trim());
                casa.cantHabitaciones = Convert.ToInt32(txtCantidadHabitaciones.Text.Trim());
                casa.areaM2 = Convert.ToInt32(txtCantidadCostruida.Text.Trim());
                logCasa.Instancia.ModifcarCasa(casa);
                logInmueble.Instancia.ModificarInmueble(inmueble);
                MessageBox.Show("Se editaron correctamente los datos del inmueble casa.");
                consultar.limpiarVariableConsultar();
                limpiarVariableInterfazModCasa();
                this.Hide();
                consultar.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            consultar.limpiarVariableConsultar();
            limpiarVariableInterfazModCasa();
            this.Hide();
            consultar.Show();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            entInmueble inmueble = new entInmueble();
            inmueble.InmuebleID = idAux;
            checkboxHabilitar.Checked = false;
            inmueble.habilitado = checkboxHabilitar.Checked;
            logInmueble.Instancia.DeshabilitarInmueble(inmueble);
            MessageBox.Show("El inmueble casa a sido deshabilitado correctamente.");
            consultar.limpiarVariableConsultar();
            limpiarVariableInterfazModCasa();
            consultar.Show();
            this.Hide();
        }
    }
}
