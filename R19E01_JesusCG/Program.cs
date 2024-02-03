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


            // INICIALIZACIÓN - RECURSOS -
            // Instanciaciópn (Reserva de Memoria) para los cinco elementos del array
            ListaVehiculos = new Vehiculo[TAMANIO];

            LogicaNegocio.CargarListaVehiculos(ListaVehiculos);

            Interfaz.MenuPrincipal(ListaVehiculos);

            // PROCESO: Carga de los Coches en la lista


         






        }
    }
}
