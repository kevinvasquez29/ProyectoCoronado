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
    public partial class RegistrarCliPropietario : Form
    {
        MantenedorCliPropietario prop;
        public RegistrarCliPropietario(MantenedorCliPropietario pro)
        {
            InitializeComponent();
            prop = pro;
        }
        public void limpiarVariableInterfazReg()
        {
            txtApellido.Clear();
            txtCelular.Clear();
            txtDireccion.Clear();
            txtDni.Clear();
            txtNombre.Clear();
            dateTimePickerFechaNacimiento.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entPropietario Prop = new entPropietario();
                Prop.Dnipropietario = int.Parse(txtDni.Text.Trim());
                Prop.nombre = txtNombre.Text.Trim();
                Prop.apellido = txtApellido.Text.Trim();
                Prop.Fechanacimiento = DateTime.Parse(dateTimePickerFechaNacimiento.Text.Trim());
                Prop.celular = int.Parse(txtCelular.Text.Trim());
                Prop.direccion = txtDireccion.Text.Trim();
                Prop.estadoPropietario = true;
                if (!logPropietario.Instancia.ExisteDatosPropietario(Prop))
                {
                    logPropietario.Instancia.RegistrarPropietario(Prop);
                    limpiarVariableInterfazReg();
                }
                else
                {
                    MessageBox.Show("El dni o el número de celular ya se encuentran en uso");
                }
                MessageBox.Show("El propietario fue registrado exitosamente ");
                prop.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarVariableInterfazReg();
            prop.Show();
            this.Hide();
        }
    }
}
