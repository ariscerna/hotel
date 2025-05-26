using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Configuration;

namespace Hotel
{
    class BD
    {
        private MySqlConnection Conexion;
        private MySqlCommand Consulta;
        private string CadenaConexion;
        

        public bool Conectar()
        {
            CadenaConexion = "Server = localhost; Database = hotel; User ID=root;Password = 1234; ";
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
            string TextComando = "INSERT INTO habitacion (num_habitacion, piso, costo, tipo) " +
                "VALUES (@num_habitacion, @piso, @costo, @tipo)";

            try
            {
                Consulta = new MySqlCommand(TextComando, Conexion);

                Consulta.Parameters.AddWithValue("@num_habitacion", mHabitacion.num_habitacion);
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

        public bool GuardarUsuerio(Usuario mUsuario)
        {
            string TextComando = "INSERT INTO usuario (Nombre, apellido_paterno, apellido_materno, UsuarioNombre, Contrasena) " +
                "VALUES (@Nombre, @apellido_paterno, @apellido_materno, @UsuarioNombre, @Contrasena)";
            try
            {
                Consulta = new MySqlCommand(TextComando, Conexion);
                Consulta.Parameters.AddWithValue("@Nombre", mUsuario.Nombre);
                Consulta.Parameters.AddWithValue("@apellido_paterno", mUsuario.apellido_paterno);
                Consulta.Parameters.AddWithValue("@apellido_materno", mUsuario.apellido_materno);
                Consulta.Parameters.AddWithValue("@UsuarioNombre", mUsuario.UsuarioNombre);
                Consulta.Parameters.AddWithValue("@Contrasena", mUsuario.Contrasena);
                Consulta.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar usuario: " + ex.Message);
                return false;
            }
        }
    }
}
