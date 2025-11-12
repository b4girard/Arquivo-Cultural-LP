namespace Trabalho_Programacao
{
    partial class FrmSugestãoFilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSugestãoFilme));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.minhaAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhasListasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SugestãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postergb = new System.Windows.Forms.GroupBox();
            this.btnposter = new System.Windows.Forms.Button();
            this.pictureBoxPosterSugestão = new System.Windows.Forms.PictureBox();
            this.idiomaoriginalSugestao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsugerir = new System.Windows.Forms.Button();
            this.anolancamentoSugestao = new System.Windows.Forms.TextBox();
            this.diretorSugestao = new System.Windows.Forms.TextBox();
            this.tituloSugestao = new System.Windows.Forms.TextBox();
            this.imdbSugestao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.postergb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosterSugestão)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minhaAreaToolStripMenuItem,
            this.SugestãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(89, 450);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // minhaAreaToolStripMenuItem
            // 
            this.minhaAreaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilUSUARIOToolStripMenuItem,
            this.criarListaToolStripMenuItem,
            this.minhasListasToolStripMenuItem});
            this.minhaAreaToolStripMenuItem.Name = "minhaAreaToolStripMenuItem";
            this.minhaAreaToolStripMenuItem.Size = new System.Drawing.Size(76, 19);
            this.minhaAreaToolStripMenuItem.Text = "Minha Area";
            // 
            // perfilUSUARIOToolStripMenuItem
            // 
            this.perfilUSUARIOToolStripMenuItem.Name = "perfilUSUARIOToolStripMenuItem";
            this.perfilUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.perfilUSUARIOToolStripMenuItem.Text = "Perfil";
            // 
            // criarListaToolStripMenuItem
            // 
            this.criarListaToolStripMenuItem.Name = "criarListaToolStripMenuItem";
            this.criarListaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.criarListaToolStripMenuItem.Text = "Criar Lista";
            // 
            // minhasListasToolStripMenuItem
            // 
            this.minhasListasToolStripMenuItem.Name = "minhasListasToolStripMenuItem";
            this.minhasListasToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.minhasListasToolStripMenuItem.Text = "Minhas Listas";
            // 
            // SugestãoToolStripMenuItem
            // 
            this.SugestãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosUSUARIOToolStripMenuItem,
            this.filmesUSUARIOToolStripMenuItem});
            this.SugestãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SugestãoToolStripMenuItem.Image")));
            this.SugestãoToolStripMenuItem.Name = "SugestãoToolStripMenuItem";
            this.SugestãoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.SugestãoToolStripMenuItem.Text = "Sugestão";
            // 
            // livrosUSUARIOToolStripMenuItem
            // 
            this.livrosUSUARIOToolStripMenuItem.Name = "livrosUSUARIOToolStripMenuItem";
            this.livrosUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.livrosUSUARIOToolStripMenuItem.Text = "Livros";
            // 
            // filmesUSUARIOToolStripMenuItem
            // 
            this.filmesUSUARIOToolStripMenuItem.Name = "filmesUSUARIOToolStripMenuItem";
            this.filmesUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.filmesUSUARIOToolStripMenuItem.Text = "Filmes";
            // 
            // postergb
            // 
            this.postergb.Controls.Add(this.btnposter);
            this.postergb.Controls.Add(this.pictureBoxPosterSugestão);
            this.postergb.Location = new System.Drawing.Point(506, 91);
            this.postergb.Name = "postergb";
            this.postergb.Size = new System.Drawing.Size(200, 191);
            this.postergb.TabIndex = 41;
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
            this.btnposter.Click += new System.EventHandler(this.btnposter_Click);
            // 
            // pictureBoxPosterSugestão
            // 
            this.pictureBoxPosterSugestão.Location = new System.Drawing.Point(41, 25);
            this.pictureBoxPosterSugestão.Name = "pictureBoxPosterSugestão";
            this.pictureBoxPosterSugestão.Size = new System.Drawing.Size(116, 133);
            this.pictureBoxPosterSugestão.TabIndex = 0;
            this.pictureBoxPosterSugestão.TabStop = false;
            // 
            // idiomaoriginalSugestao
            // 
            this.idiomaoriginalSugestao.Location = new System.Drawing.Point(99, 278);
            this.idiomaoriginalSugestao.Name = "idiomaoriginalSugestao";
            this.idiomaoriginalSugestao.Size = new System.Drawing.Size(144, 20);
            this.idiomaoriginalSugestao.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Idioma Original";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsair);
            this.groupBox1.Controls.Add(this.btnlimpar);
            this.groupBox1.Controls.Add(this.btnsugerir);
            this.groupBox1.Location = new System.Drawing.Point(274, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 181);
            this.groupBox1.TabIndex = 38;
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
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(44, 87);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(112, 23);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsugerir
            // 
            this.btnsugerir.Location = new System.Drawing.Point(46, 43);
            this.btnsugerir.Name = "btnsugerir";
            this.btnsugerir.Size = new System.Drawing.Size(112, 23);
            this.btnsugerir.TabIndex = 0;
            this.btnsugerir.Text = "Sugerir";
            this.btnsugerir.UseVisualStyleBackColor = true;
            this.btnsugerir.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // anolancamentoSugestao
            // 
            this.anolancamentoSugestao.Location = new System.Drawing.Point(99, 341);
            this.anolancamentoSugestao.Name = "anolancamentoSugestao";
            this.anolancamentoSugestao.Size = new System.Drawing.Size(144, 20);
            this.anolancamentoSugestao.TabIndex = 37;
            // 
            // diretorSugestao
            // 
            this.diretorSugestao.Location = new System.Drawing.Point(99, 215);
            this.diretorSugestao.Name = "diretorSugestao";
            this.diretorSugestao.Size = new System.Drawing.Size(144, 20);
            this.diretorSugestao.TabIndex = 36;
            // 
            // tituloSugestao
            // 
            this.tituloSugestao.Location = new System.Drawing.Point(99, 157);
            this.tituloSugestao.Name = "tituloSugestao";
            this.tituloSugestao.Size = new System.Drawing.Size(144, 20);
            this.tituloSugestao.TabIndex = 35;
            // 
            // imdbSugestao
            // 
            this.imdbSugestao.Location = new System.Drawing.Point(99, 106);
            this.imdbSugestao.Name = "imdbSugestao";
            this.imdbSugestao.Size = new System.Drawing.Size(144, 20);
            this.imdbSugestao.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ano de lançamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Diretor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Título";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "IMDB";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmSugestãoFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.postergb);
            this.Controls.Add(this.idiomaoriginalSugestao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.anolancamentoSugestao);
            this.Controls.Add(this.diretorSugestao);
            this.Controls.Add(this.tituloSugestao);
            this.Controls.Add(this.imdbSugestao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmSugestãoFilme";
            this.Text = "FrmSugestãoFilme";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.postergb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosterSugestão)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem minhaAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilUSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minhasListasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SugestãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosUSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmesUSUARIOToolStripMenuItem;
        private System.Windows.Forms.GroupBox postergb;
        private System.Windows.Forms.Button btnposter;
        private System.Windows.Forms.PictureBox pictureBoxPosterSugestão;
        private System.Windows.Forms.TextBox idiomaoriginalSugestao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsugerir;
        private System.Windows.Forms.TextBox anolancamentoSugestao;
        private System.Windows.Forms.TextBox diretorSugestao;
        private System.Windows.Forms.TextBox tituloSugestao;
        private System.Windows.Forms.TextBox imdbSugestao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}