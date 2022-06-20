using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GliottiCom
{
    public partial class LeprechaunAssistant : Form
    {

        public LeprechaunAssistant()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.ShowDialog();
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            FrmLlamar frmLlamar = new FrmLlamar();
            frmLlamar.Show();
        }
    }
}