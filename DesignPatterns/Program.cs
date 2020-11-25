using System;
using DesignPatterns.State;
using DesignPatterns.Strategy;
using DesignPatterns.Observer;
using DesignPatterns.Builder;
using DesignPatterns.Factory_Method;

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
            Console.WriteLine("4. Builder");
            Console.WriteLine("5. Factory Method");

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
                case 4:
                    Builder();
                    break;
                case 5:
                    FactoryMethod();
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

        static void Builder()
        {
            Console.WriteLine("\n---------------- PATRÓN BUILDER ----------------\n");
            
            Console.WriteLine("*** Bienvenido al menú de creación de personajes ***");
            Console.WriteLine("Por favor, seleccione su clase:");
            Console.WriteLine("1. Guerrero");
            Console.WriteLine("2. Mago");
            Console.WriteLine("3. Ninja");

            Console.Write("Ingrese una opción: ");
            var opcion = Convert.ToInt32(Console.ReadLine());

            IBuilder constructor = null;
            switch (opcion)
            {
                case 1:
                    constructor = new GuerreroBuilder();
                    break;
                case 2:
                    constructor = new MagoBuilder();
                    break;
                case 3:
                    constructor = new NinjaBuilder();
                    break;
                default:
                    break;
            };

            Director director = new Director(constructor);

            Console.Write("Ingrese el nombre de la armadura: ");
            var armadura = Console.ReadLine();

            Console.Write("Ingrese el nombre del arma: ");
            var arma = Console.ReadLine();

            Console.Write("Ingrese el nombre del casco: ");
            var casco = Console.ReadLine();

            Console.Write("Ingrese el nombre de los guantes: ");
            var guantes = Console.ReadLine();

            Console.Write("Ingrese el nombre de las botas: ");
            var botas = Console.ReadLine();

            director.CrearPersonaje(armadura, arma, casco, guantes, botas);

            Console.WriteLine(constructor.ObtenerPersonaje().ToString());

            Console.ReadLine();
        }

        static void FactoryMethod()
        {
            Console.WriteLine("\n---------------- PATRÓN FACTORY METHOD ----------------\n");

            Console.WriteLine("Por favor, seleccione el enemigo a crear:");
            Console.WriteLine("1. Orco");
            Console.WriteLine("2. Dragón");
            Console.WriteLine("3. Araña");

            Console.Write("Ingrese una opción: ");
            var opcion = Convert.ToInt32(Console.ReadLine());

            IEnemigoFactory factory = null;
            switch (opcion)
            {
                case 1:
                    factory = new OrcoFactory();
                    break;
                case 2:
                    factory = new DragonFactory();
                    break;
                case 3:
                    factory = new ArañaFactory();
                    break;
                default:
                    break;
            };

            Enemigo enemigo1 = factory.CrearEnemigo();
            Enemigo enemigo2 = factory.CrearEnemigo(100, 100, 100);

            Console.WriteLine(enemigo1.ToString());
            Console.WriteLine(enemigo2.ToString());

            Console.ReadLine();
        }
    }
}

