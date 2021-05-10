
namespace WinSIP.Forms
{
    partial class Form_Files_Insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Files_Insert));
            this.DescritivoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.BtnDuplicar = new System.Windows.Forms.Button();
            this.TempoBox = new System.Windows.Forms.NumericUpDown();
            this.btnBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TempoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DescritivoBox
            // 
            this.DescritivoBox.Location = new System.Drawing.Point(16, 58);
            this.DescritivoBox.Name = "DescritivoBox";
            this.DescritivoBox.Size = new System.Drawing.Size(269, 20);
            this.DescritivoBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descritivo";
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(16, 118);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(240, 20);
            this.PathBox.TabIndex = 3;
            this.PathBox.TextChanged += new System.EventHandler(this.PathBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tempo (s)";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(13, 270);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(95, 23);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(186, 270);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(96, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(16, 204);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(266, 23);
            this.CalcBtn.TabIndex = 10;
            this.CalcBtn.Text = "Calcular Tempo (.mp4)";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // BtnDuplicar
            // 
            this.BtnDuplicar.Location = new System.Drawing.Point(186, 241);
            this.BtnDuplicar.Name = "BtnDuplicar";
            this.BtnDuplicar.Size = new System.Drawing.Size(96, 23);
            this.BtnDuplicar.TabIndex = 11;
            this.BtnDuplicar.Text = "Duplicar";
            this.BtnDuplicar.UseVisualStyleBackColor = true;
            this.BtnDuplicar.Click += new System.EventHandler(this.BtnDuplicar_Click);
            // 
            // TempoBox
            // 
            this.TempoBox.Location = new System.Drawing.Point(16, 178);
            this.TempoBox.Name = "TempoBox";
            this.TempoBox.Size = new System.Drawing.Size(266, 20);
            this.TempoBox.TabIndex = 12;
            this.TempoBox.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(262, 118);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(29, 20);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Form_Files_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(295, 306);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.TempoBox);
            this.Controls.Add(this.BtnDuplicar);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescritivoBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Files_Insert";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "Files: Inserir";
            this.Load += new System.EventHandler(this.Form_Files_Insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TempoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescritivoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Button BtnDuplicar;
        private System.Windows.Forms.NumericUpDown TempoBox;
        private System.Windows.Forms.Button btnBrowse;
    }
}