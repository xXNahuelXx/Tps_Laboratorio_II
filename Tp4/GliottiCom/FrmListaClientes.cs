using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace GliottiCom
{
    public partial class FrmListaClientes : Form
    {
        public FrmListaClientes()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Trato de hacer la deserializacion del archivo, si el archivo no existe, lanzo una excepcion y aviso de crear uno dando de alta un cliente.
        /// Si el archivo existe muestro el listado de clientes. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> clientes = GestorArchivo<List<Cliente>>.Deserializar($"{AppDomain.CurrentDomain.BaseDirectory}\\ListaDeClientesSerializada.xml");
                foreach (Cliente item in clientes)
                {
                    int cantidad = 0; 
                    this.rtbListadoClientes.Text += item.MostrarDatosCliente();
                    this.lblCantidad.Text = $"{cantidad.CantidadTotalDeClientes(clientes)}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }
    }
}
