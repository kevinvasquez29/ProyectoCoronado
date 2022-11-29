namespace ProyectoCoronado
{
    partial class ModificarBanco
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
            this.checkBoxHabilitar = new System.Windows.Forms.CheckBox();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.txtIdBanco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1Bnaco = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1NombreBanco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxHabilitar
            // 
            this.checkBoxHabilitar.AutoSize = true;
            this.checkBoxHabilitar.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHabilitar.Location = new System.Drawing.Point(68, 236);
            this.checkBoxHabilitar.Name = "checkBoxHabilitar";
            this.checkBoxHabilitar.Size = new System.Drawing.Size(147, 25);
            this.checkBoxHabilitar.TabIndex = 55;
            this.checkBoxHabilitar.Text = "Habilitado";
            this.checkBoxHabilitar.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.Location = new System.Drawing.Point(70, 354);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(168, 30);
            this.btnDeshabilitar.TabIndex = 54;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // txtIdBanco
            // 
            this.txtIdBanco.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBanco.Location = new System.Drawing.Point(68, 160);
            this.txtIdBanco.Multiline = true;
            this.txtIdBanco.Name = "txtIdBanco";
            this.txtIdBanco.Size = new System.Drawing.Size(86, 33);
            this.txtIdBanco.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "Id Banco";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(465, 401);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(168, 30);
            this.btnSalir.TabIndex = 51;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(70, 308);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(168, 30);
            this.btnGuardar.TabIndex = 50;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1Bnaco
            // 
            this.label1Bnaco.AutoSize = true;
            this.label1Bnaco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1Bnaco.Font = new System.Drawing.Font("Algerian", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Bnaco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1Bnaco.Location = new System.Drawing.Point(196, 37);
            this.label1Bnaco.Name = "label1Bnaco";
            this.label1Bnaco.Size = new System.Drawing.Size(331, 39);
            this.label1Bnaco.TabIndex = 49;
            this.label1Bnaco.Text = "Modificar Banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Ingrese Nuevo Nombre de Banco";
            // 
            // textBox1NombreBanco
            // 
            this.textBox1NombreBanco.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1NombreBanco.Location = new System.Drawing.Point(326, 160);
            this.textBox1NombreBanco.Multiline = true;
            this.textBox1NombreBanco.Name = "textBox1NombreBanco";
            this.textBox1NombreBanco.Size = new System.Drawing.Size(308, 33);
            this.textBox1NombreBanco.TabIndex = 47;
            // 
            // ModificarBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 443);
            this.Controls.Add(this.checkBoxHabilitar);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.txtIdBanco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1Bnaco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1NombreBanco);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModificarBanco";
            this.Text = "ModificarBanco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxHabilitar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.TextBox txtIdBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1Bnaco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1NombreBanco;
    }
}