using ClosedXML.Excel;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coatza_Reporta.Utilidades
{
    public class CarpetasHelper
    {
        public static void CrearCarpetas()
        {
            string carpetaBase = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"CoatzaReporta");
            string capturas = Path.Combine(carpetaBase,"CapturasMaps");
            string pdfs = Path.Combine(carpetaBase,"ReportesPDF");
            string archivos = Path.Combine(carpetaBase,"Archivos");
            string webview = Path.Combine(carpetaBase,"WebView2");

            Directory.CreateDirectory(carpetaBase);
            Directory.CreateDirectory(capturas);
            Directory.CreateDirectory(pdfs);
            Directory.CreateDirectory(archivos);
            Directory.CreateDirectory(webview);

            if (!Directory.Exists(capturas))
            {
                Directory.CreateDirectory(capturas);
            }
            if (!Directory.Exists(pdfs))
            {
                Directory.CreateDirectory(pdfs);
            }
            if (!Directory.Exists(archivos))
            {
                Directory.CreateDirectory(archivos);
            }

            string excel = archivos + @"\Reportes.xlsx";

            if (!File.Exists(excel))
            {
                var wb = new XLWorkbook();

                var ws = wb.Worksheets.Add("Reportes");
                ws.Cell(1, 1).Value = "Folio";
                ws.Cell(1, 2).Value = "Fecha";
                ws.Cell(1, 3).Value = "Ciudadano";
                ws.Cell(1, 4).Value = "Celular";
                ws.Cell(1, 5).Value = "Tipo";
                ws.Cell(1, 6).Value = "Descripcion";
                ws.Cell(1, 7).Value = "Direccion";
                ws.Cell(1, 8).Value = "Referencias";
                ws.Cell(1, 9).Value = "Evidencia";
                ws.Cell(1, 10).Value = "ReportesPDF";
                ws.Cell(1, 11).Value = "Estado";

                wb.SaveAs(excel);
            }
        }
    }
}