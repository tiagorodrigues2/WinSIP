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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegUser
            // 
            this.lblRegUser.AutoSize = true;
            this.lblRegUser.BackColor = System.Drawing.Color.Transparent;
            this.lblRegUser.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblRegUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRegUser.Location = new System.Drawing.Point(49, 46);
            this.lblRegUser.Name = "lblRegUser";
            this.lblRegUser.Size = new System.Drawing.Size(190, 25);
            this.lblRegUser.TabIndex = 5;
            this.lblRegUser.Text = "Nome de Utilizador";
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.Username.Location = new System.Drawing.Point(54, 74);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(269, 26);
            this.Username.TabIndex = 4;
            // 
            // lblRegPass
            // 
            this.lblRegPass.AutoSize = true;
            this.lblRegPass.BackColor = System.Drawing.Color.Transparent;
            this.lblRegPass.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblRegPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRegPass.Location = new System.Drawing.Point(49, 157);
            this.lblRegPass.Name = "lblRegPass";
            this.lblRegPass.Size = new System.Drawing.Size(172, 25);
            this.lblRegPass.TabIndex = 7;
            this.lblRegPass.Text = "Confirmar Senha";
            // 
            // ConfirmarPassword
            // 
            this.ConfirmarPassword.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.ConfirmarPassword.Location = new System.Drawing.Point(54, 185);
            this.ConfirmarPassword.Name = "ConfirmarPassword";
            this.ConfirmarPassword.PasswordChar = '*';
            this.ConfirmarPassword.Size = new System.Drawing.Size(269, 26);
            this.ConfirmarPassword.TabIndex = 6;
            this.ConfirmarPassword.UseSystemPasswordChar = true;
            this.ConfirmarPassword.TextChanged += new System.EventHandler(this.ConfirmarPassword_TextChanged);
            // 
            // lblCodAcesso
            // 
            this.lblCodAcesso.AutoSize = true;
            this.lblCodAcesso.BackColor = System.Drawing.Color.Transparent;
            this.lblCodAcesso.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCodAcesso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCodAcesso.Location = new System.Drawing.Point(49, 217);
            this.lblCodAcesso.Name = "lblCodAcesso";
            this.lblCodAcesso.Size = new System.Drawing.Size(176, 25);
            this.lblCodAcesso.TabIndex = 9;
            this.lblCodAcesso.Text = "Código de Acesso";
            // 
            // btnRegistar
            // 
            this.btnRegistar.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRegistar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistar.Location = new System.Drawing.Point(54, 296);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(269, 58);
            this.btnRegistar.TabIndex = 10;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(49, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Senha";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.Password.Location = new System.Drawing.Point(54, 134);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(269, 26);
            this.Password.TabIndex = 11;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Code
            // 
            this.Code.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.Code.Location = new System.Drawing.Point(54, 245);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(269, 26);
            this.Code.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WinSIP.Properties.Resources.logo_transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(380, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 174);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegistar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinSIP.Properties.Resources.color;
            this.ClientSize = new System.Drawing.Size(612, 392);
            this.Controls.Add(this.pictureBox1);
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
            this.MinimizeBox = false;
            this.Name = "FormRegistar";
            this.ShowIcon = false;
            this.Text = "Novo Utilzador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}