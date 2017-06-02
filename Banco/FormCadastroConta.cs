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
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;
        private string tipoSelecionado;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = new Form1();
            InitializeComponent();
            comboTipoConta.Items.Add("Conta Poupança");
            comboTipoConta.Items.Add("Conta Corrente");
        }

        private void button1_Click(object sender, EventArgs e)
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

            novaConta.NumeroConta = int.Parse(numeroBox.Text);
            novaConta.cliente = new Cliente(titularBox.Text);
            novaConta.Saldo = 50.00;
            MessageBox.Show("Conta criada com Sucesso!\nSeu saldo é R$50");

            this.formPrincipal.AdicionaConta(novaConta);
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
