using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaPoupanca : Conta, ITributavel
    {
        public ContaPoupanca() { }
        public ContaPoupanca (int numero) : base(numero) { }

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
    }
}
