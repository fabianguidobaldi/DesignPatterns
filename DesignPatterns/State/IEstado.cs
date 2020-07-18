using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public interface IEstado
    {
        void ObtenerHongo();
        void ObtenerFlor();
        void TocarMonstruo();
    }
}
