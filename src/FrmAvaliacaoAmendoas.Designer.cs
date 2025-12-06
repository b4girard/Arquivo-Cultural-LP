namespace Trabalho_Programacao.database
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
            this.isbn = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.autor = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.Label();
            this.idioma = new System.Windows.Forms.Label();
            this.editora = new System.Windows.Forms.Label();
            this.n_pag = new System.Windows.Forms.Label();
            this.capa = new System.Windows.Forms.PictureBox();
            this.listComentarios = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.capa)).BeginInit();
            this.SuspendLayout();
            // 
            // isbn
            // 
            this.isbn.AutoSize = true;
            this.isbn.Location = new System.Drawing.Point(267, 45);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(35, 13);
            this.isbn.TabIndex = 1;
            this.isbn.Text = "label1";
            this.isbn.Click += new System.EventHandler(this.ISBN_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(267, 84);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(35, 13);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Location = new System.Drawing.Point(267, 122);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(35, 13);
            this.autor.TabIndex = 4;
            this.autor.Text = "label1";
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Location = new System.Drawing.Point(270, 153);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(35, 13);
            this.descricao.TabIndex = 5;
            this.descricao.Text = "label1";
            // 
            // idioma
            // 
            this.idioma.AutoSize = true;
            this.idioma.Location = new System.Drawing.Point(270, 192);
            this.idioma.Name = "idioma";
            this.idioma.Size = new System.Drawing.Size(35, 13);
            this.idioma.TabIndex = 6;
            this.idioma.Text = "label1";
            // 
            // editora
            // 
            this.editora.AutoSize = true;
            this.editora.Location = new System.Drawing.Point(277, 228);
            this.editora.Name = "editora";
            this.editora.Size = new System.Drawing.Size(35, 13);
            this.editora.TabIndex = 7;
            this.editora.Text = "label1";
            // 
            // n_pag
            // 
            this.n_pag.AutoSize = true;
            this.n_pag.Location = new System.Drawing.Point(276, 261);
            this.n_pag.Name = "n_pag";
            this.n_pag.Size = new System.Drawing.Size(35, 13);
            this.n_pag.TabIndex = 8;
            this.n_pag.Text = "label1";
            // 
            // capa
            // 
            this.capa.ErrorImage = global::Trabalho_Programacao.Properties.Resources.amendoas;
            this.capa.Image = global::Trabalho_Programacao.Properties.Resources.amendoas;
            this.capa.Location = new System.Drawing.Point(52, 32);
            this.capa.Name = "capa";
            this.capa.Size = new System.Drawing.Size(147, 196);
            this.capa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.capa.TabIndex = 0;
            this.capa.TabStop = false;
            // 
            // listComentarios
            // 
            this.listComentarios.FormattingEnabled = true;
            this.listComentarios.Location = new System.Drawing.Point(406, 154);
            this.listComentarios.Name = "listComentarios";
            this.listComentarios.Size = new System.Drawing.Size(340, 160);
            this.listComentarios.TabIndex = 9;
            // 
            // FrmAvaliacaoAmendoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Text = "FrmAvaliacaoAmendoas";
            this.Load += new System.EventHandler(this.FrmAvaliacaoAmendoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox capa;
        private System.Windows.Forms.Label isbn;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.Label idioma;
        private System.Windows.Forms.Label editora;
        private System.Windows.Forms.Label n_pag;
        private System.Windows.Forms.ListBox listComentarios;
    }
}