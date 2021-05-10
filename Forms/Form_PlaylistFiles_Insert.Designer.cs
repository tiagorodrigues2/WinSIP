
namespace WinSIP.Forms
{
    partial class Form_PlaylistFiles_Insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PlaylistFiles_Insert));
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FileBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlaylistBox = new System.Windows.Forms.ComboBox();
            this.NrOrdemBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TableName = new System.Windows.Forms.Label();
            this.TableAnterior = new System.Windows.Forms.Button();
            this.TableNext = new System.Windows.Forms.Button();
            this.ChkViewtables = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NrOrdemBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(18, 250);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(95, 23);
            this.BtnCancel.TabIndex = 17;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(191, 250);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(96, 23);
            this.BtnSave.TabIndex = 16;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "IdFile";
            // 
            // FileBox
            // 
            this.FileBox.FormattingEnabled = true;
            this.FileBox.Location = new System.Drawing.Point(18, 120);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(269, 21);
            this.FileBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "IdPlaylist";
            // 
            // PlaylistBox
            // 
            this.PlaylistBox.FormattingEnabled = true;
            this.PlaylistBox.Location = new System.Drawing.Point(18, 62);
            this.PlaylistBox.Name = "PlaylistBox";
            this.PlaylistBox.Size = new System.Drawing.Size(269, 21);
            this.PlaylistBox.TabIndex = 12;
            // 
            // NrOrdemBox
            // 
            this.NrOrdemBox.Location = new System.Drawing.Point(18, 176);
            this.NrOrdemBox.Name = "NrOrdemBox";
            this.NrOrdemBox.Size = new System.Drawing.Size(269, 20);
            this.NrOrdemBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "NrOrdem";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(635, 211);
            this.dataGridView1.TabIndex = 20;
            // 
            // TableName
            // 
            this.TableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableName.Location = new System.Drawing.Point(346, 36);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(554, 23);
            this.TableName.TabIndex = 21;
            this.TableName.Text = "%tablename%";
            this.TableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableAnterior
            // 
            this.TableAnterior.Location = new System.Drawing.Point(306, 36);
            this.TableAnterior.Name = "TableAnterior";
            this.TableAnterior.Size = new System.Drawing.Size(34, 23);
            this.TableAnterior.TabIndex = 22;
            this.TableAnterior.Text = "<";
            this.TableAnterior.UseVisualStyleBackColor = true;
            this.TableAnterior.Click += new System.EventHandler(this.TableAnterior_Click);
            // 
            // TableNext
            // 
            this.TableNext.Location = new System.Drawing.Point(906, 36);
            this.TableNext.Name = "TableNext";
            this.TableNext.Size = new System.Drawing.Size(35, 23);
            this.TableNext.TabIndex = 23;
            this.TableNext.Text = ">";
            this.TableNext.UseVisualStyleBackColor = true;
            this.TableNext.Click += new System.EventHandler(this.TableNext_Click);
            // 
            // ChkViewtables
            // 
            this.ChkViewtables.AutoSize = true;
            this.ChkViewtables.Location = new System.Drawing.Point(18, 211);
            this.ChkViewtables.Name = "ChkViewtables";
            this.ChkViewtables.Size = new System.Drawing.Size(111, 17);
            this.ChkViewtables.TabIndex = 24;
            this.ChkViewtables.Text = "Visualizar Tabelas";
            this.ChkViewtables.UseVisualStyleBackColor = true;
            this.ChkViewtables.CheckedChanged += new System.EventHandler(this.ChkViewtables_CheckedChanged);
            // 
            // Form_PlaylistFiles_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(954, 287);
            this.Controls.Add(this.ChkViewtables);
            this.Controls.Add(this.TableNext);
            this.Controls.Add(this.TableAnterior);
            this.Controls.Add(this.TableName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NrOrdemBox);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FileBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlaylistBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_PlaylistFiles_Insert";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "Form_PlaylistFiles_Insert";
            this.Load += new System.EventHandler(this.Form_PlaylistFiles_Insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NrOrdemBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FileBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PlaylistBox;
        private System.Windows.Forms.NumericUpDown NrOrdemBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label TableName;
        private System.Windows.Forms.Button TableAnterior;
        private System.Windows.Forms.Button TableNext;
        private System.Windows.Forms.CheckBox ChkViewtables;
    }
}