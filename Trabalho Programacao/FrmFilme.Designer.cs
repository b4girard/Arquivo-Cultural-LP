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
            this.postergb = new System.Windows.Forms.GroupBox();
            this.btnposter = new System.Windows.Forms.Button();
            this.pictureBoxPoster = new System.Windows.Forms.PictureBox();
            this.idiomaoriginal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.postergb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // postergb
            // 
            this.postergb.Controls.Add(this.btnposter);
            this.postergb.Controls.Add(this.pictureBoxPoster);
            this.postergb.Location = new System.Drawing.Point(583, 33);
            this.postergb.Name = "postergb";
            this.postergb.Size = new System.Drawing.Size(200, 191);
            this.postergb.TabIndex = 29;
            this.postergb.TabStop = false;
            this.postergb.Text = "Poster";
            // 
            // btnposter
            // 
            this.btnposter.Location = new System.Drawing.Point(41, 164);
            this.btnposter.Name = "btnposter";
            this.btnposter.Size = new System.Drawing.Size(116, 23);
            this.btnposter.TabIndex = 15;
            this.btnposter.Text = "Adicionar Poster";
            this.btnposter.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPoster
            // 
            this.pictureBoxPoster.Location = new System.Drawing.Point(41, 25);
            this.pictureBoxPoster.Name = "pictureBoxPoster";
            this.pictureBoxPoster.Size = new System.Drawing.Size(116, 133);
            this.pictureBoxPoster.TabIndex = 0;
            this.pictureBoxPoster.TabStop = false;
            // 
            // idiomaoriginal
            // 
            this.idiomaoriginal.Location = new System.Drawing.Point(176, 220);
            this.idiomaoriginal.Name = "idiomaoriginal";
            this.idiomaoriginal.Size = new System.Drawing.Size(144, 20);
            this.idiomaoriginal.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Idioma Original";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsair);
            this.groupBox1.Controls.Add(this.btnlimpar);
            this.groupBox1.Controls.Add(this.btngravar);
            this.groupBox1.Location = new System.Drawing.Point(351, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 181);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(44, 124);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(112, 23);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(44, 87);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(112, 23);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(46, 43);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(112, 23);
            this.btngravar.TabIndex = 0;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // anolancamento
            // 
            this.anolancamento.Location = new System.Drawing.Point(176, 283);
            this.anolancamento.Name = "anolancamento";
            this.anolancamento.Size = new System.Drawing.Size(144, 20);
            this.anolancamento.TabIndex = 23;
            // 
            // diretor
            // 
            this.diretor.Location = new System.Drawing.Point(176, 157);
            this.diretor.Name = "diretor";
            this.diretor.Size = new System.Drawing.Size(144, 20);
            this.diretor.TabIndex = 22;
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(176, 99);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(144, 20);
            this.titulo.TabIndex = 21;
            // 
            // imdb
            // 
            this.imdb.Location = new System.Drawing.Point(176, 48);
            this.imdb.Name = "imdb";
            this.imdb.Size = new System.Drawing.Size(144, 20);
            this.imdb.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ano de lançamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Diretor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Título";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "IMDB";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AreaADMToolStripMenuItem,
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(128, 614);
            this.menuStrip1.TabIndex = 30;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(176, 341);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 167);
            this.dataGridView1.TabIndex = 31;
            // 
            // btnCarregarFilme
            // 
            this.btnCarregarFilme.Location = new System.Drawing.Point(176, 514);
            this.btnCarregarFilme.Name = "btnCarregarFilme";
            this.btnCarregarFilme.Size = new System.Drawing.Size(118, 23);
            this.btnCarregarFilme.TabIndex = 32;
            this.btnCarregarFilme.Text = "Carregar Sugestões";
            this.btnCarregarFilme.UseVisualStyleBackColor = true;
            // 
            // FrmFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 614);
            this.Controls.Add(this.btnCarregarFilme);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.postergb);
            this.Controls.Add(this.idiomaoriginal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.anolancamento);
            this.Controls.Add(this.diretor);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.imdb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmFilme";
            this.Text = "FrmFilme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.postergb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox postergb;
        private System.Windows.Forms.Button btnposter;
        private System.Windows.Forms.PictureBox pictureBoxPoster;
        private System.Windows.Forms.TextBox idiomaoriginal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}