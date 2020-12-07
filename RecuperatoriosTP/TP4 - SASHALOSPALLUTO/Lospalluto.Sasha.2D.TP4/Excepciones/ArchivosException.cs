using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TEMA 15

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        public ArchivosException(Exception innerException) : base("ocurrio un error", innerException)
        {

        }

        public ArchivosException() : base("ocurrio un error")
        {

        }

        public ArchivosException(string message) : base(message)
        {

        }
    }
}
