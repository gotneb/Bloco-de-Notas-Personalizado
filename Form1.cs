using System;
using System.IO;
using System.Windows.Forms;

namespace Youtube
{
    public partial class blocoDeNotas : Form
    {
        private bool estaSalvo;
        private string textoSalvo;
        private string nomeJanela;

        public blocoDeNotas()
        {
            InitializeComponent();
        }

        private void BlocoDeNotas_Load(object sender, EventArgs e)
        {
            estaSalvo = true;
            textoSalvo = txtTexto.Text;
            nomeJanela = "Bloco de notas";
        }

        /*
         * Verifica se o texto possui alterações e altera o título
         * adicionando um '*', caso o esteja diferente do texto salvo
         * */
        private void TxtTexto_TextChanged(object sender, EventArgs e)
        {
            var textoAtual = txtTexto.Text;
            estaSalvo = false;

            if (textoAtual != textoSalvo && estaSalvo == false)
            {
                this.Text = "*" + nomeJanela;
            }
            if (textoAtual == textoSalvo)
            {
                estaSalvo = true;
                this.Text = nomeJanela;
            }
        }

        // Abre uma janela para que o user esoclha qual arquivo abrir
        private void MenuAbrirArquivo_Click(object sender, EventArgs e)
        {
            var abrirArquivo = new OpenFileDialog();
            abrirArquivo.Title = "Selecione um arquivo";
            abrirArquivo.Filter = "txt file|*txt";
            abrirArquivo.RestoreDirectory = true;

            // Pega o resultado de qual botão ele clicou
            var resultado = abrirArquivo.ShowDialog();

            // User escolheu um arquivo
            if (resultado == DialogResult.OK)
            {
                // Cria um leitor para transferir os dados para o programa atual
                using(var leitor = new StreamReader(abrirArquivo.FileName))
                {
                    txtTexto.Text = leitor.ReadToEnd();
                }
            }
        }
    }
}
