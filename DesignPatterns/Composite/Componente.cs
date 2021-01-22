using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public abstract class Componente
    {
        public virtual void Agregar(Componente componente)
        {
            throw new NotSupportedException();
        }

        public virtual void Remover(Componente componente)
        {
            throw new NotSupportedException();
        }

        public virtual List<Componente> ObtenerHijos()
        {
            throw new NotSupportedException();
        }

        public virtual void ObtenerDescripcion()
        {
            throw new NotSupportedException();
        }
    }
}
