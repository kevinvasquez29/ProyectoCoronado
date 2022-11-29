namespace ProyectoCoronado
{
    partial class ModificarCita
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
            this.btDeshabilitar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.checkBoxRealizada = new System.Windows.Forms.CheckBox();
            this.checkBoxHabilitado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxHoraCita = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCita = new System.Windows.Forms.DateTimePicker();
            this.lbFechaCita = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDeshabilitar
            // 
            this.btDeshabilitar.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeshabilitar.Location = new System.Drawing.Point(572, 229);
            this.btDeshabilitar.Name = "btDeshabilitar";
            this.btDeshabilitar.Size = new System.Drawing.Size(178, 36);
            this.btDeshabilitar.TabIndex = 64;
            this.btDeshabilitar.Text = "Deshabilitar";
            this.btDeshabilitar.UseVisualStyleBackColor = true;
            this.btDeshabilitar.Click += new System.EventHandler(this.btDeshabilitar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(582, 370);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(188, 54);
            this.btnRegresar.TabIndex = 63;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(572, 145);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(178, 36);
            this.btnModificar.TabIndex = 62;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // checkBoxRealizada
            // 
            this.checkBoxRealizada.AutoSize = true;
            this.checkBoxRealizada.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRealizada.Location = new System.Drawing.Point(209, 371);
            this.checkBoxRealizada.Name = "checkBoxRealizada";
            this.checkBoxRealizada.Size = new System.Drawing.Size(195, 25);
            this.checkBoxRealizada.TabIndex = 61;
            this.checkBoxRealizada.Text = "Cita Realizada";
            this.checkBoxRealizada.UseVisualStyleBackColor = true;
            // 
            // checkBoxHabilitado
            // 
            this.checkBoxHabilitado.AutoSize = true;
            this.checkBoxHabilitado.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHabilitado.Location = new System.Drawing.Point(14, 371);
            this.checkBoxHabilitado.Name = "checkBoxHabilitado";
            this.checkBoxHabilitado.Size = new System.Drawing.Size(147, 25);
            this.checkBoxHabilitado.TabIndex = 60;
            this.checkBoxHabilitado.Text = "Habilitado";
            this.checkBoxHabilitado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 42);
            this.label1.TabIndex = 58;
            this.label1.Text = "Modificar Cita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "Hora de la Cita";
            // 
            // comboBoxHoraCita
            // 
            this.comboBoxHoraCita.FormattingEnabled = true;
            this.comboBoxHoraCita.Items.AddRange(new object[] {
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00"});
            this.comboBoxHoraCita.Location = new System.Drawing.Point(218, 253);
            this.comboBoxHoraCita.Name = "comboBoxHoraCita";
            this.comboBoxHoraCita.Size = new System.Drawing.Size(167, 21);
            this.comboBoxHoraCita.TabIndex = 56;
            // 
            // dateTimePickerCita
            // 
            this.dateTimePickerCita.Location = new System.Drawing.Point(228, 145);
            this.dateTimePickerCita.Name = "dateTimePickerCita";
            this.dateTimePickerCita.Size = new System.Drawing.Size(229, 20);
            this.dateTimePickerCita.TabIndex = 55;
            // 
            // lbFechaCita
            // 
            this.lbFechaCita.AutoSize = true;
            this.lbFechaCita.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaCita.Location = new System.Drawing.Point(12, 140);
            this.lbFechaCita.Name = "lbFechaCita";
            this.lbFechaCita.Size = new System.Drawing.Size(222, 25);
            this.lbFechaCita.TabIndex = 54;
            this.lbFechaCita.Text = "Fecha de la Cita";
            // 
            // ModificarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 435);
            this.Controls.Add(this.btDeshabilitar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.checkBoxRealizada);
            this.Controls.Add(this.checkBoxHabilitado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxHoraCita);
            this.Controls.Add(this.dateTimePickerCita);
            this.Controls.Add(this.lbFechaCita);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModificarCita";
            this.Text = "ModificarCita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDeshabilitar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.CheckBox checkBoxRealizada;
        private System.Windows.Forms.CheckBox checkBoxHabilitado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxHoraCita;
        private System.Windows.Forms.DateTimePicker dateTimePickerCita;
        private System.Windows.Forms.Label lbFechaCita;
    }
}