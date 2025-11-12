using MySql.Data.MySqlClient;
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
    public partial class FrmFilme : Form
    {
        public FrmFilme()
        {
            InitializeComponent();
        }
        public MySqlConnection bdCon;
        public int cod = 0;

        private void Limpar()
        {
            titulo.Clear();
            imdb.Clear();
            diretor.Clear();
            idiomaoriginal.Clear();
            anolancamento.Clear();
            //pictureBoxPoster.Clear();
        }

        


        private void Gravar()
        {

            using (bdCon = new MySqlConnection("server=localhost; database=REGISTRADOR_FILMES_LIVROS; uid=root; pwd=;"))
            {
                try
                {
                    bdCon.Open();

                    if (cod == 0)
                    {
                        string sql = @"INSERT INTO filme ( IMDb_ID , Titulo, Diretor , Idioma_original , Ano_de_lancamento , Poster ) 
                                       VALUES (@IMDb_ID , @Titulo, @Diretor , @Idioma_original , @Ano_de_lancamento , @Poster)";

                        using (MySqlCommand cmd = new MySqlCommand(sql, bdCon))
                        {
                            cmd.Parameters.AddWithValue("@IMDb_ID ", imdb.Text);
                            cmd.Parameters.AddWithValue("@Titulo", titulo.Text);
                            cmd.Parameters.AddWithValue("@Diretor", diretor.Text);
                            cmd.Parameters.AddWithValue("@Idioma_original", idiomaoriginal.Text);
                            cmd.Parameters.AddWithValue("@N_Paginas", int.TryParse(anolancamento.Text, out int ano) ? ano : 0);
                            cmd.Parameters.AddWithValue("@Poster", pictureBoxPoster.ImageLocation);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("O Filme foi inserido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao cadastrar filme: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btncapa_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens|*.jpg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPoster.Image = Image.FromFile(ofd.FileName);
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btngravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLivro livro = new FrmLivro();
            livro.Show();
        }

        private void FilmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilme filme = new FrmFilme();
            filme.Show();
        }
    }
}
