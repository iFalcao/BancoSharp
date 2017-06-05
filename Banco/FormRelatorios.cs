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
    public partial class FormRelatorios : Form
    {
        List<Conta> contas;

        public FormRelatorios(List<Conta> contas)
        {
            this.contas = contas;
            InitializeComponent();
        }

        private void btnSaldoMaiorQue500_Click(object sender, EventArgs e)
        {
            var saldoMaior500 = this.contas.Where(c => c.Saldo > 500).OrderBy(c => c.cliente.Nome);
            foreach (Conta c in saldoMaior500)
            {
                listaResultados.Items.Add(c);
            }
            atualizaResumo(saldoMaior500);
        }

        private void atualizaResumo(IEnumerable<Conta> listaResultados)
        {
            double maiorS = listaResultados.Max(c => c.Saldo);
            lblMaiorSaldo.Text = maiorS.ToString("R$ #,##0.00");

            double mediaS = listaResultados.Average(c => c.Saldo);
            lblMediaSaldo.Text = mediaS.ToString("R$ #,##0.00");

            double menorS = listaResultados.Min(c => c.Saldo);
            lblMenorSaldo.Text = menorS.ToString("R$ #,##0.00");

            double totalS = listaResultados.Sum(c => c.Saldo);
            lblSaldoTotal.Text = totalS.ToString("R$ #,##0.00");
        }

        private void btnNumeroContaAte10_Click(object sender, EventArgs e)
        {
            var primeiros = from c in contas
                            where c.NumeroConta < 10
                            orderby c.cliente.Nome
                            select c;
            foreach (Conta c in primeiros)
            {
                listaResultados.Items.Add(c);
            }
            atualizaResumo(primeiros);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listaResultados.Items.Clear();
        }
    }
}
