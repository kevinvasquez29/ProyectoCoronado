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
            this.label1 = new System.Windows.Forms.Label();
            this.lbDniClienteCita = new System.Windows.Forms.Label();
            this.dataGridViewMostrarCita = new System.Windows.Forms.DataGridView();
            this.txtIDClienteCita = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalirMostrarCita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarCita)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Cita";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbDniClienteCita
            // 
            this.lbDniClienteCita.AutoSize = true;
            this.lbDniClienteCita.Location = new System.Drawing.Point(569, 113);
            this.lbDniClienteCita.Name = "lbDniClienteCita";
            this.lbDniClienteCita.Size = new System.Drawing.Size(39, 13);
            this.lbDniClienteCita.TabIndex = 1;
            this.lbDniClienteCita.Text = "ID Cita";
            // 
            // dataGridViewMostrarCita
            // 
            this.dataGridViewMostrarCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrarCita.Location = new System.Drawing.Point(72, 97);
            this.dataGridViewMostrarCita.Name = "dataGridViewMostrarCita";
            this.dataGridViewMostrarCita.Size = new System.Drawing.Size(418, 266);
            this.dataGridViewMostrarCita.TabIndex = 2;
            // 
            // txtIDClienteCita
            // 
            this.txtIDClienteCita.Location = new System.Drawing.Point(513, 155);
            this.txtIDClienteCita.Name = "txtIDClienteCita";
            this.txtIDClienteCita.Size = new System.Drawing.Size(168, 20);
            this.txtIDClienteCita.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(559, 218);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnSalirMostrarCita
            // 
            this.btnSalirMostrarCita.Location = new System.Drawing.Point(633, 364);
            this.btnSalirMostrarCita.Name = "btnSalirMostrarCita";
            this.btnSalirMostrarCita.Size = new System.Drawing.Size(75, 23);
            this.btnSalirMostrarCita.TabIndex = 5;
            this.btnSalirMostrarCita.Text = "Salir";
            this.btnSalirMostrarCita.UseVisualStyleBackColor = true;
            // 
            // MMostrarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirMostrarCita);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtIDClienteCita);
            this.Controls.Add(this.dataGridViewMostrarCita);
            this.Controls.Add(this.lbDniClienteCita);
            this.Controls.Add(this.label1);
            this.Name = "MMostrarCita";
            this.Text = "MMostrarCita";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDniClienteCita;
        private System.Windows.Forms.DataGridView dataGridViewMostrarCita;
        private System.Windows.Forms.TextBox txtIDClienteCita;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalirMostrarCita;
    }
}