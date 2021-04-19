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

        /// Inicia las textbox con numero 0 y el combobox con el operador +
        
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperador.SelectedIndex = 3;
            this.txtNumero1.Text = "0";
            this.txtNumero2.Text = "0";
        }

        /// Toma los numeros de la textbox, el operador de la combobox y realiza la operacion

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string numero1;
            string numero2;
            string operador;
            double resultado;


            numero1 = this.txtNumero1.Text.Replace('.', ',');
            numero2 = this.txtNumero2.Text.Replace('.', ',');
            operador = this.cmbOperador.Text;
            resultado = operar(numero1, numero2, operador);
            this.lblResultado.Text = resultado.ToString();

        }


        /// Restaura los valores por defecto de las cajas de texto
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Text = "0";
            this.txtNumero2.Text = "0";
            this.cmbOperador.SelectedIndex = 3;
            this.lblResultado.ResetText();
            

        }

        /// Cierra el formulario

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// convierte de decimal a binario utilizando el metodo de Numero
        private void btnConvertirABinario_click(object sender, EventArgs e)
        {
            Numero resultado = new Numero();

            this.lblResultado.Text = resultado.DecimalBinario(this.lblResultado.Text);

        }

        /// convierte de binario a decimal utilizando el metodo de Numero

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero resultado = new Numero();

            this.lblResultado.Text = resultado.BinarioDecimal(this.lblResultado.Text);



        }

        /// <summary>
        /// realiza la operacion de dos numeros, llamando al metodo de Calculadora
        /// </summary>
        /// <param name="numero1">numero 1</param>
        /// <param name="numero2">numero 2</param>
        /// <param name="operador">operador aritmetico</param>
        /// <returns></returns>
        private static double operar(string numero1, string numero2, string operador){

            Numero num1;
            Numero num2;
            double resultado;

            num1 = new Numero(numero1);
            num2 = new Numero(numero2);
            resultado = Calculadora.Operar(num1, num2, operador);

            return resultado;
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer salir?","Cerrando", MessageBoxButtons.YesNo) == DialogResult.No){

                e.Cancel = true;

            }
        }
    }
}
