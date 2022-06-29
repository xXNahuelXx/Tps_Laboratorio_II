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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            FrmListaClientes frmListaClientes = new FrmListaClientes();
            frmListaClientes.ShowDialog();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            FrmAltaCliente frmAltaCliente = new FrmAltaCliente();
            frmAltaCliente.ShowDialog();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            FrmModificarCliente frmModCliente = new FrmModificarCliente();
            frmModCliente.ShowDialog();
        }

        private void btnBajaCliente_Click(object sender, EventArgs e)
        {
            FrmBajaCliente frmBajaCliente = new FrmBajaCliente();
            frmBajaCliente.ShowDialog();
        }
    }
}
