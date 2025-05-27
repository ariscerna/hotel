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
    public partial class RegistroHabitaciones : Form
    {
        public RegistroHabitaciones()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar tipo de habitación
            string tipo = "";
            if (chkSencilla.Checked)
                tipo = "individual";
            else if (chkDoble.Checked)
                tipo = "doble";
            else if (chkSuite.Checked)
                tipo = "suite";
            else
            {
                MessageBox.Show("Selecciona un tipo de habitación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar y capturar el resto de los datos
            if (string.IsNullOrWhiteSpace(TxtNumeroH.Text) ||
                string.IsNullOrWhiteSpace(Txtpiso.Text) ||
                string.IsNullOrWhiteSpace(TxtCosto.Text))
            {
                MessageBox.Show("Completa todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear objeto
            Habitacion nuevaHabitacion = new Habitacion
            {
                num_habitacion = TxtNumeroH.Text,
                piso = int.Parse(Txtpiso.Text),
                costo = (float)decimal.Parse(TxtCosto.Text),
                tipo = tipo
            };

            // Guardar en la base de datos
            BD bd = new BD();
            if (!bd.Conectar())
            {
                MessageBox.Show("No se pudo conectar con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bd.Guardar(nuevaHabitacion))
            {
                MessageBox.Show("Habitación registrada correctamente.");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al registrar habitación.");
            }

        }

        private void LimpiarCampos()
        {
            TxtNumeroH.Clear();
            Txtpiso.Clear();
            TxtCosto.Clear();
            chkSencilla.Checked = false;
            chkDoble.Checked = false;
            chkSuite.Checked = false;
        }

        private void ChTipoH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistroHabitaciones_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelar3_Click(object sender, EventArgs e)
        {
            FrmSistema menu = new FrmSistema();
            menu.Show();
            this.Close();

        }
    }
}
