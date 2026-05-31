using ClosedXML.Excel;
using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coatza_Reporta.Utilidades
{
    public class DashboardHelper
    {
        private readonly string ruta;

        public DashboardHelper()
        {
            ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"CoatzaReporta","Archivos","Reportes.xlsx");
        }
        public DataTable ObtenerDatos()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Tipo");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Estado");

            var wb = new XLWorkbook(ruta);
            var ws = wb.Worksheet(1);

            foreach (var row in
                    ws.RowsUsed().Skip(1))
            {
                dt.Rows.Add(
                    row.Cell(5).GetString().Trim(),
                    row.Cell(2).GetString().Trim(),
                    row.Cell(11).GetString().Trim()
                );
            }

            return dt;
        }

        public int ContarPendientes()
        {
            DataTable dt = ObtenerDatos();
            int pendientes = dt.AsEnumerable().Count(r => r["Estado"].ToString() == "Pendiente");
            return pendientes;
        }

        public int ContarEn_Curso()
        {
            DataTable dt = ObtenerDatos();
            int proceso = dt.AsEnumerable().Count(r => r["Estado"].ToString() == "En Curso");
            return proceso;
        }

        public int ReportesTotal()
        {
            DataTable dt = ObtenerDatos();
            return dt.Rows.Count;
        }

        public int ReportesHoy()
        {
            DataTable dt = ObtenerDatos();
            int totalHoy = 0;
            foreach (DataRow row in dt.Rows)
            {
                DateTime fecha;

                if (DateTime.TryParse(row["Fecha"].ToString(), out fecha))
                {
                    if (fecha.Date == DateTime.Now.Date)
                    {
                        totalHoy++;
                    }
                }
            }
            return totalHoy;
        }
    }
}