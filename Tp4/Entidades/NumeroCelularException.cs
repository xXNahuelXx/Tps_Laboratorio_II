using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase NumeroCelularException que va a ser utilizada cuando el numero ingresado no cumpla con los requisitos.
    /// </summary>
    public class NumeroCelularException : Exception
    {
        public NumeroCelularException(string message) : base(message)
        {
        }

        public NumeroCelularException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
