using ClosedXML.Excel;
using Coatza_Reporta.Entidades;
using Coatza_Reporta.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coatza_Reporta.Servicios
{
    public class ExcelServicio : IGuardar
    {
        private readonly string ruta;
        public ExcelServicio()
        {
            string carpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"CoatzaReporta","Archivos");
            Directory.CreateDirectory(carpeta);
            ruta = Path.Combine(carpeta, "Reportes.xlsx");
        }
        public void Guardar (Reportes reportes)
        {
           try
           {
                var wb = new XLWorkbook(ruta);
                var ws = wb.Worksheet(1);

                int fila =
                ws.LastRowUsed().RowNumber() + 1;
                ws.Cell(fila, 1).Value = reportes.Folio;
                ws.Cell(fila, 2).Value = reportes.Fecha;
                ws.Cell(fila, 3).Value = reportes.Ciudadano;
                ws.Cell(fila, 4).Value = reportes.Celular;
                ws.Cell(fila, 5).Value = reportes.Tipo;
                ws.Cell(fila, 6).Value = reportes.Descripcion;
                ws.Cell(fila, 7).Value = reportes.Direccion;
                ws.Cell(fila, 8).Value = reportes.Referencias;
                ws.Cell(fila, 9).Value = reportes.Evidencia;
                ws.Cell(fila, 10).Value = reportes.ReportesPDF;
                ws.Cell(fila, 11).Value = reportes.Estado;

                wb.Save();
           }
           catch (Exception ex)
           {
                MessageBox.Show("Error al Guardar Excel." + ex.Message);
           }
        }
        public int ObtenerSiguienteFolio()
        {
            try
            {
                var wb = new XLWorkbook(ruta);
                var ws = wb.Worksheet(1);
                int ultimaFila = ws.LastRowUsed().RowNumber();
                return ultimaFila;
            }
            catch
            {
                return 1;
            }
        }
        public DataTable LeerReportes()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Folio");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Ciudadano");
            dt.Columns.Add("Celular");
            dt.Columns.Add("Tipo");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Referencias");
            dt.Columns.Add("Evidencia");
            dt.Columns.Add("ReportesPDF");
            dt.Columns.Add("Estado");

            var wb = new XLWorkbook(ruta);
            var ws = wb.Worksheet(1);

            foreach (var row in ws.RowsUsed().Skip(1))
            {
                dt.Rows.Add(
                    row.Cell(1).GetValue<string>(),
                    row.Cell(2).GetValue<string>(),
                    row.Cell(3).GetValue<string>(),
                    row.Cell(4).GetValue<string>(),
                    row.Cell(5).GetValue<string>(),
                    row.Cell(6).GetValue<string>(),
                    row.Cell(7).GetValue<string>(),
                    row.Cell(8).GetValue<string>(),
                    row.Cell(9).GetValue<string>(),
                    row.Cell(10).GetValue<string>(),
                    row.Cell(11).GetValue<string>()
                    );
            }
            return dt;
        }
    }
}
