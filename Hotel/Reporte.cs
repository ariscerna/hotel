using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
            CmbTipoReporte.Items.AddRange(new string[] { "Financiero", "Ocupación", "Inventario", "Otro" });
        }



        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string fecha = TxtFechaR.Text.Trim();
            string tipo = CmbTipoReporte.Text.Trim(); // Cambiado a Text por ser un TextBox
            string asunto = TxtAsunto.Text.Trim();

            if (string.IsNullOrWhiteSpace(fecha) || string.IsNullOrWhiteSpace(tipo) || string.IsNullOrWhiteSpace(asunto))
            {
                MessageBox.Show("Por favor, llena todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreArchivo = $"Reporte_{tipo}_{DateTime.Now:yyyyMMdd_HHmmss}.doc";

            try
            {
                using (StreamWriter sw = new StreamWriter(nombreArchivo, false, Encoding.UTF8))
                {
                    sw.WriteLine("Reporte - Hotel Sol");
                    sw.WriteLine($"Fecha del Reporte: {fecha}");
                    sw.WriteLine($"Tipo de Reporte: {tipo}");
                    sw.WriteLine();
                    sw.WriteLine("Asunto:");
                    sw.WriteLine(asunto);
                }

                MessageBox.Show("Reporte guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (File.Exists(nombreArchivo))
                    System.Diagnostics.Process.Start(nombreArchivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el reporte: " + ex.Message);
            }
        }

        private void BtnCancelarR_Click(object sender, EventArgs e)
        {
            FrmSistema menu = new FrmSistema();
            menu.Show();
            this.Close();
        }
    }
}
