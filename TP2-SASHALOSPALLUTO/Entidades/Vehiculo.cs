using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {        
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
                
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        #region "Metodos"
        /// <summary>
        /// Constructor que obtiene los datos del vehiculo
        /// </summary>
        /// <param name="marca">marca del auto de tipo Emarca</param>
        /// <param name="chasis">chasis del auto de tipo string</param>
        /// <param name="color">color del auto de tipo ConsoleColor</param>
        public Vehiculo(EMarca marca, string chasis, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color; 
        }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns>Un string con los datos del vehiculo</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }
        #endregion

        #region "Operadores"

        /// <summary>
        /// Convierte explicitamente el tipo Vehiculo en un string con todos los datos del vehiculo
        /// </summary>
        /// <param name="p">Vehiculo a convertir explicitamente en string</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"CHASIS: {p.chasis}\r\n");
            sb.Append($"MARCA : {p.marca}\r\n");
            sb.Append($"COLOR : {p.color}\r\n");
            sb.Append("---------------------");
            
            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1">Vehiculo 1</param>
        /// <param name="v2">Vehiculo 2</param>
        /// <returns>True si son iguales, false si son diferentes</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }

        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1">Vehiculo 1</param>
        /// <param name="v2">Vehiculo 2</param>
        /// <returns>False si son iguales, true si son diferentes</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion
                
    }
}
