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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Editora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Número de páginas:";
            // 
            // titulo
            // 
            this.titulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titulo.Location = new System.Drawing.Point(215, 122);
            this.titulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(235, 15);
            this.titulo.TabIndex = 5;
            // 
            // autor
            // 
            this.autor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.autor.Location = new System.Drawing.Point(215, 166);
            this.autor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(235, 15);
            this.autor.TabIndex = 6;
            // 
            // isbn
            // 
            this.isbn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isbn.Location = new System.Drawing.Point(215, 81);
            this.isbn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(235, 15);
            this.isbn.TabIndex = 7;
            // 
            // editora
            // 
            this.editora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editora.Location = new System.Drawing.Point(215, 254);
            this.editora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editora.Name = "editora";
            this.editora.Size = new System.Drawing.Size(235, 15);
            this.editora.TabIndex = 8;
            // 
            // npag
            // 
            this.npag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.npag.Location = new System.Drawing.Point(215, 298);
            this.npag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.npag.Name = "npag";
            this.npag.Size = new System.Drawing.Size(235, 15);
            this.npag.TabIndex = 9;
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(401, 439);
            this.btnsair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(149, 28);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(213, 406);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(149, 28);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btngravar
            // 
            this.btngravar.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngravar.Location = new System.Drawing.Point(217, 368);
            this.btngravar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(115, 31);
            this.btngravar.TabIndex = 0;
            this.btngravar.Text = "Gravar";
            this.btngravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Idioma:";
            // 
            // idioma
            // 
            this.idioma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idioma.Location = new System.Drawing.Point(215, 212);
            this.idioma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idioma.Name = "idioma";
            this.idioma.Size = new System.Drawing.Size(235, 15);
            this.idioma.TabIndex = 12;
            // 
            // btncapa
            // 
            this.btncapa.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapa.Location = new System.Drawing.Point(568, 252);
            this.btncapa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncapa.Name = "btncapa";
            this.btncapa.Size = new System.Drawing.Size(155, 28);
            this.btncapa.TabIndex = 15;
            this.btncapa.Text = "Adicionar Capa";
            this.btncapa.UseVisualStyleBackColor = true;
            this.btncapa.Click += new System.EventHandler(this.btncapa_Click);
            // 
            // pictureBoxCapa
            // 
            this.pictureBoxCapa.Location = new System.Drawing.Point(568, 81);
            this.pictureBoxCapa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxCapa.Name = "pictureBoxCapa";
            this.pictureBoxCapa.Size = new System.Drawing.Size(155, 164);
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
            this.menuStrip1.Size = new System.Drawing.Size(124, 580);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "Area Administrador";
            // 
            // AreaADMToolStripMenuItem
            // 
            this.AreaADMToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.AreaADMToolStripMenuItem.Name = "AreaADMToolStripMenuItem";
            this.AreaADMToolStripMenuItem.Size = new System.Drawing.Size(107, 28);
            this.AreaADMToolStripMenuItem.Text = "Minha Área";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LivrosToolStripMenuItem,
            this.FilmesToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.cadastroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroToolStripMenuItem.Image")));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(107, 28);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // LivrosToolStripMenuItem
            // 
            this.LivrosToolStripMenuItem.Name = "LivrosToolStripMenuItem";
            this.LivrosToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.LivrosToolStripMenuItem.Text = "Livros";
            this.LivrosToolStripMenuItem.Click += new System.EventHandler(this.LivrosToolStripMenuItem_Click);
            // 
            // FilmesToolStripMenuItem
            // 
            this.FilmesToolStripMenuItem.Name = "FilmesToolStripMenuItem";
            this.FilmesToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.FilmesToolStripMenuItem.Text = "Filmes";
            this.FilmesToolStripMenuItem.Click += new System.EventHandler(this.FilmesToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(746, 81);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(503, 209);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnCarregarLivro
            // 
            this.btnCarregarLivro.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarLivro.Location = new System.Drawing.Point(940, 321);
            this.btnCarregarLivro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCarregarLivro.Name = "btnCarregarLivro";
            this.btnCarregarLivro.Size = new System.Drawing.Size(157, 28);
            this.btnCarregarLivro.TabIndex = 17;
            this.btnCarregarLivro.Text = "Carregar Sugestões";
            this.btnCarregarLivro.UseVisualStyleBackColor = true;
            this.btnCarregarLivro.Click += new System.EventHandler(this.btnCarregarLivro_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(1261, 321);
            this.btnSelecionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(157, 28);
            this.btnSelecionar.TabIndex = 34;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // FrmLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1513, 580);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmLivro";
            this.Text = "Cadastro de Livro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}

