using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public NumberStyles CultureInfo { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textResult.Text);
            decimal resultado = 0;

            switch (operacao) 
            {
                case "soma":
                    resultado = valor1 + valor2;
                    break;
                case "subtracao":
                    resultado = valor1 - valor2;
                    break;
                case "divisao":
                    resultado = valor1 / valor2;
                    break;
                case "multiplicacao":
                    resultado = valor1 * valor2;
                    break;
            }

            textResult.Text = Convert.ToString(resultado);
        }


        private void textResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textResult.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textResult.Text += "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textResult.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textResult.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textResult.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textResult.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textResult.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textResult.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textResult.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textResult.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textResult.Text += ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textResult.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResult.Text);
            textResult.Text = "";
            operacao = "subtracao";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResult.Text);
            textResult.Text = "";
            operacao = "multiplicacao";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResult.Text);
            textResult.Text = "";
            operacao = "divisao";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResult.Text);
            textResult.Text = "";
            operacao = "soma";
        }
    }
}
