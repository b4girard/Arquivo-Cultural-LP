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

namespace Trabalho_Programacao.user.reviewFilmes.The_Good_Father
{
    public partial class FrmAvaliacaoTheGoodFather : Form
    {
        public FrmAvaliacaoTheGoodFather()
        {
            InitializeComponent();
        }

        private int filme_ID;
        private int usuario_ID;

        public FrmAvaliacaoTheGoodFather(int idLivro, int idUsuario)
        {
            InitializeComponent();
            usuario_ID = idUsuario;
            filme_ID = idLivro;
            this.Text = "Avaliar Filme: The Good Father";
        }

        private string StringConexao()
        {
            return "server=localhost; database=REGISTRADOR_FILMES_LIVROS_LP; uid=root; pwd=;";
        }

        private void SalvarAvaliacao(int nota, string comentario)
        {
            string sql = @"INSERT INTO avaliacao (ID_usuario, ID_filme, Nota, Comentario) 
                            VALUES (@idUsuario, @idFilme, @nota, @comentario)";

            try
            {
                using (MySqlConnection bdConn = new MySqlConnection(StringConexao()))
                {
                    bdConn.Open();
                    using (var cmd = new MySqlCommand(sql, bdConn))
                    {
                        cmd.Parameters.AddWithValue("@idUsuario", usuario_ID);
                        cmd.Parameters.AddWithValue("@idFilme", filme_ID);
                        cmd.Parameters.AddWithValue("@nota", nota);
                        cmd.Parameters.AddWithValue("@comentario", comentario);

                        int linhas = cmd.ExecuteNonQuery();

                        if (linhas > 0)
                        {
                            MessageBox.Show("Avaliação de Filme salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma avaliação foi salva.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar avaliação de livro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sair_Click_1(object sender, EventArgs e)
        {
            var home = new FrmHome();
            home.Show();
            this.Hide();
        }

        private void ok_Click_1(object sender, EventArgs e)
        {
            int n = (int)nota.Value;
            string c = comentario.Text;

            if (string.IsNullOrWhiteSpace(c))
            {
                MessageBox.Show("O campo de comentário não pode estar vazio.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            comentario.Clear();

            SalvarAvaliacao(n, c);

            var tgf = new FrmVerTheGoodFather(2, Sessao.ID_UsuarioLogado);
            tgf.Show();
            this.Hide();
        }

        private void comentario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
