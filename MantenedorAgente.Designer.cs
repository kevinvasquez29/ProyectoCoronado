namespace ProyectoCoronado
{
    partial class MantenedorAgente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorAgente));
            this.btRegistrarAgente = new System.Windows.Forms.Button();
            this.btModificarAgente = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btRegistrarAgente
            // 
            this.btRegistrarAgente.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarAgente.Location = new System.Drawing.Point(40, 185);
            this.btRegistrarAgente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRegistrarAgente.Name = "btRegistrarAgente";
            this.btRegistrarAgente.Size = new System.Drawing.Size(339, 62);
            this.btRegistrarAgente.TabIndex = 53;
            this.btRegistrarAgente.Text = "Registrar Agente";
            this.btRegistrarAgente.UseVisualStyleBackColor = true;
            this.btRegistrarAgente.Click += new System.EventHandler(this.btRegistrarAgente_Click);
            // 
            // btModificarAgente
            // 
            this.btModificarAgente.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificarAgente.Location = new System.Drawing.Point(645, 185);
            this.btModificarAgente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btModificarAgente.Name = "btModificarAgente";
            this.btModificarAgente.Size = new System.Drawing.Size(363, 62);
            this.btModificarAgente.TabIndex = 52;
            this.btModificarAgente.Text = "Consultar Agente";
            this.btModificarAgente.UseVisualStyleBackColor = true;
            this.btModificarAgente.Click += new System.EventHandler(this.btModificarAgente_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(804, 409);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(231, 62);
            this.btRegresar.TabIndex = 51;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbMenu.Font = new System.Drawing.Font("Algerian", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMenu.Location = new System.Drawing.Point(444, 55);
            this.lbMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(147, 53);
            this.lbMenu.TabIndex = 49;
            this.lbMenu.Text = "Menu";
            // 
            // MantenedorAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1059, 482);
            this.Controls.Add(this.btRegistrarAgente);
            this.Controls.Add(this.btModificarAgente);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.lbMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MantenedorAgente";
            this.Text = "MantenedorAgente";
            this.Load += new System.EventHandler(this.MantenedorAgente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegistrarAgente;
        private System.Windows.Forms.Button btModificarAgente;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Label lbMenu;
    }
}