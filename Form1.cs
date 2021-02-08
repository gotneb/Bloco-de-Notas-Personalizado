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
        private void txtTexto_TextChanged(object sender, EventArgs e)
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
    }
}
