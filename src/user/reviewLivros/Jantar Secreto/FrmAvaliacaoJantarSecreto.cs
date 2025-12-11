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
using Trabalho_Programacao.Usuario.Avaliacoes_Livros;

namespace Trabalho_Programacao.user.reviewLivros.Jantar_Secreto
{
    public partial class FrmAvaliacaoJantarSecreto : Form
    {
        public FrmAvaliacaoJantarSecreto()
        {
            InitializeComponent();
        }
        private int livro_ID;
        private int usuario_ID;

        public FrmAvaliacaoJantarSecreto(int idLivro, int idUsuario)
        {
            InitializeComponent();
            usuario_ID = idUsuario;
            livro_ID = idLivro;
            this.Text = "Avaliar Livro: Jantar Secreto";
        }
        private string StringConexao()
        {
            return "server=localhost; database=REGISTRADOR_FILMES_LIVROS_LP; uid=root; pwd=;";
        }

        private void SalvarAvaliacao(int nota, string comentario)
        {
            string sql = @"INSERT INTO avaliacao (ID_usuario, ID_livro, Nota, Comentario) 
                            VALUES (@idUsuario, @idLivro, @nota, @comentario)";

            try
            {
                using (MySqlConnection bdConn = new MySqlConnection(StringConexao()))
                {
                    bdConn.Open();
                    using (var cmd = new MySqlCommand(sql, bdConn))
                    {
                        cmd.Parameters.AddWithValue("@idUsuario", usuario_ID);
                        cmd.Parameters.AddWithValue("@idLivro", livro_ID);
                        cmd.Parameters.AddWithValue("@nota", nota);
                        cmd.Parameters.AddWithValue("@comentario", comentario);

                        int linhas = cmd.ExecuteNonQuery();

                        if (linhas > 0)
                        {
                            MessageBox.Show("Avaliação de Livro salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ok_Click(object sender, EventArgs e)
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

            var jantarsecreto = new FrmVerJantarSecreto(2, Sessao.ID_UsuarioLogado);
            jantarsecreto.Show();
            this.Hide();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            var home = new FrmHome();
            home.Show();
            this.Hide();
        }
    }
}
