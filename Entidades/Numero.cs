using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public Numero ()
        {
            this.numero = 0;
        }

        public Numero (double numero) :this()
        {
            this.numero = numero;
        }

        public Numero (string numero) :this(double.Parse(numero))
        {

        }

        public string SetNumero 
        {             
            set
            {
                this.numero = this.ValidarNumero(value);
            }
        }

        /// <summary>
        /// Convierte un numero binario a decimal
        /// </summary>
        /// <param name="binario">numero binario</param>
        /// <returns>devuelve el numero binario convertido a decimal, si lo ingresado no es binario, devuelve "Valor invalido" </returns>
        public string BinarioDecimal (string binario)
        {
            string aux;
            int numeroSolo;
            int nroDecimal = 0;
            int contador = binario.Length;
            string esUnNumeroBinario = "";

            if(EsBinario(binario))
            {
                for (int i = 0; i < contador; i++)
                {
                    aux = binario.Substring(binario.Length - 1, 1); //tomo solo el ultimo caracter del string
                    int.TryParse(aux, out numeroSolo); //lo convierto a entero 

                    if (numeroSolo == 1) // solo si es 1 lo elevo y lo sumo
                    {
                        nroDecimal = (int)Math.Pow(2, i) + nroDecimal;
                    }

                    binario = binario.Remove(binario.Length - 1); //elimino el ultimo caracter del string
                }
            }
            else
            {
                esUnNumeroBinario = "Valor invalido";
            }                

            if (!(esUnNumeroBinario.Equals("Valor invalido")))
            {
                esUnNumeroBinario = nroDecimal.ToString();
            }

            return esUnNumeroBinario;
        }

        /// <summary>
        /// Convierte un numero decimal pasado como double a binario
        /// </summary>
        /// <param name="numero">numero decimal</param>
        /// <returns>Devuelve el numero decimal convertido a binario</returns>
        public string DecimalBinario (double numero)
        {
            string binario = "";
            int numeroEntero;

            numeroEntero = (int)numero;

            while (numeroEntero > 1)
            {
                if (numeroEntero % 2 == 0)
                {
                    binario = "0" + binario;
                }
                else
                {
                    binario = "1" + binario;
                }

                numeroEntero = numeroEntero / 2;
            }

            binario = '1' + binario;

            return binario;
        }

        /// <summary>
        /// Convierte un numero decimal pasado como string a binario
        /// </summary>
        /// <param name="numero">numero decimal</param>
        /// <returns>Devuelve el numero decimal convertido a binario</returns>
        public string DecimalBinario(string numero)
        {
            double binario;

            double.TryParse(numero, out binario);

            return DecimalBinario(binario);
        }

        /// <summary>
        /// Verifica si el numero pasado por parametro es binario
        /// </summary>
        /// <param name="binario">Numero binario</param>
        /// <returns>Devuelve true si el numero pasado por parametro es un numero binario, caso contrario, devuelve false</returns>
        private bool EsBinario (string binario)
        {
            bool esUnNumeroBinario=true;
            string aux;
            int numeroSolo;
            int contador = binario.Length;

            for (int i = 0; i < contador; i++)
            {
                aux = binario.Substring(binario.Length - 1, 1); //tomo solo el ultimo caracter del string
                int.TryParse(aux, out numeroSolo);

                if (!(numeroSolo == 1 || numeroSolo == 0))
                {
                    esUnNumeroBinario = false;
                    break;
                }

                binario = binario.Remove(binario.Length - 1); //elimino el ultimo caracter del string

            }

            return esUnNumeroBinario;                
        }

        /// <summary>
        /// Suma dos numeros de tipo Numero
        /// </summary>
        /// <param name="n1">primer numero</param>
        /// <param name="n2">segundo numero</param>
        /// <returns>Devuelve la suma entre ambos numeros</returns>
        public static double operator + (Numero n1, Numero n2)
        {
            return (n1.numero + n2.numero);
        }

        /// <summary>
        /// Resta dos numeros de tipo Numero
        /// </summary>
        /// <param name="n1">primer numero</param>
        /// <param name="n2">segundo numero</param>
        /// <returns>Devuelve la resta entre ambos numeros</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return (n1.numero - n2.numero);
        }

        /// <summary>
        /// Multiplica dos numeros de tipo Numero
        /// </summary>
        /// <param name="n1">primer numero</param>
        /// <param name="n2">segundo numero</param>
        /// <returns>Devuelve la multiplicación entre ambos numeros</returns>
        public static double operator *(Numero n1, Numero n2)
        {            
            return (n1.numero * n2.numero);
        }

        /// <summary>
        /// Divide dos numeros de tipo Numero
        /// </summary>
        /// <param name="n1">primer numero</param>
        /// <param name="n2">segundo numero</param>
        /// <returns>Devuelve la division entre ambos numeros si el denominador es distinto de cero(0), caso contrario retornará double.MinValue</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double resultado = double.MinValue;
            if(n2.numero!=0)
            {
                resultado = n1.numero / n2.numero;
            }
            return resultado;
        }

        /// <summary>
        /// Verifica que el valor recibido sea un número
        /// </summary>
        /// <param name="strNumero">numero a validar de tipo string</param>
        /// <returns>retornará el valor del numero, en caso de que el valor no sea un numero, retornará 0 (cero)</returns>
        private double ValidarNumero (string strNumero)
        {
            double numeroValidado = 0;

            double.TryParse(strNumero, out numeroValidado);

            return numeroValidado;
        }

    }
}
