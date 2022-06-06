using Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GliottiCom
{
    public partial class FrmAltaCliente : Form, ITicketCliente
    {
        private List<Cliente> clientes;

        public FrmAltaCliente()
        {
            InitializeComponent();
            //clientes = new List<Cliente>();

            clientes = GestorArchivo<List<Cliente>>.Deserializar($"{AppDomain.CurrentDomain.BaseDirectory}\\ListaDeClientesSerializada.xml");
        }
        public List<Cliente> Clientes
        {
            get
            {
                return this.clientes;
            }
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            this.lblDniError.Visible = false;
            this.lblCelularError.Visible = false;
        }

        /// <summary>
        /// Al confirmar se cargan todos los datos de los textbox en el constructor del cliente para crearlo.
        /// En caso de errores, hay excepciones controladas, como la del dni, o celular erroneo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            PlanMovil planAux = PlanMovil.sinPlan;
            Random idVendedor = new Random();

            try
            {
                foreach (string item in cmbCompania.Items)
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
                Cliente nuevoCliente = new Cliente(this.txtNombre.Text, this.txtApellido.Text, this.txtDni.Text, this.txtCelular.Text, this.cmbCompania.SelectedItem.ToString(), planAux, this.txtDireccion.Text, this.txtMail.Text, idVendedor.Next(1, 50));
                //if (this.clientes + nuevoCliente) //No funciona. 
                this.clientes.Add(nuevoCliente);
                {
                    GestorArchivo<List<Cliente>>.Serializar("ListaDeClientesSerializada.xml", clientes);
                    DialogResult respuesta = MessageBox.Show("Cliente guardado con exito", "Exito!", MessageBoxButtons.OK);
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
        /// Interfaz implementada para que guarde el historial del movimiento del cliente, en este caso al ser un alta
        /// tiene un mensaje personalizado para el alta, con la fecha en la que se generó el movimiento. 
        /// </summary>
        /// <param name="cliente"></param>
        public void ActualizarInfoClientes(Cliente cliente)
        {
            StringBuilder sbInfo = new StringBuilder();
            sbInfo.AppendLine(cliente.MostrarDatosCliente());
            sbInfo.AppendLine($"El cliente {cliente.Nombre} {cliente.Apellido} con dni {cliente.Dni} fue dado de alta el dia {DateTime.Now.ToShortDateString()}");
            if(GestorArchivo<List<Cliente>>.HistorialClientes("HistorialClientes.txt", sbInfo.ToString()))
            {
                MessageBox.Show("Historial guardado con exito", "Exito!");
            }
        }
    }
}
