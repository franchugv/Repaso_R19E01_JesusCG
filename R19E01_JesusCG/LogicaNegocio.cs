using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R19E01_JesusCG
{
    /// <summary>
    /// Métodos que facilitan el procesamiento de los datos de la Aplicación
    /// </summary>
    public static class LogicaNegocio
    {

        public static void CargarListaVehiculos(Vehiculo[] lista)
        {
            // VARIABLES
            Vehiculo coche;


            // Instanciar Objeto -  Si no ponemos nada nos pondrá el constructor por defecto -
            coche = new Vehiculo("Ferrari", "F40FFF");

            // Proporcioner el resto de los datos
            coche.TVehiculo = TipoVehiculo.Turismo;
            coche.Combustible = TipoCombustible.Gasolina;
            coche.Estado = TipoEstados.Ocasion;
            coche.Matriculacion = new DateTime(2032, 12, 5);
            coche.PrecioContado = 80000;

            lista[0] = coche;

            // Instanciar Objeto 2 
            coche = new Vehiculo("Maseratti", "Murcialago");

            // Proporcioner el resto de los datos
            coche.TVehiculo = TipoVehiculo.Turismo;
            coche.Combustible = TipoCombustible.Gasolina;
            coche.Estado = TipoEstados.Ocasion;
            coche.Matriculacion = new DateTime(2032, 12, 5);
            coche.PrecioContado = 80000;

            // Asignarlo al array

            lista[1] = coche;

          
        }



    }
}
