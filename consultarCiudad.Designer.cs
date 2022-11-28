namespace ProyectoCoronado
{
    partial class consultarCiudad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultarCiudad));
            this.btRegresar = new System.Windows.Forms.Button();
            this.btModificarCiudad = new System.Windows.Forms.Button();
            this.txtcodCiudad = new System.Windows.Forms.TextBox();
            this.lbIngresaDni = new System.Windows.Forms.Label();
            this.dgvConsultaCiudad = new System.Windows.Forms.DataGridView();
            this.lbConsultarCiudad = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(845, 482);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(160, 48);
            this.btRegresar.TabIndex = 20;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            // 
            // btModificarCiudad
            // 
            this.btModificarCiudad.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificarCiudad.Location = new System.Drawing.Point(797, 293);
            this.btModificarCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.btModificarCiudad.Name = "btModificarCiudad";
            this.btModificarCiudad.Size = new System.Drawing.Size(160, 43);
            this.btModificarCiudad.TabIndex = 19;
            this.btModificarCiudad.Text = "Modificar";
            this.btModificarCiudad.UseVisualStyleBackColor = true;
            // 
            // txtcodCiudad
            // 
            this.txtcodCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodCiudad.Location = new System.Drawing.Point(739, 219);
            this.txtcodCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodCiudad.Name = "txtcodCiudad";
            this.txtcodCiudad.Size = new System.Drawing.Size(267, 34);
            this.txtcodCiudad.TabIndex = 18;
            // 
            // lbIngresaDni
            // 
            this.lbIngresaDni.AutoSize = true;
            this.lbIngresaDni.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngresaDni.Location = new System.Drawing.Point(751, 172);
            this.lbIngresaDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIngresaDni.Name = "lbIngresaDni";
            this.lbIngresaDni.Size = new System.Drawing.Size(255, 25);
            this.lbIngresaDni.TabIndex = 17;
            this.lbIngresaDni.Text = "Ingrese Cod Ciudad";
            // 
            // dgvConsultaCiudad
            // 
            this.dgvConsultaCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCiudad.Location = new System.Drawing.Point(0, 108);
            this.dgvConsultaCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsultaCiudad.Name = "dgvConsultaCiudad";
            this.dgvConsultaCiudad.RowHeadersWidth = 51;
            this.dgvConsultaCiudad.Size = new System.Drawing.Size(731, 380);
            this.dgvConsultaCiudad.TabIndex = 16;
            // 
            // lbConsultarCiudad
            // 
            this.lbConsultarCiudad.AutoSize = true;
            this.lbConsultarCiudad.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarCiudad.Location = new System.Drawing.Point(13, 28);
            this.lbConsultarCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConsultarCiudad.Name = "lbConsultarCiudad";
            this.lbConsultarCiudad.Size = new System.Drawing.Size(401, 45);
            this.lbConsultarCiudad.TabIndex = 15;
            this.lbConsultarCiudad.Text = "Consultar Ciudad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-108, -27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1124, 574);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // consultarCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 543);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btModificarCiudad);
            this.Controls.Add(this.txtcodCiudad);
            this.Controls.Add(this.lbIngresaDni);
            this.Controls.Add(this.dgvConsultaCiudad);
            this.Controls.Add(this.lbConsultarCiudad);
            this.Controls.Add(this.pictureBox1);
            this.Name = "consultarCiudad";
            this.Text = "consultarCiudad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Button btModificarCiudad;
        private System.Windows.Forms.TextBox txtcodCiudad;
        private System.Windows.Forms.Label lbIngresaDni;
        private System.Windows.Forms.DataGridView dgvConsultaCiudad;
        private System.Windows.Forms.Label lbConsultarCiudad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}