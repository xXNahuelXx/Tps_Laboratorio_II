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
        
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
        }

        private void Limpiar()
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.cmbOperador.Text = string.Empty;
            this.lblResultado.Text = 0.ToString();
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.btnConvertirABinario.Enabled = false;
            this.lblResultado.Text = new Operando().DecimalBinario(this.lblResultado.Text);
            this.btnConvertirADecimal.Enabled = true;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.btnConvertirADecimal.Enabled = false;
            this.lblResultado.Text = new Operando().BinarioDecimal(this.lblResultado.Text);
            this.btnConvertirABinario.Enabled = true;
        }

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
            if (this.lblResultado.Text == double.MinValue.ToString()) //Valida que si en el label recibe un MinValue producto del intento de una division por 0, muestre por pantalla un mensaje mas amigable al usuario.
            {
                this.lblResultado.Text = string.Empty;
                MessageBox.Show("No se puede dividir por 0", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lstOperaciones.Items.Add($"{this.txtNumero1.Text} {cmbOperador.SelectedItem.ToString()} {this.txtNumero2.Text} = {resultado}"); //En caso de que todo esté correcto, agrega al listBox la operacion hecha.
            }
        }
    }
}
