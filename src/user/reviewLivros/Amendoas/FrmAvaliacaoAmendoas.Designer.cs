namespace Trabalho_Programacao.user.reviewLivros.Amendoas
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
            this.sair = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.nota = new System.Windows.Forms.NumericUpDown();
            this.comentario = new System.Windows.Forms.RichTextBox();
            this.capa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capa)).BeginInit();
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
            this.sair.TabIndex = 23;
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
            this.ok.TabIndex = 22;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
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
            this.nota.TabIndex = 24;
            // 
            // comentario
            // 
            this.comentario.Location = new System.Drawing.Point(155, 43);
            this.comentario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comentario.Name = "comentario";
            this.comentario.Size = new System.Drawing.Size(189, 109);
            this.comentario.TabIndex = 25;
            this.comentario.Text = "";
            // 
            // capa
            // 
            this.capa.Image = ((System.Drawing.Image)(resources.GetObject("capa.Image")));
            this.capa.Location = new System.Drawing.Point(19, 19);
            this.capa.Name = "capa";
            this.capa.Size = new System.Drawing.Size(116, 133);
            this.capa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.capa.TabIndex = 21;
            this.capa.TabStop = false;
            // 
            // FrmAvaliacaoAmendoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1135, 471);
            this.Controls.Add(this.comentario);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.capa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAvaliacaoAmendoas";
            this.Text = "Avaliação - Amêndoas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.PictureBox capa;
        private System.Windows.Forms.NumericUpDown nota;
        private System.Windows.Forms.RichTextBox comentario;
    }
}