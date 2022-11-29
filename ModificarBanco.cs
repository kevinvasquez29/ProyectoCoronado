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
    public partial class ModificarBanco : Form
    {
        MostrandoBanco banc;
        public ModificarBanco(MostrandoBanco ban)
        {
            InitializeComponent();
            banc = ban;
        }
        public void llenarDatos(entBanco banco)
        {
            txtIdBanco.Enabled = false;
            checkBoxHabilitar.Enabled = false;
            txtIdBanco.Text = banco.BancoID.ToString();
            textBox1NombreBanco.Text = banco.Nombre.ToString();
            checkBoxHabilitar.Checked = banco.estadoBanco;
        }
        public void limpiarVariableInterfazMod()
        {
            txtIdBanco.Clear();
            textBox1NombreBanco.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                entBanco banco = new entBanco();
                banco.BancoID = int.Parse(txtIdBanco.Text.Trim());
                banco.Nombre = textBox1NombreBanco.Text.Trim();
                if (logBanco.Instancia.ExisteDatosBancoNombre(banco))
                {
                    MessageBox.Show("El nombre del banco ingresado ya está en uso.");
                }
                else
                {
                    logBanco.Instancia.EditarBanco(banco);
                    MessageBox.Show("Cambio realizado con exito");
                    banc.ListarBanco();
                    banc.limpiarVariableConsultar();
                    limpiarVariableInterfazMod();
                    banc.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entBanco banco = new entBanco();
                banco.BancoID = int.Parse(txtIdBanco.Text.Trim());
                checkBoxHabilitar.Checked = false;
                banco.estadoBanco = checkBoxHabilitar.Checked;
                logBanco.Instancia.DeshabilitarBanco(banco);
                MessageBox.Show("El banco a sido deshabilitado correctamente.");
                banc.ListarBanco();
                banc.limpiarVariableConsultar();
                limpiarVariableInterfazMod();
                banc.Show();
                this.Hide();
            }
            catch (Exception exe)
            {
                throw exe;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            banc.ListarBanco();
            banc.limpiarVariableConsultar();
            limpiarVariableInterfazMod();
            banc.Show();
            this.Hide();
        }
    }
}
