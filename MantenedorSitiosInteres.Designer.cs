namespace ProyectoCoronado
{
    partial class MantenedorSitiosInteres
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
            this.btnConsultarSitioInmueble = new System.Windows.Forms.Button();
            this.btnregistrarSitioInmueble = new System.Windows.Forms.Button();
            this.btnListarSI = new System.Windows.Forms.Button();
            this.btRegistrarSitio = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.lbSitioInteres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsultarSitioInmueble
            // 
            this.btnConsultarSitioInmueble.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarSitioInmueble.Location = new System.Drawing.Point(490, 260);
            this.btnConsultarSitioInmueble.Name = "btnConsultarSitioInmueble";
            this.btnConsultarSitioInmueble.Size = new System.Drawing.Size(250, 77);
            this.btnConsultarSitioInmueble.TabIndex = 68;
            this.btnConsultarSitioInmueble.Text = "Consultar Sitio Inmueble";
            this.btnConsultarSitioInmueble.UseVisualStyleBackColor = true;
            this.btnConsultarSitioInmueble.Click += new System.EventHandler(this.btnConsultarSitioInmueble_Click);
            // 
            // btnregistrarSitioInmueble
            // 
            this.btnregistrarSitioInmueble.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrarSitioInmueble.Location = new System.Drawing.Point(30, 260);
            this.btnregistrarSitioInmueble.Name = "btnregistrarSitioInmueble";
            this.btnregistrarSitioInmueble.Size = new System.Drawing.Size(250, 77);
            this.btnregistrarSitioInmueble.TabIndex = 67;
            this.btnregistrarSitioInmueble.Text = "Registrar Sitio Inmueble";
            this.btnregistrarSitioInmueble.UseVisualStyleBackColor = true;
            this.btnregistrarSitioInmueble.Click += new System.EventHandler(this.btnregistrarSitioInmueble_Click);
            // 
            // btnListarSI
            // 
            this.btnListarSI.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarSI.Location = new System.Drawing.Point(490, 143);
            this.btnListarSI.Name = "btnListarSI";
            this.btnListarSI.Size = new System.Drawing.Size(250, 77);
            this.btnListarSI.TabIndex = 66;
            this.btnListarSI.Text = "Consultar Sitios de interés";
            this.btnListarSI.UseVisualStyleBackColor = true;
            this.btnListarSI.Click += new System.EventHandler(this.btnListarSI_Click);
            // 
            // btRegistrarSitio
            // 
            this.btRegistrarSitio.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarSitio.Location = new System.Drawing.Point(30, 143);
            this.btRegistrarSitio.Name = "btRegistrarSitio";
            this.btRegistrarSitio.Size = new System.Drawing.Size(250, 77);
            this.btRegistrarSitio.TabIndex = 65;
            this.btRegistrarSitio.Text = "Registrar Sitio de interés";
            this.btRegistrarSitio.UseVisualStyleBackColor = true;
            this.btRegistrarSitio.Click += new System.EventHandler(this.btRegistrarSitio_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(567, 400);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(173, 50);
            this.btRegresar.TabIndex = 64;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // lbSitioInteres
            // 
            this.lbSitioInteres.AutoSize = true;
            this.lbSitioInteres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbSitioInteres.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSitioInteres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSitioInteres.Location = new System.Drawing.Point(321, 36);
            this.lbSitioInteres.Name = "lbSitioInteres";
            this.lbSitioInteres.Size = new System.Drawing.Size(150, 54);
            this.lbSitioInteres.TabIndex = 62;
            this.lbSitioInteres.Text = "Menu";
            this.lbSitioInteres.Click += new System.EventHandler(this.lbSitioInteres_Click);
            // 
            // MantenedorSitiosInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 461);
            this.Controls.Add(this.btnConsultarSitioInmueble);
            this.Controls.Add(this.btnregistrarSitioInmueble);
            this.Controls.Add(this.btnListarSI);
            this.Controls.Add(this.btRegistrarSitio);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.lbSitioInteres);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MantenedorSitiosInteres";
            this.Text = "MantenedorSitiosInteres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarSitioInmueble;
        private System.Windows.Forms.Button btnregistrarSitioInmueble;
        private System.Windows.Forms.Button btnListarSI;
        private System.Windows.Forms.Button btRegistrarSitio;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Label lbSitioInteres;
    }
}