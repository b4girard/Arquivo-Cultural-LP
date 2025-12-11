using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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

namespace Trabalho_Programacao.user.reviewFilmes.Wicked_For_Good
{
    public partial class FrmAvaliacaoWickedForGood : Form
    {
        public FrmAvaliacaoWickedForGood()
        {
            InitializeComponent();
        }

        private int filme_ID;
        private int usuario_ID;

        public FrmAvaliacaoWickedForGood( int idLivro, int idUsuario)
        {
            InitializeComponent();
            usuario_ID = idUsuario;
            filme_ID = idLivro;
            this.Text = "Avaliar Filme: Wicked For Good";
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

        private void sair_Click(object sender, EventArgs e)
        {
            var home = new FrmHome();
            home.Show();
            this.Hide();
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

            var wfg = new FrmVerWickedForGood(1, Sessao.ID_UsuarioLogado);
            wfg.Show(); 
            this.Hide();

        }
    }
}
