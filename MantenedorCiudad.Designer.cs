namespace ProyectoCoronado
{
    partial class MantenedorCiudad
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
            this.btListarCiudad = new System.Windows.Forms.Button();
            this.btRegistrarCiudad = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btListarCiudad
            // 
            this.btListarCiudad.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarCiudad.Location = new System.Drawing.Point(435, 181);
            this.btListarCiudad.Name = "btListarCiudad";
            this.btListarCiudad.Size = new System.Drawing.Size(272, 50);
            this.btListarCiudad.TabIndex = 58;
            this.btListarCiudad.Text = "Consultar Ciudad";
            this.btListarCiudad.UseVisualStyleBackColor = true;
            this.btListarCiudad.Click += new System.EventHandler(this.btListarCiudad_Click);
            // 
            // btRegistrarCiudad
            // 
            this.btRegistrarCiudad.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarCiudad.Location = new System.Drawing.Point(19, 181);
            this.btRegistrarCiudad.Name = "btRegistrarCiudad";
            this.btRegistrarCiudad.Size = new System.Drawing.Size(272, 50);
            this.btRegistrarCiudad.TabIndex = 57;
            this.btRegistrarCiudad.Text = "Registrar Ciudad";
            this.btRegistrarCiudad.UseVisualStyleBackColor = true;
            this.btRegistrarCiudad.Click += new System.EventHandler(this.btRegistrarCiudad_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(549, 375);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(173, 50);
            this.btRegresar.TabIndex = 56;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbMenu.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMenu.Location = new System.Drawing.Point(301, 28);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(150, 54);
            this.lbMenu.TabIndex = 54;
            this.lbMenu.Text = "Menu";
            // 
            // MantenedorCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 446);
            this.Controls.Add(this.btListarCiudad);
            this.Controls.Add(this.btRegistrarCiudad);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.lbMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MantenedorCiudad";
            this.Text = "MantenedorCiudad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btListarCiudad;
        private System.Windows.Forms.Button btRegistrarCiudad;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Label lbMenu;
    }
}