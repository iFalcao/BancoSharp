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
using Banco.Busca;

namespace Banco
{
    public partial class FormCadastroConta : Form
    {
        private ICollection<string> devedores;
        public Form1 formPrincipal;
        public string tipoSelecionado;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
            
            comboTipoConta.Items.Add("Conta Poupança");
            comboTipoConta.Items.Add("Conta Corrente");
            proxContaLabel.Text = Conta.ProximaConta().ToString();
            
            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraLista();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Conta novaConta;
            if (tipoSelecionado == "Poupança")
            {
                novaConta = new ContaPoupanca();
            }
            else
            {
                novaConta = new ContaCorrente();
            }
            
            novaConta.cliente = new Cliente(titularBox.Text); 
            if (!devedores.Contains(novaConta.cliente.Nome))
	        {
		        novaConta.NumeroConta = int.Parse(proxContaLabel.Text);
                novaConta.Saldo = 50.00;
                MessageBox.Show("Conta criada com Sucesso!\nSeu saldo é R$50");
                proxContaLabel.Text = Conta.ProximaConta().ToString();

                this.formPrincipal.AdicionaConta(novaConta);
	        } 
            else
	        {
                MessageBox.Show("Devedor não pode abrir conta!");
	        }
        }

        private void comboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTipoConta.SelectedIndex == 0)
            {
                tipoSelecionado = "Poupança";
            }
            else
            {
                tipoSelecionado = "Corrente";
            }
        }
    }
}
