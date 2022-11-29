namespace ProyectoCoronado
{
    partial class InmuebleSetorRegistro
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
            this.txtComentarioSector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCiudad = new System.Windows.Forms.ComboBox();
            this.Regresar = new System.Windows.Forms.Button();
            this.btnAgregarSector = new System.Windows.Forms.Button();
            this.txtNombreSector = new System.Windows.Forms.TextBox();
            this.label1NombreDelSetor = new System.Windows.Forms.Label();
            this.IngreseCuidad = new System.Windows.Forms.Label();
            this.lbNuevoSetor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtComentarioSector
            // 
            this.txtComentarioSector.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarioSector.Location = new System.Drawing.Point(26, 237);
            this.txtComentarioSector.Multiline = true;
            this.txtComentarioSector.Name = "txtComentarioSector";
            this.txtComentarioSector.Size = new System.Drawing.Size(289, 26);
            this.txtComentarioSector.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 21);
            this.label2.TabIndex = 78;
            this.label2.Text = "Comentario Del Sector";
            // 
            // comboBoxCiudad
            // 
            this.comboBoxCiudad.FormattingEnabled = true;
            this.comboBoxCiudad.Location = new System.Drawing.Point(26, 147);
            this.comboBoxCiudad.Name = "comboBoxCiudad";
            this.comboBoxCiudad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCiudad.TabIndex = 77;
            // 
            // Regresar
            // 
            this.Regresar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.Location = new System.Drawing.Point(492, 288);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(168, 30);
            this.Regresar.TabIndex = 76;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // btnAgregarSector
            // 
            this.btnAgregarSector.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSector.Location = new System.Drawing.Point(26, 288);
            this.btnAgregarSector.Name = "btnAgregarSector";
            this.btnAgregarSector.Size = new System.Drawing.Size(168, 30);
            this.btnAgregarSector.TabIndex = 75;
            this.btnAgregarSector.Text = "Agregar Sector";
            this.btnAgregarSector.UseVisualStyleBackColor = true;
            this.btnAgregarSector.Click += new System.EventHandler(this.btnAgregarSector_Click);
            // 
            // txtNombreSector
            // 
            this.txtNombreSector.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSector.Location = new System.Drawing.Point(180, 147);
            this.txtNombreSector.Multiline = true;
            this.txtNombreSector.Name = "txtNombreSector";
            this.txtNombreSector.Size = new System.Drawing.Size(272, 26);
            this.txtNombreSector.TabIndex = 74;
            // 
            // label1NombreDelSetor
            // 
            this.label1NombreDelSetor.AutoSize = true;
            this.label1NombreDelSetor.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1NombreDelSetor.Location = new System.Drawing.Point(176, 112);
            this.label1NombreDelSetor.Name = "label1NombreDelSetor";
            this.label1NombreDelSetor.Size = new System.Drawing.Size(302, 21);
            this.label1NombreDelSetor.TabIndex = 73;
            this.label1NombreDelSetor.Text = "Ingrese Nombre Del Sector";
            // 
            // IngreseCuidad
            // 
            this.IngreseCuidad.AutoSize = true;
            this.IngreseCuidad.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngreseCuidad.Location = new System.Drawing.Point(22, 112);
            this.IngreseCuidad.Name = "IngreseCuidad";
            this.IngreseCuidad.Size = new System.Drawing.Size(144, 21);
            this.IngreseCuidad.TabIndex = 72;
            this.IngreseCuidad.Text = "Elija Ciudad";
            // 
            // lbNuevoSetor
            // 
            this.lbNuevoSetor.AutoSize = true;
            this.lbNuevoSetor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbNuevoSetor.Font = new System.Drawing.Font("Algerian", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevoSetor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNuevoSetor.Location = new System.Drawing.Point(199, 40);
            this.lbNuevoSetor.Name = "lbNuevoSetor";
            this.lbNuevoSetor.Size = new System.Drawing.Size(271, 39);
            this.lbNuevoSetor.TabIndex = 71;
            this.lbNuevoSetor.Text = "Nuevo Sector";
            // 
            // InmuebleSetorRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 357);
            this.Controls.Add(this.txtComentarioSector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCiudad);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.btnAgregarSector);
            this.Controls.Add(this.txtNombreSector);
            this.Controls.Add(this.label1NombreDelSetor);
            this.Controls.Add(this.IngreseCuidad);
            this.Controls.Add(this.lbNuevoSetor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InmuebleSetorRegistro";
            this.Text = "InmuebleSetorRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComentarioSector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCiudad;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Button btnAgregarSector;
        private System.Windows.Forms.TextBox txtNombreSector;
        private System.Windows.Forms.Label label1NombreDelSetor;
        private System.Windows.Forms.Label IngreseCuidad;
        private System.Windows.Forms.Label lbNuevoSetor;
    }
}