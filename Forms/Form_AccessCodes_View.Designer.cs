namespace WinSIP.Forms
{
    partial class Form_AccessCodes_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AccessCodes_View));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BtnNewCode = new System.Windows.Forms.ToolStripButton();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.BtnAjustarLargura = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNewCode,
            this.BtnDelete,
            this.toolStripSeparator1,
            this.BtnAtualizar,
            this.BtnAjustarLargura});
            this.toolStrip2.Location = new System.Drawing.Point(3, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(282, 25);
            this.toolStrip2.TabIndex = 1;
            // 
            // BtnNewCode
            // 
            this.BtnNewCode.Image = global::WinSIP.Properties.Resources.icons8_add_file_32;
            this.BtnNewCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNewCode.Name = "BtnNewCode";
            this.BtnNewCode.Size = new System.Drawing.Size(98, 22);
            this.BtnNewCode.Text = "Novo Codigo";
            this.BtnNewCode.Click += new System.EventHandler(this.BtnNewCode_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::WinSIP.Properties.Resources.icons8_delete_file_32;
            this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(70, 22);
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Image = global::WinSIP.Properties.Resources.icons8_restore_page_32;
            this.BtnAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(73, 22);
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // BtnAjustarLargura
            // 
            this.BtnAjustarLargura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAjustarLargura.Image = global::WinSIP.Properties.Resources.icons8_diff_files_32;
            this.BtnAjustarLargura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAjustarLargura.Name = "BtnAjustarLargura";
            this.BtnAjustarLargura.Size = new System.Drawing.Size(23, 22);
            this.BtnAjustarLargura.Text = "Ajustar Largura";
            this.BtnAjustarLargura.Click += new System.EventHandler(this.BtnAjustarLargura_Click);
            // 
            // Form_AccessCodes_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_AccessCodes_View";
            this.ShowIcon = false;
            this.Text = "Table: AccessCodes View";
            this.Load += new System.EventHandler(this.Form_AccessCodes_View_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BtnNewCode;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnAtualizar;
        private System.Windows.Forms.ToolStripButton BtnAjustarLargura;
    }
}