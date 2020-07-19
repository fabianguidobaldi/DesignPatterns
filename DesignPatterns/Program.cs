using System;
using DesignPatterns.State;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------- PATRONES DE DISEÑO -------------------");
            Console.WriteLine("1. State");
            Console.WriteLine("2. Strategy");

            Console.Write("Ingrese una opción: ");
            var opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    State();
                    break;
                case 2:
                    Strategy();
                    break;
                default:
                    break;
            };
        }

        static void State()
        {
            Console.WriteLine("---------------- PATRÓN STATE ----------------");
            Mario mario = new Mario();
            Console.WriteLine(mario);

            mario.ObtenerHongo();
            Console.WriteLine(mario);

            mario.ObtenerFlor();
            Console.WriteLine(mario);

            mario.TocarMonstruo();
            Console.WriteLine(mario);

            mario.TocarMonstruo();
            Console.WriteLine(mario);

            mario.TocarMonstruo();
            Console.WriteLine(mario);

            Console.ReadLine();
        }

        static void Strategy()
        {
            Console.WriteLine("---------------- PATRÓN STRATEGY ----------------");
            Viaje viaje = new Viaje(1000);
            double duracion;
            Console.WriteLine(viaje);


            viaje.DefinirTransporte("A pie");
            Console.WriteLine("Medio de transporte: A pie - Duración del viaje: " + viaje.CalcularDuracionViaje().ToString() + "horas.");

            viaje.DefinirTransporte("En bici");
            Console.WriteLine("Medio de transporte: Bici - Duración del viaje: " + viaje.CalcularDuracionViaje().ToString() + "horas.");

            viaje.DefinirTransporte("En colectivo");
            Console.WriteLine("Medio de transporte: Colectivo - Duración del viaje: " + viaje.CalcularDuracionViaje().ToString() + "horas.");

            viaje.DefinirTransporte("En auto");
            Console.WriteLine("Medio de transporte: Auto - Duración del viaje: " + viaje.CalcularDuracionViaje().ToString() + "horas.");

            viaje.DefinirTransporte("En avión");
            Console.WriteLine("Medio de transporte: Avión - Duración del viaje: " + viaje.CalcularDuracionViaje().ToString() + "horas.");

            Console.ReadLine();
        }
    }
}
