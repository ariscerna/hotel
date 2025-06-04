using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public partial class Huesped
    {

        public int Id_huesped { set; get; }
        public string Nombre { set; get; }
        public string apellido_paterno { set; get; }
        public string apellido_materno { set; get; }
        public int Edad { set; get; }
        public string Direccion { set; get; }
        public string Telefono { set; get; }
        public string Correo { set; get; }


        public Huesped()
        {
            Id_huesped = 0;
            Nombre = "";
            apellido_paterno = "";
            apellido_materno = "";
            Edad = 0;
            Direccion = "";
            Telefono = "";
            Correo = "";
        }
    }
}