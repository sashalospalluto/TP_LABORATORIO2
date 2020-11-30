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

        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();

            lblResultado.Text = numero.DecimalBinario(lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();
            lblResultado.Text = numero.BinarioDecimal(lblResultado.Text);
        }
                
        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text)).ToString();
        }

        /// <summary>
        /// Limpia todos los TextBox, ComboBox y Label de la calculadora.
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.SelectedIndex = 4;
            lblResultado.Text = "";
            //cmbOperador.Items.Clear();
            //cmbOperador.ResetText();
            
        }

        /// <summary>
        /// Realiza la operacion aritmetica entre 2 numeros
        /// </summary>
        /// <param name="numero1">primer numero a operar</param>
        /// <param name="numero2">segundo numero a operar</param>
        /// <param name="operador">Devuelve el resultado de la operacion aritmetica</param>
        /// <returns></returns>
        private static double Operar (string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            double resultadoOperacion;
            Random rnd = new Random();
            
            if (string.IsNullOrEmpty(operador))
            {
                operador = "0";
            }
            
            resultadoOperacion = Calculadora.Operar(num1, num2, Convert.ToChar(operador));

            return resultadoOperacion;
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; //no deja que se cierre el boton
            }
        }
    }
}
