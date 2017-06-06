using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EditorSublinha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrava_Click(object sender, EventArgs e)
        {
            Stream saida = File.Open("texto.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida);
            escritor.Write(campoTexto.Text);
            escritor.Close();
            saida.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (Stream entrada = File.Open("texto.txt", FileMode.Open))
            using (StreamReader leitor = new StreamReader(entrada))
            if (File.Exists("texto.txt"))
            {
                campoTexto.Text += leitor.ReadToEnd();     
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string textoBusca = campoFind.Text;
            int resultado = campoTexto.Text.IndexOf(textoBusca);
            if (resultado >= 0)
            {
                MessageBox.Show("Encontrei na posição: " + resultado);
            }
            else
            {
                MessageBox.Show("Não consegui localizar!");
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            try
            {
                string textoBusca = campoFind.Text;
                string textoAltera = campoReplace.Text;
                campoTexto.Text = campoTexto.Text.Replace(textoBusca, textoAltera);
            }
            catch (ArgumentException aex)
            {
                MessageBox.Show("Você precisa selecionar um texto antes!");
            }
        }

        private void btnMaiuscula_Click(object sender, EventArgs e)
        {
            string textoSelecionado = campoTexto.Text.Substring(campoTexto.SelectionStart, campoTexto.SelectionLength);
            string antes = campoTexto.Text.Substring(0, campoTexto.SelectionStart);
            string depois = campoTexto.Text.Substring(campoTexto.SelectionStart + campoTexto.SelectionLength);
            campoTexto.Text = antes + textoSelecionado.ToUpper() + depois;
        }

        private void btnMinuscula_Click(object sender, EventArgs e)
        {
            string textoSelecionado = campoTexto.Text.Substring(campoTexto.SelectionStart, campoTexto.SelectionLength);
            string antes = campoTexto.Text.Substring(0, campoTexto.SelectionStart);
            string depois = campoTexto.Text.Substring(campoTexto.SelectionStart + campoTexto.SelectionLength);
            campoTexto.Text = antes + textoSelecionado.ToLower() + depois;
        }
    }
}
