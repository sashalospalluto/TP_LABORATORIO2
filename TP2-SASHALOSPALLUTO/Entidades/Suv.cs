using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region "Constructores"
        /// <summary>
        /// Constructor publico 
        /// </summary>
        /// <param name="marca">marca de tipo EMarca</param>
        /// <param name="chasis">chasis de tipo string</param>
        /// <param name="color">color de tipo ConsoleColor</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color): base(marca, chasis, color) 
        { 

        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Metodo que muestra los datos del SUV
        /// </summary>
        /// <returns>string con los datos del suv</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"\nTAMAÑO : {this.Tamanio}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
