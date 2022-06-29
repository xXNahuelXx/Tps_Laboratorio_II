using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase DniException que será lanzada cuando el dni ingresado no cumpla con los requisitos.  
    /// </summary>
    public class DniException : Exception
    {
        public DniException(string message) : base(message)
        {

        }

        public DniException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
