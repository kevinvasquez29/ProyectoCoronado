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
    public partial class MRegistrarCita : Form
    {
        MCita mantCita;
        public MRegistrarCita(MCita ci)
        {
            InitializeComponent();
            mantCita = ci;
        }
        public void limpiarVariableInterfazReg()
        {
            txtIdDelAgenteRegistrarCita.Clear();
            txtIdDelClienteRegistrarCita.Clear();
            txtIdDelInmuebleRegistrarCita.Clear();
            comboBoxHoraCita.Text = "";
            dateTimePickerCita.Text = "";
        }

        private void btnAceptarRegistrarCita_Click(object sender, EventArgs e)
        {
            int reserva = comboBoxHoraCita.SelectedIndex;
            entCita agregar = new entCita();
            agregar.Fechacita = DateTime.Parse(dateTimePickerCita.Text.Trim());
            agregar.InmuebleID = int.Parse(txtIdDelInmuebleRegistrarCita.Text.Trim());
            agregar.ClienteID = int.Parse(txtIdDelClienteRegistrarCita.Text.Trim());
            agregar.AgenteID = int.Parse(txtIdDelAgenteRegistrarCita.Text.Trim());


            switch (reserva)
            {
                case 0:
                    agregar.Fechacita = agregar.Fechacita.AddHours(8);
                    break;
                case 1:
                    agregar.Fechacita = agregar.Fechacita.AddHours(9);
                    break;
                case 2:
                    agregar.Fechacita = agregar.Fechacita.AddHours(10);
                    break;
                case 3:
                    agregar.Fechacita = agregar.Fechacita.AddHours(11);
                    break;
                case 4:
                    agregar.Fechacita = agregar.Fechacita.AddHours(12);
                    break;
                case 5:
                    agregar.Fechacita = agregar.Fechacita.AddHours(13);
                    break;
                case 6:
                    agregar.Fechacita = agregar.Fechacita.AddHours(14);
                    break;
                case 7:
                    agregar.Fechacita = agregar.Fechacita.AddHours(15);
                    break;
                case 8:
                    agregar.Fechacita = agregar.Fechacita.AddHours(16);
                    break;
            }
            if (!logCita.Instancia.ExisteCita(agregar) && logInmueble.Instancia.BuscarInmueble(agregar.InmuebleID))
            {
                try
                {

                    logCita.Instancia.RegistrarCita(agregar);
                    MessageBox.Show("La cita fue registrada correctamente.");
                    mantCita.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("No se pudo registrar correctamente la cita");
            }
        }

        private void btnCancelarRegistrarCita_Click(object sender, EventArgs e)
        {
            mantCita.Show();
            this.Hide();
        }
    }
}
