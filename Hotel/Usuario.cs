using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public string UsuarioNombre { get; set; }
        public string Contrasena { get; set; }
        public string contrasenaencrip { get; set; }

        public string tipo_usuario { get; set; } // Agregado para el tipo de usuario

        public Usuario()
        {
            Nombre = "";
            apellido_paterno = "";
            apellido_materno = "";
            UsuarioNombre = "";
            Contrasena = "";
            tipo_usuario = "";
        }
    }
}
