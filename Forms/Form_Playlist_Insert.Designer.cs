
namespace WinSIP.Forms
{
    partial class Form_Playlist_Insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Playlist_Insert));
            this.DescritivoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDuplicar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGridAddFile = new System.Windows.Forms.ToolStripButton();
            this.btnGridDelFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOrderUp = new System.Windows.Forms.ToolStripButton();
            this.btnOrderDown = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.FooterBox = new System.Windows.Forms.TextBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescritivoBox
            // 
            this.DescritivoBox.Location = new System.Drawing.Point(13, 49);
            this.DescritivoBox.Name = "DescritivoBox";
            this.DescritivoBox.Size = new System.Drawing.Size(269, 20);
            this.DescritivoBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descritivo";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(13, 386);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(95, 23);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(393, 394);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(96, 23);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDuplicar
            // 
            this.BtnDuplicar.Location = new System.Drawing.Point(393, 365);
            this.BtnDuplicar.Name = "BtnDuplicar";
            this.BtnDuplicar.Size = new System.Drawing.Size(96, 23);
            this.BtnDuplicar.TabIndex = 8;
            this.BtnDuplicar.Text = "Duplicar";
            this.BtnDuplicar.UseVisualStyleBackColor = true;
            this.BtnDuplicar.Click += new System.EventHandler(this.BtnDuplicar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ficheiros";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(476, 183);
            this.toolStripContainer1.Location = new System.Drawing.Point(13, 99);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(476, 208);
            this.toolStripContainer1.TabIndex = 14;
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
            this.dataGridView1.Size = new System.Drawing.Size(476, 183);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGridAddFile,
            this.btnGridDelFile,
            this.toolStripSeparator1,
            this.btnOrderUp,
            this.btnOrderDown});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(306, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // btnGridAddFile
            // 
            this.btnGridAddFile.Image = global::WinSIP.Properties.Resources.icons8_add_file_32;
            this.btnGridAddFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGridAddFile.Name = "btnGridAddFile";
            this.btnGridAddFile.Size = new System.Drawing.Size(123, 22);
            this.btnGridAddFile.Text = "Adicionar Ficheiro";
            this.btnGridAddFile.Click += new System.EventHandler(this.btnGridAddFile_Click);
            // 
            // btnGridDelFile
            // 
            this.btnGridDelFile.Image = global::WinSIP.Properties.Resources.icons8_delete_file_32;
            this.btnGridDelFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGridDelFile.Name = "btnGridDelFile";
            this.btnGridDelFile.Size = new System.Drawing.Size(119, 22);
            this.btnGridDelFile.Text = "Remover Ficheiro";
            this.btnGridDelFile.ToolTipText = "Remover Ficheiro";
            this.btnGridDelFile.Click += new System.EventHandler(this.btnGridDelFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOrderUp
            // 
            this.btnOrderUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOrderUp.Image = global::WinSIP.Properties.Resources.up_arrow_;
            this.btnOrderUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOrderUp.Name = "btnOrderUp";
            this.btnOrderUp.Size = new System.Drawing.Size(23, 22);
            this.btnOrderUp.Text = "toolStripButton1";
            this.btnOrderUp.ToolTipText = "Ordenar o item selecionado para cima";
            this.btnOrderUp.Click += new System.EventHandler(this.btnOrderUp_Click);
            // 
            // btnOrderDown
            // 
            this.btnOrderDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOrderDown.Image = global::WinSIP.Properties.Resources.down_arrow;
            this.btnOrderDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOrderDown.Name = "btnOrderDown";
            this.btnOrderDown.Size = new System.Drawing.Size(23, 22);
            this.btnOrderDown.Text = "Ordem para Baixo";
            this.btnOrderDown.ToolTipText = "Ordenar o item selecionado para baixo";
            this.btnOrderDown.Click += new System.EventHandler(this.btnOrderDown_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Caminho para o ficheiro Footer";
            // 
            // FooterBox
            // 
            this.FooterBox.Location = new System.Drawing.Point(13, 335);
            this.FooterBox.Name = "FooterBox";
            this.FooterBox.Size = new System.Drawing.Size(476, 20);
            this.FooterBox.TabIndex = 15;
            // 
            // Form_Playlist_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(509, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FooterBox);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDuplicar);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescritivoBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Playlist_Insert";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "Playlist: Inserir";
            this.Load += new System.EventHandler(this.Form_Playlist_Insert_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGridAddFile;
        private System.Windows.Forms.ToolStripButton btnGridDelFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnOrderUp;
        private System.Windows.Forms.ToolStripButton btnOrderDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FooterBox;
    }
}