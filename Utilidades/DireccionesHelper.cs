using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coatza_Reporta.Utilidades
{
    public class DireccionesHelper
    {
        public Dictionary<string, List<string>> ColoniasYCalles = new Dictionary<string, List<string>>()
        {
            {
                "Centro", new List<string>()
                {
                    "Av. Benito Juárez", "Hidalgo", "Morelos", "Av. Ignacio Zaragoza", "Llave", "Av. Revolución", "Av. Vicente Guerrero"
                }
            },

            {
                "Petrolera",
                new List<string>()
                {
                    "Av. Uno", "Av. Dos", "Malecón", "Avenida del Puente"
                }
            },

            {
                "Puerto México",
                new List<string>()
                {
                    "Carranza", "Allende", "Independencia", "5 de Mayo"
                }
            }
        };
    }
}