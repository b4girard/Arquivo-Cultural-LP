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
            this.components = new System.ComponentModel.Container();
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
            this.capagb = new System.Windows.Forms.GroupBox();
            this.btncapa = new System.Windows.Forms.Button();
            this.pictureBoxCapa = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AreaADMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCarregarLivro = new System.Windows.Forms.Button();
            this.capagb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Editora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Número de páginas:";
            // 
            // titulo
            // 
            this.titulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titulo.Location = new System.Drawing.Point(137, 99);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(176, 13);
            this.titulo.TabIndex = 5;
            // 
            // autor
            // 
            this.autor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.autor.Location = new System.Drawing.Point(137, 135);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(176, 13);
            this.autor.TabIndex = 6;
            // 
            // isbn
            // 
            this.isbn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isbn.Location = new System.Drawing.Point(137, 66);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(176, 13);
            this.isbn.TabIndex = 7;
            // 
            // editora
            // 
            this.editora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editora.Location = new System.Drawing.Point(137, 206);
            this.editora.Name = "editora";
            this.editora.Size = new System.Drawing.Size(176, 13);
            this.editora.TabIndex = 8;
            // 
            // npag
            // 
            this.npag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.npag.Location = new System.Drawing.Point(137, 242);
            this.npag.Name = "npag";
            this.npag.Size = new System.Drawing.Size(176, 13);
            this.npag.TabIndex = 9;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(259, 357);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(112, 23);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(118, 330);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(112, 23);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btngravar
            // 
            this.btngravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngravar.Location = new System.Drawing.Point(121, 299);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(86, 25);
            this.btngravar.TabIndex = 0;
            this.btngravar.Text = "Gravar";
            this.btngravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Idioma:";
            // 
            // idioma
            // 
            this.idioma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idioma.Location = new System.Drawing.Point(137, 172);
            this.idioma.Name = "idioma";
            this.idioma.Size = new System.Drawing.Size(176, 13);
            this.idioma.TabIndex = 12;
            // 
            // capagb
            // 
            this.capagb.Controls.Add(this.btncapa);
            this.capagb.Controls.Add(this.pictureBoxCapa);
            this.capagb.Location = new System.Drawing.Point(356, 32);
            this.capagb.Name = "capagb";
            this.capagb.Size = new System.Drawing.Size(200, 191);
            this.capagb.TabIndex = 14;
            this.capagb.TabStop = false;
            this.capagb.Text = "Capa:";
            // 
            // btncapa
            // 
            this.btncapa.Location = new System.Drawing.Point(41, 164);
            this.btncapa.Name = "btncapa";
            this.btncapa.Size = new System.Drawing.Size(116, 23);
            this.btncapa.TabIndex = 15;
            this.btncapa.Text = "Adicionar Capa";
            this.btncapa.UseVisualStyleBackColor = true;
            this.btncapa.Click += new System.EventHandler(this.btncapa_Click);
            // 
            // pictureBoxCapa
            // 
            this.pictureBoxCapa.Location = new System.Drawing.Point(41, 25);
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
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AreaADMToolStripMenuItem,
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(128, 471);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "Area Administrador";
            // 
            // AreaADMToolStripMenuItem
            // 
            this.AreaADMToolStripMenuItem.Name = "AreaADMToolStripMenuItem";
            this.AreaADMToolStripMenuItem.Size = new System.Drawing.Size(115, 19);
            this.AreaADMToolStripMenuItem.Text = "Area Administrador";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LivrosToolStripMenuItem,
            this.FilmesToolStripMenuItem});
            this.cadastroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroToolStripMenuItem.Image")));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // LivrosToolStripMenuItem
            // 
            this.LivrosToolStripMenuItem.Name = "LivrosToolStripMenuItem";
            this.LivrosToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.LivrosToolStripMenuItem.Text = "Livros";
            this.LivrosToolStripMenuItem.Click += new System.EventHandler(this.LivrosToolStripMenuItem_Click);
            // 
            // FilmesToolStripMenuItem
            // 
            this.FilmesToolStripMenuItem.Name = "FilmesToolStripMenuItem";
            this.FilmesToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.FilmesToolStripMenuItem.Text = "Filmes";
            this.FilmesToolStripMenuItem.Click += new System.EventHandler(this.FilmesToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(687, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 170);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnCarregarLivro
            // 
            this.btnCarregarLivro.Location = new System.Drawing.Point(687, 261);
            this.btnCarregarLivro.Name = "btnCarregarLivro";
            this.btnCarregarLivro.Size = new System.Drawing.Size(118, 23);
            this.btnCarregarLivro.TabIndex = 17;
            this.btnCarregarLivro.Text = "Carregar Sugestões";
            this.btnCarregarLivro.UseVisualStyleBackColor = true;
            // 
            // FrmLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 471);
            this.Controls.Add(this.btnCarregarLivro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.capagb);
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
            this.Text = "Cadastrar Livro";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.capagb.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox capagb;
        private System.Windows.Forms.PictureBox pictureBoxCapa;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btncapa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AreaADMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilmesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCarregarLivro;
    }
}

