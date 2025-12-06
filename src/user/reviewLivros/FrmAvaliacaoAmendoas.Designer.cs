namespace Trabalho_Programacao.Usuario.Avaliacoes_Livros
{
    partial class FrmAvaliacaoAmendoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAvaliacaoAmendoas));
            this.listComentarios = new System.Windows.Forms.ListBox();
            this.n_pag = new System.Windows.Forms.Label();
            this.editora = new System.Windows.Forms.Label();
            this.idioma = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.Label();
            this.autor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.Label();
            this.capa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.capa)).BeginInit();
            this.SuspendLayout();
            // 
            // listComentarios
            // 
            this.listComentarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listComentarios.FormattingEnabled = true;
            this.listComentarios.Location = new System.Drawing.Point(312, 12);
            this.listComentarios.Name = "listComentarios";
            this.listComentarios.Size = new System.Drawing.Size(340, 221);
            this.listComentarios.TabIndex = 19;
            // 
            // n_pag
            // 
            this.n_pag.AutoSize = true;
            this.n_pag.Location = new System.Drawing.Point(134, 276);
            this.n_pag.Name = "n_pag";
            this.n_pag.Size = new System.Drawing.Size(35, 13);
            this.n_pag.TabIndex = 18;
            this.n_pag.Text = "label1";
            // 
            // editora
            // 
            this.editora.AutoSize = true;
            this.editora.Location = new System.Drawing.Point(134, 232);
            this.editora.Name = "editora";
            this.editora.Size = new System.Drawing.Size(35, 13);
            this.editora.TabIndex = 17;
            this.editora.Text = "label1";
            // 
            // idioma
            // 
            this.idioma.AutoSize = true;
            this.idioma.Location = new System.Drawing.Point(134, 188);
            this.idioma.Name = "idioma";
            this.idioma.Size = new System.Drawing.Size(35, 13);
            this.idioma.TabIndex = 16;
            this.idioma.Text = "label1";
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Location = new System.Drawing.Point(134, 144);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(35, 13);
            this.descricao.TabIndex = 15;
            this.descricao.Text = "label1";
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Location = new System.Drawing.Point(134, 100);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(35, 13);
            this.autor.TabIndex = 14;
            this.autor.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = " Algo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(134, 56);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(35, 13);
            this.titulo.TabIndex = 12;
            this.titulo.Text = "label2";
            // 
            // isbn
            // 
            this.isbn.AutoSize = true;
            this.isbn.Location = new System.Drawing.Point(134, 12);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(35, 13);
            this.isbn.TabIndex = 11;
            this.isbn.Text = "label1";
            // 
            // capa
            // 
            this.capa.Image = ((System.Drawing.Image)(resources.GetObject("capa.Image")));
            this.capa.Location = new System.Drawing.Point(12, 12);
            this.capa.Name = "capa";
            this.capa.Size = new System.Drawing.Size(116, 133);
            this.capa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.capa.TabIndex = 10;
            this.capa.TabStop = false;
            // 
            // FrmAvaliacaoAmendoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listComentarios);
            this.Controls.Add(this.n_pag);
            this.Controls.Add(this.editora);
            this.Controls.Add(this.idioma);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.capa);
            this.Name = "FrmAvaliacaoAmendoas";
            this.Text = "Avaliação";
            ((System.ComponentModel.ISupportInitialize)(this.capa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listComentarios;
        private System.Windows.Forms.Label n_pag;
        private System.Windows.Forms.Label editora;
        private System.Windows.Forms.Label idioma;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label isbn;
        private System.Windows.Forms.PictureBox capa;
    }
}