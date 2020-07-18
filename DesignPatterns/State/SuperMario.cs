using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class SuperMario : IEstado
    {
        private Mario mario;

        public SuperMario(Mario mario)
        {
            this.mario = mario;
        }

        public void ObtenerFlor()
        {
            mario.SetEstado(new FireMario(mario));
        }

        public void ObtenerHongo()
        {
            Console.WriteLine("No sucede nada.");
        }

        public void TocarMonstruo()
        {
            mario.SetEstado(new SmallMario(mario));
        }

        public override string ToString()
        {
            return $"Super Mario";
        }
    }
}
