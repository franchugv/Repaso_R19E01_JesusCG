using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R19E01_JesusCG
{
    public static class Comprobaciones
    {

        public static byte ErroresByte(string cadena)
        {

            // RECURSOS

            byte result = 0;

            // VALIDACION

            if (string.IsNullOrEmpty(cadena)) throw new Exception("Cadena vacía");

            // RESULTADO

            result = Convert.ToByte(cadena);

            // SALIDA

            return result;
        }

    }
}
