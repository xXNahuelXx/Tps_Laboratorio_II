using Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GliottiCom
{
    public partial class FrmBajaCliente : Form, ITicketCliente
    {
        private List<Cliente> clientes;
        private Cliente clienteAux;
        public FrmBajaCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Deserializo la lista de clientes de un archivo, si el archivo no existe lanzo una excepcion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            this.lblDniError.Visible = false;
            this.lblCelularError.Visible = false;
            this.cmbBajaPlan.DataSource = Enum.GetValues(typeof(PlanMovil));
            try
            {
                clientes = GestorArchivo<List<Cliente>>.Deserializar($"{AppDomain.CurrentDomain.BaseDirectory}\\ListaDeClientesSerializada.xml");
            }
            catch(Exception)
            {
                MessageBox.Show("No se pudieron obtener datos, asegurese de haber dado de alta un cliente para generar el archivo!", "Error");
                clientes = new List<Cliente>();
                this.Close();
            }
        }

        /// <summary>
        /// Metodo que busca a un cliente por documento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            bool flag = false;
            try
            {
                if (this.clientes is not null)
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
                            PlanMovil planAux = (PlanMovil)this.cmbBajaPlan.SelectedItem;
                            this.txtBajaDireccion.Text = cliente.Direccion;
                            this.txtBajaMail.Text = cliente.Mail;
                            clienteAux = cliente;
                            flag = true;
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        throw new ClienteException("No existe el cliente");
                    }
                }
            }
            catch (ClienteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Metodo que elimina a un cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteAux is not null)
                {
                    DialogResult respuesta = MessageBox.Show("Esta seguro?", "Cuidado", MessageBoxButtons.YesNo);
                    {
                        if (respuesta == DialogResult.Yes)
                        {
                            _ = this.clientes - clienteAux;
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
                else
                {
                    throw new ClienteException("No se pudo eliminar");
                }
            }
            catch(ClienteException ex)
            {
                MessageBox.Show(ex.Message);
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
