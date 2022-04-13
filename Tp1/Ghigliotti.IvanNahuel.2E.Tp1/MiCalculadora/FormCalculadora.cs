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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Constructor por defecto de FormCalculadora.
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento del Form que al iniciar la aplicacion hace uso del metodo Limpiar deshabilita el uso de los botones de conversion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
        }

        /// <summary>
        /// Limpia los textBox y label de la pantalla, ademas inhabilita los botones de conversion.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.cmbOperador.Text = string.Empty;
            this.lblResultado.Text = 0.ToString();
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
        }

        // <summary>
        /// Hace uso del metodo Limpiar cuando se preciona este boton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Se hace uso del metodo Operar de la clase Calculadora para que realice una operacion matematica entre dos numeros. 
        /// Tambien se le pasa el operador para que sepa que operacion realizar.
        /// </summary>
        /// <param name="numero1">Numero que se recibe mediante el txtOperando1</param>
        /// <param name="numero2">Numero que se recibe mediante el txtOperando2</param>
        /// <param name="operador">Operador que se recibe mediante el cmbOperador</param>
        /// <returns>Retorna el resultado de la operacion realizada.</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            char auxOperador;
            double resultado = 0;
            if (numero1 != null && numero2 != null && operador != null)
            {
                char.TryParse(operador, out auxOperador);
                Operando operando1 = new Operando(numero1);
                Operando operando2 = new Operando(numero2);
                resultado = Calculadora.Operar(operando1, operando2, auxOperador);
            }
            return resultado;
        }

        /// <summary>
        /// Al apretar el boton pregunta al usuario si quiere salir de la aplicacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Boton que hace uso del metodo para convertir el numero recibido del label en binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.btnConvertirABinario.Enabled = false;
            this.lblResultado.Text = new Operando().DecimalBinario(this.lblResultado.Text);
            this.btnConvertirADecimal.Enabled = true;
        }

        /// <summary>
        /// Boton que hace uso del metodo para convertir el numero recibido del label en decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.btnConvertirADecimal.Enabled = false;
            this.lblResultado.Text = new Operando().BinarioDecimal(this.lblResultado.Text);
            this.btnConvertirABinario.Enabled = true;
        }

        /// <summary>
        /// Evento del Form que al querer cerrar la aplicacion pregunte al usuario si realmente  quiere hacerlo. Si asi lo desea, se cierra la aplicacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                this.Dispose();
            }
        }

        /// <summary>
        /// Hace uso del metodo Operar de la clase FormCalculadora, el resultado lo muestra a treaves del Label y guarda la operacion realizada en el listBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, cmbOperador.SelectedItem.ToString());
            this.lblResultado.Text = resultado.ToString();

            this.btnConvertirABinario.Enabled = false; //Se deshabilitan ambos conversores...
            this.btnConvertirADecimal.Enabled = false; //...para que el usuario no pueda hacer uso de ellos en caso de que no se cumplan las validaciones a continuacion.

            if (this.cmbOperador.SelectedItem.ToString() == string.Empty) //Valida que si el item seleccionado del comboBox es vacio, por defecto se seleccione el +.
            {
                this.cmbOperador.SelectedItem = "+";
            }
            if (this.txtNumero1.Text == string.Empty || this.txtNumero1.Text == " ") //Valida que si el textBox del Operando1 es vacio se reemplace con un 0.
            {
                this.txtNumero1.Text = "0";
            }
            if (this.txtNumero2.Text == string.Empty || this.txtNumero2.Text == " ") //Valida que si el textBox del Operando2 es vacio se reemplace con un 0.
            {
                this.txtNumero2.Text = "0";
            }
            if (this.lblResultado.Text != "0") //Valida que si el label no es 0, habilite el boton de conversion, ya que si el valor es 0, no se puede convertir en binario.
            {
                this.btnConvertirABinario.Enabled = true;
            }
            else
            {
                lstOperaciones.Items.Add($"{this.txtNumero1.Text} {cmbOperador.SelectedItem.ToString()} {this.txtNumero2.Text} = {resultado}"); //En caso de que todo esté correcto, agrega al listBox la operacion hecha.
            }
        }
    }
}
