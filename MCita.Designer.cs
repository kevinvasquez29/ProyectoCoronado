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
            this.btnRegresarCita = new System.Windows.Forms.Button();
            this.btnMostrarCita = new System.Windows.Forms.Button();
            this.btnRegistrarCita = new System.Windows.Forms.Button();
            this.lbCita = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegresarCita
            // 
            this.btnRegresarCita.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarCita.Location = new System.Drawing.Point(610, 388);
            this.btnRegresarCita.Name = "btnRegresarCita";
            this.btnRegresarCita.Size = new System.Drawing.Size(130, 34);
            this.btnRegresarCita.TabIndex = 8;
            this.btnRegresarCita.Text = "Regresar";
            this.btnRegresarCita.UseVisualStyleBackColor = true;
            this.btnRegresarCita.Click += new System.EventHandler(this.btnRegresarCita_Click);
            // 
            // btnMostrarCita
            // 
            this.btnMostrarCita.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarCita.Location = new System.Drawing.Point(504, 184);
            this.btnMostrarCita.Name = "btnMostrarCita";
            this.btnMostrarCita.Size = new System.Drawing.Size(236, 68);
            this.btnMostrarCita.TabIndex = 7;
            this.btnMostrarCita.Text = "Consultar cita";
            this.btnMostrarCita.UseVisualStyleBackColor = true;
            this.btnMostrarCita.Click += new System.EventHandler(this.btnMostrarCita_Click);
            // 
            // btnRegistrarCita
            // 
            this.btnRegistrarCita.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCita.Location = new System.Drawing.Point(27, 184);
            this.btnRegistrarCita.Name = "btnRegistrarCita";
            this.btnRegistrarCita.Size = new System.Drawing.Size(236, 68);
            this.btnRegistrarCita.TabIndex = 6;
            this.btnRegistrarCita.Text = "Registrar Cita";
            this.btnRegistrarCita.UseVisualStyleBackColor = true;
            this.btnRegistrarCita.Click += new System.EventHandler(this.btnRegistrarCita_Click);
            // 
            // lbCita
            // 
            this.lbCita.AutoSize = true;
            this.lbCita.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCita.Location = new System.Drawing.Point(311, 50);
            this.lbCita.Name = "lbCita";
            this.lbCita.Size = new System.Drawing.Size(150, 54);
            this.lbCita.TabIndex = 5;
            this.lbCita.Text = "Menu";
            // 
            // MCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 433);
            this.Controls.Add(this.btnRegresarCita);
            this.Controls.Add(this.btnMostrarCita);
            this.Controls.Add(this.btnRegistrarCita);
            this.Controls.Add(this.lbCita);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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