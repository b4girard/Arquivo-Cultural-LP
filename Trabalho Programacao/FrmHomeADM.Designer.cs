namespace Trabalho_Programacao
{
    partial class FrmHomeADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomeADM));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AreaADMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AreaADMToolStripMenuItem,
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(128, 450);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "Area Administrador";
            // 
            // AreaADMToolStripMenuItem
            // 
            this.AreaADMToolStripMenuItem.Name = "AreaADMToolStripMenuItem";
            this.AreaADMToolStripMenuItem.Size = new System.Drawing.Size(115, 19);
            this.AreaADMToolStripMenuItem.Text = "Area Administrador";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LivrosToolStripMenuItem,
            this.FilmesToolStripMenuItem});
            this.cadastroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroToolStripMenuItem.Image")));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // LivrosToolStripMenuItem
            // 
            this.LivrosToolStripMenuItem.Name = "LivrosToolStripMenuItem";
            this.LivrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LivrosToolStripMenuItem.Text = "Livros";
            this.LivrosToolStripMenuItem.Click += new System.EventHandler(this.LivrosToolStripMenuItem_Click_1);
            // 
            // FilmesToolStripMenuItem
            // 
            this.FilmesToolStripMenuItem.Name = "FilmesToolStripMenuItem";
            this.FilmesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FilmesToolStripMenuItem.Text = "Filmes";
            this.FilmesToolStripMenuItem.Click += new System.EventHandler(this.FilmesToolStripMenuItem_Click_1);
            // 
            // FrmHomeADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmHomeADM";
            this.Text = "FrmHomeADM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AreaADMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilmesToolStripMenuItem;
    }
}