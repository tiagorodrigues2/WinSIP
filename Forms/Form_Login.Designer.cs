namespace WinSIP
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.btnLogEntrar = new System.Windows.Forms.Button();
            this.txtLogUser = new System.Windows.Forms.TextBox();
            this.txtLogPass = new System.Windows.Forms.TextBox();
            this.lblLogUser = new System.Windows.Forms.Label();
            this.lblLogPass = new System.Windows.Forms.Label();
            this.CriarContaLabel = new System.Windows.Forms.LinkLabel();
            this.EsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.RememberMe = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogEntrar
            // 
            this.btnLogEntrar.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogEntrar.Location = new System.Drawing.Point(54, 204);
            this.btnLogEntrar.Name = "btnLogEntrar";
            this.btnLogEntrar.Size = new System.Drawing.Size(269, 58);
            this.btnLogEntrar.TabIndex = 0;
            this.btnLogEntrar.Text = "Entrar";
            this.btnLogEntrar.UseVisualStyleBackColor = true;
            this.btnLogEntrar.Click += new System.EventHandler(this.btnLogEntrar_Click);
            // 
            // txtLogUser
            // 
            this.txtLogUser.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogUser.Location = new System.Drawing.Point(54, 74);
            this.txtLogUser.Name = "txtLogUser";
            this.txtLogUser.Size = new System.Drawing.Size(269, 26);
            this.txtLogUser.TabIndex = 1;
            // 
            // txtLogPass
            // 
            this.txtLogPass.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogPass.Location = new System.Drawing.Point(54, 134);
            this.txtLogPass.Name = "txtLogPass";
            this.txtLogPass.Size = new System.Drawing.Size(269, 27);
            this.txtLogPass.TabIndex = 2;
            this.txtLogPass.UseSystemPasswordChar = true;
            // 
            // lblLogUser
            // 
            this.lblLogUser.AutoSize = true;
            this.lblLogUser.BackColor = System.Drawing.Color.Transparent;
            this.lblLogUser.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLogUser.Location = new System.Drawing.Point(49, 46);
            this.lblLogUser.Name = "lblLogUser";
            this.lblLogUser.Size = new System.Drawing.Size(190, 25);
            this.lblLogUser.TabIndex = 3;
            this.lblLogUser.Text = "Nome de Utilizador";
            // 
            // lblLogPass
            // 
            this.lblLogPass.AutoSize = true;
            this.lblLogPass.BackColor = System.Drawing.Color.Transparent;
            this.lblLogPass.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblLogPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLogPass.Location = new System.Drawing.Point(49, 106);
            this.lblLogPass.Name = "lblLogPass";
            this.lblLogPass.Size = new System.Drawing.Size(104, 25);
            this.lblLogPass.TabIndex = 4;
            this.lblLogPass.Text = "Password";
            // 
            // CriarContaLabel
            // 
            this.CriarContaLabel.AutoSize = true;
            this.CriarContaLabel.BackColor = System.Drawing.Color.Transparent;
            this.CriarContaLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarContaLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CriarContaLabel.Location = new System.Drawing.Point(363, 239);
            this.CriarContaLabel.Name = "CriarContaLabel";
            this.CriarContaLabel.Size = new System.Drawing.Size(212, 23);
            this.CriarContaLabel.TabIndex = 5;
            this.CriarContaLabel.TabStop = true;
            this.CriarContaLabel.Text = "Registar novo utilizador";
            this.CriarContaLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CriarContaLabel_LinkClicked);
            // 
            // EsqueceuSenha
            // 
            this.EsqueceuSenha.AutoSize = true;
            this.EsqueceuSenha.BackColor = System.Drawing.Color.Transparent;
            this.EsqueceuSenha.Font = new System.Drawing.Font("Bahnschrift", 10.25F);
            this.EsqueceuSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EsqueceuSenha.Location = new System.Drawing.Point(159, 114);
            this.EsqueceuSenha.Name = "EsqueceuSenha";
            this.EsqueceuSenha.Size = new System.Drawing.Size(159, 17);
            this.EsqueceuSenha.TabIndex = 6;
            this.EsqueceuSenha.TabStop = true;
            this.EsqueceuSenha.Text = "Esqueceu-se da senha?";
            this.EsqueceuSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EsqueceuSenha_LinkClicked);
            // 
            // RememberMe
            // 
            this.RememberMe.AutoSize = true;
            this.RememberMe.BackColor = System.Drawing.Color.Transparent;
            this.RememberMe.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12.75F, System.Drawing.FontStyle.Bold);
            this.RememberMe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RememberMe.Location = new System.Drawing.Point(54, 167);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(276, 25);
            this.RememberMe.TabIndex = 7;
            this.RememberMe.Text = " Iniciar sessão automaticamente";
            this.RememberMe.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WinSIP.Properties.Resources.logo_transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(379, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 174);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WinSIP.Properties.Resources.color;
            this.ClientSize = new System.Drawing.Size(602, 301);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RememberMe);
            this.Controls.Add(this.EsqueceuSenha);
            this.Controls.Add(this.CriarContaLabel);
            this.Controls.Add(this.lblLogPass);
            this.Controls.Add(this.lblLogUser);
            this.Controls.Add(this.txtLogPass);
            this.Controls.Add(this.txtLogUser);
            this.Controls.Add(this.btnLogEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Login";
            this.ShowIcon = false;
            this.Text = "Login";
            this.Shown += new System.EventHandler(this.FormLogin_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogEntrar;
        private System.Windows.Forms.TextBox txtLogUser;
        private System.Windows.Forms.TextBox txtLogPass;
        private System.Windows.Forms.Label lblLogUser;
        private System.Windows.Forms.Label lblLogPass;
        private System.Windows.Forms.LinkLabel CriarContaLabel;
        private System.Windows.Forms.LinkLabel EsqueceuSenha;
        private System.Windows.Forms.CheckBox RememberMe;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}