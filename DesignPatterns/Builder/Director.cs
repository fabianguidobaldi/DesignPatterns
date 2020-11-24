using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Director
    {
        public IBuilder Constructor;
        public Director(IBuilder constructor)
        {
            Constructor = constructor;
        }

        public void CrearPersonaje(string armadura, string arma, string casco, string guantes, string botas)
        {
            Constructor.SetArmadura(armadura);
            Constructor.SetArma(arma);
            Constructor.SetCasco(casco);
            Constructor.SetGuantes(guantes);
            Constructor.SetBotas(botas);
        }

        /* El objeto Director recibe un Constructor concreto por parámetro, y es el encargado de "guiar" la construcción del objeto. */

    }
}
