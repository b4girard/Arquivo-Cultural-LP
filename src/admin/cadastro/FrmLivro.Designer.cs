namespace Trabalho_Programacao
{
    partial class FrmLivro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {           
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.TextBox();
            this.autor = new System.Windows.Forms.TextBox();
            this.isbn = new System.Windows.Forms.TextBox();
            this.editora = new System.Windows.Forms.TextBox();
            this.npag = new System.Windows.Forms.TextBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.idioma = new System.Windows.Forms.TextBox();
            this.btncapa = new System.Windows.Forms.Button();
            this.pictureBoxCapa = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AreaADMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCarregarLivro = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.descricao = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.caminhoimagem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Editora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Número de páginas";
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.Color.LightSlateGray;
            this.titulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titulo.Location = new System.Drawing.Point(179, 100);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(176, 13);
            this.titulo.TabIndex = 5;
            // 
            // autor
            // 
            this.autor.BackColor = System.Drawing.Color.LightSlateGray;
            this.autor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.autor.Location = new System.Drawing.Point(179, 135);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(176, 13);
            this.autor.TabIndex = 6;
            // 
            // isbn
            // 
            this.isbn.BackColor = System.Drawing.Color.LightSlateGray;
            this.isbn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isbn.Location = new System.Drawing.Point(179, 65);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(176, 13);
            this.isbn.TabIndex = 7;
            // 
            // editora
            // 
            this.editora.BackColor = System.Drawing.Color.LightSlateGray;
            this.editora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editora.Location = new System.Drawing.Point(179, 310);
            this.editora.Name = "editora";
            this.editora.Size = new System.Drawing.Size(176, 13);
            this.editora.TabIndex = 8;
            // 
            // npag
            // 
            this.npag.BackColor = System.Drawing.Color.LightSlateGray;
            this.npag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.npag.Location = new System.Drawing.Point(179, 345);
            this.npag.Name = "npag";
            this.npag.Size = new System.Drawing.Size(176, 13);
            this.npag.TabIndex = 9;
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnsair.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnsair.FlatAppearance.BorderSize = 0;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsair.Location = new System.Drawing.Point(179, 422);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(180, 25);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnlimpar.FlatAppearance.BorderSize = 0;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(273, 365);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(86, 51);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btngravar
            // 
            this.btngravar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btngravar.FlatAppearance.BorderSize = 0;
            this.btngravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngravar.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngravar.Location = new System.Drawing.Point(179, 365);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(86, 51);
            this.btngravar.TabIndex = 0;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = false;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Idioma";
            // 
            // idioma
            // 
            this.idioma.BackColor = System.Drawing.Color.LightSlateGray;
            this.idioma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idioma.Location = new System.Drawing.Point(179, 275);
            this.idioma.Name = "idioma";
            this.idioma.Size = new System.Drawing.Size(176, 13);
            this.idioma.TabIndex = 12;
            // 
            // btncapa
            // 
            this.btncapa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btncapa.FlatAppearance.BorderSize = 0;
            this.btncapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapa.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapa.Location = new System.Drawing.Point(379, 184);
            this.btncapa.Name = "btncapa";
            this.btncapa.Size = new System.Drawing.Size(116, 33);
            this.btncapa.TabIndex = 15;
            this.btncapa.Text = "Adicionar Capa";
            this.btncapa.UseVisualStyleBackColor = false;
            this.btncapa.Click += new System.EventHandler(this.btncapa_Click);
            // 
            // pictureBoxCapa
            // 
            this.pictureBoxCapa.Location = new System.Drawing.Point(379, 45);
            this.pictureBoxCapa.Name = "pictureBoxCapa";
            this.pictureBoxCapa.Size = new System.Drawing.Size(116, 133);
            this.pictureBoxCapa.TabIndex = 0;
            this.pictureBoxCapa.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "Area Administrador";
            // 
            // AreaADMToolStripMenuItem
            // 
            this.AreaADMToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
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
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
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
            this.dataGridView1.TabIndex = 16;
            // 
            // btnCarregarLivro
            // 
            this.btnCarregarLivro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCarregarLivro.FlatAppearance.BorderSize = 0;
            this.btnCarregarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarLivro.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarLivro.Location = new System.Drawing.Point(812, 225);
            this.btnCarregarLivro.Name = "btnCarregarLivro";
            this.btnCarregarLivro.Size = new System.Drawing.Size(141, 33);
            this.btnCarregarLivro.TabIndex = 17;
            this.btnCarregarLivro.Text = "Carregar Sugestões";
            this.btnCarregarLivro.UseVisualStyleBackColor = false;
            this.btnCarregarLivro.Click += new System.EventHandler(this.btnCarregarLivro_Click);
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
            this.btnSelecionar.TabIndex = 34;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // descricao
            // 
            this.descricao.BackColor = System.Drawing.Color.LightSlateGray;
            this.descricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descricao.Location = new System.Drawing.Point(179, 170);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(176, 83);
            this.descricao.TabIndex = 36;
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
            this.label7.TabIndex = 35;
            this.label7.Text = "Descrição";
            // 
            // caminhoimagem
            // 
            this.caminhoimagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caminhoimagem.Location = new System.Drawing.Point(763, 381);
            this.caminhoimagem.Name = "caminhoimagem";
            this.caminhoimagem.Size = new System.Drawing.Size(176, 13);
            this.caminhoimagem.TabIndex = 38;
            this.caminhoimagem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(778, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 18);
            this.label8.TabIndex = 37;
            this.label8.Text = "Número de páginas";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel7.Location = new System.Drawing.Point(179, 252);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(180, 2);
            this.panel7.TabIndex = 96;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel5.Location = new System.Drawing.Point(179, 322);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 2);
            this.panel5.TabIndex = 94;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel4.Location = new System.Drawing.Point(179, 287);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 2);
            this.panel4.TabIndex = 92;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel6.Location = new System.Drawing.Point(179, 357);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(180, 2);
            this.panel6.TabIndex = 95;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.Location = new System.Drawing.Point(179, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 2);
            this.panel3.TabIndex = 93;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Location = new System.Drawing.Point(179, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 2);
            this.panel2.TabIndex = 91;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Location = new System.Drawing.Point(179, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 2);
            this.panel1.TabIndex = 90;
            // 
            // FrmLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1135, 471);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.caminhoimagem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btncapa);
            this.Controls.Add(this.btnCarregarLivro);
            this.Controls.Add(this.pictureBoxCapa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.idioma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.npag);
            this.Controls.Add(this.editora);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLivro";
            this.Text = "Cadastro de Livro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLivro_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapa)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.TextBox autor;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.TextBox editora;
        private System.Windows.Forms.TextBox npag;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idioma;
        private System.Windows.Forms.PictureBox pictureBoxCapa;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btncapa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AreaADMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilmesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCarregarLivro;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.RichTextBox descricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox caminhoimagem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

