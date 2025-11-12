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
    public partial class FrmEntrada : Form
    {
        public FrmEntrada()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        public MySqlConnection bdCon;
        public int cod = 0;

        private void Limpar()
        {
            usuario.Clear();
            nome.Clear();
            emailcadastro.Clear();
            senhacadastro.Clear();
            emaillogin.Clear();
            senhalogin.Clear();

        }
        private void Cadastrar()
        {
            using(bdCon = new MySqlConnection("server=localhost; database=REGISTRADOR_FILMES_LIVROS; uid=root; pwd=;"))
            {
                try
                {
                    bdCon.Open();

                    if (cod == 0)
                    {
                        string sql = @"INSERT INTO usuario (Usuario, Nome, E_mail, Senha, Tipo_usuario)
                                       VALUES (@Usuario, @Nome, @Email, @Senha, 'usuario')";

                        using (MySqlCommand cmd = new MySqlCommand(sql, bdCon))
                        {
                            cmd.Parameters.AddWithValue("@Usuario", usuario.Text);
                            cmd.Parameters.AddWithValue("@Nome", nome.Text);
                            cmd.Parameters.AddWithValue("@Email", emailcadastro.Text);
                            cmd.Parameters.AddWithValue("@Senha", senhacadastro.Text);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    private void Login()
        {
            using (bdCon = new MySqlConnection("server=localhost; database=REGISTRADOR_FILMES_LIVROS; uid=root; pwd=;"))
            {
                try
                {
                    bdCon.Open();

                    string sql = "SELECT * FROM usuario WHERE E_mail=@Email AND Senha=@Senha";
                    using (MySqlCommand cmd = new MySqlCommand(sql, bdCon))
                    {
                        cmd.Parameters.AddWithValue("@Email", emaillogin.Text);
                        cmd.Parameters.AddWithValue("@Senha", senhalogin.Text);

                        MySqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            string tipo = dr["Tipo_usuario"].ToString();
                            MessageBox.Show($"Login bem-sucedido! Tipo: {tipo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();

                            if (tipo == "administrador")
                            {
                                FrmHomeADM homeADM = new FrmHomeADM();
                                homeADM.ShowDialog();
                            }
                            else
                            {
                                FrmHome home = new FrmHome();
                                home.ShowDialog();
                            }

                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("E-mail ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no login: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
