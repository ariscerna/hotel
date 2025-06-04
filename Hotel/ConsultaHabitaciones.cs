using MySql.Data.MySqlClient;
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
    public partial class ConsultaHabitaciones : Form
    {
        public ConsultaHabitaciones()
        {
            InitializeComponent();
        }

        private void BtnConsultar2_Click(object sender, EventArgs e)
        {
            // Limpiar vistas previas
            DgvLibre.DataSource = null;
            DgvOcupada.DataSource = null;

            string tipoSeleccionado = "";

            if (RdbSencilla.Checked)
                tipoSeleccionado = "individual";
            else if (RdbDoble.Checked)
                tipoSeleccionado = "doble";
            else if (RdbSuite.Checked)
                tipoSeleccionado = "suite";

            if (string.IsNullOrWhiteSpace(tipoSeleccionado))
            {
                MessageBox.Show("Selecciona un tipo de habitación.");
                return;
            }

            MostrarHabitaciones(tipoSeleccionado);
        }

       

        private void MostrarHabitaciones(string tipo)
        {
            BD mBD = new BD();
            if (!mBD.Conectar())
            {
                MessageBox.Show("No se pudo conectar a la base de datos.");
                return;
            }

            try
            {
                // --- Habitaciones Libres ---
                string queryLibres = @"
                    SELECT id_habitacion AS 'ID', numero_habitacion AS 'Número', 
                           piso AS 'Piso', costo AS 'Costo', tipo AS 'Tipo'
                    FROM Habitaciones 
                    WHERE tipo = @tipo 
                      AND id_habitacion NOT IN (SELECT id_habitacion FROM Reservaciones)";

                using (MySqlCommand cmd = new MySqlCommand(queryLibres, mBD.ConexionAbierta))
                {
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable libres = new DataTable();
                    adapter.Fill(libres);
                    DgvLibre.DataSource = libres;
                }

                // --- Habitaciones Ocupadas ---
                string queryOcupadas = @"
                    SELECT id_habitacion AS 'ID', numero_habitacion AS 'Número', 
                           piso AS 'Piso', costo AS 'Costo', tipo AS 'Tipo'
                    FROM Habitaciones 
                    WHERE tipo = @tipo 
                      AND id_habitacion IN (SELECT id_habitacion FROM Reservaciones)";

                using (MySqlCommand cmd = new MySqlCommand(queryOcupadas, mBD.ConexionAbierta))
                {
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable ocupadas = new DataTable();
                    adapter.Fill(ocupadas);
                    DgvOcupada.DataSource = ocupadas;
                }

                AjustarColumnasHabitaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar habitaciones:\n" + ex.Message);
            }
            finally
            {
                mBD.Desconectar();
            }
        }


        private void AjustarColumnasHabitaciones()
        {
            // Configurar columnas DgvLibre
            if (DgvLibre.Columns.Count >= 5)
            {
                DgvLibre.Columns[0].Width = 50;   // ID
                DgvLibre.Columns[1].Width = 80;   // Número
                DgvLibre.Columns[2].Width = 60;   // Piso
                DgvLibre.Columns[3].Width = 80;   // Costo
                DgvLibre.Columns[4].Width = 100;  // Tipo
            }

            // Configurar columnas DgvOcupada
            if (DgvOcupada.Columns.Count >= 5)
            {
                DgvOcupada.Columns[0].Width = 50;
                DgvOcupada.Columns[1].Width = 80;
                DgvOcupada.Columns[2].Width = 60;
                DgvOcupada.Columns[3].Width = 80;
                DgvOcupada.Columns[4].Width = 100;
            }
        }


        private void DgvLibre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCancelar2_Click(object sender, EventArgs e)
        {
            FrmSistema menu = new FrmSistema();
            menu.Show();
            this.Close();
        }
    }
}
