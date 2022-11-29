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
    public partial class MModificarDepartamento : Form
    {
        ConsultarInmueble consultar;
        int idAux;
        public MModificarDepartamento(ConsultarInmueble consu)
        {
            InitializeComponent();
            consultar = consu;
        }


        public void DatosDepartamento(entInmueble inmu, entDepartamento depar)
        {
            checkBoxDeshabilitar.Enabled = false;
            idAux = inmu.InmuebleID;
            txtPrecio.Text = inmu.precio.ToString();
            txtPrecioMinimo.Text = inmu.precioMinimo.ToString();
            txtCantidadBaños.Text = depar.CantBao.ToString();
            txtCantidadHabitaciones.Text = depar.CantHabitacinoes.ToString();
            txtCantidadCostruida.Text = depar.Aream2.ToString();
            checkBoxDeshabilitar.Checked = inmu.habilitado;
        }
        public void limpiarVariableInterfazModDepartamento()
        {
            txtPrecio.Clear();
            txtPrecioMinimo.Clear();
            txtCantidadBaños.Clear();
            txtCantidadHabitaciones.Clear();
            txtUbicacionPiso.Clear();
            txtCantidadCostruida.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                entDepartamento departamento = new entDepartamento();
                entInmueble inmueble = new entInmueble();
                inmueble.InmuebleID = idAux;
                departamento.InmuebleID2 = idAux;
                inmueble.precio = Convert.ToInt32(txtPrecio.Text.Trim());
                inmueble.precioMinimo = Convert.ToInt32(txtPrecioMinimo.Text.Trim());
                departamento.CantBao = Convert.ToInt32(txtCantidadBaños.Text.Trim());
                departamento.CantHabitacinoes = Convert.ToInt32(txtCantidadHabitaciones.Text.Trim());
                departamento.Ubipisos = Convert.ToInt32(txtUbicacionPiso.Text.Trim());
                departamento.Aream2 = Convert.ToInt32(txtCantidadCostruida.Text.Trim());
                logDepartamento.Instancia.ModifcarDepatarmento(departamento);
                logInmueble.Instancia.ModificarInmueble(inmueble);
                MessageBox.Show("Se editaron correctamente los datos del inmueble depatarmento.");
                consultar.limpiarVariableConsultar();
                limpiarVariableInterfazModDepartamento();
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
            limpiarVariableInterfazModDepartamento();
            this.Hide();
            consultar.Show();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            entInmueble inmueble = new entInmueble();
            inmueble.InmuebleID = idAux;
            checkBoxDeshabilitar.Checked = false;
            inmueble.habilitado = checkBoxDeshabilitar.Checked;
            logInmueble.Instancia.DeshabilitarInmueble(inmueble);
            MessageBox.Show("El inmueble departamento a sido deshabilitado correctamente.");
            consultar.limpiarVariableConsultar();
            limpiarVariableInterfazModDepartamento();
            consultar.Show();
            this.Hide();
        }
    }
}
