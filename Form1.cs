using System;
using System.IO;
using System.Windows.Forms;

namespace Youtube
{
    public partial class blocoDeNotas : Form
    {
        private bool estaSalvo;
        private string textoSalvo;
        private string nomeArquivo;
        private string path;

        public blocoDeNotas()
        {
            InitializeComponent();
        }

        private void BlocoDeNotas_Load(object sender, EventArgs e)
        {
            // Obtém o caminho onde o arquivo foi aberto
            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 1)
            {
                using(var leitor = new StreamReader(args[1]))
                {
                    txtTexto.Text = leitor.ReadToEnd();
                }
                // Caminho atual do arquivo
                path = args[1];
                var info = new FileInfo(args[1]);
                nomeArquivo = info.Name;
            }
            else
            {
                path = "";
                nomeArquivo = "Novo bloco de notas";
            }
            estaSalvo = true;
            textoSalvo = txtTexto.Text;
            SalvarModificacoes();

            // Texto selecionado ao iniciar
            if (txtTexto.Text.Length > 0)
                txtTexto.SelectionStart = txtTexto.Text.Length - 1;
            else
                txtTexto.SelectionStart = txtTexto.Text.Length;
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
                this.Text = "*" + nomeArquivo;
            }
            if (textoAtual == textoSalvo)
            {
                estaSalvo = true;
                this.Text = nomeArquivo;
            }

            this.Text += " - Bloco de Notas";
        }

        // Abre uma janela para que o user escolha qual arquivo deseja abrir
        private void MenuAbrirArquivo_Click(object sender, EventArgs e)
        {
            // Cria uma janela para abrir um arquivo
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
                nomeArquivo = abrirArquivo.SafeFileName;
                path = abrirArquivo.FileName;
                SalvarModificacoes();
            }
        }

        // Método que salva o texto e o título do bloco de notas
        private void SalvarModificacoes()
        {
            this.estaSalvo = true;
            this.Text = nomeArquivo + " - Bloco de Notas";
            this.textoSalvo = txtTexto.Text;
        }

        private void MenuSalvar_Click(object sender, EventArgs e)
        {
            // Salva automacamente caso o arquivo ja 'exista'
            if (path != "")
            {
                SalvarArquivo();
                SalvarModificacoes();
            }
            /*
             * Se o arquivo não estiver salvo em nenhum lugar, uma janela
             * solicita para o usuário salvar em um local determinado pelo user
             */
            else
            {
                SalvarArquivoComo();
            }
        }

        private void SalvarArquivo()
        {
            // Cria um escritor para sobrescrever os arquivos
            using(var escritor = new StreamWriter(this.path))
            {
                escritor.WriteLine(txtTexto.Text);
            }
        }

        private void SalvarArquivoComo()
        {
            // Janela para pedir o local para salvar arquivo
            var salvarArquivo = new SaveFileDialog();
            salvarArquivo.Title = "Procure o local para salvar o arquivo";
            salvarArquivo.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            salvarArquivo.FilterIndex = 1;
            salvarArquivo.RestoreDirectory = true;

            var resposta = salvarArquivo.ShowDialog();

            if (resposta == DialogResult.OK)
            {
                using (var escritor = new StreamWriter(salvarArquivo.FileName))
                {
                    escritor.WriteLine(txtTexto.Text);
                }
                this.path = salvarArquivo.FileName;
                nomeArquivo = Path.GetFileName(this.path);
                SalvarModificacoes();
            }
        }

        // Fecha o bloco de notas
        private void BlocoDeNotas_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
             * Caso o user feche a janela sem salvar as alterações, o programa
             * questiona se ele deseja salvar
             * */
            if (estaSalvo == false)
            {
                var botoes = MessageBoxButtons.YesNoCancel;
                var mensagem = "O programa não possui alterações salvas\ndeseja salvar?";
                var titulo = "Modificações pendentes";
                var icone = MessageBoxIcon.Warning;

                var resposta = MessageBox.Show(mensagem, titulo, botoes, icone);

                // Salva o arquivo
                if (resposta == DialogResult.Yes)
                {
                    SalvarArquivo();
                }
                else if (resposta == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void MenuSalvarComo_Click(object sender, EventArgs e)
        {
            SalvarArquivoComo();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
