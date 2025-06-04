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
    public partial class InicioSeccioncs : Form
    {

        // Usuario administrador hardcodeado
        private readonly string adminUsuario = "admin";
        private readonly string adminContrasena = "1234";


        public InicioSeccioncs()
        {
            InitializeComponent();
            BtnRegistrar.Enabled = false;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
          
            Agregar_Usuario mFrmAgregarUsuario = new Agregar_Usuario();
            mFrmAgregarUsuario.Show();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuarionombre = TxtUsuario.Text.Trim();
            string contrasena = TxtContraseña.Text.Trim();

            // Si es el administrador hardcodeado
            if (usuarionombre == adminUsuario && contrasena == adminContrasena)
            {
                MessageBox.Show("Has iniciado sesión como administrador.", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnRegistrar.Enabled = true;  // activar botón registrar
                return; // NO pasamos de este formulario
            }

            // Si es un usuario normal → validación contra BD
            BD conexion = new BD();
            if (conexion.Conectar())
            {
                if (conexion.ValidarUsuario(usuarionombre, contrasena))
                {
                    MessageBox.Show("Inicio de sesión exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnRegistrar.Enabled = false; // mantener desactivado para usuarios normales

                    this.Hide();
                    FrmSistema mFrmInicio = new FrmSistema();
                    mFrmInicio.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conexion.Desconectar();
            }
            else
            {
                MessageBox.Show("No se pudo conectar a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TxtUsuario.Clear();
            TxtContraseña.Clear();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtUsuario.Clear();
            TxtContraseña.Clear();
            this.Close();
        }
    }
}
