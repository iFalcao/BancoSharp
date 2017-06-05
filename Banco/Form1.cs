using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Dictionary<string, Conta> dicionario = new Dictionary<string, Conta>();
        private List<Conta> contas = new List<Conta>();
        private Conta contaAtual;
        private Conta contaDestinatario;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            Conta c1 = new ContaPoupanca();
            c1.cliente = new Cliente("Ícaro");
            c1.Saldo = 14500.00;

            Conta c2 = new ContaCorrente();
            c2.cliente = new Cliente("Arnold");
            c2.Saldo = 1250.00;

            Conta c3 = new ContaPoupanca();
            c3.cliente = new Cliente("José");
            c3.Saldo = 5250.25;

            AdicionaConta(c1);
            AdicionaConta(c2);
            AdicionaConta(c3);
        }

        public void AdicionaConta(Conta contaCriada)
        {
            comboContas.Items.Add(contaCriada);
            this.contas.Add(contaCriada);
            this.dicionario.Add(contaCriada.cliente.Nome, contaCriada);
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            try
            {
                double valorDigitado = double.Parse(valorBox.Text);
                contaAtual.Depositar(valorDigitado);
                MessageBox.Show("Depósito efetuado com sucesso. Saldo atual: " + contaAtual.Saldo.ToString());
                saldoLabel.Text = contaAtual.Saldo.ToString();
                valorBox.Text = "";
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Valor incorreto. Tente novamente");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botaoSacar_Click(object sender, EventArgs e)
        {
            try
            {
                double valorDigitado = double.Parse(valorBox.Text);
                contaAtual.Sacar(valorDigitado);
                saldoLabel.Text = contaAtual.Saldo.ToString();
                valorBox.Text = "";
                MessageBox.Show("Saque efetuado com sucesso. Saldo atual: " + contaAtual.Saldo.ToString());
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Valor incorreto. Tente novamente");
            }
            catch (ArgumentException aex)
            {
                MessageBox.Show(aex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                MessageBox.Show("Saldo insuficiente para o Saque! Tente novamente...");
            }
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            botaoSacar.Enabled = true;
            botaoDepositar.Enabled = true;
            contaAtual = (Conta) comboContas.SelectedItem;

            titularLabel.Text = contaAtual.cliente.Nome;
            numeroContaLabel.Text = contaAtual.NumeroConta.ToString();
            saldoLabel.Text = contaAtual.Saldo.ToString();
            comboTransferencia.Text = "";

            comboTransferencia.Items.Clear();
            foreach (Conta contaUnidade in contas)
            {
                if (contaAtual == contaUnidade)
                {
                    continue;
                }
                comboTransferencia.Items.Add(contaUnidade.cliente.Nome);
            }
        }

        private void botaoTransferencia_Click(object sender, EventArgs e)
        {
            try
            {
                double valorTransferencia = double.Parse(transferenciaValorBox.Text);
                contaAtual.Sacar(valorTransferencia);
                contaDestinatario.Depositar(valorTransferencia);
                saldoLabel.Text = contaAtual.Saldo.ToString();
                MessageBox.Show("Transferência efetuada com sucesso!\n" +
                                "Remetente: " + contaAtual.cliente.Nome + " --- Saldo: " + contaAtual.Saldo
                                + "\nDestinatário: " + contaDestinatario.cliente.Nome + " --- Saldo: " + contaDestinatario.Saldo);
                transferenciaValorBox.Clear();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Valor incorreto! Tente novamente...");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            botaoTransferencia.Enabled = true;
            MessageBox.Show(comboTransferencia.SelectedText + "Destinatário Selecionado");
            foreach (Conta contaUnidade in contas)
            {
                if (comboTransferencia.SelectedText.Equals(contaUnidade.cliente.Nome))
                {
                    contaDestinatario = contaUnidade;
                }
            }
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioCadastro = new FormCadastroConta(this);            
            formularioCadastro.ShowDialog();
        }

        private void btnCalculoImpostos_Click(object sender, EventArgs e)
        {
		    if (contaAtual is ContaCorrente)
	        {
                ContaCorrente cr =(ContaCorrente)contaAtual;
                MessageBox.Show("Conta Corrente\nTitular: " + cr.cliente.Nome + "\nTributo de R$" + cr.CalculaTributo().ToString());
		    }
			else if (contaAtual is ContaPoupanca)
		    {
                ContaPoupanca cp = (ContaPoupanca)contaAtual;
	    	    MessageBox.Show("Conta Poupança\nTitular: " + cp.cliente.Nome + "\nTributo de R$" + cp.CalculaTributo().ToString());
		    }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                contaAtual = dicionario[nomeBuscaBox.Text];
                comboContas.SelectedItem = contaAtual;
            }
            catch (KeyNotFoundException inex)
            {
                MessageBox.Show("Não existe um titular com esse nome!");
            }
        }
    }
}
