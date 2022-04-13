using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza la operacion recibida por parametro entre dos numeros.
        /// </summary>
        /// <param name="num1">Numero que se utilizara para la operacion</param>
        /// <param name="num2">Numero que se utilizara para la operacion</param>
        /// <param name="operador">Operador que se utilizara para operar los numeros anteriores</param>
        /// <returns>Retorna el resultado de determinada operacion</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado;

            switch (ValidarOperador(operador))
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                default:
                    resultado = num1 + num2;
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// Valida que el operador recibido sea el correcto, en caso de no serlo por defaul retornara un +.
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns>Retorna el operador + en caso de que el operador recibido sea invalido sino retorna el operador ingresado</returns>
        private static char ValidarOperador(char operador)
        {
            char retorno = operador;
            if (operador != '+' && operador != '-' && operador != '/' && operador != '*')
            {
                retorno = '+';
            }
            return retorno;
        }
    }
}
