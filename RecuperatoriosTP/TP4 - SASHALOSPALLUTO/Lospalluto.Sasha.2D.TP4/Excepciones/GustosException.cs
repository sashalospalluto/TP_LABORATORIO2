using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TEMA 15
namespace Excepciones
{
    public class GustosException : Exception
    {
        public GustosException() :base("Demasiados gustos para el tipo de producto")
        {

        }

        public GustosException(string message) :base(message)
        {

        }
    }
}
