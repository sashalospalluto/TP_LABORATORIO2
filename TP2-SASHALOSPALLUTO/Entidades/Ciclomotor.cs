using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region "Constructores"
        /// <summary>
        /// Constructor publico
        /// </summary>
        /// <param name="marca">marca de tipo EMarca</param>
        /// <param name="chasis">chasis de tipo string</param>
        /// <param name="color">color de tipo ConsoleColor</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base (marca, chasis, color)
        {

        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Metodo que muestra los datos del ciclomotor
        /// </summary>
        /// <returns>devuelve un string con los datos del ciclomotor</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"\nTAMAÑO : {this.Tamanio}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
