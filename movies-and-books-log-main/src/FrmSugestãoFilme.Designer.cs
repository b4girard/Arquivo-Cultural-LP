namespace Trabalho_Programacao
{
    partial class FrmSugestaoFilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSugestaoFilme));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.minhaAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhasListasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SugestãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnposter = new System.Windows.Forms.Button();
            this.pictureBoxPosterSugestão = new System.Windows.Forms.PictureBox();
            this.idiomaoriginalSugestao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosterSugestão)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Franklin Gothic Book", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minhaAreaToolStripMenuItem,
            this.SugestãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(127, 554);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // minhaAreaToolStripMenuItem
            // 
            this.minhaAreaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilUSUARIOToolStripMenuItem,
            this.criarListaToolStripMenuItem,
            this.minhasListasToolStripMenuItem});
            this.minhaAreaToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.minhaAreaToolStripMenuItem.Name = "minhaAreaToolStripMenuItem";
            this.minhaAreaToolStripMenuItem.Size = new System.Drawing.Size(110, 28);
            this.minhaAreaToolStripMenuItem.Text = "Minha Área";
            // 
            // perfilUSUARIOToolStripMenuItem
            // 
            this.perfilUSUARIOToolStripMenuItem.Name = "perfilUSUARIOToolStripMenuItem";
            this.perfilUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.perfilUSUARIOToolStripMenuItem.Text = "Perfil";
            // 
            // criarListaToolStripMenuItem
            // 
            this.criarListaToolStripMenuItem.Name = "criarListaToolStripMenuItem";
            this.criarListaToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.criarListaToolStripMenuItem.Text = "Criar Lista";
            // 
            // minhasListasToolStripMenuItem
            // 
            this.minhasListasToolStripMenuItem.Name = "minhasListasToolStripMenuItem";
            this.minhasListasToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.minhasListasToolStripMenuItem.Text = "Minhas Listas";
            // 
            // SugestãoToolStripMenuItem
            // 
            this.SugestãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosUSUARIOToolStripMenuItem,
            this.filmesUSUARIOToolStripMenuItem});
            this.SugestãoToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.SugestãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SugestãoToolStripMenuItem.Image")));
            this.SugestãoToolStripMenuItem.Name = "SugestãoToolStripMenuItem";
            this.SugestãoToolStripMenuItem.Size = new System.Drawing.Size(110, 28);
            this.SugestãoToolStripMenuItem.Text = "Sugestão";
            // 
            // livrosUSUARIOToolStripMenuItem
            // 
            this.livrosUSUARIOToolStripMenuItem.Name = "livrosUSUARIOToolStripMenuItem";
            this.livrosUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.livrosUSUARIOToolStripMenuItem.Text = "Livros";
            // 
            // filmesUSUARIOToolStripMenuItem
            // 
            this.filmesUSUARIOToolStripMenuItem.Name = "filmesUSUARIOToolStripMenuItem";
            this.filmesUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.filmesUSUARIOToolStripMenuItem.Text = "Filmes";
            // 
            // btnposter
            // 
            this.btnposter.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnposter.Location = new System.Drawing.Point(764, 386);
            this.btnposter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnposter.Name = "btnposter";
            this.btnposter.Size = new System.Drawing.Size(155, 28);
            this.btnposter.TabIndex = 15;
            this.btnposter.Text = "Adicionar Poster";
            this.btnposter.UseVisualStyleBackColor = true;
            this.btnposter.Click += new System.EventHandler(this.btnposter_Click);
            // 
            // pictureBoxPosterSugestão
            // 
            this.pictureBoxPosterSugestão.Location = new System.Drawing.Point(764, 215);
            this.pictureBoxPosterSugestão.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxPosterSugestão.Name = "pictureBoxPosterSugestão";
            this.pictureBoxPosterSugestão.Size = new System.Drawing.Size(155, 164);
            this.pictureBoxPosterSugestão.TabIndex = 0;
            this.pictureBoxPosterSugestão.TabStop = false;
            this.pictureBoxPosterSugestão.Click += new System.EventHandler(this.pictureBoxPosterSugestão_Click);
            // 
            // idiomaoriginalSugestao
            // 
            this.idiomaoriginalSugestao.Location = new System.Drawing.Point(215, 342);
            this.idiomaoriginalSugestao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idiomaoriginalSugestao.Name = "idiomaoriginalSugestao";
            this.idiomaoriginalSugestao.Size = new System.Drawing.Size(191, 22);
            this.idiomaoriginalSugestao.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "Idioma Original";
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(547, 338);
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
            this.btnlimpar.Location = new System.Drawing.Point(547, 293);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(149, 28);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsugerir
            // 
            this.btnsugerir.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsugerir.Location = new System.Drawing.Point(549, 239);
            this.btnsugerir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsugerir.Name = "btnsugerir";
            this.btnsugerir.Size = new System.Drawing.Size(149, 28);
            this.btnsugerir.TabIndex = 0;
            this.btnsugerir.Text = "Sugerir";
            this.btnsugerir.UseVisualStyleBackColor = true;
            this.btnsugerir.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // anolancamentoSugestao
            // 
            this.anolancamentoSugestao.Location = new System.Drawing.Point(215, 420);
            this.anolancamentoSugestao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.anolancamentoSugestao.Name = "anolancamentoSugestao";
            this.anolancamentoSugestao.Size = new System.Drawing.Size(191, 22);
            this.anolancamentoSugestao.TabIndex = 37;
            // 
            // diretorSugestao
            // 
            this.diretorSugestao.Location = new System.Drawing.Point(215, 265);
            this.diretorSugestao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diretorSugestao.Name = "diretorSugestao";
            this.diretorSugestao.Size = new System.Drawing.Size(191, 22);
            this.diretorSugestao.TabIndex = 36;
            // 
            // tituloSugestao
            // 
            this.tituloSugestao.Location = new System.Drawing.Point(215, 193);
            this.tituloSugestao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tituloSugestao.Name = "tituloSugestao";
            this.tituloSugestao.Size = new System.Drawing.Size(191, 22);
            this.tituloSugestao.TabIndex = 35;
            // 
            // imdbSugestao
            // 
            this.imdbSugestao.Location = new System.Drawing.Point(215, 130);
            this.imdbSugestao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imdbSugestao.Name = "imdbSugestao";
            this.imdbSugestao.Size = new System.Drawing.Size(191, 22);
            this.imdbSugestao.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 400);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ano de lançamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Diretor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Título";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "IMDB";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmSugestaoFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnposter);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.pictureBoxPosterSugestão);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.idiomaoriginalSugestao);
            this.Controls.Add(this.btnsugerir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.anolancamentoSugestao);
            this.Controls.Add(this.diretorSugestao);
            this.Controls.Add(this.tituloSugestao);
            this.Controls.Add(this.imdbSugestao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSugestaoFilme";
            this.Text = "Sugestão de Filme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosterSugestão)).EndInit();
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
        private System.Windows.Forms.Button btnposter;
        private System.Windows.Forms.PictureBox pictureBoxPosterSugestão;
        private System.Windows.Forms.TextBox idiomaoriginalSugestao;
        private System.Windows.Forms.Label label4;
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