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

namespace Trabalho_Programacao
{
    public partial class FrmSugestãoFilme : Form
    {
        public FrmSugestãoFilme()
        {
            InitializeComponent();
        }

        public MySqlConnection bdCon;
        public int cod = 0;

        private void Limpar()
        {
            imdbSugestao.Clear();
            tituloSugestao.Clear();
            diretorSugestao.Clear();
            idiomaoriginalSugestao.Clear();
            anolancamentoSugestao.Clear();

        }
        private void SugestaoFilme()
        {
            
            using (bdCon = new MySqlConnection("server=localhost; database=REGISTRADOR_FILMES_LIVROS; uid=root; pwd=;"))
            {
                try
                {
                    bdCon.Open();

                    if (cod == 0)
                    {
                        string sql = @"INSERT INTO sugestaofilme ( IMDb_ID , Titulo, Diretor , Idioma_original , Ano_de_lancamento , Poster ) 
                                       VALUES (@IMDb_ID , @Titulo, @Diretor , @Idioma_original , @Ano_de_lancamento , @Poster)";

                        using (MySqlCommand cmd = new MySqlCommand(sql, bdCon))
                        {
                            cmd.Parameters.AddWithValue("@IMDb_ID ", imdbSugestao.Text);
                            cmd.Parameters.AddWithValue("@Titulo", tituloSugestao.Text);
                            cmd.Parameters.AddWithValue("@Diretor", diretorSugestao.Text);
                            cmd.Parameters.AddWithValue("@Idioma_original", idiomaoriginalSugestao.Text);
                            cmd.Parameters.AddWithValue("@N_Paginas", int.TryParse(anolancamentoSugestao.Text, out int ano) ? ano : 0);
                            cmd.Parameters.AddWithValue("@Poster", pictureBoxPosterSugestão.ImageLocation);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Sugestão enviada com sucesso", "Será avaliado em até 30 dias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao enviar a sugestão: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            SugestaoFilme();
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
            
        }
    }
}
