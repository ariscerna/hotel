namespace Hotel
{
    partial class Facturacion
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
            this.LblFacturacion = new System.Windows.Forms.Label();
            this.LblFechaF = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.LblCostoF = new System.Windows.Forms.Label();
            this.TxtCostoF = new System.Windows.Forms.TextBox();
            this.BtnCancelarF = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblFacturacion
            // 
            this.LblFacturacion.AutoSize = true;
            this.LblFacturacion.Location = new System.Drawing.Point(94, 34);
            this.LblFacturacion.Name = "LblFacturacion";
            this.LblFacturacion.Size = new System.Drawing.Size(80, 16);
            this.LblFacturacion.TabIndex = 0;
            this.LblFacturacion.Text = "Facturacion ";
            // 
            // LblFechaF
            // 
            this.LblFechaF.AutoSize = true;
            this.LblFechaF.Location = new System.Drawing.Point(13, 87);
            this.LblFechaF.Name = "LblFechaF";
            this.LblFechaF.Size = new System.Drawing.Size(132, 16);
            this.LblFechaF.TabIndex = 1;
            this.LblFechaF.Text = "Fecha de facturacion";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(170, 87);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(169, 22);
            this.TxtFecha.TabIndex = 2;
            // 
            // LblCostoF
            // 
            this.LblCostoF.AutoSize = true;
            this.LblCostoF.Location = new System.Drawing.Point(12, 165);
            this.LblCostoF.Name = "LblCostoF";
            this.LblCostoF.Size = new System.Drawing.Size(129, 16);
            this.LblCostoF.TabIndex = 3;
            this.LblCostoF.Text = "Costo de habitacion ";
            // 
            // TxtCostoF
            // 
            this.TxtCostoF.Location = new System.Drawing.Point(170, 158);
            this.TxtCostoF.Name = "TxtCostoF";
            this.TxtCostoF.Size = new System.Drawing.Size(169, 22);
            this.TxtCostoF.TabIndex = 4;
            // 
            // BtnCancelarF
            // 
            this.BtnCancelarF.Location = new System.Drawing.Point(29, 246);
            this.BtnCancelarF.Name = "BtnCancelarF";
            this.BtnCancelarF.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarF.TabIndex = 5;
            this.BtnCancelarF.Text = "Cancelar";
            this.BtnCancelarF.UseVisualStyleBackColor = true;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(170, 246);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(131, 23);
            this.BtnImprimir.TabIndex = 6;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 310);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnCancelarF);
            this.Controls.Add(this.TxtCostoF);
            this.Controls.Add(this.LblCostoF);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.LblFechaF);
            this.Controls.Add(this.LblFacturacion);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFacturacion;
        private System.Windows.Forms.Label LblFechaF;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label LblCostoF;
        private System.Windows.Forms.TextBox TxtCostoF;
        private System.Windows.Forms.Button BtnCancelarF;
        private System.Windows.Forms.Button BtnImprimir;
    }
}