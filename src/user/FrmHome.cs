using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            FrmPerfil perfil = new FrmPerfil();
            perfil.Show();
        }
        private void criarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCriarLista criarLista = new FrmCriarLista();
            criarLista.Show();
        }

        private void minhasListasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMinhasListas minhasListas = new FrmMinhasListas();
            minhasListas.Show();
        }
        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSugestaoLivro sugestãolivro = new FrmSugestaoLivro();
            sugestãolivro.Show();
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSugestaoFilme sugestaoFilme = new FrmSugestaoFilme();
            sugestaoFilme.Show();
        }

        private void minhaAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void avaliaramendoas_Click(object sender, EventArgs e)
        {
            var amendoas = new FrmAvaliacaoAmendoas(1);
            amendoas.Show();
            this.Hide();
        }

        private void avaliarjantarsecreto_Click(object sender, EventArgs e)
        {
            var jantarSecreto = new FrmAvaliacaoJantarSecreto();
            jantarSecreto.Show();
            this.Hide();
        }
    }
}
