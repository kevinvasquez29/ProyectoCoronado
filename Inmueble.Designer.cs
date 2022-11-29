namespace ProyectoCoronado
{
    partial class Inmueble
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
            this.MostrarInmueble = new System.Windows.Forms.Button();
            this.btRegistrarInmueble = new System.Windows.Forms.Button();
            this.lbInmueble = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(539, 350);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(173, 50);
            this.btRegresar.TabIndex = 57;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // MostrarInmueble
            // 
            this.MostrarInmueble.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarInmueble.Location = new System.Drawing.Point(437, 162);
            this.MostrarInmueble.Name = "MostrarInmueble";
            this.MostrarInmueble.Size = new System.Drawing.Size(275, 78);
            this.MostrarInmueble.TabIndex = 56;
            this.MostrarInmueble.Text = "Consultar Inmuebles";
            this.MostrarInmueble.UseVisualStyleBackColor = true;
            this.MostrarInmueble.Click += new System.EventHandler(this.MostrarInmueble_Click);
            // 
            // btRegistrarInmueble
            // 
            this.btRegistrarInmueble.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarInmueble.Location = new System.Drawing.Point(10, 162);
            this.btRegistrarInmueble.Name = "btRegistrarInmueble";
            this.btRegistrarInmueble.Size = new System.Drawing.Size(254, 78);
            this.btRegistrarInmueble.TabIndex = 55;
            this.btRegistrarInmueble.Text = "Registrar Inmueble";
            this.btRegistrarInmueble.UseVisualStyleBackColor = true;
            this.btRegistrarInmueble.Click += new System.EventHandler(this.btRegistrarInmueble_Click);
            // 
            // lbInmueble
            // 
            this.lbInmueble.AutoSize = true;
            this.lbInmueble.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbInmueble.Font = new System.Drawing.Font("Algerian", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInmueble.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbInmueble.Location = new System.Drawing.Point(254, 34);
            this.lbInmueble.Name = "lbInmueble";
            this.lbInmueble.Size = new System.Drawing.Size(198, 71);
            this.lbInmueble.TabIndex = 54;
            this.lbInmueble.Text = "Menu";
            // 
            // Inmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 418);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.MostrarInmueble);
            this.Controls.Add(this.btRegistrarInmueble);
            this.Controls.Add(this.lbInmueble);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Inmueble";
            this.Text = "Inmueble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Button MostrarInmueble;
        private System.Windows.Forms.Button btRegistrarInmueble;
        private System.Windows.Forms.Label lbInmueble;
    }
}