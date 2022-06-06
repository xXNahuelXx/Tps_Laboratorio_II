using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase GuardarException que va a ser utilizada cuando no se pueda guardar algun tipo de archivo.
    /// </summary>
    public class GuardarException : Exception
    {
        public GuardarException(string message) : base(message)
        {
        }

        public GuardarException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
