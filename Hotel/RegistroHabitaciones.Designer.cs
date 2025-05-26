namespace Hotel
{
    partial class RegistroHabitaciones
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
            this.ChTipoH = new System.Windows.Forms.CheckedListBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.Label();
            this.TxtNumeroH = new System.Windows.Forms.TextBox();
            this.LblPiso = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblCosto = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnCancelar3 = new System.Windows.Forms.Button();
            this.LblRegistroH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChTipoH
            // 
            this.ChTipoH.FormattingEnabled = true;
            this.ChTipoH.Items.AddRange(new object[] {
            "Habitacion  Sencilla ",
            "Habitacion   Doble",
            "Habitacion    Suite "});
            this.ChTipoH.Location = new System.Drawing.Point(170, 101);
            this.ChTipoH.Name = "ChTipoH";
            this.ChTipoH.Size = new System.Drawing.Size(212, 55);
            this.ChTipoH.TabIndex = 0;
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Location = new System.Drawing.Point(5, 101);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(125, 16);
            this.LblTipo.TabIndex = 1;
            this.LblTipo.Text = "Tipo de Habitacion ";
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(9, 216);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(142, 16);
            this.LblNumero.TabIndex = 2;
            this.LblNumero.Text = "Numero de Habitacion";
            // 
            // TxtNumeroH
            // 
            this.TxtNumeroH.Location = new System.Drawing.Point(170, 216);
            this.TxtNumeroH.Name = "TxtNumeroH";
            this.TxtNumeroH.Size = new System.Drawing.Size(212, 22);
            this.TxtNumeroH.TabIndex = 3;
            // 
            // LblPiso
            // 
            this.LblPiso.AutoSize = true;
            this.LblPiso.Location = new System.Drawing.Point(9, 283);
            this.LblPiso.Name = "LblPiso";
            this.LblPiso.Size = new System.Drawing.Size(121, 16);
            this.LblPiso.TabIndex = 4;
            this.LblPiso.Text = "Piso de Habitacion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 277);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 22);
            this.textBox1.TabIndex = 5;
            // 
            // LblCosto
            // 
            this.LblCosto.AutoSize = true;
            this.LblCosto.Location = new System.Drawing.Point(9, 341);
            this.LblCosto.Name = "LblCosto";
            this.LblCosto.Size = new System.Drawing.Size(132, 16);
            this.LblCosto.TabIndex = 6;
            this.LblCosto.Text = "Costo de Habitacion ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(170, 341);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 22);
            this.textBox2.TabIndex = 7;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(27, 400);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(114, 23);
            this.BtnRegistrar.TabIndex = 8;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar3
            // 
            this.BtnCancelar3.Location = new System.Drawing.Point(296, 399);
            this.BtnCancelar3.Name = "BtnCancelar3";
            this.BtnCancelar3.Size = new System.Drawing.Size(125, 23);
            this.BtnCancelar3.TabIndex = 9;
            this.BtnCancelar3.Text = "Cancelar";
            this.BtnCancelar3.UseVisualStyleBackColor = true;
            // 
            // LblRegistroH
            // 
            this.LblRegistroH.AutoSize = true;
            this.LblRegistroH.Location = new System.Drawing.Point(167, 27);
            this.LblRegistroH.Name = "LblRegistroH";
            this.LblRegistroH.Size = new System.Drawing.Size(160, 16);
            this.LblRegistroH.TabIndex = 10;
            this.LblRegistroH.Text = "Registro de Habitaciones";
            // 
            // RegistroHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.LblRegistroH);
            this.Controls.Add(this.BtnCancelar3);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LblCosto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblPiso);
            this.Controls.Add(this.TxtNumeroH);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.ChTipoH);
            this.Name = "RegistroHabitaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ChTipoH;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.TextBox TxtNumeroH;
        private System.Windows.Forms.Label LblPiso;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblCosto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnCancelar3;
        private System.Windows.Forms.Label LblRegistroH;
    }
}