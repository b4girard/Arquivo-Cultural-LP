using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Programacao
{
    public partial class FrmLivro : Form
    {
        public FrmLivro()
        {
            InitializeComponent();
        }

        public MySqlConnection bdCon;
        public int cod = 0;

        private void Limpar()
        {
            titulo.Clear();
            autor.Clear();
            isbn.Clear();
            idioma.Clear();
            editora.Clear();
            npag.Clear();
            //pictureBoxCapa.Clear();
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
                        string sql = @"INSERT INTO livro ( ISBN ,Titulo ,Autor ,Idioma ,Editora ,N_Paginas ,Capa ) 
                                       VALUES (@ISBN ,@Titulo ,@Autor ,@Idioma ,@Editora ,@N_Paginas ,@Capa)";

                        using (MySqlCommand cmd = new MySqlCommand(sql, bdCon))
                        {
                            cmd.Parameters.AddWithValue("@ISBN", isbn.Text);
                            cmd.Parameters.AddWithValue("@Titulo", titulo.Text);
                            cmd.Parameters.AddWithValue("@Autor", autor.Text);
                            cmd.Parameters.AddWithValue("@Idioma", idioma.Text);
                            cmd.Parameters.AddWithValue("@Editora", editora.Text);
                            cmd.Parameters.AddWithValue("@N_Paginas", int.TryParse(npag.Text, out int paginas) ? paginas : 0);
                            cmd.Parameters.AddWithValue("@Capa", pictureBoxCapa.ImageLocation);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("O Filme foi inserido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao cadastrar livro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    

        private void btncapa_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens|*.jpg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCapa.Image = Image.FromFile(ofd.FileName);
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
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
