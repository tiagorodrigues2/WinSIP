namespace WinSIP
{
    partial class FormRegistar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistar));
            this.lblRegUser = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.lblRegPass = new System.Windows.Forms.Label();
            this.ConfirmarPassword = new System.Windows.Forms.TextBox();
            this.lblCodAcesso = new System.Windows.Forms.Label();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRegUser
            // 
            this.lblRegUser.AutoSize = true;
            this.lblRegUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblRegUser.Location = new System.Drawing.Point(120, 63);
            this.lblRegUser.Name = "lblRegUser";
            this.lblRegUser.Size = new System.Drawing.Size(112, 25);
            this.lblRegUser.TabIndex = 5;
            this.lblRegUser.Text = "Utilizador";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(125, 91);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(269, 20);
            this.Username.TabIndex = 4;
            // 
            // lblRegPass
            // 
            this.lblRegPass.AutoSize = true;
            this.lblRegPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblRegPass.Location = new System.Drawing.Point(120, 174);
            this.lblRegPass.Name = "lblRegPass";
            this.lblRegPass.Size = new System.Drawing.Size(223, 25);
            this.lblRegPass.TabIndex = 7;
            this.lblRegPass.Text = "Confirmar Password";
            // 
            // ConfirmarPassword
            // 
            this.ConfirmarPassword.Location = new System.Drawing.Point(125, 202);
            this.ConfirmarPassword.Name = "ConfirmarPassword";
            this.ConfirmarPassword.PasswordChar = '*';
            this.ConfirmarPassword.Size = new System.Drawing.Size(269, 20);
            this.ConfirmarPassword.TabIndex = 6;
            this.ConfirmarPassword.UseSystemPasswordChar = true;
            this.ConfirmarPassword.TextChanged += new System.EventHandler(this.ConfirmarPassword_TextChanged);
            // 
            // lblCodAcesso
            // 
            this.lblCodAcesso.AutoSize = true;
            this.lblCodAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCodAcesso.Location = new System.Drawing.Point(120, 234);
            this.lblCodAcesso.Name = "lblCodAcesso";
            this.lblCodAcesso.Size = new System.Drawing.Size(203, 25);
            this.lblCodAcesso.TabIndex = 9;
            this.lblCodAcesso.Text = "Código de Acesso";
            // 
            // btnRegistar
            // 
            this.btnRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistar.Location = new System.Drawing.Point(125, 300);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(269, 33);
            this.btnRegistar.TabIndex = 10;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(120, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(125, 151);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(269, 20);
            this.Password.TabIndex = 11;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(125, 262);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(269, 20);
            this.Code.TabIndex = 13;
            // 
            // FormRegistar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 392);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.lblCodAcesso);
            this.Controls.Add(this.lblRegPass);
            this.Controls.Add(this.ConfirmarPassword);
            this.Controls.Add(this.lblRegUser);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRegistar";
            this.ShowIcon = false;
            this.Text = "Novo Utilzador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegUser;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label lblRegPass;
        private System.Windows.Forms.TextBox ConfirmarPassword;
        private System.Windows.Forms.Label lblCodAcesso;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Code;
    }
}