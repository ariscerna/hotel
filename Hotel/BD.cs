using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Configuration;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace Hotel
{
    class BD
    {
        private MySqlConnection Conexion;
        private MySqlCommand Consulta;
        private string CadenaConexion;
        

        public bool Conectar()
        {
            CadenaConexion = "Server = localhost; Database = Hotel_sol7; User ID=root;Password = 1234; ";
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
        public bool Guardar1(Huesped mHuespet)
        {
            string TextComando = "INSERT INTO Habitaciones(nombre, apellido_paterno, apellido_materno, edad, correo, telefono)" +
                                 "VALUES(QNombre, @apellido_paterno, @apellido_materno, @Edad, @Correo, @Telefono);";
            try
            {
                Consulta = new MySqlCommand(TextComando, Conexion);

                Consulta.Parameters.AddWithValue("@Nombre", mHuespet.Nombre);
                Consulta.Parameters.AddWithValue("@apellido_paterno", mHuespet.apellido_paterno);
                Consulta.Parameters.AddWithValue("@apellido_materno", mHuespet.apellido_materno);
                Consulta.Parameters.AddWithValue("@Edad", mHuespet.Edad);
                Consulta.Parameters.AddWithValue("@Correo", mHuespet.Correo);
                Consulta.Parameters.AddWithValue("@Telefono", mHuespet.Telefono);
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
        public ArrayList ConsultarProductos()
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
                        mHuesped.Nombre = Lector.GetString("Nombre");
                        mHuesped.apellido_paterno = Lector.GetString("apellido_paterno");
                        mHuesped.apellido_materno = Lector.GetString("apellido_materno");
                        mHuesped.Edad = Lector.GetInt32("Edad");
                        mHuesped.Correo = Lector.GetString("Correo");
                        mHuesped.Telefono = Lector.GetInt32("Telefono");
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
        public  bool Eliminar(Huesped mHuesped)
        {
            string TextoComando = "delete from Huesped " 
                + "where codigo " = mHuesped.Codigo;
            try
            {
                Consulta = new MySqlCommand(TextoComando, Conexion);
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
            string TextoComando = "UPDATE Huesped SET nombre = @Nombre ,apellido_Paterno,apellido_materno,=@Correo,Telefono " + "WHERE codigo =@Codigo";

            try
            {
                Consulta = new MySqlCommand(TextoComando, Conexion);

                Consulta.Parameters.AddWithValue("@nombre",mHuesped.Nombre);
                Consulta.Parameters.AddWithValue("@apellido_paterno",mHuesped.apellido_paterno);
                Consulta.Parameters.AddWithValue("@appellido_materno",mHuesped.apellido_materno);
                Consulta.Parameters.AddWithValue("@correo",mHuesped.Correo);
                Consulta.Parameters.AddWithValue("@telefono",mHuesped.Telefono);

                Consulta.ExecuteNonQuery();

                return true;

            }
            catch
            {
                Console.WriteLine("Error al modificar el producto : " + Exception.Message);

                    return false;
            }
        }
    }
}
