using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Hotel
{
    public partial class Reservacion : Form
    {
        public Reservacion()
        {
            InitializeComponent();
        }

        List<Reserva> listaReservas = new List<Reserva>();

        private void BtnReservar_Click(object sender, EventArgs e)
        {
            // Obtener datos del formulario
            string fecha = TxtFechaR.Text;
            string fechaSalida = TxtSalida.Text; // <-- nueva línea
            string costo = TxtCosto.Text;
            string numeroHabitacion = TxtNumeroH.Text;
            string nombreHuesped = TxtNombre.Text;

            string tipoHabitacion = "";
            if (chkSencilla.Checked)
                tipoHabitacion = "individual";
            else if (chkDoble.Checked)
                tipoHabitacion = "doble";
            else if (chkSuite.Checked)
                tipoHabitacion = "suite";

            // Validación simple
            if (string.IsNullOrWhiteSpace(fecha) || string.IsNullOrWhiteSpace(fechaSalida) ||
                string.IsNullOrWhiteSpace(costo) || string.IsNullOrWhiteSpace(numeroHabitacion) ||
                string.IsNullOrWhiteSpace(nombreHuesped) || string.IsNullOrWhiteSpace(tipoHabitacion))
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }

            try
            {
                BD mBD = new BD();
                mBD.Conectar();

                decimal Costo = decimal.Parse(costo);
                int idUsuario = 1;
                int idHabitacion = ObtenerIdHabitacion(numeroHabitacion, mBD.ConexionAbierta);
                int idHuesped = ObtenerIdHuesped(nombreHuesped, mBD.ConexionAbierta);

                if (idHabitacion == -1)
                {
                    MessageBox.Show("La habitación no existe.");
                    return;
                }

                if (idHuesped == -1)
                {
                    MessageBox.Show("El huésped no existe.");
                    return;
                }

                // Crear objeto de reservación
                Reserva reserva = new Reserva
                {
                    Fecha = fecha,
                    FechaSalida = fechaSalida, // <-- nueva línea
                    Costo = Costo,
                    NumeroHabitacion = numeroHabitacion,
                    TipoHabitacion = tipoHabitacion,
                    NombreHuesped = nombreHuesped
                };

                // Guardar en base de datos
                bool resultado = mBD.GuardarReservacion(reserva, idUsuario, idHabitacion, idHuesped);
                if (resultado)
                    MessageBox.Show("Reservación guardada correctamente.");
                else
                    MessageBox.Show("Error al guardar la reservación.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnCancelarR_Click(object sender, EventArgs e)
        {
            FrmSistema menu = new FrmSistema();
            menu.Show();
            this.Close();
        }


        

        public int ObtenerIdHabitacion(string numeroHabitacion, MySqlConnection conexion)
        {
            string query = "SELECT id_habitacion FROM Habitaciones WHERE numero_habitacion = @Numero";
            using (MySqlCommand cmd = new MySqlCommand(query, conexion))
            {
                cmd.Parameters.AddWithValue("@Numero", numeroHabitacion);
                object resultado = cmd.ExecuteScalar();
                return resultado != null ? Convert.ToInt32(resultado) : -1;
            }
        }



        public int ObtenerIdHuesped(string nombreHuesped, MySqlConnection conexion)
        {
            string query = "SELECT id_huesped FROM Huespedes WHERE nombre LIKE @Nombre LIMIT 1";
            using (MySqlCommand cmd = new MySqlCommand(query, conexion))
            {
                cmd.Parameters.AddWithValue("@Nombre", "%" + nombreHuesped + "%");

                object resultado = cmd.ExecuteScalar();
                return resultado != null ? Convert.ToInt32(resultado) : -1;
            }
        }






    }
}
