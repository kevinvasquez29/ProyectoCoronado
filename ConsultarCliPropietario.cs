using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace ProyectoCoronado
{
    public partial class ConsultarCliPropietario : Form
    {
        MantenedorCliPropietario propietario;
        ModificarInhabilitarCliPropietario modificar;
        public ConsultarCliPropietario(MantenedorCliPropietario prop)
        {
            InitializeComponent();
            listarPropietario();
            propietario = prop;
        }

        public void listarPropietario()
        {
            dgvDatosPropietario.DataSource = logPropietario.Instancia.ListarPropietario();
        }
        public void limpiarVariableConsultar()
        {
            txtIngreseDni.Clear();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                entPropietario Prop = new entPropietario();
                Prop.Dnipropietario = int.Parse(txtIngreseDni.Text.Trim());
                if (logPropietario.Instancia.BuscarPropietario(Prop))
                {
                    if (modificar == null)
                    {
                        modificar = new ModificarInhabilitarCliPropietario(this);
                    }
                    Prop = logPropietario.Instancia.DatosPropietario(Prop.Dnipropietario);
                    modificar.llenarDatos(Prop);
                    modificar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se encontró al Propietario");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            propietario.Show();
            this.Hide();
        }
    }
}
