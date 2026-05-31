using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coatza_Reporta.Entidades
{
    public class Reportes
    {
        public int Folio { get; set; }
        public DateTime Fecha { get; set; }
        public string Ciudadano { get; set; }
        public string Celular { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Referencias { get; set; }
        public string Evidencia { get; set; }
        public string ReportesPDF { get; set; }
        public string Estado { get; set; }
    }
}
