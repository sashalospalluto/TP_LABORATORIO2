using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{    
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Profesor()
        {

        }

        /// <summary>
        /// Constructor estatico que incializa el atributo random
        /// </summary>
        static Profesor()
        {
            random = new Random();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="nombre">nombre</param>
        /// <param name="apellido">apellido</param>
        /// <param name="dni">dni</param>
        /// <param name="nacionalidad">nacionalidad</param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
            this._randomClases();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que asigna  una clase al azar al profesor
        /// </summary>
        private void _randomClases()
        {
            var v = Enum.GetValues(typeof(Universidad.EClases));

            this.clasesDelDia.Enqueue((Universidad.EClases)v.GetValue(random.Next(v.Length)));

        }

        /// <summary>
        /// Metodo que me muestra los datos del profesor
        /// </summary>
        /// <returns>un string de los datos del profesor</returns>
        protected override string MostrarDatos()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine(base.MostrarDatos());
            stb.AppendLine(this.ParticiparEnClase());
            return stb.ToString();
        }

        /// <summary>
        /// Metodo que muestra los clases que da el profesor
        /// </summary>
        /// <returns>una cadena de string con las clases del dia</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine("CLASES DEL DIA:");
            foreach (Universidad.EClases clases in this.clasesDelDia)
            {
                stb.AppendLine($"{clases}");
            }

            return stb.ToString();
        }

        /// <summary>
        /// Devuelve una cadena que representa el objeto actual
        /// </summary>
        /// <returns>cadena de string con los datos de la jornada</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        } 
        #endregion

        #region Operadores
        /// <summary>
        /// Comprara si el profesor da la clase pasada por parametro
        /// </summary>
        /// <param name="i">profesor</param>
        /// <param name="clase">clase</param>
        /// <returns>true si el profesor da la clase, caso contrario devuelve false</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool daLaClase = false;

            foreach (Universidad.EClases claseProfe in i.clasesDelDia)
            {
                if (claseProfe == clase)
                {
                    daLaClase = true;
                    break;
                }
            }

            return daLaClase;
        }

        /// <summary>
        /// Comprara si el profesor da la clase pasada por parametro
        /// </summary>
        /// <param name="i">profesor</param>
        /// <param name="clase">clase</param>
        /// <returns>true si el profesor no da la clase, caso contrario devuelve false</returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        } 
        #endregion

    }
}
