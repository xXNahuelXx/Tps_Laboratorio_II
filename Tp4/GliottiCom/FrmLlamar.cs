using Entidades;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GliottiCom
{
    public partial class FrmLlamar : Form
    {
        private List<string> listaTelefonos;
        private Random r;
        private TiempoLlamada nuevoReloj;
        private CancellationTokenSource cancel;
        /// <summary>
        /// En este constructor lo que hago es traerme toda la lista de telefonos de la tabla de la base de datos.
        /// Ademas de instanciar los otros atributos que van a ser usados mas tarde.
        /// </summary>
        public FrmLlamar()
        {
            InitializeComponent();
            this.listaTelefonos = GestorSQL.LeerDatos();
            r = new Random();
            nuevoReloj = new TiempoLlamada();
            cancel = new CancellationTokenSource();
        }

        /// <summary>
        /// Genero un indice random, para que me traiga un numero de telefono random de la lista al momento de llamar.
        /// Y luego me genero un hilo secundario, para que simule la llamada activa mientras gestiono al cliente en llamada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLlamar_Load(object sender, EventArgs e)
        {
            int indiceRandom = r.Next(0, listaTelefonos.Count);
            this.lblNumero.Text += listaTelefonos[indiceRandom];
            Task.Run(() =>
         {
             nuevoReloj.IniciarLlamada(cancel);

         }, cancel.Token);

            nuevoReloj.OnNotificar += ImprimirTiempoLlamada;
        }

        /// <summary>
        /// Imprime el tiempo de la llamada en transcurso. 
        /// </summary>
        /// <param name="mensaje"></param>
        private void ImprimirTiempoLlamada(string mensaje)
        {
            if (this.lblDuracion.InvokeRequired)
            {
                Action<string> action = ImprimirTiempoLlamada;
                object[] args = { mensaje };
                this.BeginInvoke(action, args);
            }
            else
            {
                this.lblDuracion.Text = mensaje;
            }

        }

        /// <summary>
        /// El boton cortar cancela el hilo secundario y "finaliza" la llamada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCortar_Click(object sender, EventArgs e)
        {
            this.CerrarHilo();
            this.Close();
        }

        /// <summary>
        /// Cancela el hilo secundario.
        /// </summary>
        private void CerrarHilo()
        {
            cancel.Cancel();
            
        }

        /// <summary>
        /// Me guardo el numero al que estoy llamando para luego poder copiarlo al momento de dar de alta aun cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.lblNumero.Text);
        }

        private void FrmLlamar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.CerrarHilo();
        }
    }
}
