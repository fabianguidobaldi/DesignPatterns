using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class GuerreroBuilder : IBuilder
    {
        Personaje Personaje;


        public GuerreroBuilder()
        {
            this.Personaje = new Guerrero();
            Personaje.Vitalidad = 4;
            Personaje.Inteligencia = 3;
            Personaje.Fuerza = 6;
            Personaje.Destreza = 3;
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
