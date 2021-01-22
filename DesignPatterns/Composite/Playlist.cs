using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Playlist : Componente
    {
        public string Nombre;
        public List<Componente> Canciones;

        public Playlist(string nombre)
        {
            Nombre = nombre;
            Canciones = new List<Componente>();
        }

        public override void Agregar(Componente componente)
        {
            Canciones.Add(componente);
        }

        public override void Remover(Componente componente)
        {
            Canciones.Remove(componente);
        }

        public override List<Componente> ObtenerHijos()
        {
            return Canciones;
        }

        public override void ObtenerDescripcion()
        {
            Console.WriteLine($"Playlist: '{Nombre}' - Cantidad de elementos: {Canciones.Count}");
            foreach (var elem in Canciones)
            {
                elem.ObtenerDescripcion();
            }
        }
    }
}
