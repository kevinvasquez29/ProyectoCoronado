namespace ProyectoCoronado
{
    partial class ConsultarVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarVentas));
            this.dataGridViewCita = new System.Windows.Forms.DataGridView();
            this.dataGridViewVenta = new System.Windows.Forms.DataGridView();
            this.btRegresar = new System.Windows.Forms.Button();
            this.lbDatosVentas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCita
            // 
            this.dataGridViewCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCita.Location = new System.Drawing.Point(13, 324);
            this.dataGridViewCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCita.Name = "dataGridViewCita";
            this.dataGridViewCita.RowHeadersWidth = 51;
            this.dataGridViewCita.Size = new System.Drawing.Size(776, 214);
            this.dataGridViewCita.TabIndex = 13;
            // 
            // dataGridViewVenta
            // 
            this.dataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVenta.Location = new System.Drawing.Point(13, 102);
            this.dataGridViewVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewVenta.Name = "dataGridViewVenta";
            this.dataGridViewVenta.RowHeadersWidth = 51;
            this.dataGridViewVenta.Size = new System.Drawing.Size(776, 214);
            this.dataGridViewVenta.TabIndex = 11;
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(829, 270);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(176, 106);
            this.btRegresar.TabIndex = 10;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // lbDatosVentas
            // 
            this.lbDatosVentas.AutoSize = true;
            this.lbDatosVentas.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatosVentas.Location = new System.Drawing.Point(13, 38);
            this.lbDatosVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDatosVentas.Name = "lbDatosVentas";
            this.lbDatosVentas.Size = new System.Drawing.Size(681, 45);
            this.lbDatosVentas.TabIndex = 9;
            this.lbDatosVentas.Text = "Consultar venta de inmuebles";
            // 
            // ConsultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1032, 550);
            this.Controls.Add(this.dataGridViewCita);
            this.Controls.Add(this.dataGridViewVenta);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.lbDatosVentas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConsultarVentas";
            this.Text = "ConsultarVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCita;
        private System.Windows.Forms.DataGridView dataGridViewVenta;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Label lbDatosVentas;
    }
}