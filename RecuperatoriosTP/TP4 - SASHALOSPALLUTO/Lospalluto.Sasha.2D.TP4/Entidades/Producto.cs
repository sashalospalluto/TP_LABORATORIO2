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

        public abstract double CalcularPrecio();
        private List<GustoHelado> gustos;
        private double precio;

        public double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }

        public Producto()
        {
            this.gustos = new List<GustoHelado>();
        }

        public Producto(List<GustoHelado> gustos) : this()
        {
            this.gustos = gustos;            
        }

        public List<GustoHelado> SaboresDeHelado
        {
            get
            {
                return this.gustos;
            }

            set
            {
                this.gustos = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine("GUSTOS");
            foreach (GustoHelado gusto in this.gustos)
            {
                stb.AppendLine(gusto.ToString());
            }

            stb.AppendLine($"PRECIO: {this.precio}");

            return stb.ToString();
        }


    }
}
