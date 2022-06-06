using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DniException : Exception
    {
        //Cuando se busque por un dni que no exista
        //Cuando se agregue un empleado con un numero de dni > 8 || < 8
        public DniException(string message) : base(message)
        {

        }

        public DniException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
