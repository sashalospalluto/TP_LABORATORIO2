using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{    
    public class Alumno : Universitario
    {
        /// <summary>
        /// Enumerado de los estados de cuenta de un alumno
        /// </summary>
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Alumno()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="nombre">nombre</param>
        /// <param name="apellido">apellido</param>
        /// <param name="dni">dni</param>
        /// <param name="nacionalidad">nacionalidad</param>
        /// <param name="claseQueToma">claseQueToma</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
            this.estadoCuenta = EEstadoCuenta.AlDia;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="nombre">nombre</param>
        /// <param name="apellido">apellido</param>
        /// <param name="dni">dni</param>
        /// <param name="nacionalidad">nacionalidad</param>
        /// <param name="claseQueToma">claseQueToma</param>
        /// <param name="estadoCuenta">estadoCuenta</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        } 
        #endregion

        #region Operadores
        /// <summary>
        /// Indica si el alumno puede tomar la clase validando que no sea deudor y tenga la clase 
        /// </summary>
        /// <param name="a">alumno</param>
        /// <param name="clase">clase</param>
        /// <returns>true si puede tomar la clase, caso contrario devuelve false</returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            bool tomaLaClase = true;
            if (a.estadoCuenta == EEstadoCuenta.Deudor || a != clase)
            {
                tomaLaClase = false;
            }
            return tomaLaClase;
        }

        /// <summary>
        /// indica si el usuario no toma la clase
        /// </summary>
        /// <param name="a">alumno</param>
        /// <param name="clase">clase</param>
        /// <returns>true si el usuario no toma la clase, caso contrario devuelve false</returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            bool noTomaLaClase = false;
            if (a.claseQueToma != clase)
            {
                noTomaLaClase = true;
            }
            return noTomaLaClase;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que me muestra los datos del alumno
        /// </summary>
        /// <returns>un string de los datos del alumno</returns>
        protected override string MostrarDatos()
        {
            return this.ToString();
        }

        /// <summary>
        /// devolvera una cadena de la clase en la que participa
        /// </summary>
        /// <returns>cadena de string con la clase que toma</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder stb = new StringBuilder();
            stb.Append($"Clase que toma: {this.claseQueToma}");
            return stb.ToString();
        }

        /// <summary>
        /// Devuelve una cadena que representa el objeto actual
        /// </summary>
        /// <returns>cadena de string con los datos del alumno</returns>
        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine(base.MostrarDatos());
            switch (this.estadoCuenta)
            {
                case EEstadoCuenta.AlDia:
                    stb.AppendLine($"ESTADO DE CUENTA: Cuota al día");
                    break;
                case EEstadoCuenta.Deudor:
                    stb.AppendLine($"ESTADO DE CUENTA: {this.estadoCuenta}");
                    break;
                case EEstadoCuenta.Becado:
                    stb.AppendLine($"ESTADO DE CUENTA: {this.estadoCuenta}");
                    break;
            }

            stb.AppendLine($"TOMA CLASE DE: {this.claseQueToma}");

            return stb.ToString();
        } 
        #endregion

    }
}
