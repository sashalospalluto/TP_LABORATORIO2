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

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
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

            resultadoOperacion = Calculadora.Operar(num1, num2, operador);

            return resultadoOperacion;
        }
    }
}
