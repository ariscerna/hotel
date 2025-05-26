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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LblHabitacionLibre = new System.Windows.Forms.Label();
            this.LblHabitacionesOcupadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // RdbDoble
            // 
            this.RdbDoble.AutoSize = true;
            this.RdbDoble.Location = new System.Drawing.Point(23, 118);
            this.RdbDoble.Name = "RdbDoble";
            this.RdbDoble.Size = new System.Drawing.Size(137, 20);
            this.RdbDoble.TabIndex = 1;
            this.RdbDoble.Text = "Habitacion Doble ";
            this.RdbDoble.UseVisualStyleBackColor = true;
            // 
            // RdbSuite
            // 
            this.RdbSuite.AutoSize = true;
            this.RdbSuite.Checked = true;
            this.RdbSuite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RdbSuite.Location = new System.Drawing.Point(23, 183);
            this.RdbSuite.Name = "RdbSuite";
            this.RdbSuite.Size = new System.Drawing.Size(130, 20);
            this.RdbSuite.TabIndex = 2;
            this.RdbSuite.Text = "Habitacion  Suite";
            this.RdbSuite.UseVisualStyleBackColor = true;
            // 
            // RdbSencilla
            // 
            this.RdbSencilla.AutoSize = true;
            this.RdbSencilla.Location = new System.Drawing.Point(23, 66);
            this.RdbSencilla.Name = "RdbSencilla";
            this.RdbSencilla.Size = new System.Drawing.Size(145, 20);
            this.RdbSencilla.TabIndex = 3;
            this.RdbSencilla.Text = "Habitacion Sencilla";
            this.RdbSencilla.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar2
            // 
            this.BtnCancelar2.Location = new System.Drawing.Point(420, 339);
            this.BtnCancelar2.Name = "BtnCancelar2";
            this.BtnCancelar2.Size = new System.Drawing.Size(108, 23);
            this.BtnCancelar2.TabIndex = 4;
            this.BtnCancelar2.Text = "Cancelar";
            this.BtnCancelar2.UseVisualStyleBackColor = true;
            // 
            // BtnConsultar2
            // 
            this.BtnConsultar2.Location = new System.Drawing.Point(23, 339);
            this.BtnConsultar2.Name = "BtnConsultar2";
            this.BtnConsultar2.Size = new System.Drawing.Size(114, 23);
            this.BtnConsultar2.TabIndex = 5;
            this.BtnConsultar2.Text = "Consultar";
            this.BtnConsultar2.UseVisualStyleBackColor = true;
            // 
            // LblConsulta
            // 
            this.LblConsulta.AutoSize = true;
            this.LblConsulta.Location = new System.Drawing.Point(173, 20);
            this.LblConsulta.Name = "LblConsulta";
            this.LblConsulta.Size = new System.Drawing.Size(161, 16);
            this.LblConsulta.TabIndex = 6;
            this.LblConsulta.Text = "Consulta de habitaciones ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(259, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(150, 194);
            this.dataGridView1.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(473, 96);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(150, 194);
            this.dataGridView2.TabIndex = 8;
            // 
            // LblHabitacionLibre
            // 
            this.LblHabitacionLibre.AutoSize = true;
            this.LblHabitacionLibre.Location = new System.Drawing.Point(273, 69);
            this.LblHabitacionLibre.Name = "LblHabitacionLibre";
            this.LblHabitacionLibre.Size = new System.Drawing.Size(127, 16);
            this.LblHabitacionLibre.TabIndex = 9;
            this.LblHabitacionLibre.Text = "Habitaciones Libres";
            // 
            // LblHabitacionesOcupadas
            // 
            this.LblHabitacionesOcupadas.AutoSize = true;
            this.LblHabitacionesOcupadas.Location = new System.Drawing.Point(464, 67);
            this.LblHabitacionesOcupadas.Name = "LblHabitacionesOcupadas";
            this.LblHabitacionesOcupadas.Size = new System.Drawing.Size(159, 16);
            this.LblHabitacionesOcupadas.TabIndex = 10;
            this.LblHabitacionesOcupadas.Text = "Habitaciones Ocupadas :";
            // 
            // ConsultaHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 396);
            this.Controls.Add(this.LblHabitacionesOcupadas);
            this.Controls.Add(this.LblHabitacionLibre);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LblConsulta);
            this.Controls.Add(this.BtnConsultar2);
            this.Controls.Add(this.BtnCancelar2);
            this.Controls.Add(this.RdbSencilla);
            this.Controls.Add(this.RdbSuite);
            this.Controls.Add(this.RdbDoble);
            this.Name = "ConsultaHabitaciones";
            this.Text = "ConsultaHabitaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label LblHabitacionLibre;
        private System.Windows.Forms.Label LblHabitacionesOcupadas;
    }
}