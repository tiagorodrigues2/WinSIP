
namespace WinSIP.Forms
{
    partial class Form_Display_Insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Display_Insert));
            this.DescritivoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GrupoBox = new System.Windows.Forms.ComboBox();
            this.BtnDuplicar = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DescritivoBox
            // 
            this.DescritivoBox.Location = new System.Drawing.Point(12, 63);
            this.DescritivoBox.Name = "DescritivoBox";
            this.DescritivoBox.Size = new System.Drawing.Size(269, 20);
            this.DescritivoBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descritivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IdGroup";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(185, 194);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(96, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(12, 194);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(95, 23);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // GrupoBox
            // 
            this.GrupoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GrupoBox.FormattingEnabled = true;
            this.GrupoBox.Location = new System.Drawing.Point(13, 116);
            this.GrupoBox.Name = "GrupoBox";
            this.GrupoBox.Size = new System.Drawing.Size(226, 21);
            this.GrupoBox.TabIndex = 6;
            // 
            // BtnDuplicar
            // 
            this.BtnDuplicar.Location = new System.Drawing.Point(185, 165);
            this.BtnDuplicar.Name = "BtnDuplicar";
            this.BtnDuplicar.Size = new System.Drawing.Size(96, 23);
            this.BtnDuplicar.TabIndex = 7;
            this.BtnDuplicar.Text = "Duplicar";
            this.BtnDuplicar.UseVisualStyleBackColor = true;
            this.BtnDuplicar.Click += new System.EventHandler(this.BtnDuplicar_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(245, 114);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(36, 23);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // Form_Display_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(303, 230);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.BtnDuplicar);
            this.Controls.Add(this.GrupoBox);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescritivoBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Display_Insert";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "Display: Inserir Registo";
            this.Load += new System.EventHandler(this.Form_InserirDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox GrupoBox;
        private System.Windows.Forms.TextBox DescritivoBox;
        private System.Windows.Forms.Button BtnDuplicar;
        private System.Windows.Forms.Button btnSelect;
    }
}