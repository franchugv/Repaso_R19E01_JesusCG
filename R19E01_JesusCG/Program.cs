namespace R19E01_JesusCG
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TipoCombustible fuel = TipoCombustible.Hibrido;

            ///

            // Icremento o descuento del precio del vehículo según el tipo de combustible
            switch (fuel)
            {
                case TipoCombustible.Gasolina:
                    break;
                case TipoCombustible.Diesel:
                    break;
                case TipoCombustible.Hibrido:
                    break;
                case TipoCombustible.Electrico:
                    break;
            }




        }
    }
}
