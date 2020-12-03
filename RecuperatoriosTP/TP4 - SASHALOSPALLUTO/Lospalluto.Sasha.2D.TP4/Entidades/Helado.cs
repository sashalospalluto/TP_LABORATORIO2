using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Helado : Producto
    {
        public enum Tamanio
        {
            Cucurucho,
            Cuarto,
            Medio,
            Kilo
        }
        
        private Tamanio tamanio;
        private Tipo tipo;
                
        public Tamanio TamanioDelHelado
        {
            get
            {
                return tamanio;
            }
            set
            {
                this.tamanio = value;
            }
        }

        public Helado()
        {
                        
        }       

        public Helado (Tamanio tamanio, List<GustoHelado> gustos) :base(gustos)
        {
            
            this.tipo = Tipo.Helado;
            this.tamanio = tamanio;
            this.Precio = this.CalcularPrecio();
        }
                
        public static Helado operator + (Helado p , GustoHelado gusto)
        {
            bool agregado = false;

            switch (p.tamanio)
            {
                case Tamanio.Cucurucho:
                    if (p.SaboresDeHelado.Count() < 2)
                    {
                        p.SaboresDeHelado.Add(gusto);
                        agregado = true;
                    }
                    break;
                case Tamanio.Cuarto:
                case Tamanio.Medio:
                    if (p.SaboresDeHelado.Count() < 3)
                    {
                        p.SaboresDeHelado.Add(gusto);
                        agregado = true;
                    }
                    break;
                case Tamanio.Kilo:
                    if (p.SaboresDeHelado.Count() < 4)
                    {
                        p.SaboresDeHelado.Add(gusto);
                        agregado = true;
                    }
                    break;
                default:
                    break;
            }

            return p;
        }

        public static bool operator - (Helado p, GustoHelado gusto)
        {
            bool eliminado = false;

            if(p.SaboresDeHelado.Count>0)
            {
                p.SaboresDeHelado.Remove(gusto);
                eliminado = true;
            }
            
            return eliminado;
        }

        public override double CalcularPrecio ()
        {
            double precio=0;

            switch (this.tamanio)
            {
                case Tamanio.Cucurucho:
                    precio = 100;
                    break;
                case Tamanio.Cuarto:
                    precio = 170;
                    break;
                case Tamanio.Medio:
                    precio = 300;
                    break;
                case Tamanio.Kilo:
                    precio = 500;
                    break;
                default:
                    break;
            }

            return precio;
        }

        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine($"{this.tipo} TAMAÑO: {this.tamanio}");
            stb.AppendLine(base.ToString());
            return stb.ToString();
        }

    }
}
