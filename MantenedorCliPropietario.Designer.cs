namespace ProyectoCoronado
{
    partial class MantenedorCliPropietario
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
            this.btRegistrar.Location = new System.Drawing.Point(17, 218);
            this.btRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(339, 62);
            this.btRegistrar.TabIndex = 63;
            this.btRegistrar.Text = "Registrar ";
            this.btRegistrar.UseVisualStyleBackColor = true;
            // 
            // btLista
            // 
            this.btLista.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLista.Location = new System.Drawing.Point(601, 218);
            this.btLista.Margin = new System.Windows.Forms.Padding(4);
            this.btLista.Name = "btLista";
            this.btLista.Size = new System.Drawing.Size(363, 62);
            this.btLista.TabIndex = 62;
            this.btLista.Text = "Consultar";
            this.btLista.UseVisualStyleBackColor = true;
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(733, 462);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(231, 62);
            this.btRegresar.TabIndex = 61;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbMenu.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMenu.Location = new System.Drawing.Point(388, 69);
            this.lbMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(185, 66);
            this.lbMenu.TabIndex = 59;
            this.lbMenu.Text = "Menu";
            // 
            // MantenedorCliPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 537);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.btLista);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.lbMenu);
            this.Name = "MantenedorCliPropietario";
            this.Text = "MantenedorCliPropietario";
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