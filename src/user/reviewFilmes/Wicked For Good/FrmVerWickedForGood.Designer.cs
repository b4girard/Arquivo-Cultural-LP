namespace Trabalho_Programacao.user.reviewFilmes
{
    partial class FrmVerWickedForGood
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
            this.sair = new System.Windows.Forms.Button();
            this.listComentarios = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ano = new System.Windows.Forms.Label();
            this.idiomaoriginal = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.Label();
            this.diretor = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.imdb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sair.FlatAppearance.BorderSize = 0;
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sair.Location = new System.Drawing.Point(19, 197);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(116, 33);
            this.sair.TabIndex = 39;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // listComentarios
            // 
            this.listComentarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listComentarios.FormattingEnabled = true;
            this.listComentarios.Location = new System.Drawing.Point(300, 19);
            this.listComentarios.Name = "listComentarios";
            this.listComentarios.Size = new System.Drawing.Size(340, 208);
            this.listComentarios.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(19, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 30;
            this.button1.Text = "Avaliar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ano
            // 
            this.ano.AutoSize = true;
            this.ano.Location = new System.Drawing.Point(141, 241);
            this.ano.Name = "ano";
            this.ano.Size = new System.Drawing.Size(35, 13);
            this.ano.TabIndex = 45;
            this.ano.Text = "label1";
            // 
            // idiomaoriginal
            // 
            this.idiomaoriginal.AutoSize = true;
            this.idiomaoriginal.Location = new System.Drawing.Point(141, 197);
            this.idiomaoriginal.Name = "idiomaoriginal";
            this.idiomaoriginal.Size = new System.Drawing.Size(35, 13);
            this.idiomaoriginal.TabIndex = 44;
            this.idiomaoriginal.Text = "label1";
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Location = new System.Drawing.Point(141, 153);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(35, 13);
            this.descricao.TabIndex = 43;
            this.descricao.Text = "label1";
            // 
            // diretor
            // 
            this.diretor.AutoSize = true;
            this.diretor.Location = new System.Drawing.Point(141, 109);
            this.diretor.Name = "diretor";
            this.diretor.Size = new System.Drawing.Size(35, 13);
            this.diretor.TabIndex = 42;
            this.diretor.Text = "label1";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(141, 65);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(35, 13);
            this.titulo.TabIndex = 41;
            this.titulo.Text = "label2";
            // 
            // imdb
            // 
            this.imdb.AutoSize = true;
            this.imdb.Location = new System.Drawing.Point(141, 21);
            this.imdb.Name = "imdb";
            this.imdb.Size = new System.Drawing.Size(35, 13);
            this.imdb.TabIndex = 40;
            this.imdb.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabalho_Programacao.Properties.Resources._693055c050206_692f96f3d21eb_wicked2;
            this.pictureBox1.Location = new System.Drawing.Point(19, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // FrmVerWickedForGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1135, 471);
            this.Controls.Add(this.ano);
            this.Controls.Add(this.idiomaoriginal);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.diretor);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.imdb);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.listComentarios);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmVerWickedForGood";
            this.Text = "Ver - Wicked: For Good";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.ListBox listComentarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ano;
        private System.Windows.Forms.Label idiomaoriginal;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.Label diretor;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label imdb;
    }
}