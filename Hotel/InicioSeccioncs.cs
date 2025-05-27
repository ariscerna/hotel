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
        public InicioSeccioncs()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Agregar_Usuario mFrmAgregarUsuario = new Agregar_Usuario();
            mFrmAgregarUsuario.Show();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            BD conexion = new BD();
            if (conexion.Conectar())
            {
                string usuarionombre = TxtUsuario.Text.Trim();
                string contrasena = TxtContraseña.Text.Trim();

                if (conexion.ValidarUsuario(usuarionombre, contrasena))
                {
                    MessageBox.Show("Inicio de sesión exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
