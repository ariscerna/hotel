namespace Hotel
{
    partial class ConsultaHabitaciones
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
            this.RdbDoble = new System.Windows.Forms.CheckBox();
            this.RdbSuite = new System.Windows.Forms.CheckBox();
            this.RdbSencilla = new System.Windows.Forms.CheckBox();
            this.BtnCancelar2 = new System.Windows.Forms.Button();
            this.BtnConsultar2 = new System.Windows.Forms.Button();
            this.LblConsulta = new System.Windows.Forms.Label();
            this.DgvLibre = new System.Windows.Forms.DataGridView();
            this.DgvOcupada = new System.Windows.Forms.DataGridView();
            this.LblHabitacionLibre = new System.Windows.Forms.Label();
            this.LblHabitacionesOcupadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOcupada)).BeginInit();
            this.SuspendLayout();
            // 
            // RdbDoble
            // 
            this.RdbDoble.AutoSize = true;
            this.RdbDoble.Location = new System.Drawing.Point(23, 175);
            this.RdbDoble.Name = "RdbDoble";
            this.RdbDoble.Size = new System.Drawing.Size(137, 20);
            this.RdbDoble.TabIndex = 1;
            this.RdbDoble.Text = "Habitacion Doble ";
            this.RdbDoble.UseVisualStyleBackColor = true;
            // 
            // RdbSuite
            // 
            this.RdbSuite.AutoSize = true;
            this.RdbSuite.Location = new System.Drawing.Point(23, 240);
            this.RdbSuite.Name = "RdbSuite";
            this.RdbSuite.Size = new System.Drawing.Size(130, 20);
            this.RdbSuite.TabIndex = 2;
            this.RdbSuite.Text = "Habitacion  Suite";
            this.RdbSuite.UseVisualStyleBackColor = true;
            // 
            // RdbSencilla
            // 
            this.RdbSencilla.AutoSize = true;
            this.RdbSencilla.Location = new System.Drawing.Point(23, 123);
            this.RdbSencilla.Name = "RdbSencilla";
            this.RdbSencilla.Size = new System.Drawing.Size(145, 20);
            this.RdbSencilla.TabIndex = 3;
            this.RdbSencilla.Text = "Habitacion Sencilla";
            this.RdbSencilla.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar2
            // 
            this.BtnCancelar2.Location = new System.Drawing.Point(218, 328);
            this.BtnCancelar2.Name = "BtnCancelar2";
            this.BtnCancelar2.Size = new System.Drawing.Size(108, 23);
            this.BtnCancelar2.TabIndex = 4;
            this.BtnCancelar2.Text = "Cancelar";
            this.BtnCancelar2.UseVisualStyleBackColor = true;
            this.BtnCancelar2.Click += new System.EventHandler(this.BtnCancelar2_Click);
            // 
            // BtnConsultar2
            // 
            this.BtnConsultar2.Location = new System.Drawing.Point(23, 328);
            this.BtnConsultar2.Name = "BtnConsultar2";
            this.BtnConsultar2.Size = new System.Drawing.Size(114, 23);
            this.BtnConsultar2.TabIndex = 5;
            this.BtnConsultar2.Text = "Consultar";
            this.BtnConsultar2.UseVisualStyleBackColor = true;
            this.BtnConsultar2.Click += new System.EventHandler(this.BtnConsultar2_Click);
            // 
            // LblConsulta
            // 
            this.LblConsulta.AutoSize = true;
            this.LblConsulta.Location = new System.Drawing.Point(437, 9);
            this.LblConsulta.Name = "LblConsulta";
            this.LblConsulta.Size = new System.Drawing.Size(161, 16);
            this.LblConsulta.TabIndex = 6;
            this.LblConsulta.Text = "Consulta de habitaciones ";
            // 
            // DgvLibre
            // 
            this.DgvLibre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLibre.Location = new System.Drawing.Point(218, 103);
            this.DgvLibre.Name = "DgvLibre";
            this.DgvLibre.RowHeadersWidth = 51;
            this.DgvLibre.RowTemplate.Height = 24;
            this.DgvLibre.Size = new System.Drawing.Size(396, 194);
            this.DgvLibre.TabIndex = 7;
            this.DgvLibre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLibre_CellContentClick);
            // 
            // DgvOcupada
            // 
            this.DgvOcupada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOcupada.Location = new System.Drawing.Point(643, 103);
            this.DgvOcupada.Name = "DgvOcupada";
            this.DgvOcupada.RowHeadersWidth = 51;
            this.DgvOcupada.RowTemplate.Height = 24;
            this.DgvOcupada.Size = new System.Drawing.Size(402, 194);
            this.DgvOcupada.TabIndex = 8;
            // 
            // LblHabitacionLibre
            // 
            this.LblHabitacionLibre.AutoSize = true;
            this.LblHabitacionLibre.Location = new System.Drawing.Point(350, 70);
            this.LblHabitacionLibre.Name = "LblHabitacionLibre";
            this.LblHabitacionLibre.Size = new System.Drawing.Size(127, 16);
            this.LblHabitacionLibre.TabIndex = 9;
            this.LblHabitacionLibre.Text = "Habitaciones Libres";
            // 
            // LblHabitacionesOcupadas
            // 
            this.LblHabitacionesOcupadas.AutoSize = true;
            this.LblHabitacionesOcupadas.Location = new System.Drawing.Point(736, 57);
            this.LblHabitacionesOcupadas.Name = "LblHabitacionesOcupadas";
            this.LblHabitacionesOcupadas.Size = new System.Drawing.Size(159, 16);
            this.LblHabitacionesOcupadas.TabIndex = 10;
            this.LblHabitacionesOcupadas.Text = "Habitaciones Ocupadas :";
            // 
            // ConsultaHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 380);
            this.Controls.Add(this.LblHabitacionesOcupadas);
            this.Controls.Add(this.LblHabitacionLibre);
            this.Controls.Add(this.DgvOcupada);
            this.Controls.Add(this.DgvLibre);
            this.Controls.Add(this.LblConsulta);
            this.Controls.Add(this.BtnConsultar2);
            this.Controls.Add(this.BtnCancelar2);
            this.Controls.Add(this.RdbSencilla);
            this.Controls.Add(this.RdbSuite);
            this.Controls.Add(this.RdbDoble);
            this.Name = "ConsultaHabitaciones";
            this.Text = "ConsultaHabitaciones";
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOcupada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox RdbDoble;
        private System.Windows.Forms.CheckBox RdbSuite;
        private System.Windows.Forms.CheckBox RdbSencilla;
        private System.Windows.Forms.Button BtnCancelar2;
        private System.Windows.Forms.Button BtnConsultar2;
        private System.Windows.Forms.Label LblConsulta;
        private System.Windows.Forms.DataGridView DgvLibre;
        private System.Windows.Forms.DataGridView DgvOcupada;
        private System.Windows.Forms.Label LblHabitacionLibre;
        private System.Windows.Forms.Label LblHabitacionesOcupadas;
    }
}