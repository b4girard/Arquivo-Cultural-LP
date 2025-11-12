namespace Trabalho_Programacao
{
    partial class FrmSugestãoLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSugestãoLivro));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.minhaAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhasListasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SugestãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsugerir = new System.Windows.Forms.Button();
            this.capagb = new System.Windows.Forms.GroupBox();
            this.btncapa = new System.Windows.Forms.Button();
            this.pictureBoxCapaSugestão = new System.Windows.Forms.PictureBox();
            this.idiomaSugestão = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.npagSugestão = new System.Windows.Forms.TextBox();
            this.editoraSugestão = new System.Windows.Forms.TextBox();
            this.isbnSugestão = new System.Windows.Forms.TextBox();
            this.autorSugestão = new System.Windows.Forms.TextBox();
            this.tituloSugestão = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.capagb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapaSugestão)).BeginInit();
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
            this.livrosUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.livrosUSUARIOToolStripMenuItem.Text = "Livros";
            // 
            // filmesUSUARIOToolStripMenuItem
            // 
            this.filmesUSUARIOToolStripMenuItem.Name = "filmesUSUARIOToolStripMenuItem";
            this.filmesUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filmesUSUARIOToolStripMenuItem.Text = "Filmes";
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(322, 376);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(112, 23);
            this.btnsair.TabIndex = 19;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(181, 349);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(112, 23);
            this.btnlimpar.TabIndex = 17;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsugerir
            // 
            this.btnsugerir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsugerir.Location = new System.Drawing.Point(184, 318);
            this.btnsugerir.Name = "btnsugerir";
            this.btnsugerir.Size = new System.Drawing.Size(109, 25);
            this.btnsugerir.TabIndex = 15;
            this.btnsugerir.Text = "Sugerir";
            this.btnsugerir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsugerir.UseVisualStyleBackColor = true;
            this.btnsugerir.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // capagb
            // 
            this.capagb.Controls.Add(this.btncapa);
            this.capagb.Controls.Add(this.pictureBoxCapaSugestão);
            this.capagb.Location = new System.Drawing.Point(419, 51);
            this.capagb.Name = "capagb";
            this.capagb.Size = new System.Drawing.Size(200, 191);
            this.capagb.TabIndex = 30;
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
            // 
            // pictureBoxCapaSugestão
            // 
            this.pictureBoxCapaSugestão.Location = new System.Drawing.Point(41, 25);
            this.pictureBoxCapaSugestão.Name = "pictureBoxCapaSugestão";
            this.pictureBoxCapaSugestão.Size = new System.Drawing.Size(116, 133);
            this.pictureBoxCapaSugestão.TabIndex = 0;
            this.pictureBoxCapaSugestão.TabStop = false;
            // 
            // idiomaSugestão
            // 
            this.idiomaSugestão.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idiomaSugestão.Location = new System.Drawing.Point(200, 191);
            this.idiomaSugestão.Name = "idiomaSugestão";
            this.idiomaSugestão.Size = new System.Drawing.Size(176, 13);
            this.idiomaSugestão.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Idioma:";
            // 
            // npagSugestão
            // 
            this.npagSugestão.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.npagSugestão.Location = new System.Drawing.Point(200, 261);
            this.npagSugestão.Name = "npagSugestão";
            this.npagSugestão.Size = new System.Drawing.Size(176, 13);
            this.npagSugestão.TabIndex = 27;
            // 
            // editoraSugestão
            // 
            this.editoraSugestão.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editoraSugestão.Location = new System.Drawing.Point(200, 225);
            this.editoraSugestão.Name = "editoraSugestão";
            this.editoraSugestão.Size = new System.Drawing.Size(176, 13);
            this.editoraSugestão.TabIndex = 26;
            // 
            // isbnSugestão
            // 
            this.isbnSugestão.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isbnSugestão.Location = new System.Drawing.Point(200, 85);
            this.isbnSugestão.Name = "isbnSugestão";
            this.isbnSugestão.Size = new System.Drawing.Size(176, 13);
            this.isbnSugestão.TabIndex = 25;
            // 
            // autorSugestão
            // 
            this.autorSugestão.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.autorSugestão.Location = new System.Drawing.Point(200, 154);
            this.autorSugestão.Name = "autorSugestão";
            this.autorSugestão.Size = new System.Drawing.Size(176, 13);
            this.autorSugestão.TabIndex = 24;
            // 
            // tituloSugestão
            // 
            this.tituloSugestão.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tituloSugestão.Location = new System.Drawing.Point(200, 118);
            this.tituloSugestão.Name = "tituloSugestão";
            this.tituloSugestão.Size = new System.Drawing.Size(176, 13);
            this.tituloSugestão.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Número de páginas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Editora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Título:";
            // 
            // FrmSugestãoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsugerir);
            this.Controls.Add(this.capagb);
            this.Controls.Add(this.idiomaSugestão);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.npagSugestão);
            this.Controls.Add(this.editoraSugestão);
            this.Controls.Add(this.isbnSugestão);
            this.Controls.Add(this.autorSugestão);
            this.Controls.Add(this.tituloSugestão);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmSugestãoLivro";
            this.Text = "FrmSugestãoLivro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.capagb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapaSugestão)).EndInit();
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
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsugerir;
        private System.Windows.Forms.GroupBox capagb;
        private System.Windows.Forms.Button btncapa;
        private System.Windows.Forms.PictureBox pictureBoxCapaSugestão;
        private System.Windows.Forms.TextBox idiomaSugestão;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox npagSugestão;
        private System.Windows.Forms.TextBox editoraSugestão;
        private System.Windows.Forms.TextBox isbnSugestão;
        private System.Windows.Forms.TextBox autorSugestão;
        private System.Windows.Forms.TextBox tituloSugestão;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}