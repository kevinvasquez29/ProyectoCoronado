namespace ProyectoCoronado
{
    partial class ConsultarCliPropietario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbConsultar = new System.Windows.Forms.Label();
            this.btRegresar = new System.Windows.Forms.Button();
            this.txtIngreseDni = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.lbIngreseDni = new System.Windows.Forms.Label();
            this.dgvDatosPropietario = new System.Windows.Forms.DataGridView();
            this.dgvConsultarCliPropietario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPropietario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCliPropietario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbConsultar
            // 
            this.lbConsultar.AutoSize = true;
            this.lbConsultar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbConsultar.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbConsultar.Location = new System.Drawing.Point(10, 36);
            this.lbConsultar.Name = "lbConsultar";
            this.lbConsultar.Size = new System.Drawing.Size(421, 35);
            this.lbConsultar.TabIndex = 51;
            this.lbConsultar.Text = "Consultar Propietario";
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(572, 401);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(168, 30);
            this.btRegresar.TabIndex = 50;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // txtIngreseDni
            // 
            this.txtIngreseDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngreseDni.Location = new System.Drawing.Point(508, 194);
            this.txtIngreseDni.Name = "txtIngreseDni";
            this.txtIngreseDni.Size = new System.Drawing.Size(224, 31);
            this.txtIngreseDni.TabIndex = 46;
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(537, 261);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(168, 30);
            this.btAceptar.TabIndex = 49;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // lbIngreseDni
            // 
            this.lbIngreseDni.AutoSize = true;
            this.lbIngreseDni.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngreseDni.Location = new System.Drawing.Point(504, 142);
            this.lbIngreseDni.Name = "lbIngreseDni";
            this.lbIngreseDni.Size = new System.Drawing.Size(131, 21);
            this.lbIngreseDni.TabIndex = 48;
            this.lbIngreseDni.Text = "Ingrese DNI";
            // 
            // dgvDatosPropietario
            // 
            this.dgvDatosPropietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPropietario.Location = new System.Drawing.Point(-6, 85);
            this.dgvDatosPropietario.Name = "dgvDatosPropietario";
            this.dgvDatosPropietario.RowHeadersWidth = 51;
            this.dgvDatosPropietario.Size = new System.Drawing.Size(454, 346);
            this.dgvDatosPropietario.TabIndex = 45;
            // 
            // dgvConsultarCliPropietario
            // 
            this.dgvConsultarCliPropietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarCliPropietario.Location = new System.Drawing.Point(-12, 24);
            this.dgvConsultarCliPropietario.Name = "dgvConsultarCliPropietario";
            this.dgvConsultarCliPropietario.RowHeadersWidth = 51;
            this.dgvConsultarCliPropietario.Size = new System.Drawing.Size(460, 383);
            this.dgvConsultarCliPropietario.TabIndex = 44;
            // 
            // ConsultarCliPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.lbConsultar);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.txtIngreseDni);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lbIngreseDni);
            this.Controls.Add(this.dgvDatosPropietario);
            this.Controls.Add(this.dgvConsultarCliPropietario);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultarCliPropietario";
            this.Text = "ConsultarCliPropietario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPropietario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCliPropietario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbConsultar;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.TextBox txtIngreseDni;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label lbIngreseDni;
        private System.Windows.Forms.DataGridView dgvDatosPropietario;
        private System.Windows.Forms.DataGridView dgvConsultarCliPropietario;
    }
}