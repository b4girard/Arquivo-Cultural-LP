namespace Trabalho_Programacao.Usuario.Avaliacoes_Livros
{
    partial class FrmVerJantarSecreto
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
            this.button1 = new System.Windows.Forms.Button();
            this.listComentarios = new System.Windows.Forms.ListBox();
            this.n_pag = new System.Windows.Forms.Label();
            this.editora = new System.Windows.Forms.Label();
            this.idioma = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.Label();
            this.autor = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.Label();
            this.sair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(19, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Avaliar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listComentarios
            // 
            this.listComentarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listComentarios.FormattingEnabled = true;
            this.listComentarios.Location = new System.Drawing.Point(19, 251);
            this.listComentarios.Name = "listComentarios";
            this.listComentarios.Size = new System.Drawing.Size(340, 208);
            this.listComentarios.TabIndex = 27;
            this.listComentarios.SelectedIndexChanged += new System.EventHandler(this.listComentarios_SelectedIndexChanged);
            // 
            // n_pag
            // 
            this.n_pag.AutoSize = true;
            this.n_pag.Location = new System.Drawing.Point(141, 231);
            this.n_pag.Name = "n_pag";
            this.n_pag.Size = new System.Drawing.Size(35, 13);
            this.n_pag.TabIndex = 26;
            this.n_pag.Text = "label1";
            // 
            // editora
            // 
            this.editora.AutoSize = true;
            this.editora.Location = new System.Drawing.Point(141, 189);
            this.editora.Name = "editora";
            this.editora.Size = new System.Drawing.Size(35, 13);
            this.editora.TabIndex = 25;
            this.editora.Text = "label1";
            // 
            // idioma
            // 
            this.idioma.AutoSize = true;
            this.idioma.Location = new System.Drawing.Point(141, 147);
            this.idioma.Name = "idioma";
            this.idioma.Size = new System.Drawing.Size(35, 13);
            this.idioma.TabIndex = 24;
            this.idioma.Text = "label1";
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Location = new System.Drawing.Point(324, 21);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(35, 13);
            this.descricao.TabIndex = 23;
            this.descricao.Text = "label1";
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Location = new System.Drawing.Point(141, 105);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(35, 13);
            this.autor.TabIndex = 22;
            this.autor.Text = "label1";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(141, 63);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(35, 13);
            this.titulo.TabIndex = 21;
            this.titulo.Text = "label2";
            // 
            // isbn
            // 
            this.isbn.AutoSize = true;
            this.isbn.Location = new System.Drawing.Point(141, 21);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(35, 13);
            this.isbn.TabIndex = 20;
            this.isbn.Text = "label1";
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sair.FlatAppearance.BorderSize = 0;
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sair.Location = new System.Drawing.Point(19, 197);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(116, 33);
            this.sair.TabIndex = 28;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabalho_Programacao.Properties.Resources._692b7bc6a845e_jantar_secreto;
            this.pictureBox1.Location = new System.Drawing.Point(19, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FrmVerJantarSecreto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1135, 471);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.listComentarios);
            this.Controls.Add(this.n_pag);
            this.Controls.Add(this.editora);
            this.Controls.Add(this.idioma);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmVerJantarSecreto";
            this.Text = "Ver - Jantar Secreto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listComentarios;
        private System.Windows.Forms.Label n_pag;
        private System.Windows.Forms.Label editora;
        private System.Windows.Forms.Label idioma;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label isbn;
        private System.Windows.Forms.Button sair;
    }
}