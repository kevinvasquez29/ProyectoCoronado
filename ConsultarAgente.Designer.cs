namespace ProyectoCoronado
{
    partial class ConsultarAgente
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
            this.btRegresar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lbIngresaDni = new System.Windows.Forms.Label();
            this.dgvConsultaAgente = new System.Windows.Forms.DataGridView();
            this.lbConsultarAgente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAgente)).BeginInit();
            this.SuspendLayout();
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btRegresar.Location = new System.Drawing.Point(818, 452);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(152, 39);
            this.btRegresar.TabIndex = 13;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            // 
            // btModificar
            // 
            this.btModificar.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btModificar.Location = new System.Drawing.Point(764, 243);
            this.btModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(160, 43);
            this.btModificar.TabIndex = 12;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(711, 136);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(267, 34);
            this.txtDni.TabIndex = 11;
            // 
            // lbIngresaDni
            // 
            this.lbIngresaDni.AutoSize = true;
            this.lbIngresaDni.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbIngresaDni.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngresaDni.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbIngresaDni.Location = new System.Drawing.Point(705, 79);
            this.lbIngresaDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIngresaDni.Name = "lbIngresaDni";
            this.lbIngresaDni.Size = new System.Drawing.Size(200, 34);
            this.lbIngresaDni.TabIndex = 10;
            this.lbIngresaDni.Text = "Ingrese DNI";
            // 
            // dgvConsultaAgente
            // 
            this.dgvConsultaAgente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaAgente.Location = new System.Drawing.Point(13, 114);
            this.dgvConsultaAgente.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsultaAgente.Name = "dgvConsultaAgente";
            this.dgvConsultaAgente.RowHeadersWidth = 51;
            this.dgvConsultaAgente.Size = new System.Drawing.Size(653, 263);
            this.dgvConsultaAgente.TabIndex = 9;
            this.dgvConsultaAgente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaAgente_CellContentClick);
            // 
            // lbConsultarAgente
            // 
            this.lbConsultarAgente.AutoSize = true;
            this.lbConsultarAgente.BackColor = System.Drawing.Color.Ivory;
            this.lbConsultarAgente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbConsultarAgente.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarAgente.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbConsultarAgente.Location = new System.Drawing.Point(7, 9);
            this.lbConsultarAgente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConsultarAgente.Name = "lbConsultarAgente";
            this.lbConsultarAgente.Size = new System.Drawing.Size(420, 47);
            this.lbConsultarAgente.TabIndex = 7;
            this.lbConsultarAgente.Text = "CONSULTAR AGENTE";
            // 
            // ConsultarAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 504);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lbIngresaDni);
            this.Controls.Add(this.dgvConsultaAgente);
            this.Controls.Add(this.lbConsultarAgente);
            this.Name = "ConsultarAgente";
            this.Text = "ConsultarAgente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAgente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lbIngresaDni;
        private System.Windows.Forms.DataGridView dgvConsultaAgente;
        private System.Windows.Forms.Label lbConsultarAgente;
    }
}