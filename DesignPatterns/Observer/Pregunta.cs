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

        /* Sin la utilización del patrón Observer, la clase Pregunta tendría dependencias con todos los tipos de observadores (y viceversa).
         * Sin embargo, a partir de este patrón, tanto los Sujetos como los Observadores implementan su respectiva interfaz, con lo cual se
         * eliminan estas dependencias. */

        public void AgregarRespuesta(string resp)
        {
            Respuestas.Add(resp);
            Notificar();
        }

        public void Notificar()
        {
            Seguidores.ForEach(obs => obs.Actualizar(Respuestas[Respuestas.Count -1], Id)); // Estructura PUSH
            
            /* En una estructura PUSH, cuando se notifica a todos los observadores, se les envían los datos correspondientes al evento
            * que origina la notificación. En una estructura PULL, en cambio, sólo se informa de este evento, y son los observadores los
            * encargados de solicitar los datos que necesitan para realizar sus operaciones. */
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

        /* Utilizando el patrón Observer, es muy sencillo suscribir y desuscribir nuevos observadores manteniendo pocas dependencias. */
    }
}
