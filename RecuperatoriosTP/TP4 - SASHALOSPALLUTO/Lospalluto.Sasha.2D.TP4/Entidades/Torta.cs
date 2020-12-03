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
        private static Producto.Tipo tipo;

        static Torta()
        {
            tipo = Producto.Tipo.Torta;
        }

        public Torta()
        {

        }

        public Tamanio TamanioElegido
        {
            get
            {
                return this.tamanioElegido;
            }
        }


        public Torta (Tamanio tamanio, List<Producto.GustoHelado> gustos) :base(gustos)
        {            
            this.tamanioElegido = tamanio;
            this.Precio = this.CalcularPrecio();
        }

        public override double CalcularPrecio()
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

        public static Torta operator + (Torta p, GustoHelado gusto)
        {
            bool agregado = false;

            switch (p.tamanioElegido)
            {
                case Tamanio.Individual:
                    if(p.SaboresDeHelado.Count < 1)
                    {
                        p.SaboresDeHelado.Add(gusto);
                    }    
                    break;
                case Tamanio.Entero:
                    if (p.SaboresDeHelado.Count < 2)
                    {
                        p.SaboresDeHelado.Add(gusto);
                    }
                    break;
                default:
                    break;
            }

            return p;
        }

        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine($"{tipo} TAMAÑO: {this.tamanioElegido}");
            stb.AppendLine(base.ToString());
            return stb.ToString();
        }
    }
}
