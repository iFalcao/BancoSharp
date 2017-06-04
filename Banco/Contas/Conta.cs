using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.Contas
{
    public abstract class Conta
    {
        public Conta()
        {
            Conta.totalContas++;
            this.NumeroConta = totalContas;
        }

        public override bool Equals(object outraConta)
        {
            if (!(outraConta is Conta))
            {
                return false;
            }

            Conta cast = (Conta)outraConta;
            return this.NumeroConta == cast.NumeroConta;
        }

        public override string ToString()
        {
            return this.cliente.Nome;
        }

        protected static int totalContas;
        public static int ProximaConta()
        {
            return Conta.totalContas + 1;
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
            if (valorDigitado <= 0)
            {
                throw new ArgumentException("Valor inválido para depósito. Tente novamente...");
            }
            else
            {
                this.Saldo += valorDigitado;
            }
        }

        public virtual void Sacar(double valorDigitado)
        {
            if (valorDigitado <= 0)
            {
                throw new ArgumentException("Valor inválido para saque. Tente novamente!");
            }
            else if (this.Saldo > valorDigitado)
            {
                this.Saldo -= valorDigitado;
            }
            else
            {
                throw new SaldoInsuficienteException();
            }
        }
    }
}
