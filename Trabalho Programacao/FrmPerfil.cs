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
    public partial class FrmPerfil : Form
    {
        public FrmPerfil()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btngravar_Click(object sender, EventArgs e)
        {

        }

        private void perfilUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void livrosUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSugestãoLivro sugestãoLivro = new FrmSugestãoLivro();
            sugestãoLivro.Show();
        }

        private void filmesUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSugestãoFilme sugestãoFilme = new FrmSugestãoFilme();
            sugestãoFilme.Show();
        }
    }
}
