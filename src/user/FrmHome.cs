using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_Programacao.user.reviewFilmes;
using Trabalho_Programacao.Usuario.Avaliacoes_Livros;

namespace Trabalho_Programacao
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPerfil perfil = new FrmPerfil(Sessao.ID_UsuarioLogado);
            perfil.Show();
            this.Hide();
        }
        private void criarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCriarLista criarLista = new FrmCriarLista();
            criarLista.Show();
            this.Hide();
        }

        private void minhasListasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMinhasListas minhasListas = new FrmMinhasListas();
            minhasListas.Show();
            this.Hide();
        }
        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSugestaoLivro sugestãolivro = new FrmSugestaoLivro();
            sugestãolivro.Show();
            this.Hide();
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSugestaoFilme sugestaoFilme = new FrmSugestaoFilme();
            sugestaoFilme.Show();
            this.Hide();
        }

        private void minhaAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            if (Sessao.ID_UsuarioLogado <= 0)
            {
                MessageBox.Show("Você precisa estar logado!");
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void avaliaramendoas_Click(object sender, EventArgs e)
        {
            var amendoas = new FrmVerAmendoas(1, Sessao.ID_UsuarioLogado);
            amendoas.Show();
            this.Hide();
        }

        private void avaliarjantarsecreto_Click(object sender, EventArgs e)
        {
            
            var jantarSecreto = new FrmVerJantarSecreto(2, Sessao.ID_UsuarioLogado);
            jantarSecreto.Show();
            this.Hide();
        }

        private void infowicked_Click(object sender, EventArgs e)
        {
            var wfg = new FrmVerWickedForGood(1, Sessao.ID_UsuarioLogado);
            wfg.Show();
            this.Hide();
        }

        private void infothegoodfather_Click(object sender, EventArgs e)
        {
            var tgf = new FrmVerTheGoodFather(2, Sessao.ID_UsuarioLogado);
            tgf.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Sessao.ID_UsuarioLogado = 0;
            var entrada = new FrmEntrada();
            entrada.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var home = new FrmHome();
            home.Show();
            this.Hide();
        }
    }
}
