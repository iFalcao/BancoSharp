using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    public class ContaCorrente : Conta, ITributavel
    {
    
        public double CalculaTributo()
        {
            return this.Saldo * 0.05;
        }

        public override void Sacar(double valorDigitado)
        {
                base.Sacar(valorDigitado + 1.15);
        }
    }
}
