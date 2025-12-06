using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_Programacao;

namespace Trabalho_Programacao
{
    public partial class FrmMinhasListas : Form
    {
        public FrmMinhasListas()
        {
            InitializeComponent();
        }

        private void minhaAreaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void FrmMinhasListas_Load(object sender, EventArgs e)
        {
            FrmMinhasListas minhasListas = new FrmMinhasListas();
            minhasListas.Show();
        }

        private void minhasListasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void livrosUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}


