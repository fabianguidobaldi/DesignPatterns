using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public class Pregunta : ISujeto
    {
        public int Id { get; private set; }
        public string Descripcion { get; private set; }
        public List<IObservador> Seguidores { get; private set; }
        public List<string> Respuestas { get; private set; }

        public Pregunta(int id, string desc)
        {
            Id = id;
            Descripcion = desc;
            Seguidores = new List<IObservador>();
            Respuestas = new List<string>();
        }

        public void AgregarRespuesta(string resp)
        {
            Respuestas.Add(resp);
            Notificar();
        }

        public void Notificar()
        {
            Seguidores.ForEach(obs => obs.Actualizar(Respuestas[Respuestas.Count -1], Id)); // Estructura PUSH
        }

        public void Suscribir(IObservador observador)
        {
            Seguidores.Add(observador);
            Console.WriteLine(observador + " se suscribió a la pregunta " + Convert.ToString(Id));
        }

        public void Desuscribir(IObservador observador)
        {
            Seguidores.Remove(observador);
            Console.WriteLine(observador + " se desuscribió de la pregunta " + Convert.ToString(Id));
        }
    }
}
