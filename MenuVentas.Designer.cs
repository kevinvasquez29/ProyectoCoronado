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
            this.btConsultarVenta = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btVentaPropio = new System.Windows.Forms.Button();
            this.lbVenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConsultarVenta
            // 
            this.btConsultarVenta.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarVenta.Location = new System.Drawing.Point(664, 234);
            this.btConsultarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btConsultarVenta.Name = "btConsultarVenta";
            this.btConsultarVenta.Size = new System.Drawing.Size(301, 90);
            this.btConsultarVenta.TabIndex = 57;
            this.btConsultarVenta.Text = "Consultar Venta Inmuebles";
            this.btConsultarVenta.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(805, 498);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(160, 48);
            this.btSalir.TabIndex = 56;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // btVentaPropio
            // 
            this.btVentaPropio.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVentaPropio.Location = new System.Drawing.Point(36, 234);
            this.btVentaPropio.Margin = new System.Windows.Forms.Padding(4);
            this.btVentaPropio.Name = "btVentaPropio";
            this.btVentaPropio.Size = new System.Drawing.Size(301, 90);
            this.btVentaPropio.TabIndex = 55;
            this.btVentaPropio.Text = "Venta de inmuebles";
            this.btVentaPropio.UseVisualStyleBackColor = true;
            // 
            // lbVenta
            // 
            this.lbVenta.AutoSize = true;
            this.lbVenta.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVenta.Location = new System.Drawing.Point(397, 54);
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
            this.ClientSize = new System.Drawing.Size(994, 559);
            this.Controls.Add(this.btConsultarVenta);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btVentaPropio);
            this.Controls.Add(this.lbVenta);
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