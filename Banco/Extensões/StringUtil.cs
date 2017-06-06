using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.Extensões
{
    public static class StringUtil
    {
        public static string Pluralize(this string texto)
        {
            if (texto.EndsWith("s"))
            {
                return texto;
            }
            else
            {
                return texto + "s";
            }
        }
    }
}
