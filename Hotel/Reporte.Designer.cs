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
            this.BtnCancelarR = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAsunto = new System.Windows.Forms.TextBox();
            this.CmbTipoReporte = new System.Windows.Forms.ComboBox();
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
            // BtnCancelarR
            // 
            this.BtnCancelarR.Location = new System.Drawing.Point(19, 308);
            this.BtnCancelarR.Name = "BtnCancelarR";
            this.BtnCancelarR.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarR.TabIndex = 5;
            this.BtnCancelarR.Text = "Cancelar";
            this.BtnCancelarR.UseVisualStyleBackColor = true;
            this.BtnCancelarR.Click += new System.EventHandler(this.BtnCancelarR_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(250, 308);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(111, 23);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Asunto  :";
            // 
            // TxtAsunto
            // 
            this.TxtAsunto.Location = new System.Drawing.Point(160, 235);
            this.TxtAsunto.Name = "TxtAsunto";
            this.TxtAsunto.Size = new System.Drawing.Size(177, 22);
            this.TxtAsunto.TabIndex = 9;
            // 
            // CmbTipoReporte
            // 
            this.CmbTipoReporte.FormattingEnabled = true;
            this.CmbTipoReporte.Items.AddRange(new object[] {
            "Financiero",
            "Ocupacion",
            "Inventario",
            "Otro"});
            this.CmbTipoReporte.Location = new System.Drawing.Point(160, 175);
            this.CmbTipoReporte.Name = "CmbTipoReporte";
            this.CmbTipoReporte.Size = new System.Drawing.Size(177, 24);
            this.CmbTipoReporte.TabIndex = 10;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 384);
            this.Controls.Add(this.CmbTipoReporte);
            this.Controls.Add(this.TxtAsunto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelarR);
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
        private System.Windows.Forms.Button BtnCancelarR;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAsunto;
        private System.Windows.Forms.ComboBox CmbTipoReporte;
    }
}