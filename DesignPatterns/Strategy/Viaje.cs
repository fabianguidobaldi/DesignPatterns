using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class Viaje
    {
        public double Distancia { get; set; }
        public IEstrategia Transporte { get; private set; }

        public Viaje(int distancia)
        {
            Distancia = distancia;
        }

        public void DefinirTransporte(string transporte)
        {
            switch (transporte)
            {
                case "A pie":
                    Transporte = new Peaton();
                    break;
                case "En auto":
                    Transporte = new Auto();
                    break;
                case "En bici":
                    Transporte = new Bici();
                    break;
                case "En colectivo":
                    Transporte = new Colectivo();
                    break;
                case "En avión":
                    Transporte = new Avion();
                    break;
            }
        }
        /* Sin la utilización del patrón Strategy, la clase Viaje tendría la responsabilidad de implementar los diferentes algoritmos
         * para calcular la duración del viaje, y decidir en tiempo de ejecución cuál de ellos ejecutar.*/

        /* En cambio, al utilizar el patrón Strategy, cada algoritmo se representa como una clase independiente que implementa
         * una interfaz común a todos los algoritmos (en este caso, CalcularDuracionViaje), y en tiempo de ejecución (por ejemplo, según
         * la elección del usuario) se determina cuál debe ser el algoritmo a utilizar.
         * Si en el futuro fuera necesario agregar un nuevo algoritmo, basta con crear una nueva clase que implemente la interfaz común.*/

        public double CalcularDuracionViaje()
        {
            return Transporte.CalcularDuracionViaje(Distancia);
        }

        public override string ToString()
        {
            return $"Distancia del viaje: {Distancia} kms. \n";
        }

    }
}
