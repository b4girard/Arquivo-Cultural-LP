using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Trabalho_Programacao
{
    public partial class FrmSugestaoLivro : Form
    {
        private MySqlConnection bdCon;
        private int cod = 0; // ID da sugestão (se houver)
        private string caminhoImagemCompleto = string.Empty; // nome do arquivo da capa

        public FrmSugestaoLivro()
        {
            InitializeComponent();
        }

        private string StringConexao()
        {
            return "server=localhost; database=REGISTRADOR_FILMES_LIVROS_LP; uid=root; pwd=;";
        }

        private void Limpar()
        {
            isbnSugestão.Clear();
            tituloSugestão.Clear();
            autorSugestão.Clear();
            idiomaSugestão.Clear();
            editoraSugestão.Clear();
            npagSugestão.Clear();
            pictureBoxCapaSugestão.Image = null;
            caminhoImagemCompleto = string.Empty;
            cod = 0;
        }

        private void SelecionarCapa()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Selecione uma imagem para a capa";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Cria pasta se não existir
                        string pastaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\banco de dados\\Imagens_SLivro");
                        Directory.CreateDirectory(pastaDestino);

                        // Nome único para evitar sobrescrita
                        string extensao = Path.GetExtension(ofd.FileName);
                        string nomeArquivo = $"{Guid.NewGuid()}{extensao}";
                        string caminhoDestino = Path.Combine(pastaDestino, nomeArquivo);

                        // Copia imagem
                        File.Copy(ofd.FileName, caminhoDestino, true);

                        // Atualiza PictureBox
                        if (pictureBoxCapaSugestão.Image != null)
                        {
                            pictureBoxCapaSugestão.Image.Dispose();
                            pictureBoxCapaSugestão.Image = null;
                        }

                        pictureBoxCapaSugestão.Image = Image.FromFile(caminhoDestino);

                        // Salva nome do arquivo para gravar no banco
                        caminhoImagemCompleto = nomeArquivo;

                        MessageBox.Show("Imagem carregada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void GravarSugestao()
        {
            // Validar campos obrigatórios
            if (string.IsNullOrWhiteSpace(tituloSugestão.Text) || string.IsNullOrWhiteSpace(autorSugestão.Text))
            {
                MessageBox.Show("Título e autor são obrigatórios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(caminhoImagemCompleto))
            {
                MessageBox.Show("Selecione uma capa para o livro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (bdCon = new MySqlConnection(StringConexao()))
            {
                try
                {
                    bdCon.Open();

                    string sql = @"INSERT INTO sugestaolivro (ISBN, Titulo, Autor, Idioma, Editora, N_Paginas, Capa)
                                   VALUES (@ISBN, @Titulo, @Autor, @Idioma, @Editora, @N_Paginas, @Capa)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, bdCon))
                    {
                        cmd.Parameters.AddWithValue("@ISBN", isbnSugestão.Text);
                        cmd.Parameters.AddWithValue("@Titulo", tituloSugestão.Text);
                        cmd.Parameters.AddWithValue("@Autor", autorSugestão.Text);
                        cmd.Parameters.AddWithValue("@Idioma", idiomaSugestão.Text);
                        cmd.Parameters.AddWithValue("@Editora", editoraSugestão.Text);
                        cmd.Parameters.AddWithValue("@N_Paginas", int.TryParse(npagSugestão.Text, out int paginas) ? paginas : 0);
                        cmd.Parameters.AddWithValue("@Capa", caminhoImagemCompleto);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Sugestão enviada com sucesso! Será avaliada em até 30 dias.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao enviar a sugestão: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btncapa_Click(object sender, EventArgs e)
        {
            SelecionarCapa();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            GravarSugestao();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
