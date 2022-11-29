namespace ProyectoCoronado
{
    partial class Login
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
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.txtNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.btnCancelarLogin = new System.Windows.Forms.Button();
            this.lbLogin = new System.Windows.Forms.Label();
            this.btnAceptarLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(85, 217);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(348, 20);
            this.txtContraseña.TabIndex = 14;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContraseña.Location = new System.Drawing.Point(81, 171);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(162, 25);
            this.lbContraseña.TabIndex = 13;
            this.lbContraseña.Text = "Contraseña";
            // 
            // txtNombreDeUsuario
            // 
            this.txtNombreDeUsuario.Location = new System.Drawing.Point(85, 133);
            this.txtNombreDeUsuario.Name = "txtNombreDeUsuario";
            this.txtNombreDeUsuario.Size = new System.Drawing.Size(348, 20);
            this.txtNombreDeUsuario.TabIndex = 12;
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.Location = new System.Drawing.Point(81, 94);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(101, 25);
            this.lbNombreUsuario.TabIndex = 11;
            this.lbNombreUsuario.Text = "Correo";
            // 
            // btnCancelarLogin
            // 
            this.btnCancelarLogin.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarLogin.Location = new System.Drawing.Point(514, 300);
            this.btnCancelarLogin.Name = "btnCancelarLogin";
            this.btnCancelarLogin.Size = new System.Drawing.Size(153, 64);
            this.btnCancelarLogin.TabIndex = 10;
            this.btnCancelarLogin.Text = "Cancelar";
            this.btnCancelarLogin.UseVisualStyleBackColor = true;
            this.btnCancelarLogin.Click += new System.EventHandler(this.btnCancelarLogin_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(314, 36);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(129, 42);
            this.lbLogin.TabIndex = 9;
            this.lbLogin.Text = "LOGIN";
            // 
            // btnAceptarLogin
            // 
            this.btnAceptarLogin.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarLogin.Location = new System.Drawing.Point(85, 300);
            this.btnAceptarLogin.Name = "btnAceptarLogin";
            this.btnAceptarLogin.Size = new System.Drawing.Size(153, 64);
            this.btnAceptarLogin.TabIndex = 8;
            this.btnAceptarLogin.Text = "Aceptar";
            this.btnAceptarLogin.UseVisualStyleBackColor = true;
            this.btnAceptarLogin.Click += new System.EventHandler(this.btnAceptarLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 435);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lbContraseña);
            this.Controls.Add(this.txtNombreDeUsuario);
            this.Controls.Add(this.lbNombreUsuario);
            this.Controls.Add(this.btnCancelarLogin);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.btnAceptarLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.TextBox txtNombreDeUsuario;
        private System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.Button btnCancelarLogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button btnAceptarLogin;
    }
}