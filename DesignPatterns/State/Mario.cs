using System;

namespace DesignPatterns.State
{
    public class Mario
    {
        public int Vidas { get; private set; }
        public IEstado Estado { get; private set; }

        public Mario()
        {
            Vidas = 3;
            Estado = new SmallMario(this);
        }

        public void SetEstado(IEstado estado)
        {
            Estado = estado;
        }

        public void PerderVida()
        {
            Console.WriteLine("Perdí una vida");
            Vidas -= 1;

            if (Vidas == 0)
            {
                Console.WriteLine("Game over.");
            }
        }

        /* Sin la utilización del patrón State, el Estado sería un atributo simple (como un string), y en cada evento (ObtenerFlor,
         * ObtenerHongo o TocarMonstruo) se debería consultar ese estado para determinar qué acción corresponde. Al agregarse un 
         * nuevo estado, se deberían modificar todos los métodos para agregar el comportamiento correspondiente para ese nuevo
         * estado. */

        /* En cambio, al utilizar el patrón State, cada Estado se representa como una clase que implementa una interfaz (en la que
         * se definen todos los métodos que dependen del estado del objeto), y cada uno de ellos define cómo implementar esa interfaz.
         * De esta forma, al agregarse un nuevo estado, sólo se debe agregar una nueva clase que implemente la interfaz, sin realizar
         * modificaciones de código sobre las demás clases.*/

        public void ObtenerFlor()
        {
            Console.WriteLine("Encontré una flor!");
            Estado.ObtenerFlor();
        }

        public void ObtenerHongo()
        {
            Console.WriteLine("Encontré un hongo!");
            Estado.ObtenerHongo();
        }

        public void TocarMonstruo()
        {
            Console.WriteLine("Toqué un monstruo!");
            Estado.TocarMonstruo();
        }

        public override string ToString()
        {
            return $"Estado: {Estado} | Vidas: {Vidas} \n";
        }
    }
}
