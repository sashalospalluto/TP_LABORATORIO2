using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Helado : Producto
    {
        public enum TipoDeProducto
        {
            Cucurucho,
            Cuarto,
            Medio,
            Kilo
        }

        private List<GustoHelado> saboresDeHelado;
        private TipoDeProducto tipoDeProducto;

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

        private TipoDeProducto TipoDeProductoElegido
        {
            get
            {
                return tipoDeProducto;
            }
            set
            {
                this.tipoDeProducto = value;
            }
        }

        public Helado()
        {
            this.saboresDeHelado = new List<GustoHelado>();
        }

        public static bool operator + (Helado p , GustoHelado gusto)
        {
            bool agregado = false;

            switch (p.tipoDeProducto)
            {
                case TipoDeProducto.Cucurucho:
                    if (p.saboresDeHelado.Count() < 2)
                    {
                        p.saboresDeHelado.Add(gusto);
                        agregado = true;
                    }
                    break;
                case TipoDeProducto.Cuarto:
                case TipoDeProducto.Medio:
                    if (p.saboresDeHelado.Count() < 3)
                    {
                        p.saboresDeHelado.Add(gusto);
                        agregado = true;
                    }
                    break;
                case TipoDeProducto.Kilo:
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

            switch (this.tipoDeProducto)
            {
                case TipoDeProducto.Cucurucho:
                    precio = 100;
                    break;
                case TipoDeProducto.Cuarto:
                    precio = 170;
                    break;
                case TipoDeProducto.Medio:
                    precio = 300;
                    break;
                case TipoDeProducto.Kilo:
                    precio = 500;
                    break;
                default:
                    break;
            }

            return precio;
        }


    }
}
