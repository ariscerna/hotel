using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class VisualizacionUsuario : Form
    {
        private BD mBD;
        ArrayList ListaHuesped;
        Ingreso_Huesped Ingreso_Huesped;
        
        
        public VisualizacionUsuario()
        {
            InitializeComponent();
            LeerHuesped();
        }
        public void LeerHuesped()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(LeerHuesped));
                return;
            }
            mBD = new BD();
            if(mBD.Conectar())
            {
                ListaHuesped = mBD.ConsultarHuesped();
                if (ListaHuesped != null)
                {
                    DgvConsulta.DataSource = null;
                    DgvConsulta.DataSource = ListaHuesped;
                    AjustarColumnas();
                }
                else
                {
                    MessageBox.Show("No hay Huespedes guardados");
                }  
            }
            else
            {
                MessageBox.Show("No se pudo conectar");
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
