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
    public partial class MModificarTerreno : Form
    {
        ConsultarInmueble consultar;
        int idAux;
        public MModificarTerreno(ConsultarInmueble consu)
        {
            InitializeComponent();
            consultar = consu;
        }

        public void DatosTerreno(entInmueble inmueble, entTerreno terreno)
        {
            checkboxHabilitar.Enabled = false;
            idAux = inmueble.InmuebleID;
            txtPrecio.Text = inmueble.precio.ToString();
            txtPrecioMinimo.Text = inmueble.precioMinimo.ToString();
            txtArea.Text = terreno.Aream2.ToString();
            chbAgua.Checked = terreno.agua;
            chbAlcantarillado.Checked = terreno.Alcantarillado;
            chbDesague.Checked = terreno.Desague;
            chbLuz.Checked = terreno.Luz;
            checkboxHabilitar.Checked = inmueble.habilitado;
        }
        public void limpiarVariableInterfazModTerreno()
        {
            txtPrecio.Clear();
            txtPrecioMinimo.Clear();
            txtArea.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                entTerreno terreno = new entTerreno();
                entInmueble inmueble = new entInmueble();
                inmueble.InmuebleID = idAux;
                terreno.InmuebleID3 = idAux;
                inmueble.precio = Convert.ToInt32(txtPrecio.Text.Trim());
                inmueble.precioMinimo = Convert.ToInt32(txtPrecioMinimo.Text.Trim());
                terreno.Aream2 = Convert.ToInt32(txtArea.Text.Trim());
                terreno.agua = chbAgua.Checked;
                terreno.Alcantarillado = chbAlcantarillado.Checked;
                terreno.Desague = chbDesague.Checked;
                terreno.Luz = chbLuz.Checked;
                logTerreno.Instancia.ModifcarTerreno(terreno);
                logInmueble.Instancia.ModificarInmueble(inmueble);
                MessageBox.Show("Se editaron correctamente los datos del inmueble casa.");
                consultar.limpiarVariableConsultar();
                limpiarVariableInterfazModTerreno();
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
            limpiarVariableInterfazModTerreno();
            this.Hide();
            consultar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entInmueble inmueble = new entInmueble();
            inmueble.InmuebleID = idAux;
            checkboxHabilitar.Checked = false;
            inmueble.habilitado = checkboxHabilitar.Checked;
            logInmueble.Instancia.DeshabilitarInmueble(inmueble);
            MessageBox.Show("El inmueble terreno a sido deshabilitado correctamente.");
            consultar.limpiarVariableConsultar();
            limpiarVariableInterfazModTerreno();
            consultar.Show();
            this.Hide();
        }
    }
}
