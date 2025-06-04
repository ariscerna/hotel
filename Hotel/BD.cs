using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Cursor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    class BD
    {
        private MySqlConnection Conexion;
        private MySqlCommand Consulta;
        private string CadenaConexion;

        public MySqlConnection ConexionAbierta => Conexion;


        public bool Conectar()
        {
            CadenaConexion = "Server = localhost; Database = Hotel_sol1; User ID=root;Password = 1234; ";
            try
            {
                Conexion = new MySqlConnection(CadenaConexion);
                Conexion.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Desconectar()
        {
            Conexion.Close();
        }
        //Guardado de abitaciones nuevas 
        public bool Guardar(Habitacion mHabitacion)
        {
            string TextComando = "INSERT INTO Habitaciones (numero_habitacion, piso, costo, tipo) " +
                "VALUES (@numero_habitacion, @piso, @costo, @tipo)";

            try
            {
                Consulta = new MySqlCommand(TextComando, Conexion);

                Consulta.Parameters.AddWithValue("@numero_habitacion", mHabitacion.num_habitacion); // o mHabitacion.numero_habitacion si renombraste
                Consulta.Parameters.AddWithValue("@piso", mHabitacion.piso);
                Consulta.Parameters.AddWithValue("@costo", mHabitacion.costo);
                Consulta.Parameters.AddWithValue("@tipo", mHabitacion.tipo);

                Consulta.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar habitacion: " + ex.Message);
                return false;
            }
        }


        //Guardado de huespedes nuevos  
        public bool GuardarHuesped(Huesped mHuesped)
        {
            string TextComando = "INSERT INTO huespedes(id_huesped, nombre, apellido_paterno, apellido_materno, edad, direccion, correo, telefono)" +
                                 "VALUES(@Id_Huesped, @Nombre, @apellido_paterno, @apellido_materno, @Edad, @Direccion, @Correo, @Telefono);";
            try
            {
                Consulta = new MySqlCommand(TextComando, Conexion);

                Consulta.Parameters.AddWithValue("@Id_Huesped", mHuesped.Id_huesped);
                Consulta.Parameters.AddWithValue("@Nombre", mHuesped.Nombre);
                Consulta.Parameters.AddWithValue("@apellido_paterno", mHuesped.apellido_paterno);
                Consulta.Parameters.AddWithValue("@apellido_materno", mHuesped.apellido_materno);
                Consulta.Parameters.AddWithValue("@Edad", mHuesped.Edad);
                Consulta.Parameters.AddWithValue("@Direccion", mHuesped.Direccion);
                Consulta.Parameters.AddWithValue("@Correo", mHuesped.Correo);
                Consulta.Parameters.AddWithValue("@Telefono", mHuesped.Telefono);
                Consulta.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar huesped: " + ex.Message);
                return false;
            }
        }

        public bool GuardarUsuario(Usuario mUsuario)
        {
            string TextComando = "INSERT INTO Usuarios (nombre, apellido_paterno, apellido_materno, tipo_usuario, nombre_usuario, contrasena) " +
                "VALUES (@Nombre, @apellido_paterno, @apellido_materno, @tipo_usuario, @UsuarioNombre, @Contrasena)";
            try
            {
                // Generar el hash de la contraseña
                string Contrasena = GenerarHashSHA256(mUsuario.Contrasena);

                Consulta = new MySqlCommand(TextComando, Conexion);
                Consulta.Parameters.AddWithValue("@Nombre", mUsuario.Nombre);
                Consulta.Parameters.AddWithValue("@apellido_paterno", mUsuario.apellido_paterno);
                Consulta.Parameters.AddWithValue("@apellido_materno", mUsuario.apellido_materno);
                Consulta.Parameters.AddWithValue("@tipo_usuario", mUsuario.tipo_usuario);
                Consulta.Parameters.AddWithValue("@UsuarioNombre", mUsuario.UsuarioNombre);
                Consulta.Parameters.AddWithValue("@Contrasena", Contrasena); // ← Aquí estaba el error
                Consulta.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar usuario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }


        public bool GuardarReservacion(Reserva mReserva, int idUsuario, int idHabitacion, int idHuesped)
        {
            string TextComando = "INSERT INTO Reservaciones (fecha_reservacion, fecha_salida, costo_total, tipo_reservacion, id_usuario, id_habitacion, id_huesped) " +
                                 "VALUES (@Fecha, @FechaSalida, @Costo, @Tipo, @IdUsuario, @IdHabitacion, @IdHuesped)";
            try
            {
                Consulta = new MySqlCommand(TextComando, Conexion);
                Consulta.Parameters.AddWithValue("@Fecha", mReserva.Fecha);
                Consulta.Parameters.AddWithValue("@FechaSalida", mReserva.FechaSalida);
                Consulta.Parameters.AddWithValue("@Costo", mReserva.Costo);
                Consulta.Parameters.AddWithValue("@Tipo", mReserva.TipoHabitacion);
                Consulta.Parameters.AddWithValue("@IdUsuario", idUsuario);
                Consulta.Parameters.AddWithValue("@IdHabitacion", idHabitacion);
                Consulta.Parameters.AddWithValue("@IdHuesped", idHuesped);

                Consulta.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar reservación: " + ex.Message);
                return false;
            }
        }



        //Encriptar en SHA256
        public static string GenerarHashSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder resultado = new StringBuilder();


                foreach (byte b in hash)
                {
                    resultado.Append(b.ToString("x2"));
                }

                return resultado.ToString();
            }
        }


        //validar usuario
        public bool ValidarUsuario(string nombreUsuario, string contraseña)
        {
            string TextoComando = "SELECT * FROM Usuarios WHERE nombre_usuario = @NombreUsuario AND contrasena = @Contrasena";

            try
            {
                // Encriptar la contraseña ingresada para compararla con la almacenada
                string contraseñaEncriptada = GenerarHashSHA256(contraseña);

                if (Conexion.State != ConnectionState.Open)
                    Conexion.Open();

                using (MySqlCommand Consulta = new MySqlCommand(TextoComando, Conexion))
                {
                    Consulta.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    Consulta.Parameters.AddWithValue("@Contrasena", contraseñaEncriptada);

                    using (MySqlDataReader Lector = Consulta.ExecuteReader())
                    {
                        if (Lector.HasRows)
                        {
                            return true; // Usuario válido
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar usuario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false; // Usuario inválido o error
        }
        public ArrayList ConsultarHuespedes()
        {
            ArrayList ListaUsuarios = null;
            MySqlDataReader Lector;
            Huesped mHuesped;

            string TextoComando = "Select * from  Huespedes";

            try
            {

                Consulta = new MySqlCommand(TextoComando, Conexion);
                Lector = Consulta.ExecuteReader();
                if (Lector.HasRows)
                {
                    ListaUsuarios = new ArrayList();
                    while (Lector.Read())
                    {
                        mHuesped = new Huesped();
                        mHuesped.Id_huesped = Lector.GetInt32("id_huesped");
                        mHuesped.Nombre = Lector.GetString("Nombre");
                        mHuesped.apellido_paterno = Lector.GetString("apellido_paterno");
                        mHuesped.apellido_materno = Lector.GetString("apellido_materno");
                        mHuesped.Edad = Lector.GetInt32("Edad");
                        mHuesped.Direccion = Lector.GetString("Direccion");
                        mHuesped.Correo = Lector.GetString("Correo");
                        mHuesped.Telefono = Lector.GetString ("Telefono");

                        ListaUsuarios.Add(mHuesped);
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return ListaUsuarios;
        }
        public bool EliminarHuesped(Huesped mHuesped)
        {
            string TextoComando = "DELETE FROM huespedes WHERE id_huesped = @Id_Huesped";
            try
            {
                Consulta = new MySqlCommand(TextoComando, Conexion);
                Consulta.Parameters.AddWithValue("@Id_Huesped", mHuesped.Id_huesped);
                Consulta.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Modificar(Huesped mHuesped)
        {
            string TextoComando = "UPDATE Huespedes SET nombre = @Nombre, apellido_paterno = @apellido_paterno, apellido_materno = @apellido_materno, edad = @Edad, direccion = @Direccion, correo = @Correo, telefono = @Telefono " +
                                  "WHERE id_huesped = @Id_huesped;";
            try
            {
                Consulta = new MySqlCommand(TextoComando, Conexion);

                Consulta.Parameters.AddWithValue("@Nombre", mHuesped.Nombre);
                Consulta.Parameters.AddWithValue("@apellido_paterno", mHuesped.apellido_paterno);
                Consulta.Parameters.AddWithValue("@apellido_materno", mHuesped.apellido_materno);
                Consulta.Parameters.AddWithValue("@Edad", mHuesped.Edad);
                Consulta.Parameters.AddWithValue("@Direccion", mHuesped.Direccion);
                Consulta.Parameters.AddWithValue("@Correo", mHuesped.Correo);
                Consulta.Parameters.AddWithValue("@Telefono", mHuesped.Telefono);
                Consulta.Parameters.AddWithValue("@Id_huesped", mHuesped.Id_huesped);

                Consulta.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar el huésped: " + ex.Message);
                return false;
            }
        }



        public ArrayList ConsultarHuesped()
        {
            ArrayList ListaHuesped = null;
            MySqlDataReader Lector;
            Huesped mHuesped;
            string TextoComando = "Select * from  Huespedes";
            try
            {
                Consulta = new MySqlCommand(TextoComando, Conexion);
                Lector = Consulta.ExecuteReader();
                if (Lector.HasRows)
                {
                    ListaHuesped = new ArrayList();
                    while (Lector.Read())
                    {
                        mHuesped = new Huesped();
                        mHuesped.Id_huesped = Lector.GetInt32("id_huesped");
                        mHuesped.Nombre = Lector.GetString("Nombre");
                        mHuesped.apellido_paterno = Lector.GetString("apellido_paterno");
                        mHuesped.apellido_materno = Lector.GetString("apellido_materno");
                        mHuesped.Edad = Lector.GetInt32("Edad");
                        mHuesped.Direccion = Lector.GetString("Direccion");
                        mHuesped.Correo = Lector.GetString("Correo");
                        mHuesped.Telefono = Lector.GetString("Telefono");
                        ListaHuesped.Add(mHuesped);
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return ListaHuesped;
        }
    }


}
