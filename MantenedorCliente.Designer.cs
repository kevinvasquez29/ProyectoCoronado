namespace ProyectoCoronado
{
    partial class MantenedorCliente
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
            this.btRegistrar = new System.Windows.Forms.Button();
            this.btLista = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btRegistrar
            // 
            this.btRegistrar.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrar.Location = new System.Drawing.Point(13, 220);
            this.btRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(339, 62);
            this.btRegistrar.TabIndex = 58;
            this.btRegistrar.Text = "Registrar Cliente";
            this.btRegistrar.UseVisualStyleBackColor = true;
            // 
            // btLista
            // 
            this.btLista.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLista.Location = new System.Drawing.Point(560, 220);
            this.btLista.Margin = new System.Windows.Forms.Padding(4);
            this.btLista.Name = "btLista";
            this.btLista.Size = new System.Drawing.Size(363, 62);
            this.btLista.TabIndex = 57;
            this.btLista.Text = "Consultar Cliente";
            this.btLista.UseVisualStyleBackColor = true;
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(692, 430);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(231, 62);
            this.btRegresar.TabIndex = 56;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbMenu.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMenu.Location = new System.Drawing.Point(354, 61);
            this.lbMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(185, 66);
            this.lbMenu.TabIndex = 54;
            this.lbMenu.Text = "Menu";
            // 
            // MantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 515);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.btLista);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.lbMenu);
            this.Name = "MantenedorCliente";
            this.Text = "MantenedorCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Button btLista;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Label lbMenu;
    }
}