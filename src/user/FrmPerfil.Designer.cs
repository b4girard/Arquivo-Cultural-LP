namespace Trabalho_Programacao
{
    partial class FrmPerfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfil));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.minhaAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhasListasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SugestãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.listMinhasAvaliacoes = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.senhaAtual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.labNome = new System.Windows.Forms.Label();
            this.labUsuario = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label1.Location = new System.Drawing.Point(488, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label2.Location = new System.Drawing.Point(488, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label3.Location = new System.Drawing.Point(488, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label4.Location = new System.Drawing.Point(488, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha";
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.Color.LightSlateGray;
            this.usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuario.Location = new System.Drawing.Point(490, 121);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(167, 13);
            this.usuario.TabIndex = 4;
            this.usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nome
            // 
            this.nome.BackColor = System.Drawing.Color.LightSlateGray;
            this.nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nome.Location = new System.Drawing.Point(490, 156);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(167, 13);
            this.nome.TabIndex = 5;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.LightSlateGray;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Location = new System.Drawing.Point(490, 191);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(167, 13);
            this.email.TabIndex = 6;
            // 
            // senha
            // 
            this.senha.BackColor = System.Drawing.Color.LightSlateGray;
            this.senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senha.Location = new System.Drawing.Point(490, 226);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(167, 13);
            this.senha.TabIndex = 7;
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnsair.FlatAppearance.BorderSize = 0;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsair.Location = new System.Drawing.Point(584, 298);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(86, 51);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btneditar.FlatAppearance.BorderSize = 0;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Location = new System.Drawing.Point(490, 298);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(86, 51);
            this.btneditar.TabIndex = 8;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minhaAreaToolStripMenuItem,
            this.SugestãoToolStripMenuItem,
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(117, 471);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // minhaAreaToolStripMenuItem
            // 
            this.minhaAreaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilUSUARIOToolStripMenuItem,
            this.criarListaToolStripMenuItem,
            this.minhasListasToolStripMenuItem});
            this.minhaAreaToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Book", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minhaAreaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("minhaAreaToolStripMenuItem.Image")));
            this.minhaAreaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minhaAreaToolStripMenuItem.Name = "minhaAreaToolStripMenuItem";
            this.minhaAreaToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.minhaAreaToolStripMenuItem.Text = "Minha Área";
            // 
            // perfilUSUARIOToolStripMenuItem
            // 
            this.perfilUSUARIOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("perfilUSUARIOToolStripMenuItem.Image")));
            this.perfilUSUARIOToolStripMenuItem.Name = "perfilUSUARIOToolStripMenuItem";
            this.perfilUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.perfilUSUARIOToolStripMenuItem.Text = "Perfil";
            this.perfilUSUARIOToolStripMenuItem.Click += new System.EventHandler(this.perfilUSUARIOToolStripMenuItem_Click);
            // 
            // criarListaToolStripMenuItem
            // 
            this.criarListaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("criarListaToolStripMenuItem.Image")));
            this.criarListaToolStripMenuItem.Name = "criarListaToolStripMenuItem";
            this.criarListaToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.criarListaToolStripMenuItem.Text = "Criar Lista";
            this.criarListaToolStripMenuItem.Click += new System.EventHandler(this.criarListaToolStripMenuItem_Click);
            // 
            // minhasListasToolStripMenuItem
            // 
            this.minhasListasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("minhasListasToolStripMenuItem.Image")));
            this.minhasListasToolStripMenuItem.Name = "minhasListasToolStripMenuItem";
            this.minhasListasToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.minhasListasToolStripMenuItem.Text = "Minhas Listas";
            this.minhasListasToolStripMenuItem.Click += new System.EventHandler(this.minhasListasToolStripMenuItem_Click);
            // 
            // SugestãoToolStripMenuItem
            // 
            this.SugestãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosUSUARIOToolStripMenuItem,
            this.filmesUSUARIOToolStripMenuItem});
            this.SugestãoToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.SugestãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SugestãoToolStripMenuItem.Image")));
            this.SugestãoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SugestãoToolStripMenuItem.Name = "SugestãoToolStripMenuItem";
            this.SugestãoToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.SugestãoToolStripMenuItem.Text = "Sugestão";
            // 
            // livrosUSUARIOToolStripMenuItem
            // 
            this.livrosUSUARIOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("livrosUSUARIOToolStripMenuItem.Image")));
            this.livrosUSUARIOToolStripMenuItem.Name = "livrosUSUARIOToolStripMenuItem";
            this.livrosUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.livrosUSUARIOToolStripMenuItem.Text = "Livros";
            this.livrosUSUARIOToolStripMenuItem.Click += new System.EventHandler(this.livrosUSUARIOToolStripMenuItem_Click);
            // 
            // filmesUSUARIOToolStripMenuItem
            // 
            this.filmesUSUARIOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filmesUSUARIOToolStripMenuItem.Image")));
            this.filmesUSUARIOToolStripMenuItem.Name = "filmesUSUARIOToolStripMenuItem";
            this.filmesUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.filmesUSUARIOToolStripMenuItem.Text = "Filmes";
            this.filmesUSUARIOToolStripMenuItem.Click += new System.EventHandler(this.filmesUSUARIOToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(694, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(490, 238);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 2);
            this.panel5.TabIndex = 50;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(490, 203);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(180, 2);
            this.panel6.TabIndex = 51;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(490, 168);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(180, 2);
            this.panel7.TabIndex = 49;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(490, 133);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(180, 2);
            this.panel8.TabIndex = 48;
            // 
            // listMinhasAvaliacoes
            // 
            this.listMinhasAvaliacoes.FormattingEnabled = true;
            this.listMinhasAvaliacoes.Location = new System.Drawing.Point(179, 266);
            this.listMinhasAvaliacoes.Margin = new System.Windows.Forms.Padding(2);
            this.listMinhasAvaliacoes.Name = "listMinhasAvaliacoes";
            this.listMinhasAvaliacoes.Size = new System.Drawing.Size(286, 95);
            this.listMinhasAvaliacoes.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(490, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 2);
            this.panel1.TabIndex = 55;
            // 
            // senhaAtual
            // 
            this.senhaAtual.BackColor = System.Drawing.Color.LightSlateGray;
            this.senhaAtual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senhaAtual.Location = new System.Drawing.Point(490, 262);
            this.senhaAtual.Name = "senhaAtual";
            this.senhaAtual.Size = new System.Drawing.Size(167, 13);
            this.senhaAtual.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.label5.Location = new System.Drawing.Point(488, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "Senha Atual";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.labEmail.Location = new System.Drawing.Point(488, 185);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(39, 18);
            this.labEmail.TabIndex = 71;
            this.labEmail.Text = "email";
            // 
            // labNome
            // 
            this.labNome.AutoSize = true;
            this.labNome.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.labNome.Location = new System.Drawing.Point(488, 150);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(41, 18);
            this.labNome.TabIndex = 72;
            this.labNome.Text = "nome";
            // 
            // labUsuario
            // 
            this.labUsuario.AutoSize = true;
            this.labUsuario.Font = new System.Drawing.Font("Franklin Gothic Book", 10F);
            this.labUsuario.Location = new System.Drawing.Point(488, 115);
            this.labUsuario.Name = "labUsuario";
            this.labUsuario.Size = new System.Drawing.Size(53, 18);
            this.labUsuario.TabIndex = 73;
            this.labUsuario.Text = "usuario";
            // 
            // FrmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1135, 471);
            this.Controls.Add(this.labUsuario);
            this.Controls.Add(this.labNome);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.senhaAtual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listMinhasAvaliacoes);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPerfil";
            this.Text = "Perfil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem minhaAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilUSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minhasListasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SugestãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosUSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmesUSUARIOToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ListBox listMinhasAvaliacoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox senhaAtual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.Label labUsuario;
    }
}