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
    public partial class FrmSugestãoLivro : Form
    {
        public FrmSugestãoLivro()
        {
            InitializeComponent();
        }

        public MySqlConnection bdCon;
        public int cod = 0;

        private void Limpar()
        {
            isbnSugestão.Clear();
            tituloSugestão.Clear();
            autorSugestão.Clear();
            idiomaSugestão.Clear();
            editoraSugestão.Clear();
            npagSugestão.Clear();
        }


        private void SugestaoLivro()
        {
            

            using (bdCon = new MySqlConnection("server=localhost; database=REGISTRADOR_FILMES_LIVROS; uid=root; pwd=;"))
            {
                try
                {
                    bdCon.Open();

                    if (cod == 0)
                    {
                        string sql = @"INSERT INTO sugestaolivro ( ISBN ,Titulo ,Autor ,Idioma ,Editora ,N_Paginas ,Capa ) 
                                       VALUES (@ISBN ,@Titulo ,@Autor ,@Idioma ,@Editora ,@N_Paginas ,@Capa)";

                        using (MySqlCommand cmd = new MySqlCommand(sql, bdCon))
                        {
                            cmd.Parameters.AddWithValue("@ISBN", isbnSugestão.Text);
                            cmd.Parameters.AddWithValue("@Titulo", tituloSugestão.Text);
                            cmd.Parameters.AddWithValue("@Autor", autorSugestão.Text);
                            cmd.Parameters.AddWithValue("@Idioma", idiomaSugestão.Text);
                            cmd.Parameters.AddWithValue("@Editora", editoraSugestão.Text);
                            cmd.Parameters.AddWithValue("@N_Paginas", int.TryParse(npagSugestão.Text, out int paginas) ? paginas : 0);
                            cmd.Parameters.AddWithValue("@Capa", pictureBoxCapaSugestão.ImageLocation);

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
            SugestaoLivro();
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
