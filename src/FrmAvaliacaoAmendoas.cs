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
using System.IO;

namespace Trabalho_Programacao.database
{
    public partial class FrmAvaliacaoAmendoas : Form
    {
        private MySqlConnection bdCon;
        private int cod = 0; 
        private string caminhoImagemCompleto = string.Empty;
        private string StringConexao()
        {
            return "server=localhost; database=REGISTRADOR_FILMES_LIVROS_LP; uid=root; pwd=;";
        }
        public FrmAvaliacaoAmendoas()
        {
            InitializeComponent();
        }
        private int livro_ID;


        public FrmAvaliacaoAmendoas(int livroID)
        {
            InitializeComponent();
            livro_ID = livroID;

            CarregarLivro();
            CarregarAvaliacao();
        }
        private void CarregarLivro()
        {
            try
            {
                using (MySqlConnection bdConn = new MySqlConnection(StringConexao()))
                {
                    bdConn.Open();
                    string sql = "SELECT ISBN, Titulo, Autor, Descricao,Idioma, Editora, N_Paginas FROM livro WHERE ID_Livro = @ID_Livro";

                    using (var cmd = new MySqlCommand(sql, bdConn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Livro", livro_ID);

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                isbn.Text = dr.GetString("ISBN");
                                titulo.Text = dr.GetString("Titulo");
                                autor.Text = dr.GetString("Autor");
                                descricao.Text = dr.GetString("Descricao");
                                idioma.Text = dr.GetString("Idioma");
                                editora.Text = dr.GetString("Editora");
                                int numeroDePaginas = dr.GetInt32("N_Paginas");
                                n_pag.Text = dr.GetInt32("N_Paginas").ToString();
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

                    string sql = @"SELECT a.Comentario, a.Data_avaliacao, u.Nome
                                   FROM Avaliacao a
                                   JOIN Usuario u ON u.ID_usuario = a.ID_usuario
                                   WHERE a.ID_livro = @livro
                                   ORDER BY a.Data_avaliacao DESC";

                    using (var cmd = new MySqlCommand(sql, bdConn))
                    {
                        cmd.Parameters.AddWithValue("@livro", livro_ID);

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string linha =
                                    $"{dr.GetString("Nome")} — {dr.GetDateTime("Data_avaliacao").ToString("dd/MM/yyyy")}\n" +
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

        private void FrmAvaliacaoAmendoas_Load(object sender, EventArgs e)
        {

        }

        private void ISBN_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
