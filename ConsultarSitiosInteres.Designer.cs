namespace ProyectoCoronado
{
    partial class ConsultarSitiosInteres
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.lbCodigoSitio = new System.Windows.Forms.Label();
            this.txtCodigoSitio = new System.Windows.Forms.TextBox();
            this.lbVistiaSitio = new System.Windows.Forms.Label();
            this.DataGridVerSitioInteres = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVerSitioInteres)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(610, 391);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(168, 30);
            this.btnRegresar.TabIndex = 52;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(555, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "a modificar";
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(533, 264);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(168, 30);
            this.btAceptar.TabIndex = 49;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // lbCodigoSitio
            // 
            this.lbCodigoSitio.AutoSize = true;
            this.lbCodigoSitio.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoSitio.Location = new System.Drawing.Point(444, 119);
            this.lbCodigoSitio.Name = "lbCodigoSitio";
            this.lbCodigoSitio.Size = new System.Drawing.Size(378, 21);
            this.lbCodigoSitio.TabIndex = 48;
            this.lbCodigoSitio.Text = "Ingrese Codigo de Sitio de Interés";
            // 
            // txtCodigoSitio
            // 
            this.txtCodigoSitio.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoSitio.Location = new System.Drawing.Point(472, 210);
            this.txtCodigoSitio.Multiline = true;
            this.txtCodigoSitio.Name = "txtCodigoSitio";
            this.txtCodigoSitio.Size = new System.Drawing.Size(294, 30);
            this.txtCodigoSitio.TabIndex = 47;
            // 
            // lbVistiaSitio
            // 
            this.lbVistiaSitio.AutoSize = true;
            this.lbVistiaSitio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbVistiaSitio.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVistiaSitio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbVistiaSitio.Location = new System.Drawing.Point(-1, 44);
            this.lbVistiaSitio.Name = "lbVistiaSitio";
            this.lbVistiaSitio.Size = new System.Drawing.Size(424, 35);
            this.lbVistiaSitio.TabIndex = 46;
            this.lbVistiaSitio.Text = "Visita sitios de Interés";
            // 
            // DataGridVerSitioInteres
            // 
            this.DataGridVerSitioInteres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVerSitioInteres.Location = new System.Drawing.Point(5, 119);
            this.DataGridVerSitioInteres.Name = "DataGridVerSitioInteres";
            this.DataGridVerSitioInteres.RowHeadersWidth = 51;
            this.DataGridVerSitioInteres.Size = new System.Drawing.Size(432, 297);
            this.DataGridVerSitioInteres.TabIndex = 45;
            // 
            // ConsultarSitiosInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 452);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lbCodigoSitio);
            this.Controls.Add(this.txtCodigoSitio);
            this.Controls.Add(this.lbVistiaSitio);
            this.Controls.Add(this.DataGridVerSitioInteres);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultarSitiosInteres";
            this.Text = "ConsultarSitiosInteres";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVerSitioInteres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label lbCodigoSitio;
        private System.Windows.Forms.TextBox txtCodigoSitio;
        private System.Windows.Forms.Label lbVistiaSitio;
        private System.Windows.Forms.DataGridView DataGridVerSitioInteres;
    }
}