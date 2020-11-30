using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region Constructores
        /// <summary>
        /// constructor por defecto
        /// </summary>
        public Universitario()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="legajo">legajo</param>
        /// <param name="nombre">nombre</param>
        /// <param name="apellido">apellido</param>
        /// <param name="dni">dni</param>
        /// <param name="nacionalidad">nacionalidad</param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Verifica que ambos objetos sean del mismo tipo
        /// </summary>
        /// <param name="obj">objeto a comparar</param>
        /// <returns>true si son del mismo tipo, caso contrario devuelve false</returns>
        public override bool Equals(object obj)
        {
            bool sonIguales = false;
            if (obj.GetType() == this.GetType())
            {
                sonIguales = true;
            }

            return sonIguales;
        }

        /// <summary>
        /// Metodo que me muestra los datos del Universitario
        /// </summary>
        /// <returns>un string de los datos del universitario</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder stb = new StringBuilder();

            stb.Append(base.ToString());
            stb.Append($"\nLEGAJO NÚMERO: {this.legajo}\n");

            return stb.ToString();
        }

        /// <summary>
        /// metodo abstracto que devolvera una cadena de la clase en la que participa el universitario
        /// </summary>
        /// <returns>cadena de string con la clase en la que participa</returns>
        protected abstract string ParticiparEnClase(); 
        #endregion

        #region Operadores
        /// <summary>
        /// Verifica que dos universitarios tengan el mismo dni o legajo
        /// </summary>
        /// <param name="pg1">universitario 1</param>
        /// <param name="pg2">universitario 1</param>
        /// <returns>true si son iguales, caso contrario devuelve false</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool sonIguales = false;
            if (pg1.Equals(pg2))
            {
                if (pg1.Dni == pg2.Dni || pg1.legajo == pg2.legajo)
                {
                    sonIguales = true;
                }
            }

            return sonIguales;
        }

        /// <summary>
        /// Verifica que dos universitarios tengan el mismo dni o legajo
        /// </summary>
        /// <param name="pg1">universitario 1</param>
        /// <param name="pg2">universitario 1</param>
        /// <returns>true si son distintos, caso contrario devuelve false</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        } 
        #endregion

    }
}