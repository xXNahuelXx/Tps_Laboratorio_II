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
    public partial class FrmBajaCliente : Form, ITicketCliente
    {
        private List<Cliente> clientes;
        private int indiceCliente;
        public FrmBajaCliente()
        {
            InitializeComponent();
        }

        private void FrmBajaCliente_Load(object sender, EventArgs e)
        {
            this.txtBajaNombre.Enabled = false;
            this.txtBajaApellido.Enabled = false;
            this.txtBajaDni.Enabled = false;
            this.txtBajaCelular.Enabled = false;
            this.cmbBajaCompania.Enabled = false;
            this.cmbBajaPlan.Enabled = false;
            this.txtBajaDireccion.Enabled = false;
            this.txtBajaMail.Enabled = false;
            clientes = GestorArchivo<List<Cliente>>.Deserializar($"{AppDomain.CurrentDomain.BaseDirectory}\\ListaDeClientesSerializada.xml");
        }

        /// <summary>
        /// Metodo que busca a un cliente por documento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            foreach (Cliente cliente in this.clientes)
            {
                if (this.txtDniClienteABuscar.Text == cliente.Dni)
                {
                    this.txtBajaNombre.Text = cliente.Nombre;
                    this.txtBajaApellido.Text = cliente.Apellido;
                    this.txtBajaDni.Text = cliente.Dni;
                    this.txtBajaCelular.Text = cliente.NumeroCelular;
                    this.cmbBajaCompania.Text = cliente.CompaniaMovil;
                    if (cliente.Plan == PlanMovil.sinPlan)
                    {
                        this.cmbBajaPlan.Text = "Sin Plan";
                    }
                    else if (cliente.Plan == PlanMovil.basico)
                    {
                        this.cmbBajaPlan.Text = "Basico";
                    }
                    else if (cliente.Plan == PlanMovil.avanzado)
                    {
                        this.cmbBajaPlan.Text = "Avanzado";
                    }
                    else if (cliente.Plan == PlanMovil.premium)
                    {
                        this.cmbBajaPlan.Text = "Premium";
                    }
                    this.txtBajaDireccion.Text = cliente.Direccion;
                    this.txtBajaMail.Text = cliente.Mail;
                    indiceCliente = clientes.IndexOf(cliente);
                    break;
                }
            }
        }

        /// <summary>
        /// Metodo que elimina a un cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente clienteAux = null;
            DialogResult respuesta = MessageBox.Show("Esta seguro?", "Cuidado",MessageBoxButtons.YesNo);
            {
                if (respuesta == DialogResult.Yes)
                {
                    clienteAux = clientes[indiceCliente];
                    this.clientes.Remove(clientes[indiceCliente]);
                    GestorArchivo<List<Cliente>>.Serializar("ListaDeClientesSerializada.xml", clientes);
                    DialogResult respuesta2 = MessageBox.Show("Cliente eliminado con exito", "Exito!", MessageBoxButtons.OK);
                    if (respuesta2 == DialogResult.OK)
                    {
                        ActualizarInfoClientes(clienteAux);
                        this.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Interfaz implementada para que guarde el historial del movimiento del cliente, en este caso al ser una baja
        /// tiene un mensaje personalizado para la baja, con la fecha en la que se generó el movimiento. 
        /// </summary>
        /// <param name="cliente"></param>
        public void ActualizarInfoClientes(Cliente cliente)
        {
            StringBuilder sbInfo = new StringBuilder();
            sbInfo.AppendLine(cliente.MostrarDatosCliente());
            sbInfo.AppendLine($"El cliente {cliente.Nombre} {cliente.Apellido} con dni {cliente.Dni} fue dado de baja el dia {DateTime.Now.ToShortDateString()}");
            if (GestorArchivo<List<Cliente>>.HistorialClientes("HistorialClientes.txt", sbInfo.ToString()))
            {
                MessageBox.Show("Historial guardado con exito", "Exito!");
            }
        }
    }
}
