namespace ProyectoCoronado
{
    partial class RegistrarCliPropietario
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
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelRegristarPropietario = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lbDni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(231, 246);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(298, 20);
            this.dateTimePickerFechaNacimiento.TabIndex = 56;
            // 
            // labelRegristarPropietario
            // 
            this.labelRegristarPropietario.AutoSize = true;
            this.labelRegristarPropietario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelRegristarPropietario.Font = new System.Drawing.Font("Algerian", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegristarPropietario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRegristarPropietario.Location = new System.Drawing.Point(150, 19);
            this.labelRegristarPropietario.Name = "labelRegristarPropietario";
            this.labelRegristarPropietario.Size = new System.Drawing.Size(494, 42);
            this.labelRegristarPropietario.TabIndex = 55;
            this.labelRegristarPropietario.Text = "Registrar Propietario";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(40, 392);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(160, 49);
            this.btnRegistrar.TabIndex = 54;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(603, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 49);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 52;
            this.label5.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Fecha Nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nombre:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(144, 348);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(275, 20);
            this.txtDireccion.TabIndex = 46;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(144, 298);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 45;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(144, 193);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(260, 20);
            this.txtApellido.TabIndex = 44;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(144, 138);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(260, 20);
            this.txtNombre.TabIndex = 43;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(144, 88);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(207, 20);
            this.txtDni.TabIndex = 42;
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.Location = new System.Drawing.Point(42, 88);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(47, 21);
            this.lbDni.TabIndex = 41;
            this.lbDni.Text = "DNI:";
            // 
            // RegistrarCliPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 452);
            this.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.Controls.Add(this.labelRegristarPropietario);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lbDni);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistrarCliPropietario";
            this.Text = "RegistrarCliPropietario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.Label labelRegristarPropietario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lbDni;
    }
}