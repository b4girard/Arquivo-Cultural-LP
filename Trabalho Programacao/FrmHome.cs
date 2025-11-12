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
            FrmSugestãoLivro sugestãolivro = new FrmSugestãoLivro();
            sugestãolivro.Show();
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSugestãoFilme sugestãofilme = new FrmSugestãoFilme();
            sugestãofilme.Show();
        }

        private void minhaAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
