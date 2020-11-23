using System;

namespace DesignPatterns.Observer
{
    public class Usuario : IObservador
    {
        /* Utilizando el patrón Observer, como todos los observadores implementan la misma interfaz, para agregar un nuevo tipo de observador
         * sólo basta con implementar la interfaz, eliminando las dependencias con los sujetos a los cuales se suscriben. */
        public string Nickname { get; set; }

        public Usuario(string nick)
        {
            Nickname = nick;
        }

        public void Actualizar(string respuesta, int id)
        {
            Console.WriteLine(Nickname + " - " + "Nueva respuesta a la pregunta " + Convert.ToString(id) + " - " + respuesta);
        }

        public override string ToString()
        {
            return Nickname;
        }
    }
}
