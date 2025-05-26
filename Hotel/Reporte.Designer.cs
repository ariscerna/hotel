namespace Hotel
{
    partial class Reporte
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
            this.LblReporte = new System.Windows.Forms.Label();
            this.LblFechaR = new System.Windows.Forms.Label();
            this.TxtFechaR = new System.Windows.Forms.TextBox();
            this.LblTipoR = new System.Windows.Forms.Label();
            this.ChTipoR = new System.Windows.Forms.CheckedListBox();
            this.BtnCancelarR = new System.Windows.Forms.Button();
            this.BtnRegistarR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblReporte
            // 
            this.LblReporte.AutoSize = true;
            this.LblReporte.Location = new System.Drawing.Point(157, 28);
            this.LblReporte.Name = "LblReporte";
            this.LblReporte.Size = new System.Drawing.Size(56, 16);
            this.LblReporte.TabIndex = 0;
            this.LblReporte.Text = "Reporte";
            // 
            // LblFechaR
            // 
            this.LblFechaR.AutoSize = true;
            this.LblFechaR.Location = new System.Drawing.Point(13, 116);
            this.LblFechaR.Name = "LblFechaR";
            this.LblFechaR.Size = new System.Drawing.Size(122, 16);
            this.LblFechaR.TabIndex = 1;
            this.LblFechaR.Text = "Fecha de Reporte :";
            // 
            // TxtFechaR
            // 
            this.TxtFechaR.Location = new System.Drawing.Point(160, 116);
            this.TxtFechaR.Name = "TxtFechaR";
            this.TxtFechaR.Size = new System.Drawing.Size(177, 22);
            this.TxtFechaR.TabIndex = 2;
            // 
            // LblTipoR
            // 
            this.LblTipoR.AutoSize = true;
            this.LblTipoR.Location = new System.Drawing.Point(16, 175);
            this.LblTipoR.Name = "LblTipoR";
            this.LblTipoR.Size = new System.Drawing.Size(112, 16);
            this.LblTipoR.TabIndex = 3;
            this.LblTipoR.Text = "Tipo de Reporte :";
            // 
            // ChTipoR
            // 
            this.ChTipoR.FormattingEnabled = true;
            this.ChTipoR.Items.AddRange(new object[] {
            " Reporte de Queja ",
            "Reporte de Sugerencia"});
            this.ChTipoR.Location = new System.Drawing.Point(160, 175);
            this.ChTipoR.Name = "ChTipoR";
            this.ChTipoR.Size = new System.Drawing.Size(209, 55);
            this.ChTipoR.TabIndex = 4;
            // 
            // BtnCancelarR
            // 
            this.BtnCancelarR.Location = new System.Drawing.Point(19, 259);
            this.BtnCancelarR.Name = "BtnCancelarR";
            this.BtnCancelarR.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarR.TabIndex = 5;
            this.BtnCancelarR.Text = "Cancelar";
            this.BtnCancelarR.UseVisualStyleBackColor = true;
            // 
            // BtnRegistarR
            // 
            this.BtnRegistarR.Location = new System.Drawing.Point(226, 259);
            this.BtnRegistarR.Name = "BtnRegistarR";
            this.BtnRegistarR.Size = new System.Drawing.Size(111, 23);
            this.BtnRegistarR.TabIndex = 6;
            this.BtnRegistarR.Text = "Registrar";
            this.BtnRegistarR.UseVisualStyleBackColor = true;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 308);
            this.Controls.Add(this.BtnRegistarR);
            this.Controls.Add(this.BtnCancelarR);
            this.Controls.Add(this.ChTipoR);
            this.Controls.Add(this.LblTipoR);
            this.Controls.Add(this.TxtFechaR);
            this.Controls.Add(this.LblFechaR);
            this.Controls.Add(this.LblReporte);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblReporte;
        private System.Windows.Forms.Label LblFechaR;
        private System.Windows.Forms.TextBox TxtFechaR;
        private System.Windows.Forms.Label LblTipoR;
        private System.Windows.Forms.CheckedListBox ChTipoR;
        private System.Windows.Forms.Button BtnCancelarR;
        private System.Windows.Forms.Button BtnRegistarR;
    }
}