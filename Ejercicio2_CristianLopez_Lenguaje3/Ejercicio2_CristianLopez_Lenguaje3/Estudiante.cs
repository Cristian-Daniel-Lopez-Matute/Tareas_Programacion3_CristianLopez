using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_CristianLopez_Lenguaje3
{
    internal class Estudiante
    {
        public string Nombre { get; set; }
        public int edad { get; set; }

        public string cadena (string Nombre, int edad)
        {
            return Nombre+ "|" + edad;
        }
    }
}
