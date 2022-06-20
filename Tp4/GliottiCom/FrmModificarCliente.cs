using Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GliottiCom
{
    public partial class FrmModificarCliente : Form, ITicketCliente
    {
        private List<Cliente> clientes;
        private Cliente clienteAux;
        public FrmModificarCliente()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Deshabilito todos los controles para que no pueda modificar nada hasta que no encuentre al cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            //Levanto el archvio.
            try
            {
                clientes = GestorArchivo<List<Cliente>>.Deserializar($"{AppDomain.CurrentDomain.BaseDirectory}\\ListaDeClientesSerializada.xml");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron obtener datos, asegurese de haber dado de alta un cliente para generar el archivo!", "Error");
                clientes = new List<Cliente>();
                this.Close();
            }
            this.txtModNombre.Enabled = false;
            this.txtModApellido.Enabled = false;
            this.txtModDni.Enabled = false;
            this.txtModCelular.Enabled = false;
            this.cmbModCompania.Enabled = false;
            this.cmbModPlan.Enabled = false;
            this.txtModDireccion.Enabled = false;
            this.txtModMail.Enabled = false;
            this.btnGuardarCambios.Enabled = false;
            this.btnModificar.Enabled = false;
            this.lblDniError.Visible = false;
            this.lblCelularError.Visible = false;
            this.cmbModPlan.DataSource = Enum.GetValues(typeof(PlanMovil));
        }

        /// <summary>
        /// Busca al cliente por dni, una vez que lo encuentra, me guardo el cliente en un autributo auxiliar de cliente para luego poder eliminarlo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            bool flag = false;
            try
            {
                if (clientes is not null)
                {
                    foreach (Cliente cliente in this.clientes)
                    {
                        if (this.txtDniClienteABuscar.Text == cliente.Dni)
                        {
                            this.txtModNombre.Text = cliente.Nombre;
                            this.txtModApellido.Text = cliente.Apellido;
                            this.txtModDni.Text = cliente.Dni;
                            this.txtModCelular.Text = cliente.NumeroCelular;
                            this.cmbModCompania.Text = cliente.CompaniaMovil;
                            PlanMovil planAux = (PlanMovil)this.cmbModPlan.SelectedItem;
                            this.txtModDireccion.Text = cliente.Direccion;
                            this.txtModMail.Text = cliente.Mail;
                            this.btnModificar.Enabled = true;
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
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        /// <summary>
        /// Boton que es habilitado una vez que se encontró al cliente, y este a su vez habilita los campos a modificar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.txtModNombre.Enabled = true;
            this.txtModApellido.Enabled = true;
            this.txtModDni.Enabled = true;
            this.txtModCelular.Enabled = true;
            this.cmbModCompania.Enabled = true;
            this.cmbModPlan.Enabled = true;
            this.txtModDireccion.Enabled = true;
            this.txtModMail.Enabled = true;
            this.btnGuardarCambios.Enabled = true;
            this.btnModificar.Enabled = false;
        }

        /// <summary>
        /// Elimina al cliente encontrado y crea uno nuevo con los datos modificado, esta resuelto de esta manera
        /// debido a un error al tratar de appendear.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            Random idVendedor = new Random();
            try
            {
                PlanMovil planAux = (PlanMovil)this.cmbModPlan.SelectedItem;
                _ = this.clientes - this.clienteAux;
                Cliente nuevoCliente = new Cliente(this.txtModNombre.Text, this.txtModApellido.Text, this.txtModDni.Text, this.txtModCelular.Text, this.cmbModCompania.SelectedItem.ToString(), planAux, this.txtModDireccion.Text, this.txtModMail.Text, idVendedor.Next(1, 50));
                this.clientes.Add(nuevoCliente);
                {
                    GestorArchivo<List<Cliente>>.Serializar("ListaDeClientesSerializada.xml", clientes);
                    DialogResult respuesta = MessageBox.Show("Cliente modificado con exito", "Exito!", MessageBoxButtons.OK);
                    if (respuesta == DialogResult.OK)
                    {
                        ActualizarInfoClientes(nuevoCliente);
                        this.Close();
                    }
                }
            }
            catch (ClienteException ex)
            {
                MessageBox.Show($"{ex.Message}\nPruebe con otro Dni", "Error");
            }
            catch (DniException ex)
            {
                this.lblDniError.Visible = true;
                MessageBox.Show($"{ex.Message}\nModifique los datos erroneos", "Error");
            }
            catch (NumeroCelularException ex)
            {
                this.lblCelularError.Visible = true;
                MessageBox.Show($"{ex.Message}\nModifique los datos erroneos", "Error");
            }
            catch (GuardarException ex)
            {
                MessageBox.Show($"{ex.Message}\nReintente, si el problema persiste, reinicie y vuelva a cargar los datos!", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Interfaz implementada para que guarde el historial del movimiento del cliente, en este caso al ser una modificacion
        /// tiene un mensaje personalizado para la modificacion, con la fecha en la que se generó el movimiento. 
        /// </summary>
        /// <param name="cliente"></param>
        public void ActualizarInfoClientes(Cliente cliente)
        {
            StringBuilder sbInfo = new StringBuilder();
            sbInfo.AppendLine(cliente.MostrarDatosCliente());
            sbInfo.AppendLine($"El cliente {cliente.Nombre} {cliente.Apellido} con dni {cliente.Dni} fue modificado el dia {DateTime.Now.ToShortDateString()}");
            if (GestorArchivo<List<Cliente>>.HistorialClientes("HistorialClientes.txt", sbInfo.ToString()))
            {
                MessageBox.Show("Historial guardado con exito", "Exito!");
            }
        }
    }
}
