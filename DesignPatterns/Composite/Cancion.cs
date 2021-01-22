using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Cancion : Componente
    {
        string Nombre;
        string Banda;

        public Cancion(string nombre, string banda)
        {
            Nombre = nombre;
            Banda = banda;
        }
        
        public override void ObtenerDescripcion()
        {
            Console.WriteLine($"Canción: '{Nombre}' - Banda: '{Banda}'");
        }
    }
}
