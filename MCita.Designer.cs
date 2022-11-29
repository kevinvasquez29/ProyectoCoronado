namespace ProyectoCoronado
{
    partial class MCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MCita));
            this.btnRegresarCita = new System.Windows.Forms.Button();
            this.btnMostrarCita = new System.Windows.Forms.Button();
            this.btnRegistrarCita = new System.Windows.Forms.Button();
            this.lbCita = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegresarCita
            // 
            this.btnRegresarCita.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarCita.Location = new System.Drawing.Point(813, 478);
            this.btnRegresarCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresarCita.Name = "btnRegresarCita";
            this.btnRegresarCita.Size = new System.Drawing.Size(173, 42);
            this.btnRegresarCita.TabIndex = 8;
            this.btnRegresarCita.Text = "Regresar";
            this.btnRegresarCita.UseVisualStyleBackColor = true;
            this.btnRegresarCita.Click += new System.EventHandler(this.btnRegresarCita_Click);
            // 
            // btnMostrarCita
            // 
            this.btnMostrarCita.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarCita.Location = new System.Drawing.Point(672, 226);
            this.btnMostrarCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarCita.Name = "btnMostrarCita";
            this.btnMostrarCita.Size = new System.Drawing.Size(315, 84);
            this.btnMostrarCita.TabIndex = 7;
            this.btnMostrarCita.Text = "Consultar cita";
            this.btnMostrarCita.UseVisualStyleBackColor = true;
            this.btnMostrarCita.Click += new System.EventHandler(this.btnMostrarCita_Click);
            // 
            // btnRegistrarCita
            // 
            this.btnRegistrarCita.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCita.Location = new System.Drawing.Point(36, 226);
            this.btnRegistrarCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarCita.Name = "btnRegistrarCita";
            this.btnRegistrarCita.Size = new System.Drawing.Size(315, 84);
            this.btnRegistrarCita.TabIndex = 6;
            this.btnRegistrarCita.Text = "Registrar Cita";
            this.btnRegistrarCita.UseVisualStyleBackColor = true;
            this.btnRegistrarCita.Click += new System.EventHandler(this.btnRegistrarCita_Click);
            // 
            // lbCita
            // 
            this.lbCita.AutoSize = true;
            this.lbCita.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCita.Location = new System.Drawing.Point(415, 62);
            this.lbCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCita.Name = "lbCita";
            this.lbCita.Size = new System.Drawing.Size(185, 66);
            this.lbCita.TabIndex = 5;
            this.lbCita.Text = "Menu";
            // 
            // MCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 533);
            this.Controls.Add(this.btnRegresarCita);
            this.Controls.Add(this.btnMostrarCita);
            this.Controls.Add(this.btnRegistrarCita);
            this.Controls.Add(this.lbCita);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MCita";
            this.Text = "MCita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresarCita;
        private System.Windows.Forms.Button btnMostrarCita;
        private System.Windows.Forms.Button btnRegistrarCita;
        private System.Windows.Forms.Label lbCita;
    }
}