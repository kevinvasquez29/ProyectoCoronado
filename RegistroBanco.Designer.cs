namespace ProyectoCoronado
{
    partial class RegistroBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroBanco));
            this.label1Bnaco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1CodigoBanco = new System.Windows.Forms.TextBox();
            this.textbAgregarBanco = new System.Windows.Forms.TextBox();
            this.bt2RegistarBanco = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1Bnaco
            // 
            this.label1Bnaco.AutoSize = true;
            this.label1Bnaco.Location = new System.Drawing.Point(383, 33);
            this.label1Bnaco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1Bnaco.Name = "label1Bnaco";
            this.label1Bnaco.Size = new System.Drawing.Size(107, 16);
            this.label1Bnaco.TabIndex = 0;
            this.label1Bnaco.Text = "Registrar Banco ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de Banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo";
            // 
            // textBox1CodigoBanco
            // 
            this.textBox1CodigoBanco.Location = new System.Drawing.Point(119, 207);
            this.textBox1CodigoBanco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1CodigoBanco.Name = "textBox1CodigoBanco";
            this.textBox1CodigoBanco.Size = new System.Drawing.Size(132, 22);
            this.textBox1CodigoBanco.TabIndex = 3;
            // 
            // textbAgregarBanco
            // 
            this.textbAgregarBanco.Location = new System.Drawing.Point(532, 207);
            this.textbAgregarBanco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbAgregarBanco.Name = "textbAgregarBanco";
            this.textbAgregarBanco.Size = new System.Drawing.Size(132, 22);
            this.textbAgregarBanco.TabIndex = 4;
            // 
            // bt2RegistarBanco
            // 
            this.bt2RegistarBanco.Location = new System.Drawing.Point(195, 427);
            this.bt2RegistarBanco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt2RegistarBanco.Name = "bt2RegistarBanco";
            this.bt2RegistarBanco.Size = new System.Drawing.Size(100, 28);
            this.bt2RegistarBanco.TabIndex = 5;
            this.bt2RegistarBanco.Text = "Agregar";
            this.bt2RegistarBanco.UseVisualStyleBackColor = true;
            this.bt2RegistarBanco.Click += new System.EventHandler(this.bt2RegistarBanco_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(733, 427);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(100, 28);
            this.btSalir.TabIndex = 6;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // RegistroBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.bt2RegistarBanco);
            this.Controls.Add(this.textbAgregarBanco);
            this.Controls.Add(this.textBox1CodigoBanco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1Bnaco);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistroBanco";
            this.Text = "RegistroBanco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Bnaco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1CodigoBanco;
        private System.Windows.Forms.TextBox textbAgregarBanco;
        private System.Windows.Forms.Button bt2RegistarBanco;
        private System.Windows.Forms.Button btSalir;
    }
}