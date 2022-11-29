namespace ProyectoCoronado
{
    partial class MenuVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVentas));
            this.btConsultarVenta = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btVentaPropio = new System.Windows.Forms.Button();
            this.lbVenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConsultarVenta
            // 
            this.btConsultarVenta.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarVenta.Location = new System.Drawing.Point(656, 231);
            this.btConsultarVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btConsultarVenta.Name = "btConsultarVenta";
            this.btConsultarVenta.Size = new System.Drawing.Size(301, 114);
            this.btConsultarVenta.TabIndex = 57;
            this.btConsultarVenta.Text = "Consultar Venta Inmuebles";
            this.btConsultarVenta.UseVisualStyleBackColor = true;
            this.btConsultarVenta.Click += new System.EventHandler(this.btConsultarVenta_Click);
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(797, 494);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(160, 48);
            this.btSalir.TabIndex = 56;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btVentaPropio
            // 
            this.btVentaPropio.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVentaPropio.Location = new System.Drawing.Point(48, 231);
            this.btVentaPropio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btVentaPropio.Name = "btVentaPropio";
            this.btVentaPropio.Size = new System.Drawing.Size(309, 114);
            this.btVentaPropio.TabIndex = 55;
            this.btVentaPropio.Text = "Venta de inmuebles";
            this.btVentaPropio.UseVisualStyleBackColor = true;
            this.btVentaPropio.Click += new System.EventHandler(this.btVentaPropio_Click);
            // 
            // lbVenta
            // 
            this.lbVenta.AutoSize = true;
            this.lbVenta.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVenta.Location = new System.Drawing.Point(405, 57);
            this.lbVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVenta.Name = "lbVenta";
            this.lbVenta.Size = new System.Drawing.Size(185, 66);
            this.lbVenta.TabIndex = 54;
            this.lbVenta.Text = "Menu";
            // 
            // MenuVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(971, 554);
            this.Controls.Add(this.btConsultarVenta);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btVentaPropio);
            this.Controls.Add(this.lbVenta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuVentas";
            this.Text = "MenuVentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConsultarVenta;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btVentaPropio;
        private System.Windows.Forms.Label lbVenta;
    }
}