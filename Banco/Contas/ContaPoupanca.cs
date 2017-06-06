using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    public class ContaPoupanca : Conta, ITributavel
    {
        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
    }
}
