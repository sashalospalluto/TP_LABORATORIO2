using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;

        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }

        #region "Constructores"
        /// <summary>
        /// Constructor que inicializa la lista
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// Constructor que asigna el espacio disponible en el taller
        /// </summary>
        /// <param name="espacioDisponible">espacio disponible que se desea en el taller</param>
        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns>Devuelve un string con todos los datos de los vehiculos</returns>
        public override string ToString()
        {
            return Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns>Un string con los datos todos los vehiculos del tipo solicitado</returns>
        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"Tenemos {taller.vehiculos.Count} lugares ocupados de un total de {taller.espacioDisponible} disponibles");
            sb.AppendLine("");
            foreach (Vehiculo v in taller.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Ciclomotor:

                        if(v is Ciclomotor)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Sedan:

                        if(v is Sedan)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.SUV:

                        if(v is Suv)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    default:

                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns>el objeto de tipo Taller</returns>
        public static Taller operator + (Taller taller, Vehiculo vehiculo)
        {
            bool estaRepetido = false;

            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                {
                    estaRepetido = true;
                }
            }

            if (!estaRepetido && taller.espacioDisponible > taller.vehiculos.Count)
            {
                taller.vehiculos.Add(vehiculo);
            }

            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns>el taller</returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                {
                    taller.vehiculos.Remove(vehiculo);                    
                    break;
                }
            }

            return taller;
        }
        #endregion
    }
}
