using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Trabalho_Programacao
{
    public partial class FrmLivro : Form
    {
        private MySqlConnection bdCon;
        private int cod = 0; // ID do livro selecionado
        private string caminhoImagemCompleto = string.Empty;

        public FrmLivro()
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
            autor.Clear();
            descricao.Clear();
            isbn.Clear();
            idioma.Clear();
            editora.Clear();
            npag.Clear();
            caminhoimagem.Clear();
            pictureBoxCapa.Image = null;
            pictureBoxCapa.ImageLocation = null;
            cod = 0;

        }

        private void CarregarGrid()
        {
            using (MySqlConnection bdConn = new MySqlConnection(StringConexao()))
            {
                try
                {
                    bdConn.Open();
                    string sql = @"SELECT ID_Livro, ISBN, Titulo, Autor, Descricao, Idioma, Editora, N_Paginas, Capa
                                   FROM sugestaolivro ORDER BY ID_Livro";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, bdConn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao carregar livros: " + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Gravar()
        {
            if (cod == 0)
            {
                MessageBox.Show("Selecione uma sugestão primeiro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (bdCon = new MySqlConnection(StringConexao()))
            {
                try
                {
                    bdCon.Open();

                    // Pastas de imagens
                    string pastaSugestao = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "banco de dados\\imagens_livro");
                    string pastaLivros = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "banco de dados\\imagens_livro");
                    Directory.CreateDirectory(pastaLivros);

                    string caminhoOrigem = Path.Combine(pastaSugestao, caminhoImagemCompleto);
                    string caminhoDestino = Path.Combine(pastaLivros, caminhoImagemCompleto);

                    if (!string.IsNullOrEmpty(caminhoImagemCompleto) && File.Exists(caminhoOrigem))
                        File.Copy(caminhoOrigem, caminhoDestino, true);

                    // Inserir no banco principal
                    string sqlInsert = @"INSERT INTO livro (ISBN, Titulo, Autor, Descricao, Idioma, Editora, N_Paginas, Capa)
                                         VALUES (@ISBN, @Titulo, @Autor, @Descricao, @Idioma, @Editora, @N_Paginas, @Capa)";

                    using (MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, bdCon))
                    {
                        cmdInsert.Parameters.AddWithValue("@ISBN", isbn.Text);
                        cmdInsert.Parameters.AddWithValue("@Titulo", titulo.Text);
                        cmdInsert.Parameters.AddWithValue("@Autor", autor.Text);
                        cmdInsert.Parameters.AddWithValue("@Descricao", descricao.Text);
                        cmdInsert.Parameters.AddWithValue("@Idioma", idioma.Text);
                        cmdInsert.Parameters.AddWithValue("@Editora", editora.Text);
                        cmdInsert.Parameters.AddWithValue("@N_Paginas", int.TryParse(npag.Text, out int paginas) ? paginas : 0);
                        cmdInsert.Parameters.AddWithValue("@Capa", caminhoImagemCompleto);
                        cmdInsert.ExecuteNonQuery();
                    }

                    // Deletar da sugestão
                    string sqlDelete = "DELETE FROM sugestaolivro WHERE ID_Livro = @ID_Livro";
                    using (MySqlCommand cmdDelete = new MySqlCommand(sqlDelete, bdCon))
                    {
                        cmdDelete.Parameters.AddWithValue("@ID_Livro", cod);
                        cmdDelete.ExecuteNonQuery();
                    }

                    MessageBox.Show("Livro aprovado e transferido para o banco principal!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpar();
                    CarregarGrid();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao gravar livro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btncapa_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Selecione uma imagem para a capa";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Pasta onde vai ficar o livro oficial
                        string pastaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "banco de dados\\imagens_livro");
                        Directory.CreateDirectory(pastaDestino);

                        // Nome único do arquivo
                        string extensao = Path.GetExtension(ofd.FileName);
                        string nomeArquivo = $"{Guid.NewGuid()}{extensao}";
                        string caminhoDestino = Path.Combine(pastaDestino, nomeArquivo);

                        // Copia o arquivo
                        File.Copy(ofd.FileName, caminhoDestino, true);

                        // Limpa imagem antiga
                        if (pictureBoxCapa.Image != null)
                        {
                            pictureBoxCapa.Image.Dispose();
                            pictureBoxCapa.Image = null;
                        }

                        // Mostra a imagem na PictureBox
                        pictureBoxCapa.Image = Image.FromFile(caminhoDestino);

                        // Atualiza a variável e o TextBox com o caminho
                        caminhoImagemCompleto = nomeArquivo;
                        caminhoimagem.Text = caminhoDestino;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar imagem: " + ex.Message, "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            DataGridViewRow row = dataGridView1.CurrentRow;
            cod = Convert.ToInt32(row.Cells["ID_Livro"].Value);
            isbn.Text = row.Cells["ISBN"].Value?.ToString();
            titulo.Text = row.Cells["Titulo"].Value?.ToString();
            autor.Text = row.Cells["Autor"].Value?.ToString();
            descricao.Text = row.Cells["descricao"].Value?.ToString();
            idioma.Text = row.Cells["Idioma"].Value?.ToString();
            editora.Text = row.Cells["Editora"].Value?.ToString();
            npag.Text = row.Cells["N_Paginas"].Value?.ToString();

            string nomeCapa = row.Cells["Capa"].Value?.ToString();
            caminhoImagemCompleto = nomeCapa;

            pictureBoxCapa.Image?.Dispose(); // libera a imagem antiga
            pictureBoxCapa.Image = null;

            if (!string.IsNullOrEmpty(nomeCapa))
            {
                string caminhoCapa = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "..\\..\\banco de dados\\Imagens_Livro",
                    nomeCapa
                );

                // Atualiza TextBox com o caminho da imagem
                caminhoimagem.Text = caminhoCapa;

                // Mostra a imagem na PictureBox
                if (File.Exists(caminhoCapa))
                    pictureBoxCapa.Image = Image.FromFile(caminhoCapa);
                else
                    pictureBoxCapa.Image = null;
            }
            else
            {
                caminhoimagem.Text = "";
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

        private void btnCarregarLivro_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLivro livro = new FrmLivro();
            livro.Show();
            this.Hide();
        }

        private void FilmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilme filme = new FrmFilme();
            filme.Show();
            this.Hide();
        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {

        }

        private void descricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLivro_Load_1(object sender, EventArgs e)
        {

        }

        private void AreaADMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
