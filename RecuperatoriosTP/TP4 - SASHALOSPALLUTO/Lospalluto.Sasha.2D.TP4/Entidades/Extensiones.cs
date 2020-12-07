using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extensiones
    {
        /// <summary>
        /// Extension que devuelve la cantidad maxima de gustos para un tamaño de helado
        /// </summary>
        /// <param name="tamanio">tamaño del helado a evaluar</param>
        /// <returns>la cantidad maxima de gustos</returns>
        public static int CantidadDeGustosPermitidos(this Helado.Tamanio tamanio)
        {
            int cantidad = 0;

            switch (tamanio)
            {
                case Helado.Tamanio.Cucurucho:
                    cantidad = 2;
                    break;
                case Helado.Tamanio.Cuarto:
                case Helado.Tamanio.Medio:
                    cantidad = 3;
                    break;
                case Helado.Tamanio.Kilo:
                    cantidad = 4;
                    break;
                default:
                    break;
            }

            return cantidad;
        }

        /// <summary>
        /// Extension que devuelve la cantidad maxima de gustos para un tamaño de Torta
        /// </summary>
        /// <param name="tamanio">tamaño de la torta a evaluar</param>
        /// <returns>la cantidad maxima de gustos</returns>
        public static int CantidadDeGustosPermitidos(this Torta.Tamanio tamanio)
        {
            int cantidad = 0;
            switch (tamanio)
            {
                case Torta.Tamanio.Individual:
                    cantidad = 1;
                    break;
                case Torta.Tamanio.Entero:
                    cantidad = 2;
                    break;
                default:
                    break;
            }

            return cantidad;
        }

    }
}
