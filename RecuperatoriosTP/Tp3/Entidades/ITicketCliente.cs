using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ITicketCliente
    {
        /// <summary>
        /// Interface que será implementada en los formularios.
        /// </summary>
        /// <param name="cliente"></param>
        public void ActualizarInfoClientes(Cliente cliente);
    }
}
