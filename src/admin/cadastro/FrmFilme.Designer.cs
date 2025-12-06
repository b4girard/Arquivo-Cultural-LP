namespace Trabalho_Programacao
{
    partial class FrmFilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilme));
            this.btnposter = new System.Windows.Forms.Button();
            this.pictureBoxPoster = new System.Windows.Forms.PictureBox();
            this.idiomaoriginal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.anolancamento = new System.Windows.Forms.TextBox();
            this.diretor = new System.Windows.Forms.TextBox();
            this.titulo = new System.Windows.Forms.TextBox();
            this.imdb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AreaADMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCarregarFilme = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.descricao = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnposter
            // 
            this.btnposter.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnposter.FlatAppearance.BorderSize = 0;
            this.btnposter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnposter.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnposter.Location = new System.Drawing.Point(379, 184);
            this.btnposter.Name = "btnposter";
            this.btnposter.Size = new System.Drawing.Size(116, 33);
            this.btnposter.TabIndex = 15;
            this.btnposter.Text = "Adicionar Poster";
            this.btnposter.UseVisualStyleBackColor = false;
            this.btnposter.Click += new System.EventHandler(this.btnposter_Click);
            // 
            // pictureBoxPoster
            // 
            this.pictureBoxPoster.Location = new System.Drawing.Point(379, 45);
            this.pictureBoxPoster.Name = "pictureBoxPoster";
            this.pictureBoxPoster.Size = new System.Drawing.Size(116, 133);
            this.pictureBoxPoster.TabIndex = 0;
            this.pictureBoxPoster.TabStop = false;
            // 
            // idiomaoriginal
            // 
            this.idiomaoriginal.BackColor = System.Drawing.Color.LightSlateGray;
            this.idiomaoriginal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idiomaoriginal.Location = new System.Drawing.Point(179, 275);
            this.idiomaoriginal.Name = "idiomaoriginal";
            this.idiomaoriginal.Size = new System.Drawing.Size(176, 13);
            this.idiomaoriginal.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Idioma Original";
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnsair.FlatAppearance.BorderSize = 0;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsair.Location = new System.Drawing.Point(179, 387);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(180, 25);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnlimpar.FlatAppearance.BorderSize = 0;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(273, 330);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(86, 51);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            // 
            // btngravar
            // 
            this.btngravar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btngravar.FlatAppearance.BorderSize = 0;
            this.btngravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngravar.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngravar.Location = new System.Drawing.Point(179, 330);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(86, 51);
            this.btngravar.TabIndex = 0;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = false;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // anolancamento
            // 
            this.anolancamento.BackColor = System.Drawing.Color.LightSlateGray;
            this.anolancamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.anolancamento.Location = new System.Drawing.Point(179, 310);
            this.anolancamento.Name = "anolancamento";
            this.anolancamento.Size = new System.Drawing.Size(176, 13);
            this.anolancamento.TabIndex = 23;
            // 
            // diretor
            // 
            this.diretor.BackColor = System.Drawing.Color.LightSlateGray;
            this.diretor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diretor.Location = new System.Drawing.Point(179, 135);
            this.diretor.Name = "diretor";
            this.diretor.Size = new System.Drawing.Size(176, 13);
            this.diretor.TabIndex = 22;
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.Color.LightSlateGray;
            this.titulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titulo.Location = new System.Drawing.Point(179, 100);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(176, 13);
            this.titulo.TabIndex = 21;
            // 
            // imdb
            // 
            this.imdb.BackColor = System.Drawing.Color.LightSlateGray;
            this.imdb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imdb.Location = new System.Drawing.Point(179, 65);
            this.imdb.Name = "imdb";
            this.imdb.Size = new System.Drawing.Size(176, 13);
            this.imdb.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ano de lançamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Diretor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Título";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "IMDB";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AreaADMToolStripMenuItem,
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(117, 471);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "Area Administrador";
            // 
            // AreaADMToolStripMenuItem
            // 
            this.AreaADMToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Book", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaADMToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AreaADMToolStripMenuItem.Image")));
            this.AreaADMToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AreaADMToolStripMenuItem.Name = "AreaADMToolStripMenuItem";
            this.AreaADMToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.AreaADMToolStripMenuItem.Text = "Minha Área";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LivrosToolStripMenuItem,
            this.FilmesToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.cadastroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroToolStripMenuItem.Image")));
            this.cadastroToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // LivrosToolStripMenuItem
            // 
            this.LivrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LivrosToolStripMenuItem.Image")));
            this.LivrosToolStripMenuItem.Name = "LivrosToolStripMenuItem";
            this.LivrosToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.LivrosToolStripMenuItem.Text = "Livros";
            this.LivrosToolStripMenuItem.Click += new System.EventHandler(this.LivrosToolStripMenuItem_Click);
            // 
            // FilmesToolStripMenuItem
            // 
            this.FilmesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FilmesToolStripMenuItem.Image")));
            this.FilmesToolStripMenuItem.Name = "FilmesToolStripMenuItem";
            this.FilmesToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.FilmesToolStripMenuItem.Text = "Filmes";
            this.FilmesToolStripMenuItem.Click += new System.EventHandler(this.FilmesToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(562, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(515, 174);
            this.dataGridView1.TabIndex = 31;
            // 
            // btnCarregarFilme
            // 
            this.btnCarregarFilme.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCarregarFilme.FlatAppearance.BorderSize = 0;
            this.btnCarregarFilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarFilme.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarFilme.Location = new System.Drawing.Point(812, 225);
            this.btnCarregarFilme.Name = "btnCarregarFilme";
            this.btnCarregarFilme.Size = new System.Drawing.Size(141, 33);
            this.btnCarregarFilme.TabIndex = 32;
            this.btnCarregarFilme.Text = "Carregar Sugestões";
            this.btnCarregarFilme.UseVisualStyleBackColor = false;
            this.btnCarregarFilme.Click += new System.EventHandler(this.btnCarregarFilme_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSelecionar.FlatAppearance.BorderSize = 0;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(959, 225);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(118, 33);
            this.btnSelecionar.TabIndex = 33;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            // 
            // descricao
            // 
            this.descricao.BackColor = System.Drawing.Color.LightSlateGray;
            this.descricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descricao.Location = new System.Drawing.Point(179, 170);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(176, 83);
            this.descricao.TabIndex = 35;
            this.descricao.Text = "";
            this.descricao.TextChanged += new System.EventHandler(this.descricao_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(176, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "Descrição";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel7.Location = new System.Drawing.Point(179, 252);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(180, 2);
            this.panel7.TabIndex = 119;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel5.Location = new System.Drawing.Point(179, 322);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 2);
            this.panel5.TabIndex = 118;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel4.Location = new System.Drawing.Point(179, 287);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 2);
            this.panel4.TabIndex = 116;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.Location = new System.Drawing.Point(179, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 2);
            this.panel3.TabIndex = 117;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Location = new System.Drawing.Point(179, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 2);
            this.panel2.TabIndex = 115;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Location = new System.Drawing.Point(179, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 2);
            this.panel1.TabIndex = 114;
            // 
            // FrmFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1135, 471);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnposter);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnCarregarFilme);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.pictureBoxPoster);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.idiomaoriginal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.anolancamento);
            this.Controls.Add(this.diretor);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.imdb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmFilme";
            this.Text = "Cadastro de Filme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnposter;
        private System.Windows.Forms.PictureBox pictureBoxPoster;
        private System.Windows.Forms.TextBox idiomaoriginal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.TextBox anolancamento;
        private System.Windows.Forms.TextBox diretor;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.TextBox imdb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AreaADMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilmesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCarregarFilme;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.RichTextBox descricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}