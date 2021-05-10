using System;

namespace WinSIP
{
    partial class Form_GerirConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GerirConta));
            this.BtnLogout = new System.Windows.Forms.Button();
            this.SenhaAtual = new System.Windows.Forms.TextBox();
            this.NovaSenha = new System.Windows.Forms.TextBox();
            this.ConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(284, 271);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(113, 31);
            this.BtnLogout.TabIndex = 0;
            this.BtnLogout.Text = "Sair da Conta";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // SenhaAtual
            // 
            this.SenhaAtual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SenhaAtual.Location = new System.Drawing.Point(117, 74);
            this.SenhaAtual.Name = "SenhaAtual";
            this.SenhaAtual.PasswordChar = '*';
            this.SenhaAtual.Size = new System.Drawing.Size(174, 20);
            this.SenhaAtual.TabIndex = 1;
            this.SenhaAtual.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // NovaSenha
            // 
            this.NovaSenha.Location = new System.Drawing.Point(117, 126);
            this.NovaSenha.Name = "NovaSenha";
            this.NovaSenha.PasswordChar = '*';
            this.NovaSenha.Size = new System.Drawing.Size(174, 20);
            this.NovaSenha.TabIndex = 2;
            this.NovaSenha.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // ConfirmarSenha
            // 
            this.ConfirmarSenha.Location = new System.Drawing.Point(117, 169);
            this.ConfirmarSenha.Name = "ConfirmarSenha";
            this.ConfirmarSenha.PasswordChar = '*';
            this.ConfirmarSenha.Size = new System.Drawing.Size(174, 20);
            this.ConfirmarSenha.TabIndex = 3;
            this.ConfirmarSenha.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alterar Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha Atual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nova Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirmar Password";
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(117, 205);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(174, 23);
            this.BtnAlterar.TabIndex = 8;
            this.BtnAlterar.Text = "Alterar Password";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // Form_GerirConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 314);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmarSenha);
            this.Controls.Add(this.NovaSenha);
            this.Controls.Add(this.SenhaAtual);
            this.Controls.Add(this.BtnLogout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_GerirConta";
            this.ShowIcon = false;
            this.Text = "Gerir Conta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_GerirConta_FormClosing);
            this.Load += new System.EventHandler(this.Form_GerirConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.TextBox SenhaAtual;
        private System.Windows.Forms.TextBox NovaSenha;
        private System.Windows.Forms.TextBox ConfirmarSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAlterar;
    }
}