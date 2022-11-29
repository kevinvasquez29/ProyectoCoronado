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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorCiudad));
            this.btListarCiudad = new System.Windows.Forms.Button();
            this.btRegistrarCiudad = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btListarCiudad
            // 
            this.btListarCiudad.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarCiudad.Location = new System.Drawing.Point(580, 223);
            this.btListarCiudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btListarCiudad.Name = "btListarCiudad";
            this.btListarCiudad.Size = new System.Drawing.Size(363, 62);
            this.btListarCiudad.TabIndex = 58;
            this.btListarCiudad.Text = "Consultar Ciudad";
            this.btListarCiudad.UseVisualStyleBackColor = true;
            this.btListarCiudad.Click += new System.EventHandler(this.btListarCiudad_Click);
            // 
            // btRegistrarCiudad
            // 
            this.btRegistrarCiudad.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarCiudad.Location = new System.Drawing.Point(25, 223);
            this.btRegistrarCiudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRegistrarCiudad.Name = "btRegistrarCiudad";
            this.btRegistrarCiudad.Size = new System.Drawing.Size(363, 62);
            this.btRegistrarCiudad.TabIndex = 57;
            this.btRegistrarCiudad.Text = "Registrar Ciudad";
            this.btRegistrarCiudad.UseVisualStyleBackColor = true;
            this.btRegistrarCiudad.Click += new System.EventHandler(this.btRegistrarCiudad_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(732, 462);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(231, 62);
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
            this.lbMenu.Location = new System.Drawing.Point(401, 34);
            this.lbMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(185, 66);
            this.lbMenu.TabIndex = 54;
            this.lbMenu.Text = "Menu";
            // 
            // MantenedorCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(976, 549);
            this.Controls.Add(this.btListarCiudad);
            this.Controls.Add(this.btRegistrarCiudad);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.lbMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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