namespace ProyectoCoronado
{
    partial class MantenedorDeInmueble
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
            this.cboxInmuebles = new System.Windows.Forms.ComboBox();
            this.btRegresarInmueble = new System.Windows.Forms.Button();
            this.AceptarRegisInmueble = new System.Windows.Forms.Button();
            this.IngreseTipoDeInmueble = new System.Windows.Forms.Label();
            this.RegistrarInmueble = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxInmuebles
            // 
            this.cboxInmuebles.FormattingEnabled = true;
            this.cboxInmuebles.Items.AddRange(new object[] {
            "Casa",
            "Departamento",
            "Terreno"});
            this.cboxInmuebles.Location = new System.Drawing.Point(108, 219);
            this.cboxInmuebles.Name = "cboxInmuebles";
            this.cboxInmuebles.Size = new System.Drawing.Size(182, 21);
            this.cboxInmuebles.TabIndex = 61;
            // 
            // btRegresarInmueble
            // 
            this.btRegresarInmueble.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresarInmueble.Location = new System.Drawing.Point(433, 330);
            this.btRegresarInmueble.Name = "btRegresarInmueble";
            this.btRegresarInmueble.Size = new System.Drawing.Size(173, 50);
            this.btRegresarInmueble.TabIndex = 60;
            this.btRegresarInmueble.Text = "Regresar";
            this.btRegresarInmueble.UseVisualStyleBackColor = true;
            this.btRegresarInmueble.Click += new System.EventHandler(this.btRegresarInmueble_Click);
            // 
            // AceptarRegisInmueble
            // 
            this.AceptarRegisInmueble.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarRegisInmueble.Location = new System.Drawing.Point(368, 188);
            this.AceptarRegisInmueble.Name = "AceptarRegisInmueble";
            this.AceptarRegisInmueble.Size = new System.Drawing.Size(173, 50);
            this.AceptarRegisInmueble.TabIndex = 59;
            this.AceptarRegisInmueble.Text = "Aceptar";
            this.AceptarRegisInmueble.UseVisualStyleBackColor = true;
            this.AceptarRegisInmueble.Click += new System.EventHandler(this.AceptarRegisInmueble_Click);
            // 
            // IngreseTipoDeInmueble
            // 
            this.IngreseTipoDeInmueble.AutoSize = true;
            this.IngreseTipoDeInmueble.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngreseTipoDeInmueble.Location = new System.Drawing.Point(73, 178);
            this.IngreseTipoDeInmueble.Name = "IngreseTipoDeInmueble";
            this.IngreseTipoDeInmueble.Size = new System.Drawing.Size(278, 21);
            this.IngreseTipoDeInmueble.TabIndex = 58;
            this.IngreseTipoDeInmueble.Text = "Ingrese Tipo De Inmueble";
            // 
            // RegistrarInmueble
            // 
            this.RegistrarInmueble.AutoSize = true;
            this.RegistrarInmueble.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RegistrarInmueble.Font = new System.Drawing.Font("Algerian", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarInmueble.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegistrarInmueble.Location = new System.Drawing.Point(106, 46);
            this.RegistrarInmueble.Name = "RegistrarInmueble";
            this.RegistrarInmueble.Size = new System.Drawing.Size(432, 42);
            this.RegistrarInmueble.TabIndex = 57;
            this.RegistrarInmueble.Text = "Registrar Inmueble";
            // 
            // MantenedorDeInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 391);
            this.Controls.Add(this.cboxInmuebles);
            this.Controls.Add(this.btRegresarInmueble);
            this.Controls.Add(this.AceptarRegisInmueble);
            this.Controls.Add(this.IngreseTipoDeInmueble);
            this.Controls.Add(this.RegistrarInmueble);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MantenedorDeInmueble";
            this.Text = "MantenedorDeInmueble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxInmuebles;
        private System.Windows.Forms.Button btRegresarInmueble;
        private System.Windows.Forms.Button AceptarRegisInmueble;
        private System.Windows.Forms.Label IngreseTipoDeInmueble;
        private System.Windows.Forms.Label RegistrarInmueble;
    }
}