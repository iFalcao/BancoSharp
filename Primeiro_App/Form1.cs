using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiro_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeTitular = nomeBox.Text;
            int numConta = int.Parse(contaBox.Text);
            double saldo = double.Parse(saldoBox.Text);
            Conta nova = new Conta(numConta, nomeTitular, saldo);
            MessageBox.Show("Conta número: " + numConta
                            + "\n Titular: " + nomeTitular
                            + "\n Saldo: " + saldo);
            Opcoes telaOpcoes = new Opcoes();
            telaOpcoes.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
