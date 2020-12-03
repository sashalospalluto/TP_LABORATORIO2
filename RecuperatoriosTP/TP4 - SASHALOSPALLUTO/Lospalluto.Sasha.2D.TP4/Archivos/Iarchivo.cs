﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface Iarchivo <T>
    {
        /// <summary>
        /// Metodo de tipo Interfaz para guardar un archivo
        /// </summary>
        /// <param name="archivo">ruta del archivo</param>
        /// <param name="datos">datos del archivo</param>
        /// <returns></returns>
        bool Guardar(string archivo, T datos);

        /// <summary>
        /// Metodo de tipo Interfaz para leer un archivo
        /// </summary>
        /// <param name="archivo">ruta del archivo</param>
        /// <param name="datos">se pasaran por referencia los datos del archivo</param>
        /// <returns></returns>
        bool Leer(string archivo, out T datos);
        
    }
}
