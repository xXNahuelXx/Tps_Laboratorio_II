using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        /// <summary>
        /// Constructor que setea en la sobrecarga de la clase base los parametros recibidos.
        /// </summary>
        /// <param name="marca">Marca a asignar</param>
        /// <param name="chasis">Chasis a asignar</param>
        /// <param name="color">Color a asignar</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {

        }

        /// <summary>
        /// Propiedad que devuelve el tamaño: SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        /// <summary>
        /// Metodo que dedvuelve los datos del vehiculo de esta clase.
        /// </summary>
        /// <returns>Retorna los datos del vehiculo</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
