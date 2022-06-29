using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        /// <summary>
        /// Enumerados de las marcas de los vehiculos, con valor de 0 a 6 por defecto.
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }

        /// <summary>
        /// Enumerados de los tamaños de los vehiculos, con valor por defecto de 0 a 2.
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        //Atributos
        private string chasis;
        private ConsoleColor color;
        private EMarca marca;

        public Vehiculo(string chasis,EMarca marca,ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get;}

        /// <summary>
        /// Realiza el casteo explicito y publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        /// <summary>
        /// Realiza la sobracarga del tipo de dato string para que muestre los datos del vehiculo cuando se requiera castear.
        /// </summary>
        /// <param name="p">Recbe un vehiculo para luego ser mostrado</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"CHASIS: {p.chasis}\r\n");
            sb.Append($"MARCA : {p.marca}\r\n");
            sb.Append($"COLOR : {p.color}\r\n");
            sb.AppendLine("---------------------");
            sb.Append($"\nTAMAÑO : {p.Tamanio}\r");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (!(v1 is null) && !(v2 is null))
            {
                return string.Compare(v1.chasis, v2.chasis) == 0;
            }

            return false;
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
