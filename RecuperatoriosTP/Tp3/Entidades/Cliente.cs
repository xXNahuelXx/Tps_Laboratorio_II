using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public sealed class Cliente
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string numeroCelular;
        private string companiaMovil;
        private PlanMovil plan;
        private string direccion;
        private string mail;
        private int vendedorId;

        /// <summary>
        /// Constructor de cliente por defecto para la serializacion.
        /// </summary>
        public Cliente()
        {

        }

        /// <summary>
        /// Constructor de cliente
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="numeroCelular"></param>
        /// <param name="companiaMovil"></param>
        /// <param name="plan"></param>
        /// <param name="direccion"></param>
        /// <param name="mail"></param>
        /// <param name="vendedorId"></param>
        public Cliente(string nombre, string apellido, string dni, string numeroCelular, string companiaMovil,PlanMovil plan, string direccion, string mail, int vendedorId)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Dni = dni;
            this.NumeroCelular = numeroCelular;
            this.companiaMovil = companiaMovil;
            this.plan = plan;
            this.Direccion = direccion;
            this.Mail = mail;
            this.vendedorId = vendedorId;
        }
        /// <summary>
        /// Propiedad que devuelve y asigna el nombre;
        /// </summary>
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
        /// <summary>
        /// Propiedad que devuelve y asigna el apellido.
        /// </summary>
        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        /// <summary>
        /// Propiedad que devuelve el dni y al momento de asignar lo valido, si no es correcto, lanzo una excepcion.
        /// </summary>
        public string Dni
        {
            get
            {
                return this.dni;
            }

            set
            {
                if (ValidarDni(value))
                {
                    this.dni = value;
                }
                else
                {
                    throw new DniException("Dni invalido! Porfavor verifique que haya ingresado correctamente");
                }
            }
        }

        /// <summary>
        ///  Propiedad que devuelve el numero de celular y al momento de asignar lo valido, si no es correcto, lanzo una excepcion.
        /// </summary>
        public string NumeroCelular
        {
            get
            {
                return numeroCelular;
            }

            set
            {
                if(ValidarNumeroCelular(value))
                {
                    this.numeroCelular = value;
                }
                else
                {
                    throw new NumeroCelularException("Numero invalido, verifique que haya ingresado correctamente");
                }
            }
        }

        /// <summary>
        /// Propiedad que devuelve y asigna la compañia movil.
        /// </summary>
        public string CompaniaMovil
        {
            get
            {
                return companiaMovil;
            }

            set
            {
                companiaMovil = value;
            }
        }

        /// <summary>
        /// Propiedad que devuelve y asigna un plan movil
        /// </summary>
        public PlanMovil Plan
        {
            get
            {
                return plan;
            }
            set
            {
                this.plan = value;
            }
        }

        /// <summary>
        /// Propiedad que devuelve y asigna la direccion.
        /// </summary>
        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        /// <summary>
        /// Propiedad que devuelve y asigna el mail.
        /// </summary>
        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }

        /// <summary>
        /// Propiedad que devuelve y setea el id del vendedor que atendió a este cliente.
        /// </summary>
        public int VendedorId
        {
            get
            {
                return vendedorId;
            }

            set
            {
                vendedorId = value;
            }
        }

        /// <summary>
        /// Metodo que valida que el dni no contenga letras, y no contenga mas o menos de 8 numeros.
        /// </summary>
        /// <param name="dniAValidar"></param>
        /// <returns></returns>
        public static bool ValidarDni(string dniAValidar)
        {
            if(!string.IsNullOrEmpty(dniAValidar))
            {
                foreach (char numero in dniAValidar)
                {
                    if (((numero < '0' || numero > '9') || dniAValidar.Length != 8))
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            
            return true;
        }

        /// <summary>
        /// Metodo que valida que el numero de celular no contenga letras, y no contenga mas o menos de 10 digitos. 
        /// </summary>
        /// <param name="numeroAValidar"></param>
        /// <returns></returns>
        public static bool ValidarNumeroCelular(string numeroAValidar)
        {
            if(!string.IsNullOrEmpty(numeroAValidar))
            {
                foreach (char numero in numeroAValidar)
                {
                    if ((numero < '0' || numero > '9') || numeroAValidar.Length != 10)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Metodo que llama al ToString
        /// </summary>
        /// <returns></returns>
        public string MostrarDatosCliente()
        {
            return this.ToString();
        }

        /// <summary>
        /// Sobrecarga del ToString para que muestre los datos del cliente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"Dni: {this.Dni} ");
            sb.AppendLine($"Celular: {this.NumeroCelular}");
            sb.AppendLine($"Compañia: {this.CompaniaMovil} ");
            sb.AppendLine($"Plan: {this.Plan} ");
            sb.AppendLine($"Direccion: {this.Direccion}");
            sb.AppendLine($"Mail: {this.Mail} ");
            sb.AppendLine($"VendedorId: {this.VendedorId}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador == que devuelve true cuando 2 clientes son iguales al tener el mismo dni.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator == (Cliente c1, Cliente c2)
        {
            return c1.dni == c2.dni;
        }

        /// <summary>
        /// Sobrecarga del operador != indicando cuando 2 clientes no son igules.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        /// <summary>
        /// Sobrecarga del operador + para que me agregue un cliente en la lista si no exite. Devuelve ClienteException 
        /// si le pasan un cliente que ya existe. 
        /// Aunque tuve un problema con este metodo, no con el metodo en si, esta bien codeado y pasó los test
        /// Por alguna razon que desconozco el problema lo trae la lista, nunca entra en el foreach, no se como resolverlo.
        /// Por lo que quedó inutilizado, para continuar con el tp use el Add normal, pero dejo de todas formas el metodo.
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        /// <exception cref="ClienteException"></exception>
        public static bool operator +(List<Cliente> clientes,Cliente c)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente!=c)
                {
                    clientes.Add(c);
                    return true;
                }
                else
                {
                    throw new ClienteException("Este cliente ya existe");
                }
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador - para que quite un cliente de la lista si existe. Devuelve ClienteException si le pasan un 
        /// cliente que no existe.
        /// Mismo problema de arribia.
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        /// <exception cref="ClienteException"></exception>
        public static bool operator -(List<Cliente> clientes, Cliente c)
        {
            foreach (Cliente cliente in clientes)
            {
                if (c == cliente)
                {
                    clientes.Remove(c);
                    return true;
                }
                else
                {
                    throw new ClienteException("No se puede eliminar un cliente que no existe");
                }
            }
            return false;
        }
    }
    /// <summary>
    /// Enumerado con los planes moviles.
    /// </summary>
    public enum PlanMovil
    {
        sinPlan,
        basico,
        avanzado,
        premium
    }
}
