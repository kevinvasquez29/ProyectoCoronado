namespace ProyectoCoronado
{
    partial class ConsultarContratoInmueble
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
            this.btnSalirDCI = new System.Windows.Forms.Button();
            this.btnInhabilitarDCI = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.textBoxDNIDCI = new System.Windows.Forms.TextBox();
            this.labelIngresoDNIDCI = new System.Windows.Forms.Label();
            this.lbDatosContrato = new System.Windows.Forms.Label();
            this.dataGridDatosCI = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatosCI)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirDCI
            // 
            this.btnSalirDCI.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirDCI.Location = new System.Drawing.Point(658, 399);
            this.btnSalirDCI.Name = "btnSalirDCI";
            this.btnSalirDCI.Size = new System.Drawing.Size(103, 31);
            this.btnSalirDCI.TabIndex = 14;
            this.btnSalirDCI.Text = "Salir";
            this.btnSalirDCI.UseVisualStyleBackColor = true;
            // 
            // btnInhabilitarDCI
            // 
            this.btnInhabilitarDCI.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitarDCI.Location = new System.Drawing.Point(550, 262);
            this.btnInhabilitarDCI.Name = "btnInhabilitarDCI";
            this.btnInhabilitarDCI.Size = new System.Drawing.Size(174, 31);
            this.btnInhabilitarDCI.TabIndex = 13;
            this.btnInhabilitarDCI.Text = "Inhabilitar";
            this.btnInhabilitarDCI.UseVisualStyleBackColor = true;
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(584, 198);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(103, 31);
            this.btAceptar.TabIndex = 12;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // textBoxDNIDCI
            // 
            this.textBoxDNIDCI.Location = new System.Drawing.Point(520, 158);
            this.textBoxDNIDCI.Name = "textBoxDNIDCI";
            this.textBoxDNIDCI.Size = new System.Drawing.Size(230, 20);
            this.textBoxDNIDCI.TabIndex = 11;
            // 
            // labelIngresoDNIDCI
            // 
            this.labelIngresoDNIDCI.AutoSize = true;
            this.labelIngresoDNIDCI.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresoDNIDCI.Location = new System.Drawing.Point(497, 118);
            this.labelIngresoDNIDCI.Name = "labelIngresoDNIDCI";
            this.labelIngresoDNIDCI.Size = new System.Drawing.Size(316, 25);
            this.labelIngresoDNIDCI.TabIndex = 10;
            this.labelIngresoDNIDCI.Text = "Ingrese DNI propietario:";
            // 
            // lbDatosContrato
            // 
            this.lbDatosContrato.AutoSize = true;
            this.lbDatosContrato.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatosContrato.Location = new System.Drawing.Point(-1, 29);
            this.lbDatosContrato.Name = "lbDatosContrato";
            this.lbDatosContrato.Size = new System.Drawing.Size(544, 35);
            this.lbDatosContrato.TabIndex = 9;
            this.lbDatosContrato.Text = "Consultar Contrato Inmueble";
            // 
            // dataGridDatosCI
            // 
            this.dataGridDatosCI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatosCI.Location = new System.Drawing.Point(5, 87);
            this.dataGridDatosCI.Name = "dataGridDatosCI";
            this.dataGridDatosCI.RowHeadersWidth = 51;
            this.dataGridDatosCI.Size = new System.Drawing.Size(486, 343);
            this.dataGridDatosCI.TabIndex = 8;
            // 
            // ConsultarContratoInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 440);
            this.Controls.Add(this.btnSalirDCI);
            this.Controls.Add(this.btnInhabilitarDCI);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.textBoxDNIDCI);
            this.Controls.Add(this.labelIngresoDNIDCI);
            this.Controls.Add(this.lbDatosContrato);
            this.Controls.Add(this.dataGridDatosCI);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultarContratoInmueble";
            this.Text = "ConsultarContratoInmueble";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatosCI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirDCI;
        private System.Windows.Forms.Button btnInhabilitarDCI;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.TextBox textBoxDNIDCI;
        private System.Windows.Forms.Label labelIngresoDNIDCI;
        private System.Windows.Forms.Label lbDatosContrato;
        private System.Windows.Forms.DataGridView dataGridDatosCI;
    }
}