using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torta : Producto
    {
        public enum Tamanio
        {
            Individual,
            Entero
        }

        private Tamanio tamanioElegido;
        private Producto.GustoHelado gusto;
        private static Producto.Tipo tipo;

        static Torta()
        {
            tipo = Producto.Tipo.Torta;
        }

        public Torta (Tamanio tamanio, Producto.GustoHelado gusto)
        {
            this.gusto = gusto;
            this.tamanioElegido = tamanio;
        }

        public override double Precio()
        {
            double precio = 0;
            switch (this.tamanioElegido)
            {
                case Tamanio.Individual:
                    precio = 120;
                    break;
                case Tamanio.Entero:
                    precio = 400;
                    break;
                default:
                    break;
            }

            return precio;
        }
    }
}
