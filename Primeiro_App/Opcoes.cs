using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiro_App
{
    public partial class Opcoes : Form
    {
        public Opcoes()
        {
            InitializeComponent();
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            Conta conta = Conta.acharConta(titularSaqueBox.Text);
            conta.sacar(double.Parse(saqueBox.Text), conta);
        }

        private void Opcoes_Load(object sender, EventArgs e)
        {

        }
    }
}
