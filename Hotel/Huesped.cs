using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Huesped
    {

        public string Nombre { set; get; }
        public string apellido_paterno { set; get; }
        public string apellido_materno { set; get; }
        public int Edad { set; get; }
        public string Direccion { set; get; }
        public int Telefono { set; get; }
        public string Correo { set; get; }


        public Huesped()
        {
            Nombre = "";
            apellido_paterno = "";
            apellido_materno = "";
            Edad = 0;
            Direccion = "";
            Telefono = 0;
            Correo = "";
        }
    }
}