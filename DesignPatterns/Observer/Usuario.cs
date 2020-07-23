using System;

namespace DesignPatterns.Observer
{
    public class Usuario : IObservador
    {
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
