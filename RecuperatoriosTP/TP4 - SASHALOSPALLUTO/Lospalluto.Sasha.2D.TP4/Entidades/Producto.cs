using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        public enum GustoHelado
        {
            Granizado,
            Americana,
            Chocolate,
            Tramontana,
            Mascarpone,
            frutilla,
            Vainilla
        }

        public enum Tipo
        {
            Helado,
            Torta
        }

        public abstract double Precio();
    }
}
