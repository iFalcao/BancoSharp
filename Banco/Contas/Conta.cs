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
        protected static int totalContas;
        private int numeroConta;
        private double saldo;
        public Cliente cliente { get; set; }
        
        
        public static int ProximaConta()
        {
            return Conta.totalContas + 1;
        }

        public int NumeroConta
        {
            get { return numeroConta; }
            set { numeroConta = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public Conta()
        {
            Conta.totalContas++;
            this.NumeroConta = totalContas;
        }

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
    }
}
