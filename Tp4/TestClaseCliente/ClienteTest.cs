using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestClaseCliente
{
    [TestClass]
    public class ClienteTest
    {
        /// <summary>
        /// Metodo de testeo que verifica que el metodo ValidarDni esté escrito correctamente.
        /// </summary>
        [TestMethod]
        public void ValidarDni_CuandoElDniContengaCifrasDistintasAOchoYCuandoContengaLetras_DevolveraFalseCuandoSeaIncorrecto()
        {
            string dniAValidar = "41068f41";

            bool actual = Cliente.ValidarDni(dniAValidar);

            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Metodo de testeo que verifica que el metodo ValidarNumeroCelular esté escrito correctamente.
        /// </summary>
        [TestMethod]
        public void ValidarNumeroCelular_CuandoElNumeroContengaLetrasOSeaMayorOMenorA10Cifras_DevolveraFlaseCuandoSeaIncorrecto()
        {
            string numeroAValidar = "115412f198";

            bool actual = Cliente.ValidarNumeroCelular(numeroAValidar);

            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Metodo de testeo que verifica que al momento de instanciar mal un cliente con un dni erroneo, lance una excepcion del tipo DniException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DniException))]
        public void CuandoInstancioUnClienteConDniMalIngresado_DevuelveUnaDniException()
        {
            Cliente c = new Cliente("Nahuel", "Ghigliotti", "41026g81", "1154124119", "Claro", PlanMovil.sinPlan, "Fafa", "efwe", 3);

        }

        /// <summary>
        /// Metodo de testeo que verifica que al momento de instanciar mal un cliente con un numero de celular erroneo, lance una excepcion del tipo NumeroCelularException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NumeroCelularException))]
        public void CuandoInstancioUnClienteConNumeroDeCelularMalIngresado_DevuelveUnaNumeroCelularException()
        {
            Cliente c = new Cliente("Nahuel", "Ghigliotti", "41026881", "115412 89", "Claro", PlanMovil.sinPlan, "Fafa", "efwe", 3);
        }

        /// <summary>
        /// Metodo que devuelve ClienteException cuando quiero añadir a la lista un cliente ya existente (mismo dni).
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ClienteException))]
        public void ComprobarQueNoExistaElClienteAlMomentoDeCrearlo_DevulveClienteException()
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente c = new Cliente("Nahuel", "Ghigliotti", "41026881", "1154124119", "Claro", PlanMovil.sinPlan, "Fafa", "efwe", 3);
            clientes.Add(c);
            Cliente c1 = new Cliente("Charlie", "Mason", "41026881", "1154134119", "Personal", PlanMovil.premium, "erger", "ergerg", 2);
            _=clientes + c1;
        }

        /// <summary>
        /// Metodo que testea si puedo agregar un cliente a la lista.
        /// </summary>
        [TestMethod]
        public void ComprobarQuePuedaAgregarUnClienteALaListaDeClientes_DevuelveTrueSiPudo()
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente c = new Cliente("Nahuel", "Ghigliotti", "41026881", "1154124119", "Claro", PlanMovil.sinPlan, "Fafa", "efwe", 3);
            bool actual = clientes + c;
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Metodo que testea si puedo quitar un cliente de la lista.
        /// </summary>
        [TestMethod]
        public void ComprobarQuePuedaQuitarUnClienteDeLaListaDeClientes_DevuelveTrueSiPudo()
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente c = new Cliente("Nahuel", "Ghigliotti", "41026881", "1154124119", "Claro", PlanMovil.sinPlan, "Fafa", "efwe", 3);
            _ = clientes + c;

            bool actual = clientes - c;

            Assert.IsTrue(actual);
        }
    }
}
