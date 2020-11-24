using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class NinjaBuilder : IBuilder
    {
        Personaje Personaje;


        public NinjaBuilder()
        {
            this.Personaje = new Ninja();
            Personaje.Vitalidad = 3;
            Personaje.Inteligencia = 3;
            Personaje.Fuerza = 4;
            Personaje.Destreza = 6;
        }

        public void SetArma(string arma)
        {
            Personaje.Arma = arma;
        }

        public void SetArmadura(string armadura)
        {
            Personaje.Armadura = armadura;
        }

        public void SetBotas(string botas)
        {
            Personaje.Botas = botas;
        }

        public void SetCasco(string casco)
        {
            Personaje.Casco = casco;
        }

        public void SetGuantes(string guantes)
        {
            Personaje.Guantes = guantes;
        }

        public Personaje ObtenerPersonaje()
        {
            return this.Personaje;
        }
    }
}
