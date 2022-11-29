namespace ProyectoCoronado
{
    partial class ConsultarCliPropietario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarCliPropietario));
            this.lbConsultar = new System.Windows.Forms.Label();
            this.btRegresar = new System.Windows.Forms.Button();
            this.txtIngreseDni = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.lbIngreseDni = new System.Windows.Forms.Label();
            this.dgvDatosPropietario = new System.Windows.Forms.DataGridView();
            this.dgvConsultarCliPropietario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPropietario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCliPropietario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbConsultar
            // 
            this.lbConsultar.AutoSize = true;
            this.lbConsultar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbConsultar.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbConsultar.Location = new System.Drawing.Point(13, 44);
            this.lbConsultar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConsultar.Name = "lbConsultar";
            this.lbConsultar.Size = new System.Drawing.Size(519, 45);
            this.lbConsultar.TabIndex = 51;
            this.lbConsultar.Text = "Consultar Propietario";
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(763, 494);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(224, 37);
            this.btRegresar.TabIndex = 50;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // txtIngreseDni
            // 
            this.txtIngreseDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngreseDni.Location = new System.Drawing.Point(677, 239);
            this.txtIngreseDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIngreseDni.Name = "txtIngreseDni";
            this.txtIngreseDni.Size = new System.Drawing.Size(297, 37);
            this.txtIngreseDni.TabIndex = 46;
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(716, 321);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(224, 37);
            this.btAceptar.TabIndex = 49;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // lbIngreseDni
            // 
            this.lbIngreseDni.AutoSize = true;
            this.lbIngreseDni.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngreseDni.Location = new System.Drawing.Point(672, 175);
            this.lbIngreseDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIngreseDni.Name = "lbIngreseDni";
            this.lbIngreseDni.Size = new System.Drawing.Size(157, 25);
            this.lbIngreseDni.TabIndex = 48;
            this.lbIngreseDni.Text = "Ingrese DNI";
            // 
            // dgvDatosPropietario
            // 
            this.dgvDatosPropietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPropietario.Location = new System.Drawing.Point(-8, 105);
            this.dgvDatosPropietario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDatosPropietario.Name = "dgvDatosPropietario";
            this.dgvDatosPropietario.RowHeadersWidth = 51;
            this.dgvDatosPropietario.Size = new System.Drawing.Size(605, 426);
            this.dgvDatosPropietario.TabIndex = 45;
            // 
            // dgvConsultarCliPropietario
            // 
            this.dgvConsultarCliPropietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarCliPropietario.Location = new System.Drawing.Point(-16, 30);
            this.dgvConsultarCliPropietario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvConsultarCliPropietario.Name = "dgvConsultarCliPropietario";
            this.dgvConsultarCliPropietario.RowHeadersWidth = 51;
            this.dgvConsultarCliPropietario.Size = new System.Drawing.Size(613, 471);
            this.dgvConsultarCliPropietario.TabIndex = 44;
            // 
            // ConsultarCliPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1043, 558);
            this.Controls.Add(this.lbConsultar);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.txtIngreseDni);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lbIngreseDni);
            this.Controls.Add(this.dgvDatosPropietario);
            this.Controls.Add(this.dgvConsultarCliPropietario);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConsultarCliPropietario";
            this.Text = "ConsultarCliPropietario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPropietario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCliPropietario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbConsultar;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.TextBox txtIngreseDni;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label lbIngreseDni;
        private System.Windows.Forms.DataGridView dgvDatosPropietario;
        private System.Windows.Forms.DataGridView dgvConsultarCliPropietario;
    }
}