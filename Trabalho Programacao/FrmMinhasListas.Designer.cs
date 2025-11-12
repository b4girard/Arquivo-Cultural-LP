namespace Trabalho_Programacao
{
    partial class FrmMinhasListas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMinhasListas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.minhaAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhasListasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SugestãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(126, 450);
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
            this.minhaAreaToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.minhaAreaToolStripMenuItem.Text = "Minha Area";
            // 
            // perfilUSUARIOToolStripMenuItem
            // 
            this.perfilUSUARIOToolStripMenuItem.Name = "perfilUSUARIOToolStripMenuItem";
            this.perfilUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.perfilUSUARIOToolStripMenuItem.Text = "Perfil";
            this.perfilUSUARIOToolStripMenuItem.Click += new System.EventHandler(this.perfilUSUARIOToolStripMenuItem_Click);
            // 
            // criarListaToolStripMenuItem
            // 
            this.criarListaToolStripMenuItem.Name = "criarListaToolStripMenuItem";
            this.criarListaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.criarListaToolStripMenuItem.Text = "Criar Lista";
            this.criarListaToolStripMenuItem.Click += new System.EventHandler(this.criarListaToolStripMenuItem_Click);
            // 
            // minhasListasToolStripMenuItem
            // 
            this.minhasListasToolStripMenuItem.Name = "minhasListasToolStripMenuItem";
            this.minhasListasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minhasListasToolStripMenuItem.Text = "Minhas Listas";
            this.minhasListasToolStripMenuItem.Click += new System.EventHandler(this.minhasListasToolStripMenuItem_Click);
            // 
            // SugestãoToolStripMenuItem
            // 
            this.SugestãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosUSUARIOToolStripMenuItem,
            this.filmesUSUARIOToolStripMenuItem});
            this.SugestãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SugestãoToolStripMenuItem.Image")));
            this.SugestãoToolStripMenuItem.Name = "SugestãoToolStripMenuItem";
            this.SugestãoToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.SugestãoToolStripMenuItem.Text = "Sugestão";
            // 
            // livrosUSUARIOToolStripMenuItem
            // 
            this.livrosUSUARIOToolStripMenuItem.Name = "livrosUSUARIOToolStripMenuItem";
            this.livrosUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.livrosUSUARIOToolStripMenuItem.Text = "Livros";
            this.livrosUSUARIOToolStripMenuItem.Click += new System.EventHandler(this.livrosUSUARIOToolStripMenuItem_Click);
            // 
            // filmesUSUARIOToolStripMenuItem
            // 
            this.filmesUSUARIOToolStripMenuItem.Name = "filmesUSUARIOToolStripMenuItem";
            this.filmesUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filmesUSUARIOToolStripMenuItem.Text = "Filmes";
            // 
            // FrmMinhasListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMinhasListas";
            this.Text = "FrmMinhasListas";
            this.Load += new System.EventHandler(this.FrmMinhasListas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}