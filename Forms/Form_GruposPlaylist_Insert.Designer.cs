
namespace WinSIP.Forms
{
    partial class Form_GruposPlaylist_Insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GruposPlaylist_Insert));
            this.GrupoBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlaylistBox = new System.Windows.Forms.ComboBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ChkViewTables = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TableName = new System.Windows.Forms.Label();
            this.TableAnterior = new System.Windows.Forms.Button();
            this.TableNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupoBox
            // 
            this.GrupoBox.FormattingEnabled = true;
            this.GrupoBox.Location = new System.Drawing.Point(13, 37);
            this.GrupoBox.Name = "GrupoBox";
            this.GrupoBox.Size = new System.Drawing.Size(269, 21);
            this.GrupoBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IdGrupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IdPlaylist";
            // 
            // PlaylistBox
            // 
            this.PlaylistBox.FormattingEnabled = true;
            this.PlaylistBox.Location = new System.Drawing.Point(13, 95);
            this.PlaylistBox.Name = "PlaylistBox";
            this.PlaylistBox.Size = new System.Drawing.Size(269, 21);
            this.PlaylistBox.TabIndex = 2;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(13, 169);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(95, 23);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(186, 169);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(96, 23);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ChkViewTables
            // 
            this.ChkViewTables.AutoSize = true;
            this.ChkViewTables.Location = new System.Drawing.Point(13, 122);
            this.ChkViewTables.Name = "ChkViewTables";
            this.ChkViewTables.Size = new System.Drawing.Size(111, 17);
            this.ChkViewTables.TabIndex = 12;
            this.ChkViewTables.Text = "Visualizar Tabelas";
            this.ChkViewTables.UseVisualStyleBackColor = true;
            this.ChkViewTables.CheckedChanged += new System.EventHandler(this.ChkViewTables_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(326, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(429, 155);
            this.dataGridView1.TabIndex = 13;
            // 
            // TableName
            // 
            this.TableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableName.Location = new System.Drawing.Point(401, 14);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(281, 23);
            this.TableName.TabIndex = 14;
            this.TableName.Text = "%tablename%";
            this.TableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableAnterior
            // 
            this.TableAnterior.Location = new System.Drawing.Point(326, 8);
            this.TableAnterior.Name = "TableAnterior";
            this.TableAnterior.Size = new System.Drawing.Size(36, 23);
            this.TableAnterior.TabIndex = 15;
            this.TableAnterior.Text = "<";
            this.TableAnterior.UseVisualStyleBackColor = true;
            this.TableAnterior.Click += new System.EventHandler(this.TableAnterior_Click);
            // 
            // TableNext
            // 
            this.TableNext.Location = new System.Drawing.Point(718, 8);
            this.TableNext.Name = "TableNext";
            this.TableNext.Size = new System.Drawing.Size(37, 23);
            this.TableNext.TabIndex = 16;
            this.TableNext.Text = ">";
            this.TableNext.UseVisualStyleBackColor = true;
            this.TableNext.Click += new System.EventHandler(this.TableNext_Click);
            // 
            // Form_GruposPlaylist_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(768, 205);
            this.Controls.Add(this.TableNext);
            this.Controls.Add(this.TableAnterior);
            this.Controls.Add(this.TableName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ChkViewTables);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlaylistBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrupoBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_GruposPlaylist_Insert";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "GruposPlaylist: Inserir";
            this.Load += new System.EventHandler(this.Form_GruposPlaylist_Insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GrupoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PlaylistBox;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.CheckBox ChkViewTables;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label TableName;
        private System.Windows.Forms.Button TableAnterior;
        private System.Windows.Forms.Button TableNext;
    }
}