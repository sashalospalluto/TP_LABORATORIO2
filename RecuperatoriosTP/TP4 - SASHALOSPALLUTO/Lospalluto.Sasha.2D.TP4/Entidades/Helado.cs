using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

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

        #region Constructores
        /// <summary>
        /// constructor por defecto
        /// </summary>
        public Helado()
        {

        }

        /// <summary>
        /// Constructor que obtiene tamaño y gustos de helado
        /// </summary>
        /// <param name="tamanio">tamaño del helado</param>
        /// <param name="gustos">gustos</param>
        public Helado(Tamanio tamanio, List<GustoHelado> gustos) : base(gustos)
        {

            this.tipo = Tipo.Helado;
            this.tamanio = tamanio;
            this.Precio = this.CalcularPrecio();
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Operador que agrega un gusto al helado TEMA 15
        /// </summary>
        /// <param name="p">helado</param>
        /// <param name="gusto">gusto de helado</param>
        /// <returns>el helado</returns>
        public static Helado operator +(Helado p, GustoHelado gusto)
        {
            int maximo = p.tamanio.CantidadDeGustosPermitidos();

            if (p.SaboresDeHelado.Count() < maximo)
            {
                p.SaboresDeHelado.Add(gusto);
            }
            else
            {
                throw new GustosException();
            }

            return p;
        }

        /// <summary>
        /// Operador que elimina un gusto al helado
        /// </summary>
        /// <param name="p">helado</param>
        /// <param name="gusto">gusto de helado</param>
        /// <returns>el helado</returns>
        public static bool operator -(Helado p, GustoHelado gusto)
        {
            bool eliminado = false;

            if (p.SaboresDeHelado.Count > 0)
            {
                p.SaboresDeHelado.Remove(gusto);
                eliminado = true;
            }

            return eliminado;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Calcula el precio de cada tipo de helado
        /// </summary>
        /// <returns>el precio del helado</returns>
        public override double CalcularPrecio()
        {
            double precio = 0;

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

        /// <summary>
        /// Metodo override de ToString
        /// </summary>
        /// <returns>cadena de caracteres con los datos del helado</returns>
        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine($"{this.tipo} TAMAÑO: {this.tamanio}");
            stb.AppendLine(base.ToString());
            return stb.ToString();
        } 
        #endregion

    }
}
