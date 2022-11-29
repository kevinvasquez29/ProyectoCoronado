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
    public partial class ConsultarAgente : Form
    {
        MantenedorAgente agente;
        ModificarAgente modificar;
        public ConsultarAgente(MantenedorAgente menu)
        {
            InitializeComponent();
            ListarAgente();
            agente = menu;
        }

        public void ListarAgente()
        {
            dgvConsultaAgente.DataSource = logAgente.Instancia.ListarAgentes();
        }

        public void limpiarVariableConsultar()
        {
            txtDni.Clear();
        }



        private void dgvConsultaAgente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultarAgente_Load(object sender, EventArgs e)
        {

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entAgente Age = new entAgente();
                Age.dni = int.Parse(txtDni.Text.Trim());
                if (logAgente.Instancia.BuscarAgente(Age))
                {
                    if (modificar == null)
                    {
                        modificar = new ModificarAgente(this);
                    }
                    Age = logAgente.Instancia.DatosAgente(Age.dni);
                    modificar.llenarDatos(Age);
                    modificar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se encontró al agente");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
