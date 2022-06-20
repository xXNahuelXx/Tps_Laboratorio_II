using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MiExtensionInt
    {
        /// <summary>
        /// Metodo de extension que devuelve la cantidad total de clientes.
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="clientes"></param>
        /// <returns></returns>
        public static int CantidadTotalDeClientes(this int cantidad, List<Cliente> clientes)
        {
            return clientes.Count;
        }
    }
}
