using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calculadora_WF
{
    public partial class calculadora_radio : Form
    {
        char operador;
        double primeiro;
        double segundo;
        bool first;
        bool second;
        char conta;
        public calculadora_radio()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1))
            {
                primeiro = num1;
                first = true;
                label3.Text = "resultado";
            }
            else if (textBox1.Text == "")
            {
                first = false;
                label3.Text = "insira um valor 1°";
            }
            else
            {
                first = false;
                label3.Text = "somente números";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double num2))
            {
                second = true;
                segundo = num2;
                label3.Text = "resultado";
            }
            else if (textBox2.Text == "")
            {
                second = false;
                label3.Text = "falta o 2°";
            }
            else
            {
                second = false;
                label3.Text = "somente números";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                conta = '+';
                label2.Text = conta.ToString();

            }
            ;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                conta = '-';
                label2.Text = conta.ToString();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) 
            {
                conta = '/';
                label2.Text = conta.ToString();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) 
            {
                conta = '*';
                label2.Text = conta.ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                conta = '^';
                label2.Text = conta.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label2.Text = "?";
            label3.Text = "Resultado";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (first && second) 
            {
                switch (conta) 
                {
                    case ('+'):
                        label3.Text = (primeiro + segundo).ToString();
                        break;
                    case '-':
                        label3.Text = (primeiro - segundo).ToString();
                        break;
                    case '*':
                        label3.Text = (primeiro * segundo).ToString();
                        break;
                    case '/':
                        if (segundo != 0)
                        {
                            label3.Text = (primeiro / segundo).ToString();
                        }
                        else 
                        {
                            label3.Text = "divisão por zero";
                        }
                        break;
                    case '^':
                        label3.Text = Math.Pow(primeiro, segundo).ToString();
                        break;
                    default:
                        label3.Text = (first, second).ToString();
                        break;
                }
            }
            else 
            {
                label3.Text = "Apenas valores válidos";
            }
        }
    }
}
