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
            this.btRegresar.Location = new System.Drawing.Point(773, 447);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(160, 48);
            this.btRegresar.TabIndex = 11;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            // 
            // datagridSitioInmueble
            // 
            this.datagridSitioInmueble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSitioInmueble.Location = new System.Drawing.Point(21, 115);
            this.datagridSitioInmueble.Margin = new System.Windows.Forms.Padding(4);
            this.datagridSitioInmueble.Name = "datagridSitioInmueble";
            this.datagridSitioInmueble.RowHeadersWidth = 51;
            this.datagridSitioInmueble.Size = new System.Drawing.Size(639, 380);
            this.datagridSitioInmueble.TabIndex = 10;
            // 
            // lbConsultarAgente
            // 
            this.lbConsultarAgente.AutoSize = true;
            this.lbConsultarAgente.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarAgente.Location = new System.Drawing.Point(13, 45);
            this.lbConsultarAgente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConsultarAgente.Name = "lbConsultarAgente";
            this.lbConsultarAgente.Size = new System.Drawing.Size(563, 45);
            this.lbConsultarAgente.TabIndex = 8;
            this.lbConsultarAgente.Text = "Consultar Sitio Inmueble";
            // 
            // ConsultarSitioInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 522);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.datagridSitioInmueble);
            this.Controls.Add(this.lbConsultarAgente);
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