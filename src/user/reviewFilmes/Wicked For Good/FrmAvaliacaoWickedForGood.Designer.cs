namespace Trabalho_Programacao.user.reviewFilmes.Wicked_For_Good
{
    partial class FrmAvaliacaoWickedForGood
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
            this.ok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comentario = new System.Windows.Forms.RichTextBox();
            this.nota = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota)).BeginInit();
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
            this.sair.TabIndex = 42;
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
            this.ok.TabIndex = 41;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabalho_Programacao.Properties.Resources._693055c050206_692f96f3d21eb_wicked2;
            this.pictureBox1.Location = new System.Drawing.Point(19, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // comentario
            // 
            this.comentario.Location = new System.Drawing.Point(155, 43);
            this.comentario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comentario.Name = "comentario";
            this.comentario.Size = new System.Drawing.Size(189, 109);
            this.comentario.TabIndex = 44;
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
            this.nota.TabIndex = 43;
            // 
            // FrmAvaliacaoWickedForGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1135, 471);
            this.Controls.Add(this.comentario);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAvaliacaoWickedForGood";
            this.Text = "Avaliação - Wicked: For Good";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox comentario;
        private System.Windows.Forms.NumericUpDown nota;
    }
}