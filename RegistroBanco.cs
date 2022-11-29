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
    public partial class RegistroBanco : Form
    {
        MantenedorBanco mantBanco;
        public RegistroBanco(MantenedorBanco ban)
        {
            InitializeComponent();
            textBox1CodigoBanco.Enabled = false;
            mantBanco = ban;
        }
        public void limpiarVariableInterfazReg()
        {
            textbAgregarBanco.Clear();
            textBox1CodigoBanco.Clear();
        }

        private void bt2RegistarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                entBanco ban = new entBanco();
                ban.Nombre = textbAgregarBanco.Text.Trim();
                ban.estadoBanco = true;

                if (logBanco.Instancia.ExisteDatosBancoNombre(ban))
                {
                    MessageBox.Show("El Nombre del banco ya se encuentra en uso.");
                }
                else
                {
                    logBanco.Instancia.RegistrarBanco(ban);
                    MessageBox.Show("El banco se a registrado correctamente.");
                    limpiarVariableInterfazReg();
                    mantBanco.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error..." + ex);
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            limpiarVariableInterfazReg();
            mantBanco.Show();
            this.Hide();
        }
    }
}
