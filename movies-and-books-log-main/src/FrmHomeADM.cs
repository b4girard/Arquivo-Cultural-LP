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
    public partial class FrmHomeADM : Form
    {
        public FrmHomeADM()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void LivrosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmLivro livro = new FrmLivro();
            livro.Show();
        }

        private void FilmesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmFilme filme = new FrmFilme();
            filme.Show();
        }
    }
}
