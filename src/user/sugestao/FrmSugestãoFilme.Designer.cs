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
            this.descricaoSugestao = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosterSugestão)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Franklin Gothic Book", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minhaAreaToolStripMenuItem,
            this.SugestãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(117, 471);
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
            // 
            // criarListaToolStripMenuItem
            // 
            this.criarListaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("criarListaToolStripMenuItem.Image")));
            this.criarListaToolStripMenuItem.Name = "criarListaToolStripMenuItem";
            this.criarListaToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.criarListaToolStripMenuItem.Text = "Criar Lista";
            // 
            // minhasListasToolStripMenuItem
            // 
            this.minhasListasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("minhasListasToolStripMenuItem.Image")));
            this.minhasListasToolStripMenuItem.Name = "minhasListasToolStripMenuItem";
            this.minhasListasToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.minhasListasToolStripMenuItem.Text = "Minhas Listas";
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
            // 
            // filmesUSUARIOToolStripMenuItem
            // 
            this.filmesUSUARIOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filmesUSUARIOToolStripMenuItem.Image")));
            this.filmesUSUARIOToolStripMenuItem.Name = "filmesUSUARIOToolStripMenuItem";
            this.filmesUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.filmesUSUARIOToolStripMenuItem.Text = "Filmes";
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
            // pictureBoxPosterSugestão
            // 
            this.pictureBoxPosterSugestão.Location = new System.Drawing.Point(379, 45);
            this.pictureBoxPosterSugestão.Name = "pictureBoxPosterSugestão";
            this.pictureBoxPosterSugestão.Size = new System.Drawing.Size(116, 133);
            this.pictureBoxPosterSugestão.TabIndex = 0;
            this.pictureBoxPosterSugestão.TabStop = false;
            this.pictureBoxPosterSugestão.Click += new System.EventHandler(this.pictureBoxPosterSugestão_Click);
            // 
            // idiomaoriginalSugestao
            // 
            this.idiomaoriginalSugestao.BackColor = System.Drawing.Color.LightSlateGray;
            this.idiomaoriginalSugestao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idiomaoriginalSugestao.Location = new System.Drawing.Point(179, 275);
            this.idiomaoriginalSugestao.Name = "idiomaoriginalSugestao";
            this.idiomaoriginalSugestao.Size = new System.Drawing.Size(176, 13);
            this.idiomaoriginalSugestao.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 39;
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
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
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
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsugerir
            // 
            this.btnsugerir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnsugerir.FlatAppearance.BorderSize = 0;
            this.btnsugerir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsugerir.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsugerir.Location = new System.Drawing.Point(179, 330);
            this.btnsugerir.Name = "btnsugerir";
            this.btnsugerir.Size = new System.Drawing.Size(86, 51);
            this.btnsugerir.TabIndex = 0;
            this.btnsugerir.Text = "Sugerir";
            this.btnsugerir.UseVisualStyleBackColor = false;
            this.btnsugerir.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // anolancamentoSugestao
            // 
            this.anolancamentoSugestao.BackColor = System.Drawing.Color.LightSlateGray;
            this.anolancamentoSugestao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.anolancamentoSugestao.Location = new System.Drawing.Point(179, 310);
            this.anolancamentoSugestao.Name = "anolancamentoSugestao";
            this.anolancamentoSugestao.Size = new System.Drawing.Size(176, 13);
            this.anolancamentoSugestao.TabIndex = 37;
            // 
            // diretorSugestao
            // 
            this.diretorSugestao.BackColor = System.Drawing.Color.LightSlateGray;
            this.diretorSugestao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diretorSugestao.Location = new System.Drawing.Point(179, 135);
            this.diretorSugestao.Name = "diretorSugestao";
            this.diretorSugestao.Size = new System.Drawing.Size(176, 13);
            this.diretorSugestao.TabIndex = 36;
            // 
            // tituloSugestao
            // 
            this.tituloSugestao.BackColor = System.Drawing.Color.LightSlateGray;
            this.tituloSugestao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tituloSugestao.Location = new System.Drawing.Point(179, 100);
            this.tituloSugestao.Name = "tituloSugestao";
            this.tituloSugestao.Size = new System.Drawing.Size(176, 13);
            this.tituloSugestao.TabIndex = 35;
            // 
            // imdbSugestao
            // 
            this.imdbSugestao.BackColor = System.Drawing.Color.LightSlateGray;
            this.imdbSugestao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imdbSugestao.Location = new System.Drawing.Point(179, 65);
            this.imdbSugestao.Name = "imdbSugestao";
            this.imdbSugestao.Size = new System.Drawing.Size(176, 13);
            this.imdbSugestao.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ano de lançamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Diretor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Título";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "IMDB";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // descricaoSugestao
            // 
            this.descricaoSugestao.BackColor = System.Drawing.Color.LightSlateGray;
            this.descricaoSugestao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descricaoSugestao.Location = new System.Drawing.Point(179, 170);
            this.descricaoSugestao.Name = "descricaoSugestao";
            this.descricaoSugestao.Size = new System.Drawing.Size(176, 83);
            this.descricaoSugestao.TabIndex = 42;
            this.descricaoSugestao.Text = "";
            this.descricaoSugestao.TextChanged += new System.EventHandler(this.descricao_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(176, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "Descrição";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel7.Location = new System.Drawing.Point(179, 252);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(180, 2);
            this.panel7.TabIndex = 98;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel5.Location = new System.Drawing.Point(179, 322);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 2);
            this.panel5.TabIndex = 96;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel4.Location = new System.Drawing.Point(179, 287);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 2);
            this.panel4.TabIndex = 94;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.Location = new System.Drawing.Point(179, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 2);
            this.panel3.TabIndex = 95;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Location = new System.Drawing.Point(179, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 2);
            this.panel2.TabIndex = 93;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Location = new System.Drawing.Point(179, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 2);
            this.panel1.TabIndex = 92;
            // 
            // FrmSugestaoFilme
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
            this.Controls.Add(this.descricaoSugestao);
            this.Controls.Add(this.label7);
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
            this.Name = "FrmSugestaoFilme";
            this.Text = "Sugestão de Filme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSugestaoFilme_Load);
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
        private System.Windows.Forms.RichTextBox descricaoSugestao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}