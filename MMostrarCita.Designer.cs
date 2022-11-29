namespace ProyectoCoronado
{
    partial class MMostrarCita
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
            this.dataGridViewMostrarCita = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalirMostrarCita = new System.Windows.Forms.Button();
            this.txtIDClienteCita = new System.Windows.Forms.TextBox();
            this.lbDniClienteCita = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarCita)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMostrarCita
            // 
            this.dataGridViewMostrarCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrarCita.Location = new System.Drawing.Point(26, 65);
            this.dataGridViewMostrarCita.Name = "dataGridViewMostrarCita";
            this.dataGridViewMostrarCita.RowHeadersWidth = 51;
            this.dataGridViewMostrarCita.Size = new System.Drawing.Size(422, 356);
            this.dataGridViewMostrarCita.TabIndex = 36;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(538, 217);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(132, 31);
            this.btnAceptar.TabIndex = 35;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalirMostrarCita
            // 
            this.btnSalirMostrarCita.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirMostrarCita.Location = new System.Drawing.Point(709, 398);
            this.btnSalirMostrarCita.Name = "btnSalirMostrarCita";
            this.btnSalirMostrarCita.Size = new System.Drawing.Size(82, 37);
            this.btnSalirMostrarCita.TabIndex = 34;
            this.btnSalirMostrarCita.Text = "Salir";
            this.btnSalirMostrarCita.UseVisualStyleBackColor = true;
            this.btnSalirMostrarCita.Click += new System.EventHandler(this.btnSalirMostrarCita_Click);
            // 
            // txtIDClienteCita
            // 
            this.txtIDClienteCita.Location = new System.Drawing.Point(464, 158);
            this.txtIDClienteCita.Name = "txtIDClienteCita";
            this.txtIDClienteCita.Size = new System.Drawing.Size(298, 20);
            this.txtIDClienteCita.TabIndex = 33;
            // 
            // lbDniClienteCita
            // 
            this.lbDniClienteCita.AutoSize = true;
            this.lbDniClienteCita.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDniClienteCita.Location = new System.Drawing.Point(555, 107);
            this.lbDniClienteCita.Name = "lbDniClienteCita";
            this.lbDniClienteCita.Size = new System.Drawing.Size(95, 25);
            this.lbDniClienteCita.TabIndex = 32;
            this.lbDniClienteCita.Text = "ID Cita";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 42);
            this.label1.TabIndex = 30;
            this.label1.Text = "Consultar Cita";
            // 
            // MMostrarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMostrarCita);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnSalirMostrarCita);
            this.Controls.Add(this.txtIDClienteCita);
            this.Controls.Add(this.lbDniClienteCita);
            this.Controls.Add(this.label1);
            this.Name = "MMostrarCita";
            this.Text = "MMostrarCita";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMostrarCita;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalirMostrarCita;
        private System.Windows.Forms.TextBox txtIDClienteCita;
        private System.Windows.Forms.Label lbDniClienteCita;
        private System.Windows.Forms.Label label1;
    }
}