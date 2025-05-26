using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Habitacion
    {
        public int Id_habitacion { get; set; }

        public string num_habitacion { get; set; }

        public int piso { get; set; }

        public float costo { get; set; }

        public string tipo { get; set; }

        public Habitacion()
        {
            Id_habitacion = 0;
            num_habitacion = "";
            piso = 0;
            costo = 0;
            tipo = "";
        }

    }
}
