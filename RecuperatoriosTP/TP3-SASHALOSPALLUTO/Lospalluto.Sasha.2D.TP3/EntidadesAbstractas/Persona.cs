using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{  
    public abstract class Persona
    {
        /// <summary>
        /// enumerado que describe los dos tipos de nacionalidad permitidos
        /// </summary>
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int dni;

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre">nombre</param>
        /// <param name="apellido">apellido</param>
        /// <param name="nacionalidad">nacionalidad</param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre">nombre</param>
        /// <param name="apellido">apellido</param>
        /// <param name="dni">dni</param>
        /// <param name="nacionalidad">nacionalidad</param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, dni.ToString(), nacionalidad)
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre">nombre</param>
        /// <param name="apellido">apellido</param>
        /// <param name="dni">dni</param>
        /// <param name="nacionalidad">nacionalidad</param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;

        } 
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }

        }

        /// <summary>
        /// propiedad de apellido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }

        }

        /// <summary>
        /// propiedad de dni (int)
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }

        }

        /// <summary>
        /// propiedad de dni (string)
        /// </summary>
        public string StringToDNI
        {
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }

        }
        /// <summary>
        /// Propiedad de nacionalidad
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get
            {
                return ENacionalidad.Argentino;
            }
            set
            {
                if (value == ENacionalidad.Argentino || value == ENacionalidad.Extranjero)
                {
                    this.nacionalidad = value;
                }
                else
                {
                    throw new NacionalidadInvalidaException();
                }

            }

        } 
        #endregion

        #region Metodos

        /// <summary>
        /// Devuelve una cadena que representa el objeto actual
        /// </summary>
        /// <returns>cadena de string con los datos de la persona</returns>
        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();

            stb.Append($"NOMBRE COMPLETO: {this.apellido}, {this.nombre}");
            stb.Append($"\nNACIONALIDAD: {this.Nacionalidad}\n");

            return stb.ToString();
        }

        /// <summary>
        /// Valida que el dni de tipo int corresponda con el tipo de nacionalidad
        /// </summary>
        /// <param name="nacionalidad">nacionalidad</param>
        /// <param name="dato">dni</param>
        /// <returns>dni validado</returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            return ValidarDni(nacionalidad, dato.ToString());
        }

        /// <summary>
        /// Valida que el dni de tipo string corresponda con el tipo de nacionalidad
        /// </summary>
        /// <param name="nacionalidad">nacionalidad</param>
        /// <param name="dato">dni</param>
        /// <returns>dni validado, caso contrario se presentan excepciones</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni;

            if (int.TryParse(dato, out dni))
            {
                if (dni >= 1 && dni <= 99999999)
                {
                    switch (nacionalidad)
                    {
                        case ENacionalidad.Argentino:

                            if (dni < 1 || dni > 89999999)
                            {
                                throw new NacionalidadInvalidaException("La nacionalidad no se condice con el número de DNI");
                            }
                            break;

                        case ENacionalidad.Extranjero:

                            if (dni < 90000000 || dni > 99999999)
                            {
                                throw new NacionalidadInvalidaException("La nacionalidad no se condice con el número de DNI");
                            }
                            break;

                        default:
                            throw new NacionalidadInvalidaException();
                    }
                }
                else
                {
                    throw new DniInvalidoException("DNI fuera de rango");
                }
            }
            else
            {
                throw new DniInvalidoException("No es un dni");
            }


            return dni;
        }

        /// <summary>
        /// Verifica que el dato pasado sea un nombre
        /// </summary>
        /// <param name="dato">nombre o apellido</param>
        /// <returns>nombre validado, caso contrario se presenta excepcion</returns>
        private string ValidarNombreApellido(string dato)
        {
            for (int i = 0; i < dato.Length; i++)
            {
                if (!char.IsLetter(dato[i]))
                {
                    throw new Exception("Nombre invalido");
                }
            }

            return dato;
        } 
        #endregion

        #region Operadores
        /// <summary>
        /// verifica que la persona tenga la misma nacionalidad que la que se pasa por parametro
        /// </summary>
        /// <param name="persona">persona</param>
        /// <param name="nacionalidad">nacionalidad</param>
        /// <returns>true si son iguales, caso contrario devuelve false</returns>
        public static bool operator ==(Persona persona, ENacionalidad nacionalidad)
        {
            bool sonIguales = false;
            if (persona.nacionalidad == nacionalidad)
            {
                sonIguales = true;
            }
            return sonIguales;
        }

        /// <summary>
        /// verifica que la persona tenga la misma nacionalidad que la que se pasa por parametro
        /// </summary>
        /// <param name="persona">persona</param>
        /// <param name="nacionalidad">nacionalidad</param>
        /// <returns>true si son diferentes, caso contrario devuelve false</returns>
        public static bool operator !=(Persona persona, ENacionalidad nacionalidad)
        {
            return !(persona == nacionalidad);
        } 
        #endregion
    }
}