namespace ProyectoCoronado
{
    partial class MantenedorBanco
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
            this.bt3MostraBanco = new System.Windows.Forms.Button();
            this.bt2RegistarBanco = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.label1Bnaco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt3MostraBanco
            // 
            this.bt3MostraBanco.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3MostraBanco.Location = new System.Drawing.Point(434, 212);
            this.bt3MostraBanco.Name = "bt3MostraBanco";
            this.bt3MostraBanco.Size = new System.Drawing.Size(235, 33);
            this.bt3MostraBanco.TabIndex = 15;
            this.bt3MostraBanco.Text = "Consultar Banco";
            this.bt3MostraBanco.UseVisualStyleBackColor = true;
            this.bt3MostraBanco.Click += new System.EventHandler(this.bt3MostraBanco_Click);
            // 
            // bt2RegistarBanco
            // 
            this.bt2RegistarBanco.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2RegistarBanco.Location = new System.Drawing.Point(42, 212);
            this.bt2RegistarBanco.Name = "bt2RegistarBanco";
            this.bt2RegistarBanco.Size = new System.Drawing.Size(235, 33);
            this.bt2RegistarBanco.TabIndex = 14;
            this.bt2RegistarBanco.Text = "Registrar Banco";
            this.bt2RegistarBanco.UseVisualStyleBackColor = true;
            this.bt2RegistarBanco.Click += new System.EventHandler(this.bt2RegistarBanco_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btSalir.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(577, 400);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(92, 34);
            this.btSalir.TabIndex = 13;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // label1Bnaco
            // 
            this.label1Bnaco.AutoSize = true;
            this.label1Bnaco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1Bnaco.Font = new System.Drawing.Font("Algerian", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Bnaco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1Bnaco.Location = new System.Drawing.Point(302, 54);
            this.label1Bnaco.Name = "label1Bnaco";
            this.label1Bnaco.Size = new System.Drawing.Size(120, 42);
            this.label1Bnaco.TabIndex = 11;
            this.label1Bnaco.Text = "Menu";
            // 
            // MantenedorBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 459);
            this.Controls.Add(this.bt3MostraBanco);
            this.Controls.Add(this.bt2RegistarBanco);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.label1Bnaco);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MantenedorBanco";
            this.Text = "MantenedorBanco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt3MostraBanco;
        private System.Windows.Forms.Button bt2RegistarBanco;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label label1Bnaco;
    }
}