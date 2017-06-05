using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;

namespace Banco.Busca
{
    class GeradorDeDevedores
    {
        public SortedSet<string> GeraLista() 
        {
            SortedSet<string> nomes = new SortedSet<string>();
            
            for (int i = 0; i < 30000; i++)
            {
                nomes.Add("devedor " + i);
            }

            return nomes;
        }
    }
}
