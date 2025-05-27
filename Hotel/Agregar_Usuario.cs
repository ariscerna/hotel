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
    public partial class Agregar_Usuario : Form
    {
        private int Modo;

        public Agregar_Usuario()
        {
            InitializeComponent();
            Modo = 0;
        }
        public void SetUsuario(Usuario mUsuario)
        {
            Modo = 1;
            TxtContraseña.Text = mUsuario.Contrasena.ToString();
            TxtContraseña.Enabled = false;
            TxtNombreUsuario.Text = mUsuario.Nombre;
            TxtApellidoU.Text = mUsuario.apellido_paterno;
            TxtApellidoM.Text = mUsuario.apellido_materno;
            TxtTipoU.Text = mUsuario.tipo_usuario;
            TxtContraseña.Text = mUsuario.Contrasena;
        }
        private void LblRegistroU_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistarU_Click(object sender, EventArgs e)
        {
            Usuario mUsuario = new Usuario();
            BD conexion = new BD();


            mUsuario.Nombre = (TxtNombreUsuario.Text);
            mUsuario.apellido_paterno = (TxtApellidoU.Text);
            mUsuario.apellido_materno = (TxtApellidoM.Text);
            mUsuario.Contrasena = (TxtContraseña.Text);
            mUsuario.UsuarioNombre = (TxtNombreUsuario2.Text); // Asignar el nombre de usuario
            mUsuario.tipo_usuario = (TxtTipoU.Text);


            if (conexion.Conectar())
            {
                if (Modo == 0)
                {
                    if (conexion.GuardarUsuario(mUsuario))
                    {
                        MessageBox.Show("Usuario registrado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Error  al registrar el usuario");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingresa todos los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    conexion.Desconectar();
                }
                else
                {
                    MessageBox.Show("No se pudo conectar a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void BtnCancelarU_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
