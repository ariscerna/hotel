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
    public partial class Ingreso_Huesped : Form
    {

        private int Modo;
        private bool modoEdicion = false;
        private Huesped huespedActual;


        public Ingreso_Huesped()
        {
            InitializeComponent();
            Modo = 0;
        }

        private void BtnIngresarH_Click(object sender, EventArgs e)
        {
            Huesped mHuesped = new Huesped();
            BD mBD = new BD();

            if (mBD.Conectar())
            {
                Huesped h = new Huesped();
                h.Id_huesped = int.Parse(TxtCodigo.Text);
                h.Nombre = TxtNombreH.Text;
                h.apellido_paterno = TxtApellidoP.Text;
                h.apellido_materno = TxtApellidoM.Text;
                h.Edad = int.Parse(TxtEdad.Text);
                h.Direccion = TxtDireccion.Text;
                h.Correo = TxtCorreo.Text;
                h.Telefono = TxtTelefono.Text;

                bool exito;

                if (modoEdicion)
                {
                    // Le pasamos el mismo ID para que se actualice
                    h.Id_huesped = huespedActual.Id_huesped;
                    exito = mBD.Modificar(h);
                }
                else
                {
                    // Se está agregando uno nuevo
                   // h.Id_huesped = GenerarNuevoID(); // opcional si es autoincremental, puedes quitar esta línea
                    exito = mBD.GuardarHuesped(h);
                }

                if (exito)
                {
                    MessageBox.Show("Huésped guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar el huésped", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                mBD.Desconectar();
            }
            else
            {
                MessageBox.Show("No se pudo conectar a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelarH_Click(object sender, EventArgs e)
        {
            VisualizacionUsuario menu = new VisualizacionUsuario();
            menu.Show();
            this.Close();
        }

        public void SetHuespedes(Huesped h)
        {
            modoEdicion = true;
            huespedActual = h;

            // Rellenar los campos del formulario con los datos actuales
            TxtCodigo.Text = h.Id_huesped.ToString();   
            TxtNombreH.Text = h.Nombre;
            TxtApellidoP.Text = h.apellido_paterno;
            TxtApellidoM.Text = h.apellido_materno;
            TxtEdad.Text = h.Edad.ToString();
            TxtDireccion.Text = h.Direccion;
            TxtCorreo.Text = h.Correo;
            TxtTelefono.Text = h.Telefono;
        }


        private void Ingreso_Huesped_Load(object sender, EventArgs e)
        {

        }
    }
}
