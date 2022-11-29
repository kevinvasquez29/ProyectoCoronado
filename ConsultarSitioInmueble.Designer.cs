namespace ProyectoCoronado
{
    partial class ConsultarSitioInmueble
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
            this.btRegresar = new System.Windows.Forms.Button();
            this.datagridSitioInmueble = new System.Windows.Forms.DataGridView();
            this.lbConsultarAgente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSitioInmueble)).BeginInit();
            this.SuspendLayout();
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(580, 363);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(120, 39);
            this.btRegresar.TabIndex = 11;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // datagridSitioInmueble
            // 
            this.datagridSitioInmueble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSitioInmueble.Location = new System.Drawing.Point(16, 93);
            this.datagridSitioInmueble.Name = "datagridSitioInmueble";
            this.datagridSitioInmueble.RowHeadersWidth = 51;
            this.datagridSitioInmueble.Size = new System.Drawing.Size(479, 309);
            this.datagridSitioInmueble.TabIndex = 10;
            // 
            // lbConsultarAgente
            // 
            this.lbConsultarAgente.AutoSize = true;
            this.lbConsultarAgente.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarAgente.Location = new System.Drawing.Point(10, 37);
            this.lbConsultarAgente.Name = "lbConsultarAgente";
            this.lbConsultarAgente.Size = new System.Drawing.Size(458, 35);
            this.lbConsultarAgente.TabIndex = 8;
            this.lbConsultarAgente.Text = "Consultar Sitio Inmueble";
            // 
            // ConsultarSitioInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 424);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.datagridSitioInmueble);
            this.Controls.Add(this.lbConsultarAgente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultarSitioInmueble";
            this.Text = "ConsultarSitioInmueble";
            ((System.ComponentModel.ISupportInitialize)(this.datagridSitioInmueble)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.DataGridView datagridSitioInmueble;
        private System.Windows.Forms.Label lbConsultarAgente;
    }
}