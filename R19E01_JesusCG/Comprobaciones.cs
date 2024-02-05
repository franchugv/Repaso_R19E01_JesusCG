using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R19E01_JesusCG
{
    public static class Comprobaciones
    {

        public static byte ErroresByteCompleto(string cadena)
        {

            // RECURSOS

            byte result = 0;

            // VALIDACION

            if (string.IsNullOrEmpty(cadena)) throw new Exception("Cadena vacía");

            // RESULTADO

            result = Convert.ToByte(cadena);

            // VALIDACIÓN

            if (result > 2) throw new Exception($"Supera el rango establecido (0 - 2)");

            // SALIDA

            return result;
        }


        public static byte ErroresByteVehiculo(string cadena)
        {

            // RECURSOS

            byte result = 0;

            // VALIDACION

            if (string.IsNullOrEmpty(cadena)) throw new Exception("Cadena vacía");

            // RESULTADO

            result = Convert.ToByte(cadena);

            // VALIDACIÓN

            if (result > 5) throw new Exception($"Supera el rango establecido (0 - 5)");

            // SALIDA

            return result;
        }

    }
}
