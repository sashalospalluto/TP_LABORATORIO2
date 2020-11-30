using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace ClasesInstanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private Jornada()
        {
            alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="clase">clase que se va a dar</param>
        /// <param name="instructor"> Profesor que la va a dictar</param>
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de List<Alumno> alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        /// <summary>
        /// Propiedad de Universidad.EClases clase
        /// </summary>
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        /// <summary>
        /// Propiedad Profesor instructor
        /// </summary>
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        } 
        #endregion

        #region Operadores
        /// <summary>
        /// Operador que verifica si un alumno participa en una clase de la jornada
        /// </summary>
        /// <param name="j">jornada</param>
        /// <param name="a">alumno</param>
        /// <returns>true si participa en una clase de la jornada, caso contrario devuelve false</returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool participa = false;
            if (a == j.clase)
            {
                participa = true;
            }
            return participa;
        }
        /// <summary>
        /// Operador que verifica si un alumno participa en una clase de la jornada
        /// </summary>
        /// <param name="j">jornada</param>
        /// <param name="a">alumno</param>
        /// <returns>true si no participa en una clase de la jornada, caso contrario devuelve false</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// operador que agrega un alumno a la jornada
        /// </summary>
        /// <param name="j">jornada</param>
        /// <param name="a">alumno</param>
        /// <returns>la jornada</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j == a)
            {
                j.alumnos.Add(a);
            }

            return j;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que guarda una jornada en un archivo con extension .txt
        /// </summary>
        /// <param name="jornada">jornada a guardad</param>
        /// <returns>true si se guardó correctamente, caso contrario devuelve false</returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto texto = null;

            try
            {
                texto = new Texto();

                texto.Guardar("Jornada", jornada.ToString());
            }
            catch (Exception)
            {

                throw;
            }

            return true;
        }

        /// <summary>
        /// Metodo que lee una jornada en un archivo con extension .txt
        /// </summary>
        /// <returns>cadena de string con los datos de la jornada leida</returns>
        public static string Leer()
        {
            Texto texto = null;
            string jornada = null;

            try
            {
                texto = new Texto();
                texto.Leer("Jornada", out jornada);
            }
            catch (Exception)
            {

                throw;
            }

            return jornada;
        }


        /// <summary>
        /// Devuelve una cadena que representa el objeto actual
        /// </summary>
        /// <returns>cadena de string con los datos de la jornada</returns>
        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();

            stb.Append($"CLASE DE: {this.clase}");
            stb.Append($" POR {this.instructor}");
            stb.AppendLine("ALUMNOS");
            foreach (Alumno alumno in this.alumnos)
            {
                stb.AppendLine(alumno.ToString());
            }
            stb.AppendLine("<--------------------------------------------->");
            return stb.ToString();
        } 
        #endregion

    }
}
