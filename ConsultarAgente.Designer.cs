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
            this.btRegresar.Location = new System.Drawing.Point(614, 367);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(114, 32);
            this.btRegresar.TabIndex = 13;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            // 
            // btModificar
            // 
            this.btModificar.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btModificar.Location = new System.Drawing.Point(573, 197);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(120, 35);
            this.btModificar.TabIndex = 12;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(533, 110);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(201, 29);
            this.txtDni.TabIndex = 11;
            // 
            // lbIngresaDni
            // 
            this.lbIngresaDni.AutoSize = true;
            this.lbIngresaDni.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbIngresaDni.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngresaDni.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbIngresaDni.Location = new System.Drawing.Point(529, 64);
            this.lbIngresaDni.Name = "lbIngresaDni";
            this.lbIngresaDni.Size = new System.Drawing.Size(159, 26);
            this.lbIngresaDni.TabIndex = 10;
            this.lbIngresaDni.Text = "Ingrese DNI";
            // 
            // dgvConsultaAgente
            // 
            this.dgvConsultaAgente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaAgente.Location = new System.Drawing.Point(10, 93);
            this.dgvConsultaAgente.Name = "dgvConsultaAgente";
            this.dgvConsultaAgente.RowHeadersWidth = 51;
            this.dgvConsultaAgente.Size = new System.Drawing.Size(490, 214);
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
            this.lbConsultarAgente.Location = new System.Drawing.Point(5, 7);
            this.lbConsultarAgente.Name = "lbConsultarAgente";
            this.lbConsultarAgente.Size = new System.Drawing.Size(341, 37);
            this.lbConsultarAgente.TabIndex = 7;
            this.lbConsultarAgente.Text = "CONSULTAR AGENTE";
            // 
            // ConsultarAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 410);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lbIngresaDni);
            this.Controls.Add(this.dgvConsultaAgente);
            this.Controls.Add(this.lbConsultarAgente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultarAgente";
            this.Text = "ConsultarAgente";
            this.Load += new System.EventHandler(this.ConsultarAgente_Load);
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