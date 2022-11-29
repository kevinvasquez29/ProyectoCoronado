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
    public partial class ModificarCita : Form
    {
        MMostrarCita muestraCita;
        int idAuxCita;
        public ModificarCita(MMostrarCita cit)
        {
            InitializeComponent();
            muestraCita = cit;
        }
        public void llenarDatos(entCita cita)
        {
            idAuxCita = cita.CitaID;
            checkBoxHabilitado.Enabled = false;
            checkBoxRealizada.Enabled = false;
            dateTimePickerCita.Text = cita.Fechacita.ToString(); ;
            checkBoxHabilitado.Checked = cita.Estadocita;
            checkBoxRealizada.Checked = cita.Realizado;
        }
        public void limpiarVariableInterfazMod()
        {
            dateTimePickerCita.Text = "";
            comboBoxHoraCita.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int reserva = comboBoxHoraCita.SelectedIndex;
                entCita cita = new entCita();
                cita.CitaID = idAuxCita;
                cita.Fechacita = DateTime.Parse(dateTimePickerCita.Text.Trim());
                switch (reserva)
                {
                    case 0:
                        cita.Fechacita = cita.Fechacita.AddHours(8);
                        break;
                    case 1:
                        cita.Fechacita = cita.Fechacita.AddHours(9);
                        break;
                    case 2:
                        cita.Fechacita = cita.Fechacita.AddHours(10);
                        break;
                    case 3:
                        cita.Fechacita = cita.Fechacita.AddHours(11);
                        break;
                    case 4:
                        cita.Fechacita = cita.Fechacita.AddHours(12);
                        break;
                    case 5:
                        cita.Fechacita = cita.Fechacita.AddHours(13);
                        break;
                    case 6:
                        cita.Fechacita = cita.Fechacita.AddHours(14);
                        break;
                    case 7:
                        cita.Fechacita = cita.Fechacita.AddHours(15);
                        break;
                    case 8:
                        cita.Fechacita = cita.Fechacita.AddHours(16);
                        break;
                }
                logCita.Instancia.ModifcarCita(cita);
                MessageBox.Show("Se editaron correctamente los datos de la cita");
                muestraCita.ListarCita();
                muestraCita.limpiarVariableConsultar();
                limpiarVariableInterfazMod();
                muestraCita.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCita cita = new entCita();
                cita.CitaID = idAuxCita;
                checkBoxHabilitado.Checked = false;
                cita.Estadocita = checkBoxHabilitado.Checked;
                logCita.Instancia.DeshabilitarCita(cita);
                MessageBox.Show("La cita a sido deshabilitada correctamente.");
                muestraCita.ListarCita();
                muestraCita.limpiarVariableConsultar();
                limpiarVariableInterfazMod();
                muestraCita.Show();
                this.Hide();
            }
            catch (Exception exe)
            {
                throw exe;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            muestraCita.ListarCita();
            muestraCita.limpiarVariableConsultar();
            limpiarVariableInterfazMod();
            muestraCita.Show();
            this.Hide();
        }
    }
}
