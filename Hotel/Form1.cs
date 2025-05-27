using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class FrmSistema : Form
    {


        public FrmSistema()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (RdbConsulta.Checked)
            {
                ConsultaHabitaciones formulario = new ConsultaHabitaciones();
                formulario.Show();
                this.Hide(); // Opcional, para ocultar el menú principal
            }
            else if (RdbRegistrohab.Checked)
            {
                RegistroHabitaciones formulario = new RegistroHabitaciones();
                formulario.Show();
                this.Hide();
            }
            else if (RbdVisualizacion.Checked)
            {
                VisualizacionUsuario formulario = new VisualizacionUsuario();
                formulario.Show();
                this.Hide();
            }
            else if (RdbReservacion.Checked)
            {
                Reservacion formulario = new Reservacion();
                formulario.Show();
                this.Hide();
            }
            else if (RdbReportes.Checked)
            {
                Reporte formulario = new Reporte();
                formulario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor selecciona una opción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
       
}
