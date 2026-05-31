using Coatza_Reporta.Entidades;
using Coatza_Reporta.Servicios;
using Coatza_Reporta.Utilidades;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace Coatza_Reporta.Forms
{
    public partial class Reporte : Form
    {
        Reportes reportes = new Reportes();
        DireccionesHelper direcciones = new DireccionesHelper();
        string rutaPDFGenerado = "";

        public Reporte()
        {
            InitializeComponent();
        }

        private async void Reporte_Load(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            cmbColonia.Items.Clear();
            foreach (var colonia in direcciones.ColoniasYCalles.Keys)
            {
                cmbColonia.Items.Add(colonia);
            }

            string webViewDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"CoatzaReporta","WebView2");
            Directory.CreateDirectory(webViewDataFolder);
            var env = await CoreWebView2Environment.CreateAsync(null,webViewDataFolder);

            await webView21.EnsureCoreWebView2Async(env);

            cmbTipo.Items.Add("Alumbrado");
            cmbTipo.Items.Add("Bache");
            cmbTipo.Items.Add("Basura");
            cmbTipo.Items.Add("Contaminación");
            cmbTipo.Items.Add("Drenaje");
            cmbTipo.Items.Add("Fuga");
            cmbTipo.Items.Add("Obra Pública");
            cmbTipo.Items.Add("Obstrucción");
            cmbTipo.Items.Add("Ruido");
            cmbTipo.Items.Add("Seguridad");
            cmbTipo.Items.Add("Semáforo");
        }

        private void btnUbicar_Click(object sender, EventArgs e)
        {
            groupBoxCelular.Visible = true;
            webView21.Visible = true;
            string direccion = cmbCalle.Text + " " + txtExterior.Text + " " + cmbColonia.Text + " " + txtPostal.Text;
            string url = "https://www.google.com/maps?q=/Coatzacoalcos" + Uri.EscapeDataString(direccion);
            webView21.CoreWebView2.Navigate(url);
        }

        private void btnCrear_Reporte_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el Nombre del Ciudadano");
                txtNombre.Focus();
                return;
            }
            if (txtCelular.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el Número de Celular");
                txtCelular.Focus();
                return;
            }
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Reporte");
                cmbTipo.Focus();
                return;
            }
            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese una Descripción");
                txtDescripcion.Focus();
                return;
            }
            if (txtReferencias.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Referencias");
                txtReferencias.Focus();
                return;
            }
            if (cmbCalle.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese una Calle");
                cmbCalle.Focus();
                return;
            }
            if (cmbCalle_Esq.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese una Calle contra Esquina");
                cmbCalle_Esq.Focus();
                return;
            }
            if (cmbColonia.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese una Colonia");
                cmbColonia.Focus();
                return;
            }
            if (txtPostal.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un Código Postal");
                txtPostal.Focus();
                return;
            }
            if (txtExterior.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un Número Exterior");
                txtExterior.Focus();
                return;
            }

            ExcelServicio excel = new ExcelServicio();

            int folio = excel.ObtenerSiguienteFolio();
            reportes.Folio = folio;

            reportes.Fecha = DateTime.Now;
            reportes.Ciudadano = txtNombre.Text;
            reportes.Celular = txtCelular.Text;
            reportes.Tipo = cmbTipo.Text;
            reportes.Descripcion = txtDescripcion.Text;
            string direccion = cmbCalle.Text + " #" + txtExterior.Text + " contra esquina " + cmbCalle_Esq.Text + " - Colonia " + cmbColonia.Text + " - Código Postal" + txtPostal.Text + " - Coatzacoalcos";
            reportes.Direccion = direccion;
            reportes.Referencias = txtReferencias.Text;
            string carpetaCapturas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"CoatzaReporta","CapturasMaps");
            reportes.Evidencia = Path.Combine(carpetaCapturas,txtImagen.Text + ".png");

            if (txtImagen.Text.Trim() == "")
            {
                MessageBox.Show("Debe Subir una Captura");
                return;
            }

            PDFServicio pdf = new PDFServicio();
            pdf.GenerarPDF(reportes);
            rutaPDFGenerado = reportes.ReportesPDF;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void btnBase_Click(object sender, EventArgs e)
        {
            Servidor servidor = new Servidor();
            servidor.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            groupBoxCelular.Visible = false;
            webView21.Visible = false;
        }

        private void btnSubir_Captura_Click(object sender, EventArgs e)
        {
            try
            {
                string carpetaCapturas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"CoatzaReporta","CapturasMaps");
                Directory.CreateDirectory(carpetaCapturas);
                if (txtImagen.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese un Nombre para la Imagen");
                    txtImagen.Focus();
                    return;
                }
                if (pictureBoxImagen.Image != null)
                {
                    pictureBoxImagen.Image.Dispose();
                    pictureBoxImagen.Image = null;
                    string filePath = Path.Combine(carpetaCapturas,txtImagen.Text + ".png");
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                }
                openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxImagen.Image = Image.FromFile(openFileDialog1.FileName);
                    string rutaImagen = Path.Combine(carpetaCapturas,txtImagen.Text + ".png");
                    pictureBoxImagen.Image.Save(rutaImagen,System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el Nombre del Ciudadano");
                txtNombre.Focus();
                return;
            }
            if (txtCelular.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el Número de Celular");
                txtCelular.Focus();
                return;
            }
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Reporte");
                cmbTipo.Focus();
                return;
            }
            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese una Descripción");
                txtDescripcion.Focus();
                return;
            }
            if (txtReferencias.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Referencias");
                txtReferencias.Focus();
                return;
            }
            if (cmbCalle.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese una Calle");
                cmbCalle.Focus();
                return;
            }
            if (cmbCalle_Esq.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese una Calle contra Esquina");
                cmbCalle_Esq.Focus();
                return;
            }
            if (cmbCalle.Text == cmbCalle_Esq.Text)
            {
                MessageBox.Show("La Calle principal y la Calle contra Esquina no pueden ser Iguales.");
                return;
            }
            if (cmbColonia.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese una Colonia");
                cmbColonia.Focus();
                return;
            }
            if (txtPostal.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un Código Postal");
                txtPostal.Focus();
                return;
            }
            if (txtExterior.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un Número Exterior");
                txtExterior.Focus();
                return;
            }

            if (string.IsNullOrEmpty(rutaPDFGenerado))
            {
                MessageBox.Show("Primero debe Generar el Reporte PDF.");
                return;
            }
            if (!File.Exists(rutaPDFGenerado))
            {
                MessageBox.Show("El PDF Generado no Existe.");
                return;
            }

            reportes.Fecha = DateTime.Now;
            reportes.Ciudadano = txtNombre.Text;
            reportes.Celular = txtCelular.Text;
            reportes.Tipo = cmbTipo.Text;
            reportes.Descripcion = txtDescripcion.Text;
            string direccion = cmbCalle.Text + " #" + txtExterior.Text + " contra esquina " + cmbCalle_Esq.Text + " - Colonia " + cmbColonia.Text + " - Código Postal" + txtPostal.Text + " - Coatzacoalcos";
            reportes.Direccion = direccion;
            reportes.Referencias = txtReferencias.Text;
            string carpetaCapturas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"CoatzaReporta","CapturasMaps");
            Directory.CreateDirectory(carpetaCapturas);
            reportes.Evidencia = Path.Combine(carpetaCapturas,txtImagen.Text + ".png");
            reportes.ReportesPDF = rutaPDFGenerado;
            reportes.Estado = "Pendiente";

            ExcelServicio excel = new ExcelServicio();
            excel.Guardar(reportes);
            MessageBox.Show("Reporte Guardado en Excel Correctamente.");
        }

        private void cmbColonia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCalle.Items.Clear();
            cmbCalle_Esq.Items.Clear();

            string colonia = cmbColonia.Text;

            if (direcciones.ColoniasYCalles.ContainsKey(colonia))
            {
                foreach (var calle in direcciones.ColoniasYCalles[colonia])
                {
                    cmbCalle.Items.Add(calle);
                    cmbCalle_Esq.Items.Add(calle);
                }
            }
        }

        private void cmbCalle_Esq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCalle.Text == cmbCalle_Esq.Text)
            {
                MessageBox.Show("La Calle Principal y la Calle contra Esquina no Pueden ser Iguales.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCalle_Esq.SelectedIndex = -1;
            }
        }

        private void Reporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
