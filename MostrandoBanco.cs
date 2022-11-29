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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ProyectoCoronado
{
    public partial class MostrandoBanco : Form
    {
        MantenedorBanco banc;
        ModificarBanco mod;
        public MostrandoBanco(MantenedorBanco ban)
        {
            InitializeComponent();
            ListarBanco();
            banc = ban;
        }
        public void ListarBanco()
        {
            DataGridMostrarBanco.DataSource = logBanco.Instancia.ListarBancos();
        }
        public void limpiarVariableConsultar()
        {
            textBox1IngresoBanco.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                entBanco banco = new entBanco();
                banco.BancoID = int.Parse(textBox1IngresoBanco.Text.Trim());
                if (logBanco.Instancia.BuscarBanco(banco))
                {
                    if (mod == null)
                    {
                        mod = new ModificarBanco(this);
                    }
                    banco = logBanco.Instancia.DatosBanco(banco.BancoID);
                    mod.llenarDatos(banco);
                    mod.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se encontró al Banco");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            banc.Show();
            this.Hide();
        }
    }
}
