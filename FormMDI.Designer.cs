
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
            this.selecionarMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.selecionarMonitorToolStripMenuItem,
            this.abrirMonitorToolStripMenuItem,
            this.administraçaoToolStripMenuItem,
            this.gerenciarContaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(169, 587);
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
            this.tabelasToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
            this.tabelasToolStripMenuItem.Size = new System.Drawing.Size(156, 25);
            this.tabelasToolStripMenuItem.Text = "Tabelas";
            // 
            // displaysToolStripMenuItem
            // 
            this.displaysToolStripMenuItem.Name = "displaysToolStripMenuItem";
            this.displaysToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.displaysToolStripMenuItem.Text = "Displays";
            this.displaysToolStripMenuItem.Click += new System.EventHandler(this.displaysToolStripMenuItem_Click);
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.gruposToolStripMenuItem.Text = "Grupos";
            this.gruposToolStripMenuItem.Click += new System.EventHandler(this.gruposToolStripMenuItem_Click);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.filesToolStripMenuItem.Text = "Files";
            this.filesToolStripMenuItem.Click += new System.EventHandler(this.filesToolStripMenuItem_Click);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.playlistToolStripMenuItem.Text = "Playlist";
            this.playlistToolStripMenuItem.Click += new System.EventHandler(this.playlistToolStripMenuItem_Click);
            // 
            // browserToolStripMenuItem
            // 
            this.browserToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.browserToolStripMenuItem.Name = "browserToolStripMenuItem";
            this.browserToolStripMenuItem.Size = new System.Drawing.Size(156, 25);
            this.browserToolStripMenuItem.Text = "Testar Monitor";
            this.browserToolStripMenuItem.Click += new System.EventHandler(this.browserToolStripMenuItem_Click);
            // 
            // selecionarMonitorToolStripMenuItem
            // 
            this.selecionarMonitorToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.selecionarMonitorToolStripMenuItem.Name = "selecionarMonitorToolStripMenuItem";
            this.selecionarMonitorToolStripMenuItem.Size = new System.Drawing.Size(156, 25);
            this.selecionarMonitorToolStripMenuItem.Text = "Selecionar Monitor";
            this.selecionarMonitorToolStripMenuItem.Click += new System.EventHandler(this.selecionarMonitorToolStripMenuItem_Click);
            // 
            // abrirMonitorToolStripMenuItem
            // 
            this.abrirMonitorToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.abrirMonitorToolStripMenuItem.Name = "abrirMonitorToolStripMenuItem";
            this.abrirMonitorToolStripMenuItem.Size = new System.Drawing.Size(156, 25);
            this.abrirMonitorToolStripMenuItem.Text = "Abrir Monitor";
            this.abrirMonitorToolStripMenuItem.Click += new System.EventHandler(this.abrirMonitorToolStripMenuItem_Click);
            // 
            // administraçaoToolStripMenuItem
            // 
            this.administraçaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirUtilizadoresToolStripMenuItem,
            this.gerirCódigosDeAcessoToolStripMenuItem});
            this.administraçaoToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.administraçaoToolStripMenuItem.Name = "administraçaoToolStripMenuItem";
            this.administraçaoToolStripMenuItem.Size = new System.Drawing.Size(156, 25);
            this.administraçaoToolStripMenuItem.Text = "Administraçao";
            // 
            // gerirUtilizadoresToolStripMenuItem
            // 
            this.gerirUtilizadoresToolStripMenuItem.Name = "gerirUtilizadoresToolStripMenuItem";
            this.gerirUtilizadoresToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.gerirUtilizadoresToolStripMenuItem.Text = "Gerir Utilizadores";
            this.gerirUtilizadoresToolStripMenuItem.Click += new System.EventHandler(this.gerirUtilizadoresToolStripMenuItem_Click);
            // 
            // gerirCódigosDeAcessoToolStripMenuItem
            // 
            this.gerirCódigosDeAcessoToolStripMenuItem.Name = "gerirCódigosDeAcessoToolStripMenuItem";
            this.gerirCódigosDeAcessoToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.gerirCódigosDeAcessoToolStripMenuItem.Text = "Gerir Códigos de Acesso";
            this.gerirCódigosDeAcessoToolStripMenuItem.Click += new System.EventHandler(this.gerirCódigosDeAcessoToolStripMenuItem_Click);
            // 
            // gerenciarContaToolStripMenuItem
            // 
            this.gerenciarContaToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.gerenciarContaToolStripMenuItem.Name = "gerenciarContaToolStripMenuItem";
            this.gerenciarContaToolStripMenuItem.Size = new System.Drawing.Size(156, 25);
            this.gerenciarContaToolStripMenuItem.Text = "Gerenciar Conta";
            this.gerenciarContaToolStripMenuItem.Click += new System.EventHandler(this.gerenciarContaToolStripMenuItem_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinSIP.Properties.Resources.background_small1;
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
        private System.Windows.Forms.ToolStripMenuItem administraçaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirUtilizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirCódigosDeAcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecionarMonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirMonitorToolStripMenuItem;
    }
}

