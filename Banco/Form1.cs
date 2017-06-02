using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private List<Conta> contas;
        public Conta contaAtual;
        public Conta contaDestinatario;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new List<Conta>();

            Conta c1 = new ContaPoupanca(1);
            c1.cliente = new Cliente("Icaro");
            c1.Saldo = 14500.00;
            this.AdicionaConta(c1);

            Conta c2 = new ContaCorrente(2);
            c2.cliente = new Cliente("Teste");
            c2.Saldo = 1250.00;
            this.AdicionaConta(c2);

            Conta c3 = new ContaPoupanca(3);
            c3.cliente = new Cliente("José");
            c3.Saldo = 5250.25;
            this.AdicionaConta(c3);
        }

        public void AdicionaConta(Conta contaCriada)
        {
            this.contas.Add(contaCriada);
            comboContas.Items.Add(contaCriada.cliente.Nome);
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            double valorDigitado = double.Parse(valorBox.Text);
            contaAtual.Depositar(valorDigitado);
            saldoLabel.Text = contaAtual.Saldo.ToString();
            valorBox.Text = "";
        }

        private void botaoSacar_Click(object sender, EventArgs e)
        {
            double valorDigitado = double.Parse(valorBox.Text);
            contaAtual.Sacar(valorDigitado);
            saldoLabel.Text = contaAtual.Saldo.ToString();
            valorBox.Text = "";
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            contaAtual = contas[comboContas.SelectedIndex];
            comboTransferencia.Items.Clear();
            foreach (Conta contaUnidade in contas)
            {
                if (contaAtual == contaUnidade)
                {
                    continue;
                }
                comboTransferencia.Items.Add(contaUnidade.cliente.Nome);
            }

            titularLabel.Text = contaAtual.cliente.Nome;
            numeroContaLabel.Text = contaAtual.NumeroConta.ToString();
            saldoLabel.Text = contaAtual.Saldo.ToString();
            comboTransferencia.Text = "";
        }

        private void botaoTransferencia_Click(object sender, EventArgs e)
        {
            double valorTransferencia = double.Parse(transferenciaValorBox.Text);
            if (contaAtual.Sacar(valorTransferencia))
            {
                contaDestinatario.Depositar(valorTransferencia);
            }
            saldoLabel.Text = contaAtual.Saldo.ToString();
        }

        private void comboTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceDest = comboTransferencia.SelectedIndex;
            contaDestinatario = contas[indiceDest+1];
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioCadastro = new FormCadastroConta(this);
            formularioCadastro.ShowDialog();
        }

        private void btnCalculoImpostos_Click(object sender, EventArgs e)
        {
		    if (contaAtual is ContaCorrente cr)
	        {
		        MessageBox.Show("Conta Corrente\nTitular: " + cr.cliente.Nome + "\nTributo de R$" + cr.CalculaTributo().ToString());
		    }
			else if (contaAtual is ContaPoupanca cp)
		    {
	    	    MessageBox.Show("Conta Poupança\nTitular: " + cp.cliente.Nome + "\nTributo de R$" + cp.CalculaTributo().ToString());
		    }
        }
    }
}
