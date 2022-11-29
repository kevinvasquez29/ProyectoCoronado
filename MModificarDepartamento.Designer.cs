namespace ProyectoCoronado
{
    partial class MModificarDepartamento
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
            this.checkBoxDeshabilitar = new System.Windows.Forms.CheckBox();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUbicacionPiso = new System.Windows.Forms.TextBox();
            this.labelModificarDepartamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadCostruida = new System.Windows.Forms.TextBox();
            this.txtCantidadHabitaciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCantidadBaños = new System.Windows.Forms.TextBox();
            this.txtPrecioMinimo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxDeshabilitar
            // 
            this.checkBoxDeshabilitar.AutoSize = true;
            this.checkBoxDeshabilitar.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDeshabilitar.Location = new System.Drawing.Point(37, 358);
            this.checkBoxDeshabilitar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxDeshabilitar.Name = "checkBoxDeshabilitar";
            this.checkBoxDeshabilitar.Size = new System.Drawing.Size(147, 25);
            this.checkBoxDeshabilitar.TabIndex = 115;
            this.checkBoxDeshabilitar.Text = "Habilitado";
            this.checkBoxDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.Location = new System.Drawing.Point(448, 388);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(189, 37);
            this.btnDeshabilitar.TabIndex = 114;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 21);
            this.label3.TabIndex = 113;
            this.label3.Text = "Ubicación Piso:";
            // 
            // txtUbicacionPiso
            // 
            this.txtUbicacionPiso.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacionPiso.Location = new System.Drawing.Point(190, 274);
            this.txtUbicacionPiso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUbicacionPiso.Multiline = true;
            this.txtUbicacionPiso.Name = "txtUbicacionPiso";
            this.txtUbicacionPiso.Size = new System.Drawing.Size(252, 26);
            this.txtUbicacionPiso.TabIndex = 112;
            // 
            // labelModificarDepartamento
            // 
            this.labelModificarDepartamento.AutoSize = true;
            this.labelModificarDepartamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelModificarDepartamento.Font = new System.Drawing.Font("Algerian", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarDepartamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelModificarDepartamento.Location = new System.Drawing.Point(30, 15);
            this.labelModificarDepartamento.Name = "labelModificarDepartamento";
            this.labelModificarDepartamento.Size = new System.Drawing.Size(539, 42);
            this.labelModificarDepartamento.TabIndex = 111;
            this.labelModificarDepartamento.Text = "Modificar Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 21);
            this.label1.TabIndex = 110;
            this.label1.Text = "Cantidad de Habitaciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 21);
            this.label2.TabIndex = 109;
            this.label2.Text = "Cantidad Costruida en Metros Cuadrados:";
            // 
            // txtCantidadCostruida
            // 
            this.txtCantidadCostruida.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadCostruida.Location = new System.Drawing.Point(436, 315);
            this.txtCantidadCostruida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidadCostruida.Multiline = true;
            this.txtCantidadCostruida.Name = "txtCantidadCostruida";
            this.txtCantidadCostruida.Size = new System.Drawing.Size(219, 26);
            this.txtCantidadCostruida.TabIndex = 108;
            // 
            // txtCantidadHabitaciones
            // 
            this.txtCantidadHabitaciones.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadHabitaciones.Location = new System.Drawing.Point(302, 228);
            this.txtCantidadHabitaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidadHabitaciones.Multiline = true;
            this.txtCantidadHabitaciones.Name = "txtCantidadHabitaciones";
            this.txtCantidadHabitaciones.Size = new System.Drawing.Size(252, 26);
            this.txtCantidadHabitaciones.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 21);
            this.label6.TabIndex = 106;
            this.label6.Text = "Cantidad de Baños:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 21);
            this.label7.TabIndex = 105;
            this.label7.Text = "Precio Minimo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 104;
            this.label8.Text = "Precio:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(238, 388);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(189, 37);
            this.btnCancelar.TabIndex = 103;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(21, 388);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(189, 37);
            this.btnAceptar.TabIndex = 102;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCantidadBaños
            // 
            this.txtCantidadBaños.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadBaños.Location = new System.Drawing.Point(222, 183);
            this.txtCantidadBaños.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidadBaños.Multiline = true;
            this.txtCantidadBaños.Name = "txtCantidadBaños";
            this.txtCantidadBaños.Size = new System.Drawing.Size(252, 25);
            this.txtCantidadBaños.TabIndex = 101;
            // 
            // txtPrecioMinimo
            // 
            this.txtPrecioMinimo.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioMinimo.Location = new System.Drawing.Point(190, 131);
            this.txtPrecioMinimo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecioMinimo.Multiline = true;
            this.txtPrecioMinimo.Name = "txtPrecioMinimo";
            this.txtPrecioMinimo.Size = new System.Drawing.Size(252, 25);
            this.txtPrecioMinimo.TabIndex = 100;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(190, 89);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(252, 25);
            this.txtPrecio.TabIndex = 99;
            // 
            // MModificarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 448);
            this.Controls.Add(this.checkBoxDeshabilitar);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUbicacionPiso);
            this.Controls.Add(this.labelModificarDepartamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidadCostruida);
            this.Controls.Add(this.txtCantidadHabitaciones);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCantidadBaños);
            this.Controls.Add(this.txtPrecioMinimo);
            this.Controls.Add(this.txtPrecio);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MModificarDepartamento";
            this.Text = "MModificarDepartamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDeshabilitar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUbicacionPiso;
        private System.Windows.Forms.Label labelModificarDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadCostruida;
        private System.Windows.Forms.TextBox txtCantidadHabitaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCantidadBaños;
        private System.Windows.Forms.TextBox txtPrecioMinimo;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}