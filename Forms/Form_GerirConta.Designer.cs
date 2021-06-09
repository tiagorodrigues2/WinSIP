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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLogout
            // 
            this.BtnLogout.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.BtnLogout.ForeColor = System.Drawing.Color.Tomato;
            this.BtnLogout.Location = new System.Drawing.Point(6, 262);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(212, 55);
            this.BtnLogout.TabIndex = 0;
            this.BtnLogout.Text = "Sair da Conta";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // SenhaAtual
            // 
            this.SenhaAtual.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.75F, System.Drawing.FontStyle.Bold);
            this.SenhaAtual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SenhaAtual.Location = new System.Drawing.Point(10, 70);
            this.SenhaAtual.Name = "SenhaAtual";
            this.SenhaAtual.PasswordChar = '*';
            this.SenhaAtual.Size = new System.Drawing.Size(224, 26);
            this.SenhaAtual.TabIndex = 1;
            this.SenhaAtual.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // NovaSenha
            // 
            this.NovaSenha.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.75F, System.Drawing.FontStyle.Bold);
            this.NovaSenha.Location = new System.Drawing.Point(12, 139);
            this.NovaSenha.Name = "NovaSenha";
            this.NovaSenha.PasswordChar = '*';
            this.NovaSenha.Size = new System.Drawing.Size(222, 26);
            this.NovaSenha.TabIndex = 2;
            this.NovaSenha.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // ConfirmarSenha
            // 
            this.ConfirmarSenha.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.75F, System.Drawing.FontStyle.Bold);
            this.ConfirmarSenha.Location = new System.Drawing.Point(12, 203);
            this.ConfirmarSenha.Name = "ConfirmarSenha";
            this.ConfirmarSenha.PasswordChar = '*';
            this.ConfirmarSenha.Size = new System.Drawing.Size(222, 26);
            this.ConfirmarSenha.TabIndex = 3;
            this.ConfirmarSenha.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha Atual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nova Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirmar Password";
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.BtnAlterar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAlterar.Location = new System.Drawing.Point(10, 262);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(224, 55);
            this.BtnAlterar.TabIndex = 8;
            this.BtnAlterar.Text = "Alterar Password";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnAlterar);
            this.groupBox1.Controls.Add(this.SenhaAtual);
            this.groupBox1.Controls.Add(this.ConfirmarSenha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NovaSenha);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 323);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar Senha";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BtnLogout);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(279, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 323);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Definições";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 98);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form_GerirConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinSIP.Properties.Resources.color;
            this.ClientSize = new System.Drawing.Size(530, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_GerirConta";
            this.ShowIcon = false;
            this.Text = "Gerir Conta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_GerirConta_FormClosing);
            this.Load += new System.EventHandler(this.Form_GerirConta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.TextBox SenhaAtual;
        private System.Windows.Forms.TextBox NovaSenha;
        private System.Windows.Forms.TextBox ConfirmarSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}