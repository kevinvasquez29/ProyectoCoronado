namespace ProyectoCoronado
{
    partial class MantenedorSector
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
            this.lbRegistrar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.lbSector = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRegistrar
            // 
            this.lbRegistrar.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistrar.Location = new System.Drawing.Point(28, 186);
            this.lbRegistrar.Name = "lbRegistrar";
            this.lbRegistrar.Size = new System.Drawing.Size(254, 50);
            this.lbRegistrar.TabIndex = 58;
            this.lbRegistrar.Text = "Registrar Sector";
            this.lbRegistrar.UseVisualStyleBackColor = true;
            this.lbRegistrar.Click += new System.EventHandler(this.lbRegistrar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.Location = new System.Drawing.Point(482, 186);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(272, 50);
            this.btConsultar.TabIndex = 57;
            this.btConsultar.Text = "Consultar Sector";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(580, 384);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(173, 50);
            this.btRegresar.TabIndex = 56;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // lbSector
            // 
            this.lbSector.AutoSize = true;
            this.lbSector.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbSector.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSector.Location = new System.Drawing.Point(307, 54);
            this.lbSector.Name = "lbSector";
            this.lbSector.Size = new System.Drawing.Size(150, 54);
            this.lbSector.TabIndex = 54;
            this.lbSector.Text = "Menu";
            // 
            // MantenedorSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 444);
            this.Controls.Add(this.lbRegistrar);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.lbSector);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MantenedorSector";
            this.Text = "MantenedorSector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lbRegistrar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Label lbSector;
    }
}