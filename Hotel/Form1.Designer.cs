namespace Hotel
{
    partial class FrmSistema
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.RdbReservacion = new System.Windows.Forms.RadioButton();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.RdbReportes = new System.Windows.Forms.RadioButton();
            this.RdbConsulta = new System.Windows.Forms.RadioButton();
            this.RdbRegistrohab = new System.Windows.Forms.RadioButton();
            this.RbdVisualizacion = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // RdbReservacion
            // 
            this.RdbReservacion.AutoSize = true;
            this.RdbReservacion.Location = new System.Drawing.Point(81, 147);
            this.RdbReservacion.Name = "RdbReservacion";
            this.RdbReservacion.Size = new System.Drawing.Size(87, 20);
            this.RdbReservacion.TabIndex = 6;
            this.RdbReservacion.Text = "Reservar ";
            this.RdbReservacion.UseVisualStyleBackColor = true;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(237, 225);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(93, 29);
            this.BtnAceptar.TabIndex = 7;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "1.-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "2.-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "3.-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "5.-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "4.-";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(24, 225);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(81, 29);
            this.BtnCancelar.TabIndex = 16;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Menu Principal";
            // 
            // RdbReportes
            // 
            this.RdbReportes.AutoSize = true;
            this.RdbReportes.Location = new System.Drawing.Point(81, 174);
            this.RdbReportes.Name = "RdbReportes";
            this.RdbReportes.Size = new System.Drawing.Size(84, 20);
            this.RdbReportes.TabIndex = 19;
            this.RdbReportes.Text = "Reportes";
            this.RdbReportes.UseVisualStyleBackColor = true;
            // 
            // RdbConsulta
            // 
            this.RdbConsulta.AutoSize = true;
            this.RdbConsulta.Location = new System.Drawing.Point(84, 63);
            this.RdbConsulta.Name = "RdbConsulta";
            this.RdbConsulta.Size = new System.Drawing.Size(152, 20);
            this.RdbConsulta.TabIndex = 21;
            this.RdbConsulta.TabStop = true;
            this.RdbConsulta.Text = "Consultar Habitacion";
            this.RdbConsulta.UseVisualStyleBackColor = true;
            // 
            // RdbRegistrohab
            // 
            this.RdbRegistrohab.AutoSize = true;
            this.RdbRegistrohab.Location = new System.Drawing.Point(84, 93);
            this.RdbRegistrohab.Name = "RdbRegistrohab";
            this.RdbRegistrohab.Size = new System.Drawing.Size(166, 20);
            this.RdbRegistrohab.TabIndex = 2;
            this.RdbRegistrohab.Text = "Registro de Habitacion";
            this.RdbRegistrohab.UseVisualStyleBackColor = true;
            // 
            // RbdVisualizacion
            // 
            this.RbdVisualizacion.AutoSize = true;
            this.RbdVisualizacion.Location = new System.Drawing.Point(84, 121);
            this.RbdVisualizacion.Name = "RbdVisualizacion";
            this.RbdVisualizacion.Size = new System.Drawing.Size(173, 20);
            this.RbdVisualizacion.TabIndex = 22;
            this.RbdVisualizacion.TabStop = true;
            this.RbdVisualizacion.Text = "Visualizacion de usuario";
            this.RbdVisualizacion.UseVisualStyleBackColor = true;
            this.RbdVisualizacion.CheckedChanged += new System.EventHandler(this.RbdVisualizacion_CheckedChanged);
            // 
            // FrmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 309);
            this.Controls.Add(this.RbdVisualizacion);
            this.Controls.Add(this.RdbConsulta);
            this.Controls.Add(this.RdbReportes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.RdbReservacion);
            this.Controls.Add(this.RdbRegistrohab);
            this.Name = "FrmSistema";
            this.Text = " Hotel \"Sol\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton RdbReservacion;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RdbReportes;
        private System.Windows.Forms.RadioButton RdbConsulta;
        private System.Windows.Forms.RadioButton RdbRegistrohab;
        private System.Windows.Forms.RadioButton RbdVisualizacion;
    }
}

