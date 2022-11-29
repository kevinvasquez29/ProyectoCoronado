namespace ProyectoCoronado
{
    partial class ConsultarInmueble
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
            this.dtgTipoInmueble = new System.Windows.Forms.DataGridView();
            this.btnSalirInmueble = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIngresoDNIDCI = new System.Windows.Forms.Label();
            this.comboBoxTipoInmueble = new System.Windows.Forms.ComboBox();
            this.lbDatosContrato = new System.Windows.Forms.Label();
            this.dataGridViewConsulInmuble = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoInmueble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulInmuble)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTipoInmueble
            // 
            this.dtgTipoInmueble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTipoInmueble.Location = new System.Drawing.Point(21, 288);
            this.dtgTipoInmueble.Margin = new System.Windows.Forms.Padding(4);
            this.dtgTipoInmueble.Name = "dtgTipoInmueble";
            this.dtgTipoInmueble.RowHeadersWidth = 51;
            this.dtgTipoInmueble.Size = new System.Drawing.Size(637, 185);
            this.dtgTipoInmueble.TabIndex = 45;
            // 
            // btnSalirInmueble
            // 
            this.btnSalirInmueble.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirInmueble.Location = new System.Drawing.Point(791, 435);
            this.btnSalirInmueble.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalirInmueble.Name = "btnSalirInmueble";
            this.btnSalirInmueble.Size = new System.Drawing.Size(137, 38);
            this.btnSalirInmueble.TabIndex = 44;
            this.btnSalirInmueble.Text = "Salir";
            this.btnSalirInmueble.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(791, 351);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(137, 38);
            this.btnAceptar.TabIndex = 43;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(741, 288);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(217, 22);
            this.txtCodigo.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(658, 237);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Codigo inmueble Modifcar";
            // 
            // labelIngresoDNIDCI
            // 
            this.labelIngresoDNIDCI.AutoSize = true;
            this.labelIngresoDNIDCI.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresoDNIDCI.Location = new System.Drawing.Point(713, 128);
            this.labelIngresoDNIDCI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIngresoDNIDCI.Name = "labelIngresoDNIDCI";
            this.labelIngresoDNIDCI.Size = new System.Drawing.Size(275, 31);
            this.labelIngresoDNIDCI.TabIndex = 40;
            this.labelIngresoDNIDCI.Text = "Tipo de Inmueble:";
            // 
            // comboBoxTipoInmueble
            // 
            this.comboBoxTipoInmueble.FormattingEnabled = true;
            this.comboBoxTipoInmueble.Items.AddRange(new object[] {
            "Casa",
            "Departamento",
            "Terreno"});
            this.comboBoxTipoInmueble.Location = new System.Drawing.Point(761, 178);
            this.comboBoxTipoInmueble.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTipoInmueble.Name = "comboBoxTipoInmueble";
            this.comboBoxTipoInmueble.Size = new System.Drawing.Size(184, 24);
            this.comboBoxTipoInmueble.TabIndex = 39;
            // 
            // lbDatosContrato
            // 
            this.lbDatosContrato.AutoSize = true;
            this.lbDatosContrato.Font = new System.Drawing.Font("Monotype Corsiva", 35.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatosContrato.Location = new System.Drawing.Point(254, -135);
            this.lbDatosContrato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDatosContrato.Name = "lbDatosContrato";
            this.lbDatosContrato.Size = new System.Drawing.Size(458, 71);
            this.lbDatosContrato.TabIndex = 38;
            this.lbDatosContrato.Text = "Consultar Inmuebles";
            // 
            // dataGridViewConsulInmuble
            // 
            this.dataGridViewConsulInmuble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulInmuble.Location = new System.Drawing.Point(13, 45);
            this.dataGridViewConsulInmuble.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewConsulInmuble.Name = "dataGridViewConsulInmuble";
            this.dataGridViewConsulInmuble.RowHeadersWidth = 51;
            this.dataGridViewConsulInmuble.Size = new System.Drawing.Size(637, 188);
            this.dataGridViewConsulInmuble.TabIndex = 37;
            // 
            // ConsultarInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 535);
            this.Controls.Add(this.dtgTipoInmueble);
            this.Controls.Add(this.btnSalirInmueble);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIngresoDNIDCI);
            this.Controls.Add(this.comboBoxTipoInmueble);
            this.Controls.Add(this.lbDatosContrato);
            this.Controls.Add(this.dataGridViewConsulInmuble);
            this.Name = "ConsultarInmueble";
            this.Text = "ConsultarInmueble";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoInmueble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulInmuble)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTipoInmueble;
        private System.Windows.Forms.Button btnSalirInmueble;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIngresoDNIDCI;
        private System.Windows.Forms.ComboBox comboBoxTipoInmueble;
        private System.Windows.Forms.Label lbDatosContrato;
        private System.Windows.Forms.DataGridView dataGridViewConsulInmuble;
    }
}