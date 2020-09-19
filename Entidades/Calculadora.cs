using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza la operacion aritmetica correspondiente
        /// </summary>
        /// <param name="num1">primer numero ingresado</param>
        /// <param name="num2">segundo numero ingresado</param>
        /// <param name="operador">operación aritmetica a realizar</param>
        /// <returns>resultado de la operación aritmetica</returns>
        public static double Operar (Numero num1, Numero num2, char operador)
        {
            string operadorAUtilizar;
            double resultado=0;

            operadorAUtilizar = ValidarOperador(operador);                      

            switch (operadorAUtilizar)
            {
                case "+":
                    resultado= num1 + num2;
                    break;
                case "-":
                    resultado= num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
            }

            return resultado;
        }

        /// <summary>
        /// Valida si la operación aritmetica pasada por parametro, es correcta
        /// </summary>
        /// <param name="operador">operacion aritmetica a validar</param>
        /// <returns>Devuelve la operacion aritmetica ingresada, en caso de que no exista, se devuelve el operador suma (+)</returns>
        private static string ValidarOperador (char operador)
        {
            string operadorValidado;

            switch (operador)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                    operadorValidado = operador.ToString();
                    break;               
                default:
                    operadorValidado = "+";
                    break;
            }
            return operadorValidado;
        }

    }
}
