using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R19E01_JesusCG
{
    /// <summary>
    /// Métodos para la interacción Aplicación - Usuario Final
    /// </summary>
    public static class Interfaz
    {


        public static void MenuPrincipal()
        {
            // TODO: Implementación del Menú Principal
            Console.WriteLine($"");
        }

        public static void MostrarListadoCompleto(Vehiculo[] lista)
        {


            // RECURSOS

            // ENTRADA


            // PROCESO

            // SALIDA

            Console.WriteLine($"MARCA\tMODELO \tTIPO\tCOMBUSTIBLE\tESTADO\tMATRICULACIÓN\tPRECIO\tPRECIO REBABJADO");

            foreach (Vehiculo coche in lista)
            {
                Console.WriteLine($"{coche.Marca}\t{coche.Modelo}\t{coche.TVehiculo.ToString()}\t{coche.Matriculacion}\t{coche.PrecioContado}\t{coche.PrecioFinanciado}\t{coche.Estado.ToString()}\t{coche.Combustible.ToString()}");
            }

            Console.Write("Pulse Enter para Continuar...");
            Console.ReadLine();
        }

        internal static void MostrarListadoVehiculo(Vehiculo[] listaVehiculos)
        {
            throw new NotImplementedException();
        }
    }
}
