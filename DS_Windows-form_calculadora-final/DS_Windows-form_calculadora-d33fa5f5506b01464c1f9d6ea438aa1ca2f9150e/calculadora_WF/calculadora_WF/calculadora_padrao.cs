using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_WF
{
    public partial class calculadora_padrao : Form
    {
        decimal submisso;
        decimal vNumAnta;
        string vOperacao = "";
        bool vLimparVisor;
        decimal vnumatual;
        public calculadora_padrao()
        {
            InitializeComponent();
        }

        //private void F_digitos(object sender, EventArgs e)
        //{
        //    if (((Button)sender).Text == "-")
        //    {
        //        submisso = decimal.Parse(lblvisor.Text);
        //    }
        //    string digito = ((Button)sender).Text;
        //    if (lblvisor.Text == "0" || vLimparVisor) 
        //    {
        //        lblvisor.Text = "";
        //        vLimparVisor = false;
        //    }
        //    lblvisor.Text += digito;
        //    this.ActiveControl = null;
        //    submisso = decimal.Parse(lblvisor.Text);
        //    label1.Text = submisso.ToString();
        //}
        private void F_digitos(object sender, EventArgs e)
        {
            ExecutarDigito(((Button)sender).Text);
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla é numérica
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                string digito = (e.KeyCode - Keys.D0).ToString();
                ExecutarDigito(digito);
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                string digito = (e.KeyCode - Keys.NumPad0).ToString();
                ExecutarDigito(digito);
            }
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                ExecutarDigito("-");
            }
        }

        private void ExecutarDigito(string digito)
        {
            if (digito == "-")
            {
                submisso = decimal.Parse(lblvisor.Text);
            }

            if (lblvisor.Text == "0" || vLimparVisor)
            {
                lblvisor.Text = "";
                vLimparVisor = false;
            }

            lblvisor.Text += digito;
            this.ActiveControl = null;
            submisso = decimal.Parse(lblvisor.Text);
            label1.Text = submisso.ToString();
        }

        private void F_operacoes(object sender, EventArgs e)
        {
            if (lblvisor.Text == "dividiu por zero :(")
            {
                lblvisor.Text = "0";
            }
            vNumAnta = decimal.Parse(lblvisor.Text);
            vOperacao = ((Button)sender).Text;
            vLimparVisor = true;
            lblhist.Text = "";
            lblhist.Text = vNumAnta + " " + vOperacao + " ";
            lblvisor.Focus();
        }
        private void Botao_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.Gray; // cor enquanto pressionado
            }
        }

        private void Botao_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = SystemColors.Control; // volta para cor padrão
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!lblvisor.Text.Contains(","))
            {
                lblvisor.Text += ",";
            }
        }

        private void calculadora_padrao_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (vOperacao != "") 
            {
                decimal vnumatual = decimal.Parse(lblvisor.Text);
                lblhist.Text = "";
                lblhist.Text = vNumAnta + " " + vOperacao + " " + submisso + " " + "=";
                switch (vOperacao)
                {
                    case "+":
                        vNumAnta = (vNumAnta + submisso);
                        lblvisor.Text = (vNumAnta).ToString();
                        break;
                    case "-":
                        vNumAnta = (vNumAnta - submisso);
                        lblvisor.Text = (vNumAnta).ToString();
                        break;
                    case "*":
                        vNumAnta = (vNumAnta * submisso);
                        lblvisor.Text = (vNumAnta).ToString();
                        break;
                    case "/":
                        try
                        {
                            vNumAnta = (vNumAnta / submisso);
                            lblvisor.Text = (vNumAnta).ToString();
                        }
                        catch (DivideByZeroException)
                        {
                            lblhist.Text = "dividiu por zero";
                            lblvisor.Text = "0";
                        }
                        break;
                    case "^":
                        vNumAnta = Convert.ToDecimal((Math.Pow(decimal.ToDouble(vNumAnta), decimal.ToDouble(submisso))));
                        lblvisor.Text = (vNumAnta).ToString();
                        break;
                
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            lblvisor.Text = lblvisor.Text.Substring(0, lblvisor.Text.Length - 1);
            if (lblvisor.Text == "")
            {
                lblvisor.Text = "0";
                if(lblvisor.Text == "0") 
                {
                    lblhist.Text = "";
                }
            }
        }

        private void calculadora_padrao_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            vNumAnta = 0;
            vnumatual = 0;
            vOperacao = "";
            lblhist.Text = "";
            lblvisor.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lblvisor.Text = "0";
            submisso = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!lblvisor.Text.Contains("-") && lblvisor.Text != "0")
            {
                lblvisor.Text = "-" + lblvisor.Text;
            }
            else if (lblvisor.Text.Contains("-") && lblvisor.Text != "0")
            {
                lblvisor.Text = lblvisor.Text.Replace("-".ToString(), "");
            }
            
        }

        private void calculadora_padrao_KeyDown_1(object sender, KeyEventArgs e)
        {
           // BackColor = Color.DarkGray;
            //ForeColor = Color.White;
        }

        private void calculadora_padrao_Load_1(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
