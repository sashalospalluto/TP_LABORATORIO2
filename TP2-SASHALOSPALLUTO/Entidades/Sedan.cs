using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo 
        { 
            CuatroPuertas, CincoPuertas
        }

        ETipo tipo;

        #region "Constructores"
        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca">marca de tipo EMarca</param>
        /// <param name="chasis">chasis de tipo string</param>
        /// <param name="color">color de tipo ConsoleColor</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color): base(marca, chasis, color)
        {
            this.tipo = ETipo.CuatroPuertas;
        }

        /// <summary>
        /// Constructor publico
        /// </summary>
        /// <param name="marca">marca de tipo EMarca</param>
        /// <param name="chasis">chasis de tipo string</param>
        /// <param name="color">color de tipo ConsoleColor</param>
        /// <param name="tipo">tipo de sedan de tipo ETipo</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo):this(marca,chasis,color)
        {
            this.tipo = tipo;
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Metodo que muestra los datos del Sedan
        /// </summary>
        /// <returns>string con los datos del sedan</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"\nTAMAÑO : {this.Tamanio}");
            sb.AppendLine($"TIPO : {this.tipo}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
