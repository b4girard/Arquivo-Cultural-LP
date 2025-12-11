namespace Trabalho_Programacao.user.reviewLivros.Jantar_Secreto
{
    partial class FrmAvaliacaoJantarSecreto
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comentario = new System.Windows.Forms.RichTextBox();
            this.nota = new System.Windows.Forms.NumericUpDown();
            this.sair = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabalho_Programacao.Properties.Resources._692b7bc6a845e_jantar_secreto;
            this.pictureBox1.Location = new System.Drawing.Point(19, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // comentario
            // 
            this.comentario.Location = new System.Drawing.Point(155, 66);
            this.comentario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comentario.Name = "comentario";
            this.comentario.Size = new System.Drawing.Size(198, 86);
            this.comentario.TabIndex = 27;
            this.comentario.Text = "";
            // 
            // nota
            // 
            this.nota.Location = new System.Drawing.Point(155, 19);
            this.nota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nota.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(44, 20);
            this.nota.TabIndex = 26;
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sair.FlatAppearance.BorderSize = 0;
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sair.Location = new System.Drawing.Point(19, 198);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(116, 33);
            this.sair.TabIndex = 29;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ok.FlatAppearance.BorderSize = 0;
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok.Location = new System.Drawing.Point(19, 158);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(116, 33);
            this.ok.TabIndex = 28;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // FrmAvaliacaoJantarSecreto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1135, 471);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.comentario);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAvaliacaoJantarSecreto";
            this.Text = "Avaliação - Jantar Secreto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox comentario;
        private System.Windows.Forms.NumericUpDown nota;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button ok;
    }
}