using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;



namespace Archivos
{
    public class Texto : Iarchivo<string> 
    {
        /// <summary>
        /// Guarda un archivo con extension .txt
        /// </summary>
        /// <param name="archivo">ruta del archivo</param>
        /// <param name="datos">datos a guardar</param>
        /// <returns>retorna true si se pudo guardar, caso contrario retorna false</returns>
        public bool Guardar(string archivo, string datos)
        {
            bool guardado = false;
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter($"{archivo}.txt",true);
                writer.WriteLine(datos);
                guardado = true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
            finally
            {
                if(writer!=null)
                {
                    writer.Close();
                }
            }
            return guardado;
        }

        /// <summary>
        /// Lee un archivo con extension .txt
        /// </summary>
        /// <param name="archivo">ruta del archivo</param>
        /// <param name="datos">se devolverán los datos leidos del archivo</param>
        /// <returns>retorna true si se pudo leer, caso contrario retorna false</returns>
        public bool Leer(string archivo, out string datos)
        {
            bool leido = false;
            StreamReader reader = null;
            datos = null;

            try
            {
                reader = new StreamReader($"{archivo}.txt");
                datos = reader.ReadToEnd();
                leido = true;
            }
            catch(Exception ex)
            {
                throw new ArchivosException(ex);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            
            return leido;
        }
    }
}
