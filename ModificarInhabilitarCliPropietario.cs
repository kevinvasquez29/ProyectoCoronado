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
    public partial class ModificarInhabilitarCliPropietario : Form
    {
        ConsultarCliPropietario propi;
        public ModificarInhabilitarCliPropietario(ConsultarCliPropietario pro)
        {
            InitializeComponent();
            propi = pro;

        }
        public void llenarDatos(entPropietario propietario)
        {
            txtId.Enabled = false;
            txtDNI.Enabled = false;
            checkHabilitar.Enabled = false;
            txtId.Text = propietario.PropietarioID.ToString();
            txtDNI.Text = propietario.Dnipropietario.ToString();
            txtNombre.Text = propietario.nombre.ToString();
            txtApellido.Text = propietario.apellido.ToString();
            txtCelular.Text = propietario.celular.ToString();
            txtDireccion.Text = propietario.direccion.ToString();
            checkHabilitar.Checked = propietario.estadoPropietario;
        }
        public void limpiarVariableInterfazMod()
        {
            txtId.Clear();
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCelular.Clear();
            txtDireccion.Clear();
        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            try
            {
                entPropietario Prop = new entPropietario();
                Prop.PropietarioID = int.Parse(txtId.Text.Trim());
                Prop.Dnipropietario = int.Parse(txtDNI.Text.Trim());
                Prop.nombre = txtNombre.Text.Trim();
                Prop.apellido = txtApellido.Text.Trim();
                Prop.celular = int.Parse(txtCelular.Text.Trim());
                Prop.direccion = txtDireccion.Text.Trim();
                logPropietario.Instancia.ModificarPropietario(Prop);
                MessageBox.Show("Se editaron correctamente los datos del propietario");
                propi.listarPropietario();
                propi.limpiarVariableConsultar();
                limpiarVariableInterfazMod();
                propi.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entPropietario prop = new entPropietario();
                prop.PropietarioID = int.Parse(txtId.Text.Trim());
                prop.Dnipropietario = int.Parse(txtDNI.Text.Trim());
                checkHabilitar.Checked = false;
                prop.estadoPropietario = checkHabilitar.Checked;
                logPropietario.Instancia.HabilitarPropietario(prop);
                MessageBox.Show("El propietario a sido deshabilitado correctamente");
                propi.listarPropietario();
                propi.limpiarVariableConsultar();
                limpiarVariableInterfazMod();
                propi.Show();
                this.Hide();
            }
            catch (Exception exe)
            {
                throw exe;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            propi.listarPropietario();
            propi.limpiarVariableConsultar();
            limpiarVariableInterfazMod();
            propi.Show();
            this.Hide();
        }
    }
}
