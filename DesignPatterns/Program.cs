using System;
using DesignPatterns.State;
using DesignPatterns.Strategy;
using DesignPatterns.Observer;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------- PATRONES DE DISEÑO -------------------");
            Console.WriteLine("1. State");
            Console.WriteLine("2. Strategy");
            Console.WriteLine("3. Observer");

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
                case 3:
                    Observer();
                    break;
                default:
                    break;
            };
        }

        static void State()
        {
            Console.WriteLine("\n---------------- PATRÓN STATE ----------------\n");
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
            Console.WriteLine("\n---------------- PATRÓN STRATEGY ----------------\n");
            Viaje viaje = new Viaje(1000);
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

        static void Observer()
        {
            Console.WriteLine("\n---------------- PATRÓN OBSERVER ----------------\n");
            Usuario usuario1 = new Usuario("Imback");
            Usuario usuario2 = new Usuario("K1ng");
            Usuario usuario3 = new Usuario("Likantr0p0");

            Pregunta pregunta1 = new Pregunta(1, "¿Un remedio casero para el dolor de cabeza?");
            pregunta1.Suscribir(usuario1);
            pregunta1.Suscribir(usuario2);
            Console.WriteLine("");

            Pregunta pregunta2 = new Pregunta(2, "¿De qué color es el caballo blanco de San Martin?");
            pregunta2.Suscribir(usuario2);
            pregunta2.Suscribir(usuario3);
            Console.WriteLine("");

            pregunta1.AgregarRespuesta("Adermicina!");
            Console.WriteLine("");

            pregunta2.AgregarRespuesta("Celeste");
            Console.WriteLine("");
            pregunta2.AgregarRespuesta("Azul");
            Console.WriteLine("");

            pregunta1.AgregarRespuesta("Un buen baño");
            Console.WriteLine("");

            pregunta2.Desuscribir(usuario3);
            Console.WriteLine("");

            pregunta2.AgregarRespuesta("Blanco!");
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
