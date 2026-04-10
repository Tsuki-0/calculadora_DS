using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace calculadora_WF
{
    public partial class MDI : Form
    {
        private void AbrirForm<T>() where T : Form, new()
        {
            Form formularioExistente = Application.OpenForms
                .OfType<T>()
                .FirstOrDefault();

            if (formularioExistente == null)
            {
                T novoForm = new T();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
            else
            {
                formularioExistente.BringToFront();
            }
        }

        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }

        private void MDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(
                "Deseja realmente encerrar o programa?",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes) 
            {
                e.Cancel = false;
            } 
            else
            {
                e.Cancel = true;
            }
        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm<calculadora_botoes>();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statime.Text = DateTime.Now.ToString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void comRadioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm<calculadora_radio>();
        }

        private void janelasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cascatasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);

        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("NotePad");
        }

        private void navegadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Firefox");
        }

        private void comVisorÚnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm<calculadora_padrao>();
        }
    }
}
