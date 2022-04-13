using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Constructor por defecto que asigna como valor 0 para el atributo numero de la clase.
        /// </summary>
        public Operando() : this(0)
        {

        }

        /// <summary>
        /// Constructor que setea el numero de tipo double recibido por parametro al atributo numero.
        /// </summary>
        /// <param name="numero">Numero a setear en el atributo.</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que setea el numero de tipo string recibido por parametro a traves de la propiedad Numero.
        /// </summary>
        /// <param name="strNumero">Numero a setear en el atributo</param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Propiedad que setea el valor recibido en el atributo Numero, a su vez se hace uso del metodo que valida el operando.
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// Valida que el operando recibido sea numerico. 
        /// </summary>
        /// <param name="strNumero">Numero de tipo string a validar.</param>
        /// <returns>Retorna 0 en caso de que el numero recibido no sea de tipo numerico, si este es correcto lo parsea double y lo devuelve.</returns>
        private double ValidarOperando(string strNumero)
        {
            foreach (char item in strNumero)
            {
                if (item < '0' || item > '9')
                {
                    return 0;
                }
            }
            double.TryParse(strNumero.Replace('.', ','), out numero); //Parsea y remplaza el punto (.) por la coma (,).
            return numero;
        }

        /// <summary>
        /// Valida que lo recibido sea binario.
        /// </summary>
        /// <param name="binario">Numero binario recibido por parametro en formato string a validar.</param>
        /// <returns>Retorna false en caso de que no sea binario y true si lo es.</returns>
        private bool EsBinario(string binario)
        {
            foreach (char binarioavalidar in binario)
            {
                if (binarioavalidar != '0' && binarioavalidar != '1')
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Realiza la conversion de un numero binario de tipo string en decimal.
        /// </summary>
        /// <param name="binario">Numero binario recibido por parametro de tipo string a convertir.</param>
        /// <returns>Retorna el numero en tipo string convertido en decimal, en caso de que no se haya podido retorna "Valor Invalido".</returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = null;
            double acum = 0;
            double expo = binario.Length - 1;

            if (EsBinario(binario))
            {
                foreach (char auxNum in binario)
                {
                    if (auxNum == '1')
                    {
                        acum += Math.Pow(2, expo);
                    }
                    expo--;
                }
                retorno = acum.ToString();
            }
            else
            {
                retorno = "Valor Invalido";
            }

            return retorno;
        }

        /// <summary>
        /// Realiza la conversion de un numero decimal a binario.
        /// </summary>
        /// <param name="numero">Numero recibido por parametro a convertir.</param>
        /// <returns>Retorna el numero de tipo string convertido en binario, en caso de que no se haya podido retorna "Valor Invalido".</returns>
        public string DecimalBinario(double numero)
        {
            string cadena = null;
            int auxNumero = (int)numero;
            if (auxNumero > 0)
            {
                while (auxNumero > 0)
                {
                    if (auxNumero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    auxNumero = auxNumero / 2;
                }
            }
            else
            {
                cadena = "Valor Invalido";
            }
            return cadena;
        }

        /// <summary>
        /// Realiza la conversion de un numero decimal a binario.
        /// </summary>
        /// <param name="numero">Numero recibido por parametro de tipo string a convertir.</param>
        /// <returns>Retorna el numero de tipo string convertido en binario, en caso de que no se haya podido retorna "Valor Invalido".</returns>
        public string DecimalBinario(string numero)
        {
            string cadena = null;
            double auxNumero;
            if (double.TryParse(numero, out auxNumero))
            {
                cadena = DecimalBinario(auxNumero);
            }
            else
            {
                cadena = "Valor Invalido";
            }
            return cadena;
        }

        /// <summary>
        ///  Sobrecarga del operador - para que pueda restar dos objetos de tipo Operando.
        /// </summary>
        /// <param name="n1">Objeto de tipo Operando.</param>
        /// <param name="n2">Objeto de tipo Operando</param>
        /// <returns>Retorna el resultado de la resta entre estos dos.</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        ///  Sobrecarga del operador * para que pueda multiplicar dos objetos de tipo Operando.
        /// </summary>
        /// <param name="n1">Objeto de tipo Operando.</param>
        /// <param name="n2">Objeto de tipo Operando</param>
        /// <returns>Retorna el resultado de la multiplicacion entre estos dos.</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        ///  Sobrecarga del operador / para que pueda dividir dos objetos de tipo Operando.
        /// </summary>
        /// <param name="n1">Objeto de tipo Operando.</param>
        /// <param name="n2">Objeto de tipo Operando</param>
        /// <returns>Retorna el resultado de la division entre estos dos.</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }

        /// <summary>
        ///  Sobrecarga del operador + para que pueda sumar dos objetos de tipo Operando.
        /// </summary>
        /// <param name="n1">Objeto de tipo Operando.</param>
        /// <param name="n2">Objeto de tipo Operando</param>
        /// <returns>Retorna el resultado de la suma entre estos dos.</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
    }
}
