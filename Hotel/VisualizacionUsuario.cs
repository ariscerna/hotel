using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Hotel
{
    public partial class VisualizacionUsuario : Form
    {
        private BD mBD;
        ArrayList ListaHuesped;
        Ingreso_Huesped Ingreso_Huesped;


        public VisualizacionUsuario()
        {
            InitializeComponent();
            LeerHuesped();
        }
        public void LeerHuesped()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(LeerHuesped));
                return;
            }
            mBD = new BD();
            if (mBD.Conectar())
            {
                ListaHuesped = mBD.ConsultarHuesped();
                if (ListaHuesped != null)
                {
                    DgvConsulta.DataSource = null;
                    DgvConsulta.DataSource = ListaHuesped;
                    AjustarColumnas();
                }
                else
                {
                    MessageBox.Show("No hay Huespedes guardados");
                }
            }
            else
            {
                MessageBox.Show("No se pudo conectar");
            }
        }

        private void AjustarColumnas()
        {
            DgvConsulta.Columns[0].Width = 50;
            DgvConsulta.Columns[1].Width = 80;
            DgvConsulta.Columns[2].Width = 100;
            DgvConsulta.Columns[3].Width = 100;
            DgvConsulta.Columns[4].Width = 100;
            DgvConsulta.Columns[5].Width = 100;
            DgvConsulta.Columns[6].Width = 100;
            DgvConsulta.Columns[7].Width = 100;

        }




        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Ingreso_Huesped = new Ingreso_Huesped();
            Ingreso_Huesped.ShowDialog();
            LeerHuesped();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FrmSistema menu = new FrmSistema();
            menu.Show();
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Huesped huesped;
            DialogResult Respuesta;
            if (DgvConsulta.SelectedRows.Count > 0)
            {
                huesped = (Huesped)DgvConsulta.SelectedRows[0].DataBoundItem;
                Respuesta = MessageBox.Show(this, "¿Desea eliminar el Huesped seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Respuesta == DialogResult.Yes)
                {
                    if (mBD.Conectar())
                    {
                        if
                            (mBD.EliminarHuesped(huesped))
                        {
                            MessageBox.Show("Huesped eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LeerHuesped();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el Huesped", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        mBD.Desconectar();
                        LeerHuesped();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo conectar a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Huesped mHuesped;
            int FilaSeleccionada;
            Ingreso_Huesped mIngreso_Huesped;

            if (DgvConsulta.RowCount > 0)
            {
                FilaSeleccionada = DgvConsulta.CurrentRow.Index;
                mHuesped = (Huesped)ListaHuesped[FilaSeleccionada];
                mIngreso_Huesped = new Ingreso_Huesped();
                mIngreso_Huesped.SetHuespedes(mHuesped);
                mIngreso_Huesped.ShowDialog();
                LeerHuesped();
            }
            else
            {
                MessageBox.Show("No hay Huespedes para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaArchivo = "HuespedesExportados.csv";

                Archivo archivo = new Archivo();

                archivo.ExportarAExcelComoCSV(rutaArchivo, ListaHuesped.Cast<Huesped>().ToList());

                if (File.Exists(rutaArchivo))
                {
                    System.Diagnostics.Process.Start(rutaArchivo);
                }
                else
                {
                    MessageBox.Show("El archivo no se pudo crear o encontrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar abrir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                // Definir la ruta del archivo CSV
                string rutaArchivo = "ProductosExportados.csv";

                // Crear el archivo si no existe
                Archivo archivo = new Archivo();
                archivo.ExportarAExcelComoCSV(rutaArchivo, ListaHuesped.Cast<Huesped>().ToList());

                // Verificar si el archivo existe
                if (File.Exists(rutaArchivo))
                {
                    // Usar un proceso para imprimir el archivo usando Excel o el programa predeterminado
                    System.Diagnostics.Process printProcess = new System.Diagnostics.Process();
                    printProcess.StartInfo.FileName = rutaArchivo;
                    printProcess.StartInfo.Verb = "Print"; // Indica que se imprimirá el archivo
                    printProcess.StartInfo.CreateNoWindow = true; // Evitar abrir ventanas
                    printProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    printProcess.Start();

                    MessageBox.Show("El archivo se envió a la impresora.", "Impresión Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El archivo no existe. Por favor, verifica la ruta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar imprimir: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void VisualizacionUsuario_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void DgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            if (DgvConsulta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un huésped para generar la factura.");
                return;
            }

            Huesped huesped = (Huesped)DgvConsulta.SelectedRows[0].DataBoundItem;

            BD bd = new BD();
            if (!bd.Conectar())
            {
                MessageBox.Show("No se pudo conectar a la base de datos.");
                return;
            }

            try
            {
                // Buscar última reservación del huésped
                string query = @"
            SELECT r.fecha_reservacion, r.fecha_salida, r.costo_total, 
                   r.tipo_reservacion, h.numero_habitacion, h.tipo, h.costo, h.piso
            FROM Reservaciones r
            JOIN Habitaciones h ON r.id_habitacion = h.id_habitacion
            WHERE r.id_huesped = @idHuesped
            ORDER BY r.fecha_reservacion DESC
            LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, bd.ConexionAbierta))
                {
                    cmd.Parameters.AddWithValue("@idHuesped", huesped.Id_huesped);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Este huésped no tiene reservaciones.");
                            return;
                        }

                        DateTime fecha = DateTime.Now;
                        DateTime fechaEntrada = reader.GetDateTime("fecha_reservacion");
                        DateTime fechaSalida = reader.GetDateTime("fecha_salida");
                        int dias = (fechaSalida - fechaEntrada).Days;

                        string tipo = reader.GetString("tipo_reservacion");
                        string numero = reader.GetString("numero_habitacion");
                        string tipoHab = reader.GetString("tipo");
                        int piso = reader.GetInt32("piso");
                        float costoNoche = reader.GetFloat("costo");
                        float total = dias * costoNoche;

                        // Generar factura en CSV
                        string rutaArchivo = $"Factura_{huesped.Id_huesped}_{huesped.Nombre.Replace(" ", "_")}.csv";

                        using (StreamWriter sw = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
                        {
                            sw.WriteLine("Factura - Hotel Sol");
                            sw.WriteLine($"Fecha de generación,{fecha:yyyy-MM-dd HH:mm:ss}");
                            sw.WriteLine($"Fecha de entrada,{fechaEntrada:yyyy-MM-dd}");
                            sw.WriteLine($"Fecha de salida,{fechaSalida:yyyy-MM-dd}");
                            sw.WriteLine();

                            sw.WriteLine("ID Huesped,Nombre,Tipo de Habitación,Número,Piso,Días,Costo por noche,Total");
                            sw.WriteLine($"{huesped.Id_huesped},{huesped.Nombre} {huesped.apellido_paterno},{tipoHab},{numero},{piso},{dias},{costoNoche},{total}");
                        }

                        MessageBox.Show("Factura generada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (File.Exists(rutaArchivo))
                        {
                            System.Diagnostics.Process.Start(rutaArchivo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar la factura: " + ex.Message);
            }
            finally
            {
                bd.Desconectar();
            }
        }
    }
}
