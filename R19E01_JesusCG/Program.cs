namespace R19E01_JesusCG
{
    internal class Program
    {
        /// <summary>
        /// Controlador Principal
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // CONSTANTES

            const int TAMANIO = 5;

            // RECURSOS

            Vehiculo[] ListaVehiculos;            

            int opcionMenu = 0;
            string aux = "";

            // INICIALIZACIÓN - RECURSOS -
            // Instanciaciópn (Reserva de Memoria) para los cinco elementos del array
            ListaVehiculos = new Vehiculo[TAMANIO];


            Interfaz.MenuPrincipal();

            // PROCESO: Carga de los Coches en la lista
            LogicaNegocio.CargarListaVehiculos(ListaVehiculos);


            Console.Write("Escriba un número: ");
            aux = Console.ReadLine();

            opcionMenu = Convert.ToByte(aux);

            do
            {
                // Mostrar Menú Principal


                // Leer Opción


                // Acción a Realizar
                switch(opcionMenu)
                {
                    case 0:
                        // NO HACE NADA
                        break;
                    case 1:
                        Interfaz.MostrarListadoCompleto(ListaVehiculos);
                        break;
                    case 2:
                        Interfaz.MostrarListadoVehiculo(ListaVehiculos);
                        break;
                }

            } while (opcionMenu != 0);






        }
    }
}
