using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Archivo
    {
        private string NombreArchivo;
        private StreamWriter Escritor;
        private StreamReader Lector;

        public Archivo()
        {
            NombreArchivo = "Huespedes.csv";
        }

        public Archivo(string NombreArchivo)
        {
            this.NombreArchivo = NombreArchivo;
        }

        public void CrearArchivo()
        {
            Escritor = new StreamWriter(NombreArchivo);
            Escritor.Close();
        }

        public void Escribir(Huesped mHuesped)
        {
            Escritor = new StreamWriter(NombreArchivo, true);
            Escritor.WriteLine(
                mHuesped.Id_huesped + "," +
                mHuesped.Nombre + "," +
                mHuesped.apellido_paterno + "," +
                mHuesped.apellido_materno + "," +
                mHuesped.Edad + "," +
                mHuesped.Direccion + "," +
                mHuesped.Telefono + "," +
                mHuesped.Correo
            );
            Escritor.Close();
        }

        public List<Huesped> Leer()
        {
            string linea;
            string[] datos;
            List<Huesped> ListaProductos = new List<Huesped>();

            Lector = new StreamReader(NombreArchivo);
            while (!Lector.EndOfStream)
            {
                linea = Lector.ReadLine();
                datos = linea.Split(',');

                Huesped mHuesped = new Huesped
                {
                    Id_huesped = int.Parse(datos[0]),
                    Nombre = datos[1],
                    apellido_paterno = datos[2],
                    apellido_materno = datos[3],
                    Edad = int.Parse(datos[4]),
                    Direccion = datos[5],
                    Telefono = datos[6],
                    Correo = datos[7]
                };
                ListaProductos.Add(mHuesped);
            }
            Lector.Close();

            return ListaProductos;
        }

        public void ExportarAExcelComoCSV(string rutaArchivo, List<Huesped> huespeds)
        {
            try
            {
                using (StreamWriter escritor = new StreamWriter(rutaArchivo))
                {
                    // Escribir encabezados
                    escritor.WriteLine("Id_Huesped,Nombre,Apellido paterno,Apellido Materno,Edad,Direccion,Telefono,Correo");

                    // Escribir los datos de los productos
                    foreach (Huesped mHuesped in huespeds)
                    {
                        escritor.WriteLine(
                            mHuesped.Id_huesped + "," +
                            mHuesped.Nombre + "," +
                            mHuesped.apellido_paterno + "," +
                            mHuesped.apellido_materno + "," +
                            mHuesped.Edad + "," +
                            mHuesped.Direccion + "," +
                            mHuesped.Telefono + "," +
                            mHuesped.Correo
                            );
                    }
                }

                Console.WriteLine("Datos exportados correctamente a Excel (CSV).");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al exportar los datos: " + ex.Message);
            }
        }
    }
}
