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

        private List<GustoHelado> saboresDeHelado;
        private Tamanio tamanio;
        private Tipo tipo;

        public List<GustoHelado> SaboresDeHelado 
        {
            get
            {
                return this.saboresDeHelado;
            }

            set
            {
                this.saboresDeHelado = value;
            }
        }

        private Tamanio TamanioDelHelado
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
            this.saboresDeHelado = new List<GustoHelado>();
            this.tipo = Tipo.Helado;
            
        }

        public Helado (Tamanio tamanio, List<GustoHelado> gustos)
        {
            this.tamanio = tamanio;
            this.saboresDeHelado = gustos;
        }

        public static bool operator + (Helado p , GustoHelado gusto)
        {
            bool agregado = false;

            switch (p.tamanio)
            {
                case Tamanio.Cucurucho:
                    if (p.saboresDeHelado.Count() < 2)
                    {
                        p.saboresDeHelado.Add(gusto);
                        agregado = true;
                    }
                    break;
                case Tamanio.Cuarto:
                case Tamanio.Medio:
                    if (p.saboresDeHelado.Count() < 3)
                    {
                        p.saboresDeHelado.Add(gusto);
                        agregado = true;
                    }
                    break;
                case Tamanio.Kilo:
                    if (p.saboresDeHelado.Count() < 4)
                    {
                        p.saboresDeHelado.Add(gusto);
                        agregado = true;
                    }
                    break;
                default:
                    break;
            }

            return agregado;
        }

        public static bool operator - (Helado p, GustoHelado gusto)
        {
            bool eliminado = false;

            if(p.saboresDeHelado.Count>0)
            {
                p.saboresDeHelado.Remove(gusto);
                eliminado = true;
            }
            
            return eliminado;
        }

        public override double Precio ()
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


    }
}
