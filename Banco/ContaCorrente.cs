using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente : Conta, ITributavel
    {
        public ContaCorrente ()	{}
        public ContaCorrente(int numero) : base(numero) { }

        public double CalculaTributo()
        {
            return this.Saldo * 0.05;
        }

        public override bool Sacar(double valorDigitado)
        {
            if (base.Sacar(valorDigitado + 1.15))
            {
                return true;
            }
            else return false;
            
        }
    }
}
