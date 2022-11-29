namespace ProyectoCoronado
{
    partial class RegistrarCiudad
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
            this.labelRegistarCiudad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textReferenciasCiudad = new System.Windows.Forms.TextBox();
            this.textCódigoPostal = new System.Windows.Forms.TextBox();
            this.txtNombreCiudad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelRegistarCiudad
            // 
            this.labelRegistarCiudad.AutoSize = true;
            this.labelRegistarCiudad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelRegistarCiudad.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistarCiudad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRegistarCiudad.Location = new System.Drawing.Point(154, 63);
            this.labelRegistarCiudad.Name = "labelRegistarCiudad";
            this.labelRegistarCiudad.Size = new System.Drawing.Size(476, 54);
            this.labelRegistarCiudad.TabIndex = 52;
            this.labelRegistarCiudad.Text = "Registrar Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Referencias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Código Postal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Nombre de Ciudad:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(381, 385);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(160, 49);
            this.btnRegistrar.TabIndex = 48;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(591, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 49);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // textReferenciasCiudad
            // 
            this.textReferenciasCiudad.Location = new System.Drawing.Point(244, 328);
            this.textReferenciasCiudad.Name = "textReferenciasCiudad";
            this.textReferenciasCiudad.Size = new System.Drawing.Size(360, 20);
            this.textReferenciasCiudad.TabIndex = 45;
            // 
            // textCódigoPostal
            // 
            this.textCódigoPostal.Location = new System.Drawing.Point(244, 262);
            this.textCódigoPostal.Name = "textCódigoPostal";
            this.textCódigoPostal.Size = new System.Drawing.Size(360, 20);
            this.textCódigoPostal.TabIndex = 44;
            // 
            // txtNombreCiudad
            // 
            this.txtNombreCiudad.Location = new System.Drawing.Point(244, 183);
            this.txtNombreCiudad.Name = "txtNombreCiudad";
            this.txtNombreCiudad.Size = new System.Drawing.Size(360, 20);
            this.txtNombreCiudad.TabIndex = 43;
            // 
            // RegistrarCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 476);
            this.Controls.Add(this.labelRegistarCiudad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.textReferenciasCiudad);
            this.Controls.Add(this.textCódigoPostal);
            this.Controls.Add(this.txtNombreCiudad);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistrarCiudad";
            this.Text = "RegistrarCiudad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegistarCiudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textReferenciasCiudad;
        private System.Windows.Forms.TextBox textCódigoPostal;
        private System.Windows.Forms.TextBox txtNombreCiudad;
    }
}