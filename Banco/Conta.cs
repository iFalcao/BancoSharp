using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public class Conta
    {
        public Conta() { }
        public Conta(int numero)
        {
            this.NumeroConta = numero;
        }

        private int numeroConta;

        public int NumeroConta
        {
            get { return numeroConta; }
            set { numeroConta = value; }
        }

        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public Cliente cliente { get; set; }

        public void Depositar(double valorDigitado)
        {
            this.Saldo += valorDigitado;
            MessageBox.Show("Operação efetuada com sucesso");
        }

        public virtual bool Sacar(double valorDigitado)
        {
            if (this.Saldo > valorDigitado)
            {
                this.Saldo -= valorDigitado;
                MessageBox.Show("Operação efetuada com sucesso");
                return true;
            }
            else
            {
                MessageBox.Show("Saldo insuficiente! Altere o valor e tente novamente...");
                return false;
            }
        }
    }
}
