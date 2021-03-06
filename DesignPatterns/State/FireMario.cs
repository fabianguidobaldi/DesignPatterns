﻿using System;

namespace DesignPatterns.State
{
    public class FireMario : IEstado
    {
        private Mario mario;

        public FireMario(Mario mario)
        {
            this.mario = mario;
        }

        public void ObtenerFlor()
        {
            Console.WriteLine("No sucede nada.");
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
            return $"Fire Mario";
        }
    }
}
