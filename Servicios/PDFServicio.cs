using Coatza_Reporta.Entidades;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coatza_Reporta.Servicios
{
    public class PDFServicio
    {
        public void GenerarPDF(Reportes reportes)
        {
            try
            {
                PdfDocument documento = new PdfDocument();
                documento.Info.Title = "Reporte : Coatza Reporta";

                PdfPage pagina = documento.AddPage();

                XGraphics gfx = XGraphics.FromPdfPage(pagina);
                XTextFormatter tf = new XTextFormatter(gfx);

                XFont titulo = new XFont("Arial", 20, XFontStyleEx.Bold);
                XFont texto = new XFont("Arial", 12);

                gfx.DrawString("COATZA REPORTA", titulo, new XSolidBrush(XColor.FromArgb(51, 36, 34)), new XRect(0, 20, pagina.Width.Point, pagina.Height.Point), XStringFormats.TopCenter);
                int y = 80;
                gfx.DrawString("Folio: " + reportes.Folio, texto, XBrushes.Black, 40, y);
                y += 30;
                gfx.DrawString("Fecha: " + reportes.Fecha.ToString(), texto, XBrushes.Black, 40, y);
                y += 30;
                gfx.DrawString("Ciudadano: " + reportes.Ciudadano, texto, XBrushes.Black, 40, y);
                y += 30;
                gfx.DrawString("Celular: " + reportes.Celular, texto, XBrushes.Black, 40, y);
                y += 30;
                gfx.DrawString("Tipo: " + reportes.Tipo, texto, XBrushes.Black, 40, y);
                y += 30;
                gfx.DrawString("Descripción: " + reportes.Descripcion, texto, XBrushes.Black, 40, y);
                y += 30;
                tf.DrawString("Dirección: " + reportes.Direccion, texto, XBrushes.Black, new XRect(40, y, 500, 100));
                y += 60;
                tf.DrawString("Referencias: " + reportes.Referencias, texto, XBrushes.Black, new XRect(40, y, 500, 100));
                y += 60;

                if (File.Exists(reportes.Evidencia))
                {
                    XImage imagen = XImage.FromFile(reportes.Evidencia);
                    gfx.DrawImage(imagen, 40, y, 500, 400);
                }

                string carpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"CoatzaReporta","ReportesPDF");
                Directory.CreateDirectory(carpeta);
                string nombrePDF = Path.Combine(carpeta,$"Reporte_{reportes.Folio}.pdf");
                reportes.ReportesPDF = nombrePDF;
                documento.Save(nombrePDF);

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = nombrePDF;
                psi.UseShellExecute = true;
                Process.Start(psi);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al Generar el PDF." + ex.Message);
            }
        }
    }
}