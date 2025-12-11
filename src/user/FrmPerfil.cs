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
    public partial class FrmPerfil : Form
    {
        private int usuario_ID;
        public FrmPerfil(int idUsuario)
        {
            InitializeComponent();
            usuario_ID = idUsuario;
            CarregarDadosPerfil();
            CarregarAvaliacao();
        }
        private string StringConexao()
        {
            return "server=localhost; database=REGISTRADOR_FILMES_LIVROS_LP; uid=root; pwd=;";
        }

        private void CarregarDadosPerfil()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(StringConexao()))
                {
                    conn.Open();

                    string sql = "SELECT Usuario, Nome, E_mail FROM Usuario WHERE ID_usuario = @id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", usuario_ID);

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                labNome.Text = dr.GetString("Nome");
                                labEmail.Text = dr.GetString("E_mail");
                                labUsuario.Text = dr.GetString("Usuario");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar perfil: " + ex.Message);
            }
        }

        private void CarregarAvaliacao()
        {

            try
            {
                using (MySqlConnection bdConn = new MySqlConnection(StringConexao()))
                {
                    bdConn.Open();

                    string sql = @"SELECT a.Comentario, a.Data_avaliacao, u.Nome AS Usuario,
                                    l.Titulo AS Livro, f.Titulo AS Filme FROM Avaliacao a 
                                    JOIN Usuario u ON u.ID_usuario = a.ID_usuario
                                    LEFT JOIN Livro l ON l.ID_livro = a.ID_livro
                                    LEFT JOIN Filme f ON f.ID_filme = a.ID_filme
                                    WHERE a.ID_usuario = @usuario
                                    ORDER BY a.Data_avaliacao DESC;";

                    using (var cmd = new MySqlCommand(sql, bdConn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario_ID);

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string livro = dr["Livro"] == DBNull.Value ? "" : dr.GetString("Livro");
                                string filme = dr["Filme"] == DBNull.Value ? "" : dr.GetString("Filme");

                                string titulo = !string.IsNullOrEmpty(livro) ? livro : filme;

                                string linha =
                                    $"{dr.GetString("Usuario")} — {titulo} - {dr.GetDateTime("Data_avaliacao").ToString("dd/MM/yyyy")}\n " +
                                    $"{dr.GetString("Comentario")}";

                                listMinhasAvaliacoes.Items.Add(linha);
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

        private void EditarPerfil()
        {
            string n = nome.Text.Trim();
            string e_mail = email.Text.Trim();
            string u = usuario.Text.Trim();
            string s = senha.Text.Trim();        
            string sa = senhaAtual.Text.Trim();   

            if (sa == "")
            {
                MessageBox.Show("Digite sua senha atual para editar o perfil.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(StringConexao()))
                {
                    conn.Open();

                    string sqlSenha = "SELECT Senha FROM Usuario WHERE ID_usuario = @id";

                    string senhaCorreta;

                    using (var cmdSenha = new MySqlCommand(sqlSenha, conn))
                    {
                        cmdSenha.Parameters.AddWithValue("@id", usuario_ID);
                        senhaCorreta = cmdSenha.ExecuteScalar()?.ToString();
                    }

                    if (senhaCorreta == null || sa != senhaCorreta)
                    {
                        MessageBox.Show("Senha incorreta! Não é possível editar o perfil.");
                        return;
                    }

                    string sqlUpdate;

                    if (string.IsNullOrEmpty(s))
                    {
                        sqlUpdate = @"UPDATE Usuario 
                              SET Nome = @nome, E_mail = @email, Usuario = @usuario
                              WHERE ID_usuario = @id";
                    }
                    else
                    {
                        sqlUpdate = @"UPDATE Usuario 
                              SET Nome = @nome, E_mail = @email, Usuario = @usuario, Senha = @senha
                              WHERE ID_usuario = @id";
                    }

                    using (var cmdUpdate = new MySqlCommand(sqlUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@nome", n);
                        cmdUpdate.Parameters.AddWithValue("@email", e_mail);
                        cmdUpdate.Parameters.AddWithValue("@usuario", u);
                        cmdUpdate.Parameters.AddWithValue("@id", usuario_ID);

                        if (!string.IsNullOrEmpty(s))
                            cmdUpdate.Parameters.AddWithValue("@senha", s);

                        cmdUpdate.ExecuteNonQuery();
                    }

                    MessageBox.Show("Perfil atualizado com sucesso!");
                }

                CarregarDadosPerfil();
                nome.Clear();
                usuario.Clear();
                email.Clear();
                senha.Clear();
                senhaAtual.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar perfil: " + ex.Message);
            }
        }



        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btngravar_Click(object sender, EventArgs e)
        {

        }

        private void perfilUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPerfil perfil = new FrmPerfil(Sessao.ID_UsuarioLogado);
            perfil.Show();
            this.Hide();
        }

        private void criarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCriarLista criarLista = new FrmCriarLista();
            criarLista.Show();
            this.Hide();
        }

        private void minhasListasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMinhasListas minhasListas = new FrmMinhasListas();
            minhasListas.Show();
            this.Hide();
        }

        private void livrosUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSugestaoLivro sugestãoLivro = new FrmSugestaoLivro();
            sugestãoLivro.Show();
            this.Hide();
        }

        private void filmesUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSugestaoFilme sugestãoFilme = new FrmSugestaoFilme();
            sugestãoFilme.Show();
            this.Hide();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            EditarPerfil();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var home = new FrmHome();
            home.Show();
            this.Hide();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Sessao.ID_UsuarioLogado = 0;
            var entrada = new FrmEntrada();
            entrada.Show();

            this.Hide();
        }
    }
}
