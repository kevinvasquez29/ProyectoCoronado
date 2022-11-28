namespace ProyectoCoronado
{
    partial class ContratoInmueble
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelContratoInmueblePropietario = new System.Windows.Forms.Label();
            this.btnRegistrarContratoInmueble = new System.Windows.Forms.Button();
            this.btnListarContratoInmueble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(735, 479);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelContratoInmueblePropietario
            // 
            this.labelContratoInmueblePropietario.AutoSize = true;
            this.labelContratoInmueblePropietario.Font = new System.Drawing.Font("Algerian", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContratoInmueblePropietario.Location = new System.Drawing.Point(200, 46);
            this.labelContratoInmueblePropietario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContratoInmueblePropietario.Name = "labelContratoInmueblePropietario";
            this.labelContratoInmueblePropietario.Size = new System.Drawing.Size(621, 65);
            this.labelContratoInmueblePropietario.TabIndex = 6;
            this.labelContratoInmueblePropietario.Text = "Contrato Inmueble";
            // 
            // btnRegistrarContratoInmueble
            // 
            this.btnRegistrarContratoInmueble.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarContratoInmueble.Location = new System.Drawing.Point(116, 208);
            this.btnRegistrarContratoInmueble.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarContratoInmueble.Name = "btnRegistrarContratoInmueble";
            this.btnRegistrarContratoInmueble.Size = new System.Drawing.Size(285, 75);
            this.btnRegistrarContratoInmueble.TabIndex = 7;
            this.btnRegistrarContratoInmueble.Text = "Registrar Contrato de Inmueble";
            this.btnRegistrarContratoInmueble.UseVisualStyleBackColor = true;
            // 
            // btnListarContratoInmueble
            // 
            this.btnListarContratoInmueble.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarContratoInmueble.Location = new System.Drawing.Point(613, 208);
            this.btnListarContratoInmueble.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarContratoInmueble.Name = "btnListarContratoInmueble";
            this.btnListarContratoInmueble.Size = new System.Drawing.Size(285, 75);
            this.btnListarContratoInmueble.TabIndex = 8;
            this.btnListarContratoInmueble.Text = "Consultar Contrato Inmueble";
            this.btnListarContratoInmueble.UseVisualStyleBackColor = true;
            // 
            // ContratoInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListarContratoInmueble);
            this.Controls.Add(this.btnRegistrarContratoInmueble);
            this.Controls.Add(this.labelContratoInmueblePropietario);
            this.Name = "ContratoInmueble";
            this.Text = "ContratoInmueble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelContratoInmueblePropietario;
        private System.Windows.Forms.Button btnRegistrarContratoInmueble;
        private System.Windows.Forms.Button btnListarContratoInmueble;
    }
}