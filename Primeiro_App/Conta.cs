using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiro_App
{
    class Conta
    {
        int numero { get; set; }
        string nomeTitular { get; set; }
        public double saldo { get; private set; }
        

        public Conta(int num, string nome, double saldo)
        {
            this.numero = num;
            this.nomeTitular = nome;
            this.saldo = saldo;
        }

        public void sacar(double valor, Conta conta)
        {
            if (conta.saldo < valor)
            {
                MessageBox.Show("Saldo insuficiente. Saldo atual:  %.2f" + conta.saldo);
            }
            else
            {
                conta.saldo -= valor;
                MessageBox.Show("Saque efetuado com sucesso! Saldo atual:  %.2f" + conta.saldo);
            }
        }

        public static Conta acharConta(string titular)
        {
            Conta achada = null;
            List<Conta> todasContas = new List<Conta>();
            foreach(Conta conta in todasContas) {
                if (conta.nomeTitular == titular)
                {
                    achada = conta;
                }
            }
            return achada;
        }
    }
}
