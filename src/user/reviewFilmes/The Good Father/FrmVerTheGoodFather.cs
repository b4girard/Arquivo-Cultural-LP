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
using Trabalho_Programacao.user.reviewFilmes.The_Good_Father;

namespace Trabalho_Programacao.user.reviewFilmes
{
    public partial class FrmVerTheGoodFather : Form
    {

        private MySqlConnection bdCon;

        private string StringConexao()
        {
            return "server=localhost; database=REGISTRADOR_FILMES_LIVROS_LP; uid=root; pwd=;";
        }
        private int filme_ID;
        private int usuario_ID;


        public FrmVerTheGoodFather()
        {
            InitializeComponent();
        }

        public FrmVerTheGoodFather(int filmeID, int usuarioID)
        {
            InitializeComponent();
            filme_ID = filmeID;
            usuario_ID = usuarioID;

            CarregarFilme();
            CarregarAvaliacao();
        }

        private void CarregarFilme()
        {
            try
            {
                using (MySqlConnection bdConn = new MySqlConnection(StringConexao()))
                {
                    bdConn.Open();
                    string sql = "SELECT IMDb_ID, Titulo, Diretor, Descricao, Idioma_original ,Ano_de_lancamento FROM filme WHERE ID_Filme = @ID_Filme";

                    using (var cmd = new MySqlCommand(sql, bdConn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Filme", filme_ID);

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                imdb.Text = dr.GetString("IMDb_ID");
                                titulo.Text = dr.GetString("Titulo");
                                diretor.Text = dr.GetString("Diretor");
                                descricao.Text = dr.GetString("Descricao");
                                idiomaoriginal.Text = dr.GetString("Idioma_original");
                                int anolancamento = dr.GetInt32("Ano_de_lancamento");
                                ano.Text = dr.GetInt32("Ano_de_lancamento").ToString();

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar livro: " + ex.Message);
            }
        }

        private void CarregarAvaliacao()
        {

            try
            {
                using (MySqlConnection bdConn = new MySqlConnection(StringConexao()))
                {
                    bdConn.Open();
                    string sql = @"SELECT a.ID_usuario, a.Comentario, a.Data_avaliacao, u.Nome
                                   FROM Avaliacao a
                                   JOIN Usuario u ON u.ID_usuario = a.ID_usuario
                                   WHERE a.ID_filme = @filme
                                   ORDER BY a.Data_avaliacao DESC";

                    using (var cmd = new MySqlCommand(sql, bdConn))
                    {
                        cmd.Parameters.AddWithValue("@filme", filme_ID);

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string linha =
                                    $"{dr.GetInt32("ID_usuario")} — {dr.GetDateTime("Data_avaliacao").ToString("dd/MM/yyyy")}\n" + " " +
                                    $"{dr.GetString("Comentario")}";

                                listComentarios.Items.Add(linha);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar comentários: " + ex.Message);
            }
        }

        private void sair_Click(object sender, EventArgs e)
        {
            var home = new FrmHome();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var avaliar = new FrmAvaliacaoTheGoodFather(filme_ID, usuario_ID);
            avaliar.Show();
            this.Hide();
        }

        private void listComentarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
