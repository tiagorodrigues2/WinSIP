
namespace WinSIP.Forms
{
    partial class Form_GruposPlaylist_View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GruposPlaylist_View));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BtnNew = new System.Windows.Forms.ToolStripButton();
            this.BtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.BtnAjustarColunas = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.statusStrip1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 403);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNew,
            this.BtnUpdate,
            this.BtnDelete,
            this.toolStripSeparator1,
            this.BtnRefresh,
            this.BtnAjustarColunas});
            this.toolStrip2.Location = new System.Drawing.Point(3, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(297, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BtnNew
            // 
            this.BtnNew.Image = global::WinSIP.Properties.Resources.icons8_add_file_32;
            this.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(56, 22);
            this.BtnNew.Text = "Novo";
            this.BtnNew.ToolTipText = "Inserir novo registo";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Image = global::WinSIP.Properties.Resources.icons8_edit_file_32;
            this.BtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(57, 22);
            this.BtnUpdate.Text = "Editar";
            this.BtnUpdate.ToolTipText = "Editar registo(s) selecionado(s)";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::WinSIP.Properties.Resources.icons8_delete_file_32;
            this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(70, 22);
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.ToolTipText = "Eliminar registo(s) selecionado(s)";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = global::WinSIP.Properties.Resources.icons8_restore_page_32;
            this.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(73, 22);
            this.BtnRefresh.Text = "Atualizar";
            this.BtnRefresh.ToolTipText = "Atualizar lista";
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnAjustarColunas
            // 
            this.BtnAjustarColunas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAjustarColunas.Image = global::WinSIP.Properties.Resources.icons8_diff_files_32;
            this.BtnAjustarColunas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAjustarColunas.Name = "BtnAjustarColunas";
            this.BtnAjustarColunas.Size = new System.Drawing.Size(23, 22);
            this.BtnAjustarColunas.Text = "Ajustar Largura das Colunas";
            this.BtnAjustarColunas.ToolTipText = "Ajustar largura das colunas";
            this.BtnAjustarColunas.Click += new System.EventHandler(this.BtnAjustarColunas_Click);
            // 
            // Form_GruposPlaylist_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_GruposPlaylist_View";
            this.ShowIcon = false;
            this.Text = "GruposPlaylist: Tabela";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_GruposPlaylist_View_FormClosing);
            this.Load += new System.EventHandler(this.Form_GruposPlaylist_View_Load);
            this.Shown += new System.EventHandler(this.Form_GruposPlaylist_View_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BtnNew;
        private System.Windows.Forms.ToolStripButton BtnUpdate;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton BtnRefresh;
        private System.Windows.Forms.ToolStripButton BtnAjustarColunas;
    }
}