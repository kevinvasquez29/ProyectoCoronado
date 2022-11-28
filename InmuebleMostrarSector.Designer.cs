namespace ProyectoCoronado
{
    partial class InmuebleMostrarSector
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btAceptarSector = new System.Windows.Forms.Button();
            this.DataGridMostrarSector = new System.Windows.Forms.DataGridView();
            this.lbMostrandoSector = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMostrarSector)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(564, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 25);
            this.label1.TabIndex = 70;
            this.label1.Text = "Ingrese Codigo a Modificar";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(620, 198);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(259, 22);
            this.txtCodigo.TabIndex = 69;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(694, 406);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(231, 62);
            this.btnRegresar.TabIndex = 68;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btAceptarSector
            // 
            this.btAceptarSector.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptarSector.Location = new System.Drawing.Point(635, 239);
            this.btAceptarSector.Margin = new System.Windows.Forms.Padding(4);
            this.btAceptarSector.Name = "btAceptarSector";
            this.btAceptarSector.Size = new System.Drawing.Size(231, 62);
            this.btAceptarSector.TabIndex = 67;
            this.btAceptarSector.Text = "Aceptar";
            this.btAceptarSector.UseVisualStyleBackColor = true;
            // 
            // DataGridMostrarSector
            // 
            this.DataGridMostrarSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMostrarSector.Location = new System.Drawing.Point(26, 116);
            this.DataGridMostrarSector.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridMostrarSector.Name = "DataGridMostrarSector";
            this.DataGridMostrarSector.RowHeadersWidth = 51;
            this.DataGridMostrarSector.Size = new System.Drawing.Size(538, 352);
            this.DataGridMostrarSector.TabIndex = 66;
            // 
            // lbMostrandoSector
            // 
            this.lbMostrandoSector.AutoSize = true;
            this.lbMostrandoSector.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbMostrandoSector.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostrandoSector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMostrandoSector.Location = new System.Drawing.Point(18, 25);
            this.lbMostrandoSector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMostrandoSector.Name = "lbMostrandoSector";
            this.lbMostrandoSector.Size = new System.Drawing.Size(390, 45);
            this.lbMostrandoSector.TabIndex = 65;
            this.lbMostrandoSector.Text = "Mostando Sector";
            // 
            // InmuebleMostrarSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btAceptarSector);
            this.Controls.Add(this.DataGridMostrarSector);
            this.Controls.Add(this.lbMostrandoSector);
            this.Name = "InmuebleMostrarSector";
            this.Text = "InmuebleMostrarSector";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMostrarSector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btAceptarSector;
        private System.Windows.Forms.DataGridView DataGridMostrarSector;
        private System.Windows.Forms.Label lbMostrandoSector;
    }
}