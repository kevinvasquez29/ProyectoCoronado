namespace ProyectoCoronado
{
    partial class ModificarInhabilitarCiudad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarInhabilitarCiudad));
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodCiudad = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelModificarCiudad = new System.Windows.Forms.Label();
            this.textReferenciasCiudad = new System.Windows.Forms.TextBox();
            this.textCódigoPostal = new System.Windows.Forms.TextBox();
            this.txtNombreCiudad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "Codigo Ciudad:";
            // 
            // txtCodCiudad
            // 
            this.txtCodCiudad.Location = new System.Drawing.Point(277, 167);
            this.txtCodCiudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodCiudad.Name = "txtCodCiudad";
            this.txtCodCiudad.Size = new System.Drawing.Size(200, 22);
            this.txtCodCiudad.TabIndex = 46;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(833, 443);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(213, 60);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(833, 284);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(213, 60);
            this.btnModificar.TabIndex = 44;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 409);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Referencias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Codigo Postal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nombre de Ciudad:";
            // 
            // labelModificarCiudad
            // 
            this.labelModificarCiudad.AutoSize = true;
            this.labelModificarCiudad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelModificarCiudad.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarCiudad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelModificarCiudad.Location = new System.Drawing.Point(235, 49);
            this.labelModificarCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModificarCiudad.Name = "labelModificarCiudad";
            this.labelModificarCiudad.Size = new System.Drawing.Size(569, 66);
            this.labelModificarCiudad.TabIndex = 40;
            this.labelModificarCiudad.Text = "Modificar Ciudad";
            // 
            // textReferenciasCiudad
            // 
            this.textReferenciasCiudad.Location = new System.Drawing.Point(220, 409);
            this.textReferenciasCiudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textReferenciasCiudad.Name = "textReferenciasCiudad";
            this.textReferenciasCiudad.Size = new System.Drawing.Size(479, 22);
            this.textReferenciasCiudad.TabIndex = 38;
            // 
            // textCódigoPostal
            // 
            this.textCódigoPostal.Location = new System.Drawing.Point(245, 322);
            this.textCódigoPostal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCódigoPostal.Name = "textCódigoPostal";
            this.textCódigoPostal.Size = new System.Drawing.Size(479, 22);
            this.textCódigoPostal.TabIndex = 37;
            // 
            // txtNombreCiudad
            // 
            this.txtNombreCiudad.Location = new System.Drawing.Point(289, 234);
            this.txtNombreCiudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCiudad.Name = "txtNombreCiudad";
            this.txtNombreCiudad.Size = new System.Drawing.Size(479, 22);
            this.txtNombreCiudad.TabIndex = 36;
            // 
            // ModificarInhabilitarCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1059, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodCiudad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelModificarCiudad);
            this.Controls.Add(this.textReferenciasCiudad);
            this.Controls.Add(this.textCódigoPostal);
            this.Controls.Add(this.txtNombreCiudad);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModificarInhabilitarCiudad";
            this.Text = "ModificarInhabilitarCiudad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodCiudad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelModificarCiudad;
        private System.Windows.Forms.TextBox textReferenciasCiudad;
        private System.Windows.Forms.TextBox textCódigoPostal;
        private System.Windows.Forms.TextBox txtNombreCiudad;
    }
}