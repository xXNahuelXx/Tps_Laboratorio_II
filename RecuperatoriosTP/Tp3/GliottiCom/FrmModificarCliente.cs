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
        private int indiceAuxiliar;
        public FrmModificarCliente()
        {
            InitializeComponent();
            //Levanto el archvio.
            clientes = GestorArchivo<List<Cliente>>.Deserializar($"{AppDomain.CurrentDomain.BaseDirectory}\\ListaDeClientesSerializada.xml");
        }

        /// <summary>
        /// Deshabilito todos los controles para que no pueda modificar nada hasta que no encuentre al cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
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
        }

        /// <summary>
        /// Busca al cliente por id, una vez que lo encuentra, me guardo el indice para poder eliminarlo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarCliente_Click(object sender, EventArgs e)
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
                    if (cliente.Plan == PlanMovil.sinPlan)
                    {
                        this.cmbModPlan.Text = "Sin Plan";
                    }
                    else if (cliente.Plan == PlanMovil.basico)
                    {
                        this.cmbModPlan.Text = "Basico";
                    }
                    else if (cliente.Plan == PlanMovil.avanzado)
                    {
                        this.cmbModPlan.Text = "Avanzado";
                    }
                    else if (cliente.Plan == PlanMovil.premium)
                    {
                        this.cmbModPlan.Text = "Premium";
                    }
                    this.txtModDireccion.Text = cliente.Direccion;
                    this.txtModMail.Text = cliente.Mail;
                    this.btnModificar.Enabled = true;
                    indiceAuxiliar = clientes.IndexOf(cliente);
                    break;
                }
                
            }
            this.clientes.Remove(clientes[indiceAuxiliar]);
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
            PlanMovil planAux = PlanMovil.sinPlan;
            Random idVendedor = new Random();

            try
            {
                foreach (string item in this.cmbModCompania.Items)
                {
                    if (item == "Sin Plan")
                    {
                        planAux = PlanMovil.sinPlan;
                    }
                    else if (item == "Basico")
                    {
                        planAux = PlanMovil.basico;
                    }
                    else if (item == "Avanzado")
                    {
                        planAux = PlanMovil.avanzado;
                    }
                    else if (item == "Premium")
                    {
                        planAux = PlanMovil.premium;
                    }
                }
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
