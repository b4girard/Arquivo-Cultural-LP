using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Trabalho_Programacao
{
    public partial class FrmSugestaoFilme : Form
    {
        public FrmSugestaoFilme()
        {
            InitializeComponent();
        }

        private MySqlConnection bdCon;
        private int cod = 0;

        private string StringConexao()
        {
            return "server=localhost; database=REGISTRADOR_FILMES_LIVROS_LP; uid=root; pwd=;";
        }

        private void Limpar()
        {
            imdbSugestao.Clear();
            tituloSugestao.Clear();
            diretorSugestao.Clear();
            idiomaoriginalSugestao.Clear();
            anolancamentoSugestao.Clear();
            pictureBoxPosterSugestão.Image = null;
            pictureBoxPosterSugestão.ImageLocation = null;
            cod = 0;
        }

        private void EnviarSugestaoFilme()
        {
            using (bdCon = new MySqlConnection(StringConexao()))
            {
                try
                {
                    bdCon.Open();

                    string sql = @"INSERT INTO sugestaofilme 
                        (IMDb_ID, Titulo, Diretor, Idioma_original, Ano_de_lancamento, Poster)
                        VALUES (@IMDb_ID, @Titulo, @Diretor, @Idioma_original, @Ano_de_lancamento, @Poster)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, bdCon))
                    {
                        cmd.Parameters.AddWithValue("@IMDb_ID", imdbSugestao.Text);
                        cmd.Parameters.AddWithValue("@Titulo", tituloSugestao.Text);
                        cmd.Parameters.AddWithValue("@Diretor", diretorSugestao.Text);
                        cmd.Parameters.AddWithValue("@Idioma_original", idiomaoriginalSugestao.Text);
                        cmd.Parameters.AddWithValue("@Ano_de_lancamento",
                            int.TryParse(anolancamentoSugestao.Text, out int ano) ? ano : 0);
                        cmd.Parameters.AddWithValue("@Poster", pictureBoxPosterSugestão.ImageLocation ?? "");

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Sugestão enviada com sucesso!\nSerá avaliada em até 30 dias.",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpar();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao enviar a sugestão: " + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            EnviarSugestaoFilme();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnposter_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Selecione uma imagem para o poster";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string pastaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\banco de dados\\Imagens_SFilme");
                        Directory.CreateDirectory(pastaDestino);

                        // Gera nome único com GUID
                        string extensao = Path.GetExtension(ofd.FileName);
                        string nomeArquivo = $"{Guid.NewGuid()}{extensao}";
                        string caminhoDestino = Path.Combine(pastaDestino, nomeArquivo);

                        // Copia a imagem para a pasta do projeto
                        File.Copy(ofd.FileName, caminhoDestino, true);

                        // Mostra a imagem no PictureBox
                        pictureBoxPosterSugestão.Image = Image.FromFile(caminhoDestino);

                        // Salva somente o nome do arquivo (para gravar no banco)
                        pictureBoxPosterSugestão.ImageLocation = nomeArquivo;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar imagem: " + ex.Message, "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pictureBoxPosterSugestão_Click(object sender, EventArgs e)
        {

        }
    }
}
