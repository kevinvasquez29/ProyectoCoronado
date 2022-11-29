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
            this.cboxInmuebles.Location = new System.Drawing.Point(144, 269);
            this.cboxInmuebles.Margin = new System.Windows.Forms.Padding(4);
            this.cboxInmuebles.Name = "cboxInmuebles";
            this.cboxInmuebles.Size = new System.Drawing.Size(241, 24);
            this.cboxInmuebles.TabIndex = 61;
            // 
            // btRegresarInmueble
            // 
            this.btRegresarInmueble.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresarInmueble.Location = new System.Drawing.Point(577, 406);
            this.btRegresarInmueble.Margin = new System.Windows.Forms.Padding(4);
            this.btRegresarInmueble.Name = "btRegresarInmueble";
            this.btRegresarInmueble.Size = new System.Drawing.Size(231, 62);
            this.btRegresarInmueble.TabIndex = 60;
            this.btRegresarInmueble.Text = "Regresar";
            this.btRegresarInmueble.UseVisualStyleBackColor = true;
            // 
            // AceptarRegisInmueble
            // 
            this.AceptarRegisInmueble.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarRegisInmueble.Location = new System.Drawing.Point(490, 231);
            this.AceptarRegisInmueble.Margin = new System.Windows.Forms.Padding(4);
            this.AceptarRegisInmueble.Name = "AceptarRegisInmueble";
            this.AceptarRegisInmueble.Size = new System.Drawing.Size(231, 62);
            this.AceptarRegisInmueble.TabIndex = 59;
            this.AceptarRegisInmueble.Text = "Aceptar";
            this.AceptarRegisInmueble.UseVisualStyleBackColor = true;
            // 
            // IngreseTipoDeInmueble
            // 
            this.IngreseTipoDeInmueble.AutoSize = true;
            this.IngreseTipoDeInmueble.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngreseTipoDeInmueble.Location = new System.Drawing.Point(97, 219);
            this.IngreseTipoDeInmueble.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IngreseTipoDeInmueble.Name = "IngreseTipoDeInmueble";
            this.IngreseTipoDeInmueble.Size = new System.Drawing.Size(331, 25);
            this.IngreseTipoDeInmueble.TabIndex = 58;
            this.IngreseTipoDeInmueble.Text = "Ingrese Tipo De Inmueble";
            // 
            // RegistrarInmueble
            // 
            this.RegistrarInmueble.AutoSize = true;
            this.RegistrarInmueble.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RegistrarInmueble.Font = new System.Drawing.Font("Algerian", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarInmueble.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegistrarInmueble.Location = new System.Drawing.Point(142, 57);
            this.RegistrarInmueble.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegistrarInmueble.Name = "RegistrarInmueble";
            this.RegistrarInmueble.Size = new System.Drawing.Size(526, 53);
            this.RegistrarInmueble.TabIndex = 57;
            this.RegistrarInmueble.Text = "Registrar Inmueble";
            // 
            // MantenedorDeInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 481);
            this.Controls.Add(this.cboxInmuebles);
            this.Controls.Add(this.btRegresarInmueble);
            this.Controls.Add(this.AceptarRegisInmueble);
            this.Controls.Add(this.IngreseTipoDeInmueble);
            this.Controls.Add(this.RegistrarInmueble);
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