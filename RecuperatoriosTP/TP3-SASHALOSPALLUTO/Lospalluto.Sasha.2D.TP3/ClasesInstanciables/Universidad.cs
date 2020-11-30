using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace ClasesInstanciables
{    
    public class Universidad
    {
        /// <summary>
        /// Enumerador con las clases que se pueden dictar en la universidad
        /// </summary>
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }

        private List<Alumno> alumnos;
        private List<Jornada> jornadas;
        private List<Profesor> profesores;

        #region Constructores
        /// <summary>
        /// constructor que incializa las listas de alumnos, jornadas y profesores
        /// </summary>
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornadas = new List<Jornada>();
            this.profesores = new List<Profesor>();
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
        /// Propiedad de List<Jornada> jornadas
        /// </summary>
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornadas;
            }
            set
            {
                this.jornadas = value;
            }
        }

        /// <summary>
        /// Propiedad de List<Profesor> profesores
        /// </summary>
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }

            set
            {
                this.profesores = value;
            }
        } 
        #endregion

        #region Operadores

        /// <summary>
        /// compara si un alumno esta inscripto en la universidad
        /// </summary>
        /// <param name="g">universidad</param>
        /// <param name="a">alumno</param>
        /// <returns>true si se encuentra inscripto, caso contrario devuelve false</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool inscripto = false;
            foreach (Alumno alumno in g.alumnos)
            {
                if (alumno == a)
                {
                    inscripto = true;
                    break;
                }
            }
            return inscripto;
        }

        /// <summary>
        /// compara si un alumno esta inscripto en la universidad
        /// </summary>
        /// <param name="g">universidad</param>
        /// <param name="a">alumno</param>
        /// <returns>true si no se encuentra inscripto, caso contrario devuelve false</returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// verifica si un profesor esta dando cases en la universidd
        /// </summary>
        /// <param name="g">universidad</param>
        /// <param name="a">alumno</param>
        /// <returns>true si da clases, caso contrario devuelve false</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            bool daClases = false;

            foreach (Profesor profesor in g.profesores)
            {
                if (profesor == i)
                {
                    daClases = true;
                    break;
                }
            }

            return daClases;
        }

        /// <summary>
        /// verifica si un profesor esta dando cases en la universidd
        /// </summary>
        /// <param name="g">universidad</param>
        /// <param name="a">alumno</param>
        /// <returns>true si no da clases, caso contrario devuelve false</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// busca si un profesor da la clase en la universidad
        /// </summary>
        /// <param name="u">universidad</param>
        /// <param name="clase">clase</param>
        /// <returns>el profesor que da la clase</returns>
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            Profesor profeQueDaLaClase = new Profesor();
            foreach (Profesor profesor in u.profesores)
            {
                if (profesor == clase)
                {
                    profeQueDaLaClase = profesor;
                    break;
                }
            }

            return profeQueDaLaClase;
        }

        /// <summary>
        /// Devuelve el primer profesor que de una clase distinta a la buscada
        /// </summary>
        /// <param name="u">universidad</param>
        /// <param name="clase">clase</param>
        /// <returns></returns>
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            Profesor profeQueDaLaClase = new Profesor();
            foreach (Profesor profesor in u.profesores)
            {
                if (profesor != clase)
                {
                    profeQueDaLaClase = profesor;
                    break;
                }
            }

            return profeQueDaLaClase;
        }

        /// <summary>
        /// genera una jornada nueva con la clase pasada por valor y agrega a los alumnos para esa jornada
        /// </summary>
        /// <param name="g">universidad</param>
        /// <param name="clase">clase</param>
        /// <returns>universidad</returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada nuevaJornada;

            foreach (Profesor profesor in g.profesores)
            {
                if (profesor == clase)
                {
                    nuevaJornada = new Jornada(clase, profesor);
                    foreach (Alumno alumno in g.alumnos)
                    {
                        if (alumno == clase)
                        {
                            nuevaJornada += alumno;
                        }
                    }

                    g.jornadas.Add(nuevaJornada);
                }
                else
                {
                    throw new SinProfesorException();
                }
            }

            return g;
        }

        /// <summary>
        /// agrega un alumno a la universidad si es que no existe
        /// </summary>
        /// <param name="u">universidad</param>
        /// <param name="a">alumno</param>
        /// <returns>universidad</returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }

            return u;
        }

        /// <summary>
        /// agrega un profesor a la universidad si es que no existe
        /// </summary>
        /// <param name="g">universidad</param>
        /// <param name="i">profesor</param>
        /// <returns>universidad</returns>
        public static Universidad operator +(Universidad g, Profesor i)
        {
            if (g != i)
            {
                g.profesores.Add(i);
            }
            return g;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Indexador de Jornada
        /// </summary>
        /// <param name="i">posicion de la jornada</param>
        /// <returns>la jornada de la posicion i</returns>
        public Jornada this[int i]
        {
            get
            {
                return jornadas[i];
            }
            set
            {
                jornadas[i] = value;
            }
        }

        /// <summary>
        /// Metodo que guarda la universidad en un archivo con extension .xml
        /// </summary>
        /// <param name="uni">universidad a guardad</param>
        /// <returns>true si se guardó correctamente, caso contrario devuelve false</returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> xml = new Xml<Universidad>();

            return xml.Guardar("Universidad", uni); ;
        }

        /// <summary>
        /// Metodo que lee los datos de un archivo con extension .xml
        /// </summary>
        /// <returns>cadena de string con los datos de la universidad leida</returns>
        public static Universidad Leer()
        {
            Xml<Universidad> xml = new Xml<Universidad>();

            xml.Leer("Universidad", out Universidad universidad);

            return universidad;
        }

        /// <summary>
        /// Metodo que me muestra los datos de la universidad
        /// </summary>
        /// <returns>un string de los datos de la universidad</returns>
        private string MostrarDatos(Universidad uni)
        {
            StringBuilder stb = new StringBuilder();

            foreach (Jornada jornada in uni.jornadas)
            {
                stb.AppendLine(jornada.ToString());
            }
            return stb.ToString();
        }


        /// <summary>
        /// Devuelve una cadena que representa el objeto actual
        /// </summary>
        /// <returns>cadena de string con los datos de la universidad</returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }
        #endregion

    }
}
