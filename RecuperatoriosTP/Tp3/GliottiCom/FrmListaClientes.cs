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

        private void rtbListadoClientes_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            List<Cliente> clientes = GestorArchivo<List<Cliente>>.Deserializar($"{AppDomain.CurrentDomain.BaseDirectory}\\ListaDeClientesSerializada.xml");
            foreach (Cliente item in clientes)
            {
                this.rtbListadoClientes.Text += item.MostrarDatosCliente();
            }
        }
    }
}
