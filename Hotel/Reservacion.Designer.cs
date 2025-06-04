namespace Hotel
{
    partial class Reservacion
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
            this.LblReservacion = new System.Windows.Forms.Label();
            this.LbLFechaR = new System.Windows.Forms.Label();
            this.TxtFechaR = new System.Windows.Forms.TextBox();
            this.LblCostoR = new System.Windows.Forms.Label();
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.LblTipoR = new System.Windows.Forms.Label();
            this.LblNombreR = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnCancelarR = new System.Windows.Forms.Button();
            this.BtnReservar = new System.Windows.Forms.Button();
            this.chkSencilla = new System.Windows.Forms.CheckBox();
            this.chkDoble = new System.Windows.Forms.CheckBox();
            this.chkSuite = new System.Windows.Forms.CheckBox();
            this.LblNumeroH = new System.Windows.Forms.Label();
            this.TxtNumeroH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblReservacion
            // 
            this.LblReservacion.AutoSize = true;
            this.LblReservacion.Location = new System.Drawing.Point(174, 33);
            this.LblReservacion.Name = "LblReservacion";
            this.LblReservacion.Size = new System.Drawing.Size(84, 16);
            this.LblReservacion.TabIndex = 0;
            this.LblReservacion.Text = "Reservacion";
            // 
            // LbLFechaR
            // 
            this.LbLFechaR.AutoSize = true;
            this.LbLFechaR.Location = new System.Drawing.Point(19, 68);
            this.LbLFechaR.Name = "LbLFechaR";
            this.LbLFechaR.Size = new System.Drawing.Size(144, 16);
            this.LbLFechaR.TabIndex = 1;
            this.LbLFechaR.Text = "Fecha de Reservacion";
            // 
            // TxtFechaR
            // 
            this.TxtFechaR.Location = new System.Drawing.Point(201, 68);
            this.TxtFechaR.Name = "TxtFechaR";
            this.TxtFechaR.Size = new System.Drawing.Size(180, 22);
            this.TxtFechaR.TabIndex = 2;
            // 
            // LblCostoR
            // 
            this.LblCostoR.AutoSize = true;
            this.LblCostoR.Location = new System.Drawing.Point(15, 146);
            this.LblCostoR.Name = "LblCostoR";
            this.LblCostoR.Size = new System.Drawing.Size(141, 16);
            this.LblCostoR.TabIndex = 3;
            this.LblCostoR.Text = "Costo de Reservacion";
            // 
            // TxtCosto
            // 
            this.TxtCosto.Location = new System.Drawing.Point(202, 146);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(180, 22);
            this.TxtCosto.TabIndex = 4;
            // 
            // LblTipoR
            // 
            this.LblTipoR.AutoSize = true;
            this.LblTipoR.Location = new System.Drawing.Point(16, 234);
            this.LblTipoR.Name = "LblTipoR";
            this.LblTipoR.Size = new System.Drawing.Size(122, 16);
            this.LblTipoR.TabIndex = 5;
            this.LblTipoR.Text = "Tipo de Habitacion";
            // 
            // LblNombreR
            // 
            this.LblNombreR.AutoSize = true;
            this.LblNombreR.Location = new System.Drawing.Point(19, 327);
            this.LblNombreR.Name = "LblNombreR";
            this.LblNombreR.Size = new System.Drawing.Size(137, 16);
            this.LblNombreR.TabIndex = 7;
            this.LblNombreR.Text = "Nombre  de Huesped";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(191, 327);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(191, 22);
            this.TxtNombre.TabIndex = 8;
            // 
            // BtnCancelarR
            // 
            this.BtnCancelarR.Location = new System.Drawing.Point(19, 415);
            this.BtnCancelarR.Name = "BtnCancelarR";
            this.BtnCancelarR.Size = new System.Drawing.Size(119, 23);
            this.BtnCancelarR.TabIndex = 9;
            this.BtnCancelarR.Text = "Cancelar";
            this.BtnCancelarR.UseVisualStyleBackColor = true;
            this.BtnCancelarR.Click += new System.EventHandler(this.BtnCancelarR_Click);
            // 
            // BtnReservar
            // 
            this.BtnReservar.Location = new System.Drawing.Point(288, 415);
            this.BtnReservar.Name = "BtnReservar";
            this.BtnReservar.Size = new System.Drawing.Size(131, 23);
            this.BtnReservar.TabIndex = 10;
            this.BtnReservar.Text = "Reservar";
            this.BtnReservar.UseVisualStyleBackColor = true;
            this.BtnReservar.Click += new System.EventHandler(this.BtnReservar_Click);
            // 
            // chkSencilla
            // 
            this.chkSencilla.AutoSize = true;
            this.chkSencilla.Location = new System.Drawing.Point(202, 230);
            this.chkSencilla.Name = "chkSencilla";
            this.chkSencilla.Size = new System.Drawing.Size(77, 20);
            this.chkSencilla.TabIndex = 11;
            this.chkSencilla.Text = "Sencilla";
            this.chkSencilla.UseVisualStyleBackColor = true;
            // 
            // chkDoble
            // 
            this.chkDoble.AutoSize = true;
            this.chkDoble.Location = new System.Drawing.Point(202, 256);
            this.chkDoble.Name = "chkDoble";
            this.chkDoble.Size = new System.Drawing.Size(66, 20);
            this.chkDoble.TabIndex = 12;
            this.chkDoble.Text = "Doble";
            this.chkDoble.UseVisualStyleBackColor = true;
            // 
            // chkSuite
            // 
            this.chkSuite.AutoSize = true;
            this.chkSuite.Checked = true;
            this.chkSuite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSuite.Location = new System.Drawing.Point(202, 282);
            this.chkSuite.Name = "chkSuite";
            this.chkSuite.Size = new System.Drawing.Size(59, 20);
            this.chkSuite.TabIndex = 13;
            this.chkSuite.Text = "Suite";
            this.chkSuite.UseVisualStyleBackColor = true;
            // 
            // LblNumeroH
            // 
            this.LblNumeroH.AutoSize = true;
            this.LblNumeroH.Location = new System.Drawing.Point(16, 234);
            this.LblNumeroH.Name = "LblNumeroH";
            this.LblNumeroH.Size = new System.Drawing.Size(142, 16);
            this.LblNumeroH.TabIndex = 14;
            this.LblNumeroH.Text = "Numero de Habitacion";
            // 
            // TxtNumeroH
            // 
            this.TxtNumeroH.Location = new System.Drawing.Point(202, 189);
            this.TxtNumeroH.Name = "TxtNumeroH";
            this.TxtNumeroH.Size = new System.Drawing.Size(179, 22);
            this.TxtNumeroH.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fecha de Salida :";
            // 
            // TxtSalida
            // 
            this.TxtSalida.Location = new System.Drawing.Point(202, 104);
            this.TxtSalida.Name = "TxtSalida";
            this.TxtSalida.Size = new System.Drawing.Size(180, 22);
            this.TxtSalida.TabIndex = 17;
            // 
            // Reservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.TxtSalida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNumeroH);
            this.Controls.Add(this.LblNumeroH);
            this.Controls.Add(this.chkSuite);
            this.Controls.Add(this.chkDoble);
            this.Controls.Add(this.chkSencilla);
            this.Controls.Add(this.BtnReservar);
            this.Controls.Add(this.BtnCancelarR);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombreR);
            this.Controls.Add(this.LblTipoR);
            this.Controls.Add(this.TxtCosto);
            this.Controls.Add(this.LblCostoR);
            this.Controls.Add(this.TxtFechaR);
            this.Controls.Add(this.LbLFechaR);
            this.Controls.Add(this.LblReservacion);
            this.Name = "Reservacion";
            this.Text = "Reservacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblReservacion;
        private System.Windows.Forms.Label LbLFechaR;
        private System.Windows.Forms.TextBox TxtFechaR;
        private System.Windows.Forms.Label LblCostoR;
        private System.Windows.Forms.TextBox TxtCosto;
        private System.Windows.Forms.Label LblTipoR;
        private System.Windows.Forms.Label LblNombreR;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnCancelarR;
        private System.Windows.Forms.Button BtnReservar;
        private System.Windows.Forms.CheckBox chkSencilla;
        private System.Windows.Forms.CheckBox chkDoble;
        private System.Windows.Forms.CheckBox chkSuite;
        private System.Windows.Forms.Label LblNumeroH;
        private System.Windows.Forms.TextBox TxtNumeroH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSalida;
    }
}