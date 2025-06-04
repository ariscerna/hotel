namespace Hotel
{
    partial class VisionReporte
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
            this.DgvVisionreporte = new System.Windows.Forms.DataGridView();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVisionreporte)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvVisionreporte
            // 
            this.DgvVisionreporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVisionreporte.Location = new System.Drawing.Point(12, 12);
            this.DgvVisionreporte.Name = "DgvVisionreporte";
            this.DgvVisionreporte.RowHeadersWidth = 51;
            this.DgvVisionreporte.RowTemplate.Height = 24;
            this.DgvVisionreporte.Size = new System.Drawing.Size(436, 205);
            this.DgvVisionreporte.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(373, 239);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // VisionReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 274);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.DgvVisionreporte);
            this.Name = "VisionReporte";
            this.Text = "VisionReporte";
            ((System.ComponentModel.ISupportInitialize)(this.DgvVisionreporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvVisionreporte;
        private System.Windows.Forms.Button BtnSalir;
    }
}