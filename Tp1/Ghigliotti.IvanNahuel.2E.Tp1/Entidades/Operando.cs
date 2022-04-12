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

        public Operando() : this(0)
        {

        }

        public Operando(double numero) : this(numero.ToString())
        {

        }

        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);

            }
        }

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

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
    }
}
