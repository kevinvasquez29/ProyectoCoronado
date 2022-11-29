namespace ProyectoCoronado
{
    partial class MostrandoBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrandoBanco));
            this.DataGridMostrarBanco = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1IngresoBanco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label1Bnaco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMostrarBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridMostrarBanco
            // 
            this.DataGridMostrarBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMostrarBanco.Location = new System.Drawing.Point(515, 182);
            this.DataGridMostrarBanco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridMostrarBanco.Name = "DataGridMostrarBanco";
            this.DataGridMostrarBanco.RowHeadersWidth = 51;
            this.DataGridMostrarBanco.Size = new System.Drawing.Size(501, 273);
            this.DataGridMostrarBanco.TabIndex = 42;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(31, 434);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(224, 37);
            this.btnSalir.TabIndex = 41;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(31, 373);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(224, 37);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(664, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Datos del Banco";
            // 
            // textBox1IngresoBanco
            // 
            this.textBox1IngresoBanco.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1IngresoBanco.Location = new System.Drawing.Point(31, 258);
            this.textBox1IngresoBanco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1IngresoBanco.Multiline = true;
            this.textBox1IngresoBanco.Name = "textBox1IngresoBanco";
            this.textBox1IngresoBanco.Size = new System.Drawing.Size(297, 40);
            this.textBox1IngresoBanco.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ingrese Codigo de Banco";
            // 
            // label1Bnaco
            // 
            this.label1Bnaco.AutoSize = true;
            this.label1Bnaco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1Bnaco.Font = new System.Drawing.Font("Algerian", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Bnaco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1Bnaco.Location = new System.Drawing.Point(261, 41);
            this.label1Bnaco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1Bnaco.Name = "label1Bnaco";
            this.label1Bnaco.Size = new System.Drawing.Size(471, 53);
            this.label1Bnaco.TabIndex = 35;
            this.label1Bnaco.Text = "Consultar Banco ";
            // 
            // MostrandoBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1063, 574);
            this.Controls.Add(this.DataGridMostrarBanco);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1IngresoBanco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1Bnaco);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MostrandoBanco";
            this.Text = "MostrandoBanco";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMostrarBanco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridMostrarBanco;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1IngresoBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label1Bnaco;
    }
}