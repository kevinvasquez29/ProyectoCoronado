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
    public partial class RegistrarTerreno : Form
    {
        MantenedorDeInmueble inmuebles;
        public RegistrarTerreno(MantenedorDeInmueble inm)
        {
            InitializeComponent();
            inmuebles = inm;
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
            txtDireccionT.Clear();
            txtPrecioMinT.Clear();
            txtPrecioT.Clear();
            txtRegisPubliT.Clear();
            chbAgua.Checked = false;
            chbAlcantarillado.Checked = false;
            chbLuz.Checked = false;
            chbDesague.Checked = false;
        }

        private void AceptarRegisTerreno_Click(object sender, EventArgs e)
        {
            try
            {
                entInmueble inmueble = new entInmueble();
                entTerreno terreno = new entTerreno();
                inmueble.SectorID = Convert.ToInt32(comboBoxSector.SelectedValue);
                inmueble.idPropietario = Convert.ToInt32(comboBoxPropietario.SelectedValue);
                inmueble.direccion = txtDireccionT.Text.Trim();
                inmueble.precio = (float)Convert.ToDouble(txtPrecioT.Text.Trim());
                inmueble.precioMinimo = (float)Convert.ToDouble(txtPrecioMinT.Text.Trim());
                inmueble.nRegistroPublico = int.Parse(txtRegisPubliT.Text.Trim());
                inmueble.vendido = false;
                inmueble.habilitado = true;
                terreno.agua = chbAgua.Checked;
                terreno.Luz = chbLuz.Checked;
                terreno.Alcantarillado = chbAlcantarillado.Checked;
                terreno.Desague = chbDesague.Checked;
                if (!logInmueble.Instancia.ExisteNRegistros(inmueble.nRegistroPublico))
                {
                    logInmueble.Instancia.RegistrarInmueble(inmueble);
                    terreno.InmuebleID3 = logInmueble.Instancia.BuscarNRegistroPublico(inmueble.nRegistroPublico).InmuebleID;
                    logTerreno.Instancia.RegistrarInmuebleTerreno(terreno);
                    MessageBox.Show("Se registró correctamente el terreno");
                    limpiarVariableInterfazReg();
                    inmuebles.Show();
                    this.Hide();
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
                throw ex;
            }
        }

        private void RegresarTerreno_Click(object sender, EventArgs e)
        {
            limpiarVariableInterfazReg();
            ListarSector();
            ListarPropietario();
            this.Hide();
            inmuebles.Show();
        }
    }
}
