
namespace WinSIP.Forms
{
    partial class Form_Grupos_Insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Grupos_Insert));
            this.DescritivoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDuplicar = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGridAddPlaylist = new System.Windows.Forms.ToolStripButton();
            this.btnGridDelPlaylist = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGridItemUp = new System.Windows.Forms.ToolStripButton();
            this.btnGridItemDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnToggleActive = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescritivoBox
            // 
            this.DescritivoBox.Location = new System.Drawing.Point(16, 38);
            this.DescritivoBox.Name = "DescritivoBox";
            this.DescritivoBox.Size = new System.Drawing.Size(269, 20);
            this.DescritivoBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descritivo";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(13, 324);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(95, 23);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(376, 330);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(96, 23);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDuplicar
            // 
            this.BtnDuplicar.Location = new System.Drawing.Point(376, 301);
            this.BtnDuplicar.Name = "BtnDuplicar";
            this.BtnDuplicar.Size = new System.Drawing.Size(96, 23);
            this.BtnDuplicar.TabIndex = 8;
            this.BtnDuplicar.Text = "Duplicar";
            this.BtnDuplicar.UseVisualStyleBackColor = true;
            this.BtnDuplicar.Click += new System.EventHandler(this.BtnDuplicar_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(456, 197);
            this.toolStripContainer1.Location = new System.Drawing.Point(16, 73);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(456, 222);
            this.toolStripContainer1.TabIndex = 9;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(456, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGridAddPlaylist,
            this.btnGridDelPlaylist,
            this.toolStripSeparator1,
            this.btnGridItemUp,
            this.btnGridItemDown,
            this.toolStripSeparator2,
            this.BtnToggleActive});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(397, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // btnGridAddPlaylist
            // 
            this.btnGridAddPlaylist.Image = global::WinSIP.Properties.Resources.icons8_add_file_32;
            this.btnGridAddPlaylist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGridAddPlaylist.Name = "btnGridAddPlaylist";
            this.btnGridAddPlaylist.Size = new System.Drawing.Size(118, 22);
            this.btnGridAddPlaylist.Text = "Adicionar Playlist";
            this.btnGridAddPlaylist.ToolTipText = "Adicionar uma playlist ao grupo";
            this.btnGridAddPlaylist.Click += new System.EventHandler(this.btnGridAddPlaylist_Click);
            // 
            // btnGridDelPlaylist
            // 
            this.btnGridDelPlaylist.Image = global::WinSIP.Properties.Resources.icons8_delete_file_32;
            this.btnGridDelPlaylist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGridDelPlaylist.Name = "btnGridDelPlaylist";
            this.btnGridDelPlaylist.Size = new System.Drawing.Size(114, 22);
            this.btnGridDelPlaylist.Text = "Remover Playlist";
            this.btnGridDelPlaylist.ToolTipText = "Remover a playlist selecionada do grupo";
            this.btnGridDelPlaylist.Click += new System.EventHandler(this.btnGridDelPlaylist_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGridItemUp
            // 
            this.btnGridItemUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGridItemUp.Image = global::WinSIP.Properties.Resources.up_arrow_;
            this.btnGridItemUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGridItemUp.Name = "btnGridItemUp";
            this.btnGridItemUp.Size = new System.Drawing.Size(23, 22);
            this.btnGridItemUp.Text = "Ativar/Desativar";
            this.btnGridItemUp.Click += new System.EventHandler(this.btnGridItemUp_Click);
            // 
            // btnGridItemDown
            // 
            this.btnGridItemDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGridItemDown.Image = global::WinSIP.Properties.Resources.down_arrow;
            this.btnGridItemDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGridItemDown.Name = "btnGridItemDown";
            this.btnGridItemDown.Size = new System.Drawing.Size(23, 22);
            this.btnGridItemDown.Text = "toolStripButton4";
            this.btnGridItemDown.Click += new System.EventHandler(this.btnGridItemDown_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnToggleActive
            // 
            this.BtnToggleActive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnToggleActive.Image = ((System.Drawing.Image)(resources.GetObject("BtnToggleActive.Image")));
            this.BtnToggleActive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnToggleActive.Name = "BtnToggleActive";
            this.BtnToggleActive.Size = new System.Drawing.Size(95, 22);
            this.BtnToggleActive.Text = "Ativar/Desativar";
            this.BtnToggleActive.ToolTipText = "Ativar ou Desativar a Playlist selecionada";
            this.BtnToggleActive.Click += new System.EventHandler(this.BtnToggleActive_Click);
            // 
            // Form_Grupos_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(492, 360);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.BtnDuplicar);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescritivoBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Grupos_Insert";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "Grupos: Novo";
            this.Load += new System.EventHandler(this.Form_Grupos_Insert_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescritivoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDuplicar;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGridAddPlaylist;
        private System.Windows.Forms.ToolStripButton btnGridDelPlaylist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnGridItemUp;
        private System.Windows.Forms.ToolStripButton btnGridItemDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnToggleActive;
    }
}