using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace R19E01_JesusCG
{
    /// <summary>
    /// Métodos para la interacción Aplicación - Usuario Final
    /// </summary>
    public static class Interfaz
    {


        public static void MenuPrincipal(Vehiculo[] Lista)
        {



            int opcionMenu = 0;
            string aux = "";

            Console.WriteLine($"0 - SALIR");
            Console.WriteLine($"1 - Mostrar Listado Completo");
            Console.WriteLine($"2 - Mostrar Listado Vehículo");

            Console.WriteLine("--------------------------------------");

            Console.Write("Escriba un número: [0 - 2]: ");
            aux = Console.ReadLine();


            try
            {
                opcionMenu = Comprobaciones.ErroresByteCompleto(aux);
            }
            catch (Exception Error)
            {
                Console.WriteLine($"Error: {Error.Message}");
            }


            do
            {
                // Mostrar Menú Principal


                // Leer Opción


                // Acción a Realizar
                switch (opcionMenu)
                {
                    case 0:

                        opcionMenu = 0;

                        break;
                    case 1:
                        MostrarListadoCompleto(Lista);
                        break;
                    case 2:
                        MostrarListadoVehiculo(Lista);
                        break;
                }

            } while (opcionMenu != 0);
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
                Console.WriteLine($"\n{coche.Marca}\t{coche.Modelo}\t{coche.TVehiculo}\t{coche.Matriculacion}\t{coche.PrecioContado}\t{coche.PrecioFinanciado}\t{coche.Estado}\t{coche.Combustible}\n");
            }

            Console.Write("Pulse Enter para Continuar...");
            Console.ReadLine();
            Console.Clear();
            MenuPrincipal(lista);
        }

        internal static void MostrarListadoVehiculo(Vehiculo[] Lista)
        {

            // RECURSOS

            // ENTRADA

            int opcionMenu = 0;
            string aux = "";

            Console.Write("Elija una opción [1 - 5]: ");
            aux = Console.ReadLine();

            try
            {
                opcionMenu = Comprobaciones.ErroresByteVehiculo(aux);
            }
            catch (Exception Error)
            {
                Console.WriteLine($"Error: {Error.Message}");
            }
            do
            {
                // Mostrar Menú Principal


                // Leer Opción


                // Acción a Realizar

                // Lista



                switch (opcionMenu)
                {
                    case 0:
                        opcionMenu = 0;
                        break;
                    case 1:


                        Console.WriteLine($"MARCA\tMODELO");


                        Vehiculo PrimerCoche = Lista[0];
                                Console.WriteLine($"{PrimerCoche.Marca}\t{PrimerCoche.Modelo}");
                                  
                       

                            Console.Write("Pulse Enter para Continuar...");
                            Console.ReadLine();
                            Console.Clear();
                        

                        // Volver al menú principal
                        MenuPrincipal(Lista);
                        break;
                    case 2:


                        Console.WriteLine($"MARCA\tMODELO");


                        Vehiculo SegundoCoche = Lista[1];
                        Console.WriteLine($"{SegundoCoche.Marca}\t{SegundoCoche.Modelo}");



                        Console.Write("Pulse Enter para Continuar...");
                        Console.ReadLine();
                        Console.Clear();


                        // Volver al menú principal
                        MenuPrincipal(Lista);
                        break;
                    case 3:
                        Console.WriteLine($"MARCA\tMODELO");


                        Vehiculo TercerCoche = Lista[2];
                        Console.WriteLine($"{TercerCoche.Marca}\t{TercerCoche.Modelo}");



                        Console.Write("Pulse Enter para Continuar...");
                        Console.ReadLine();
                        Console.Clear();


                        // Volver al menú principal
                        MenuPrincipal(Lista);

                        break;
                    case 4:
                        Console.WriteLine($"MARCA\tMODELO");

                        Vehiculo CuartoCoche = Lista[3];
                        Console.WriteLine($"{CuartoCoche.Marca}\t{CuartoCoche.Modelo}");



                        Console.Write("Pulse Enter para Continuar...");
                        Console.ReadLine();
                        Console.Clear();


                        // Volver al menú principal
                        MenuPrincipal(Lista);


                        break;
                    case 5:
                        Console.WriteLine($"MARCA\tMODELO");

                        Vehiculo QuintoCoche = Lista[4];
                        Console.WriteLine($"{QuintoCoche.Marca}\t{QuintoCoche.Modelo}");



                        Console.Write("Pulse Enter para Continuar...");
                        Console.ReadLine();
                        Console.Clear();


                        // Volver al menú principal
                        MenuPrincipal(Lista);

                        break;
                        
                }

            } while (opcionMenu != 0);

            // PROCESO

            // SALIDA

           


        }
    }
}
