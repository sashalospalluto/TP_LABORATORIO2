﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml <T> : Iarchivo<T>
    {
        /// <summary>
        /// Guarda un archivo con extension .xml
        /// </summary>
        /// <param name="archivo">ruta del archivo</param>
        /// <param name="datos">se devolverán los datos leidos del archivo</param>
        /// <returns>retorna true si se pudo guardar, caso contrario retorna false</returns>
        public bool Guardar (string archivo, T datos)
        {
            bool guardado = false;
            XmlTextWriter textWriter=null;
            XmlSerializer serializer;
            try
            {
                textWriter = new XmlTextWriter($"{archivo}.xml", UTF8Encoding.UTF8);
                serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(textWriter, datos);
                guardado = true;
            }
            catch (Exception ex)
            {

                throw new ArchivosException(ex);
            }
            finally
            {
                if(textWriter!=null)
                {
                    textWriter.Close();
                }
            }
            
            return guardado;
        }

        /// <summary>
        /// lee archivo con extension .xml
        /// </summary>
        /// <param name="archivo">ruta del archivo</param>
        /// <param name="datos">datos a leer del archivo</param>
        /// <returns>retorna true si se pudo leer, caso contrario retorna false</returns>
        public bool Leer(string archivo, out T datos)
        {
            bool leido = false;
            XmlSerializer serializer;
            XmlTextReader reader = null;
            
            try
            {
                serializer = new XmlSerializer(typeof(T));
                reader = new XmlTextReader($"{archivo}.xml");
                datos = (T)serializer.Deserialize(reader);
                leido = true;
            }
            catch (Exception ex)
            {

                throw new ArchivosException(ex);
            }
            finally
            {
                if(reader!=null)
                {
                    reader.Close();
                }

            }
                       
            return leido;
        }
    }
}
