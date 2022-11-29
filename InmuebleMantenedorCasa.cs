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
    public partial class InmuebleMantenedorCasa : Form
    {
        MantenedorDeInmueble Mantinmueble;
        public InmuebleMantenedorCasa(MantenedorDeInmueble inm)
        {
            InitializeComponent();
            Mantinmueble = inm;
            ListarSector();
            ListarPropietario();
        }
        public void ListarSector()
        {
            comboBoxSector.DataSource = logSector.Instancia.ListarSector();
            comboBoxSector.DisplayMember = "Nombresector";
            comboBoxSector.ValueMember = "SectorID";
        }
        public void ListarPropietario()
        {
            comboBoxPropietario.DataSource = logPropietario.Instancia.ListarPropietario();
            comboBoxPropietario.DisplayMember = "Nombre";
            comboBoxPropietario.ValueMember = "PropietarioID";
        }
        public void limpiarVariableInterfazReg()
        {
            txtAream2.Clear();
            textBox1CantidadBaños.Clear();
            textBox1CantidadHabitaciones.Clear();
            textBox1CantidadPisos.Clear();
            textBox1Direccion.Clear();
            textBox1Precio.Clear();
            textBox1PrecioMin.Clear();
            textBox1RegistrosPublios.Clear();
            chbJardin.Checked = false;
            chbPiscina.Checked = false;
            dtpFecha.Text = "";
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            limpiarVariableInterfazReg();
            ListarSector();
            ListarPropietario();
            this.Hide();
            Mantinmueble.Show();
        }

        private void AceptarRegisCasa_Click(object sender, EventArgs e)
        {
            try
            {
                entInmueble inmueble = new entInmueble();
                entCasa casa = new entCasa();
                inmueble.SectorID = Convert.ToInt32(comboBoxSector.SelectedValue);
                inmueble.idPropietario = Convert.ToInt32(comboBoxPropietario.SelectedValue);
                inmueble.direccion = textBox1Direccion.Text.Trim();
                inmueble.precio = (float)Convert.ToDouble(textBox1Precio.Text.Trim());
                inmueble.precioMinimo = (float)Convert.ToDouble(textBox1PrecioMin.Text.Trim());
                inmueble.nRegistroPublico = int.Parse(textBox1RegistrosPublios.Text.Trim());
                inmueble.vendido = false;
                inmueble.habilitado = true;
                casa.cantPisos = int.Parse(textBox1CantidadPisos.Text.Trim());
                casa.cantBaños = int.Parse(textBox1CantidadBaños.Text.Trim());
                casa.cantHabitaciones = int.Parse(textBox1CantidadHabitaciones.Text.Trim());
                casa.areaM2 = (float)Convert.ToDouble(txtAream2.Text.Trim());
                casa.piscina = chbPiscina.Checked;
                casa.jardin = chbJardin.Checked;
                casa.fechaConstruccion = dtpFecha.Value;
                if (!logInmueble.Instancia.ExisteNRegistros(inmueble.nRegistroPublico))
                {
                    logInmueble.Instancia.RegistrarInmueble(inmueble);
                    casa.InmuebleID1 = logInmueble.Instancia.BuscarNRegistroPublico(inmueble.nRegistroPublico).InmuebleID;
                    MessageBox.Show("Se registró correctamente la casa");
                    logCasa.Instancia.RegistrarInmuebleCasa(casa);
                    limpiarVariableInterfazReg();
                    this.Hide();
                    Mantinmueble.Show();
                }
                else
                {
                    MessageBox.Show("El número de registro público ya se encuentra registrado en otro inmueble.");
                }
                ListarPropietario();
                ListarSector();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error.." + ex);
            }
        }
    }
}
