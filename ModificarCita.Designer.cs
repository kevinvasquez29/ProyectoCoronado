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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarCita));
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
            this.btDeshabilitar.Location = new System.Drawing.Point(763, 282);
            this.btDeshabilitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDeshabilitar.Name = "btDeshabilitar";
            this.btDeshabilitar.Size = new System.Drawing.Size(237, 44);
            this.btDeshabilitar.TabIndex = 64;
            this.btDeshabilitar.Text = "Deshabilitar";
            this.btDeshabilitar.UseVisualStyleBackColor = true;
            this.btDeshabilitar.Click += new System.EventHandler(this.btDeshabilitar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(776, 455);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(251, 66);
            this.btnRegresar.TabIndex = 63;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(763, 178);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(237, 44);
            this.btnModificar.TabIndex = 62;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // checkBoxRealizada
            // 
            this.checkBoxRealizada.AutoSize = true;
            this.checkBoxRealizada.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRealizada.Location = new System.Drawing.Point(279, 457);
            this.checkBoxRealizada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxRealizada.Name = "checkBoxRealizada";
            this.checkBoxRealizada.Size = new System.Drawing.Size(233, 29);
            this.checkBoxRealizada.TabIndex = 61;
            this.checkBoxRealizada.Text = "Cita Realizada";
            this.checkBoxRealizada.UseVisualStyleBackColor = true;
            // 
            // checkBoxHabilitado
            // 
            this.checkBoxHabilitado.AutoSize = true;
            this.checkBoxHabilitado.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHabilitado.Location = new System.Drawing.Point(19, 457);
            this.checkBoxHabilitado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxHabilitado.Name = "checkBoxHabilitado";
            this.checkBoxHabilitado.Size = new System.Drawing.Size(175, 29);
            this.checkBoxHabilitado.TabIndex = 60;
            this.checkBoxHabilitado.Text = "Habilitado";
            this.checkBoxHabilitado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 53);
            this.label1.TabIndex = 58;
            this.label1.Text = "Modificar Cita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 31);
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
            this.comboBoxHoraCita.Location = new System.Drawing.Point(291, 311);
            this.comboBoxHoraCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxHoraCita.Name = "comboBoxHoraCita";
            this.comboBoxHoraCita.Size = new System.Drawing.Size(221, 24);
            this.comboBoxHoraCita.TabIndex = 56;
            // 
            // dateTimePickerCita
            // 
            this.dateTimePickerCita.Location = new System.Drawing.Point(304, 178);
            this.dateTimePickerCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerCita.Name = "dateTimePickerCita";
            this.dateTimePickerCita.Size = new System.Drawing.Size(304, 22);
            this.dateTimePickerCita.TabIndex = 55;
            // 
            // lbFechaCita
            // 
            this.lbFechaCita.AutoSize = true;
            this.lbFechaCita.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaCita.Location = new System.Drawing.Point(16, 172);
            this.lbFechaCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaCita.Name = "lbFechaCita";
            this.lbFechaCita.Size = new System.Drawing.Size(270, 31);
            this.lbFechaCita.TabIndex = 54;
            this.lbFechaCita.Text = "Fecha de la Cita";
            // 
            // ModificarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1040, 535);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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