using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Trabalho_Programacao
{
    public partial class FrmFilme : Form
    {
        private MySqlConnection bdCon;
        private int cod = 0; // ID do filme selecionado

        public FrmFilme()
        {
            InitializeComponent();
        }

        private string StringConexao()
        {
            return "server=localhost; database=REGISTRADOR_FILMES_LIVROS_LP; uid=root; pwd=;";
        }

        private void Limpar()
        {
            titulo.Clear();
            imdb.Clear();
            diretor.Clear();
            idiomaoriginal.Clear();
            anolancamento.Clear();
            pictureBoxPoster.Image = null;
            pictureBoxPoster.ImageLocation = null;
            cod = 0;
        }

        private void Gravar()
        {
            if (cod == 0)
            {
                MessageBox.Show("Selecione uma sugestão primeiro!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (bdCon = new MySqlConnection(StringConexao()))
            {
                try
                {
                    bdCon.Open();

                    string sqlInsert = @"INSERT INTO filme 
                        (IMDb_ID, Titulo, Diretor, Idioma_original, Ano_de_lancamento, Poster)
                        VALUES (@IMDb_ID, @Titulo, @Diretor, @Idioma_original, @Ano_de_lancamento, @Poster)";

                    using (MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, bdCon))
                    {
                        cmdInsert.Parameters.AddWithValue("@IMDb_ID", imdb.Text);
                        cmdInsert.Parameters.AddWithValue("@Titulo", titulo.Text);
                        cmdInsert.Parameters.AddWithValue("@Diretor", diretor.Text);
                        cmdInsert.Parameters.AddWithValue("@Idioma_original", idiomaoriginal.Text);
                        cmdInsert.Parameters.AddWithValue("@Ano_de_lancamento",
                            int.TryParse(anolancamento.Text, out int ano) ? ano : 0);
                        cmdInsert.Parameters.AddWithValue("@Poster", pictureBoxPoster.ImageLocation ?? "");

                        cmdInsert.ExecuteNonQuery();
                    }

                    string sqlDelete = "DELETE FROM sugestaofilme WHERE ID_filme = @ID_filme";
                    using (MySqlCommand cmdDelete = new MySqlCommand(sqlDelete, bdCon))
                    {
                        cmdDelete.Parameters.AddWithValue("@ID_filme", cod);
                        cmdDelete.ExecuteNonQuery();
                    }

                    MessageBox.Show("Filme aprovado e transferido para o banco principal!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpar();
                    CarregarGrid();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao gravar filme: " + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CarregarGrid()
        {
            using (MySqlConnection bdConn = new MySqlConnection(StringConexao()))
            {
                try
                {
                    bdConn.Open();
                    string sql = @"SELECT ID_filme, IMDb_ID, Titulo, Diretor, Idioma_original, 
                                          Ano_de_lancamento, Poster
                                   FROM sugestaofilme ORDER BY ID_filme";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, bdConn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao carregar filmes: " + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma linha primeiro!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cod = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_filme"].Value);
            imdb.Text = dataGridView1.CurrentRow.Cells["IMDb_ID"].Value?.ToString();
            titulo.Text = dataGridView1.CurrentRow.Cells["Titulo"].Value?.ToString();
            diretor.Text = dataGridView1.CurrentRow.Cells["Diretor"].Value?.ToString();
            idiomaoriginal.Text = dataGridView1.CurrentRow.Cells["Idioma_original"].Value?.ToString();
            anolancamento.Text = dataGridView1.CurrentRow.Cells["Ano_de_lancamento"].Value?.ToString();

            string nomePoster = dataGridView1.CurrentRow.Cells["Poster"].Value?.ToString();
            if (!string.IsNullOrEmpty(nomePoster))
            {
                string caminhoPoster = Path.Combine(Application.StartupPath, "Imagens_Filme", nomePoster);

                if (File.Exists(caminhoPoster))
                {
                    if (pictureBoxPoster.Image != null)
                    {
                        pictureBoxPoster.Image.Dispose();
                        pictureBoxPoster.Image = null;
                    }

                    pictureBoxPoster.Image = Image.FromFile(caminhoPoster);
                }
                else
                {
                    pictureBoxPoster.Image = null;
                }
            }
            else
            {
                pictureBoxPoster.Image = null;
            }
        }

        private void btncapa_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Selecione uma imagem para o poster";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string pastaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\banco de dados\\Imagens_Filme");
                        Directory.CreateDirectory(pastaDestino);

                        // Gera nome único com GUID
                        string extensao = Path.GetExtension(ofd.FileName);
                        string nomeArquivo = $"{Guid.NewGuid()}{extensao}";
                        string caminhoDestino = Path.Combine(pastaDestino, nomeArquivo);

                        // Copia a imagem para a pasta do projeto
                        File.Copy(ofd.FileName, caminhoDestino, true);

                        // Mostra a imagem no PictureBox
                        pictureBoxPoster.Image = Image.FromFile(caminhoDestino);

                        // Salva o nome do arquivo (para gravar no banco)
                        pictureBoxPoster.ImageLocation = nomeArquivo;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar poster: " + ex.Message, "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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

        private void btnCarregarFilme_Click(object sender, EventArgs e)
        {
            CarregarGrid();
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

        private void btnposter_Click(object sender, EventArgs e)
        {

        }
    }
}
