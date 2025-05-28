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
            if (mBD.Conectar())
            {
                ListaHuesped = mBD.Consultarhuespedes();
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

        private void AjustarColumnas()
        {
            DgvConsulta.Columns[0].Width = 100;
            DgvConsulta.Columns[1].Width = 80;
            DgvConsulta.Columns[2].Width = 200;
            DgvConsulta.Columns[3].Width = 100;
            DgvConsulta.Columns[4].Width = 100;
        }




        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Ingreso_Huesped = new Ingreso_Huesped();
            Ingreso_Huesped.ShowDialog();
            LeerHuesped();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmSistema frmSistema = new FrmSistema();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Huesped huesped;
            DialogResult Respuesta;
            if (DgvConsulta.SelectedRows.Count > 0)
            {
                huesped = (Huesped)DgvConsulta.SelectedRows[0].DataBoundItem;
                Respuesta = MessageBox.Show(this, "¿Desea eliminar el Huesped seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Respuesta == DialogResult.Yes)
                {
                    if (mBD.Conectar())
                    {
                        if
                            (mBD.EliminarHuesped(huesped))
                        {
                            MessageBox.Show("Huesped eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LeerHuesped();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el Huesped", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        mBD.Desconectar();
                        LeerHuesped();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo conectar a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Huesped mHuesped;
            int FilaSeleccionada;
            Ingreso_Huesped mIngreso_Huesped;

            if (DgvConsulta.RowCount > 0)
            {
                FilaSeleccionada = DgvConsulta.CurrentRow.Index;
                mHuesped = (Huesped)ListaHuesped[FilaSeleccionada];
                mIngreso_Huesped = new Ingreso_Huesped();
                mIngreso_Huesped.SetHuesped(mHuesped);
                mIngreso_Huesped.ShowDialog();
                LeerHuesped();
            }
            else
            {
                MessageBox.Show("No hay Huespedes para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
