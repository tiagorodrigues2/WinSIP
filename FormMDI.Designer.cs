
namespace WinSIP
{
    partial class FormMDI
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.template2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraçaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirUtilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirCódigosDeAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelasToolStripMenuItem,
            this.browserToolStripMenuItem,
            this.administraçaoToolStripMenuItem,
            this.gerenciarContaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 587);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // tabelasToolStripMenuItem
            // 
            this.tabelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displaysToolStripMenuItem,
            this.gruposToolStripMenuItem,
            this.filesToolStripMenuItem,
            this.playlistToolStripMenuItem});
            this.tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
            this.tabelasToolStripMenuItem.Size = new System.Drawing.Size(97, 19);
            this.tabelasToolStripMenuItem.Text = "Tabelas";
            // 
            // displaysToolStripMenuItem
            // 
            this.displaysToolStripMenuItem.Name = "displaysToolStripMenuItem";
            this.displaysToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.displaysToolStripMenuItem.Text = "Displays";
            this.displaysToolStripMenuItem.Click += new System.EventHandler(this.displaysToolStripMenuItem_Click);
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.gruposToolStripMenuItem.Text = "Grupos";
            this.gruposToolStripMenuItem.Click += new System.EventHandler(this.gruposToolStripMenuItem_Click);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.filesToolStripMenuItem.Text = "Files";
            this.filesToolStripMenuItem.Click += new System.EventHandler(this.filesToolStripMenuItem_Click);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.playlistToolStripMenuItem.Text = "Playlist";
            this.playlistToolStripMenuItem.Click += new System.EventHandler(this.playlistToolStripMenuItem_Click);
            // 
            // browserToolStripMenuItem
            // 
            this.browserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.template2ToolStripMenuItem});
            this.browserToolStripMenuItem.Name = "browserToolStripMenuItem";
            this.browserToolStripMenuItem.Size = new System.Drawing.Size(97, 19);
            this.browserToolStripMenuItem.Text = "Browser";
            // 
            // template2ToolStripMenuItem
            // 
            this.template2ToolStripMenuItem.Name = "template2ToolStripMenuItem";
            this.template2ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.template2ToolStripMenuItem.Text = "Template 2";
            this.template2ToolStripMenuItem.Click += new System.EventHandler(this.template2ToolStripMenuItem_Click);
            // 
            // administraçaoToolStripMenuItem
            // 
            this.administraçaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirUtilizadoresToolStripMenuItem,
            this.gerirCódigosDeAcessoToolStripMenuItem});
            this.administraçaoToolStripMenuItem.Name = "administraçaoToolStripMenuItem";
            this.administraçaoToolStripMenuItem.Size = new System.Drawing.Size(97, 19);
            this.administraçaoToolStripMenuItem.Text = "Administraçao";
            // 
            // gerirUtilizadoresToolStripMenuItem
            // 
            this.gerirUtilizadoresToolStripMenuItem.Name = "gerirUtilizadoresToolStripMenuItem";
            this.gerirUtilizadoresToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.gerirUtilizadoresToolStripMenuItem.Text = "Gerir Utilizadores";
            this.gerirUtilizadoresToolStripMenuItem.Click += new System.EventHandler(this.gerirUtilizadoresToolStripMenuItem_Click);
            // 
            // gerirCódigosDeAcessoToolStripMenuItem
            // 
            this.gerirCódigosDeAcessoToolStripMenuItem.Name = "gerirCódigosDeAcessoToolStripMenuItem";
            this.gerirCódigosDeAcessoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.gerirCódigosDeAcessoToolStripMenuItem.Text = "Gerir Códigos de Acesso";
            this.gerirCódigosDeAcessoToolStripMenuItem.Click += new System.EventHandler(this.gerirCódigosDeAcessoToolStripMenuItem_Click);
            // 
            // gerenciarContaToolStripMenuItem
            // 
            this.gerenciarContaToolStripMenuItem.Name = "gerenciarContaToolStripMenuItem";
            this.gerenciarContaToolStripMenuItem.Size = new System.Drawing.Size(97, 19);
            this.gerenciarContaToolStripMenuItem.Text = "Gerenciar Conta";
            this.gerenciarContaToolStripMenuItem.Click += new System.EventHandler(this.gerenciarContaToolStripMenuItem_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 587);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormMDI";
            this.Text = "Sistema Gestor de Multimédia Remota";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tabelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem template2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraçaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirUtilizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirCódigosDeAcessoToolStripMenuItem;
    }
}

