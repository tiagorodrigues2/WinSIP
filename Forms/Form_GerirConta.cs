using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSIP.Dados;

namespace WinSIP
{
    public partial class Form_GerirConta : Form
    {
        User_t User;
        FormMDI pMdi;

        public bool exited = false;

        bool ForceChangePassword = false;

        public Form_GerirConta( User_t LoggedUser, FormMDI mdi, bool ForceChangePassword )
        {
            InitializeComponent();

            try
            {
                User = LoggedUser;
                pMdi = mdi;

                this.Text = "Gerir Conta: " + User.username;
                this.label1.Text = "Alterar Password: " + User.username;

                this.ForceChangePassword = ForceChangePassword;

                if ( this.ForceChangePassword )
                {
                    BtnLogout.Visible = false;
                    SenhaAtual.Text = LoggedUser.password;
                }

                textBox_TextChanged( this, new EventArgs() );
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
                this.Close();
            }
        }

        private void BtnLogout_Click( object sender, EventArgs e )
        {
            try
            {
                DialogResult Dialog = MessageBox.Show( "Tem a certeza que fazer Logout?\nVerifique que todo o seu trabalho foi guardado.", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation );

                if ( Dialog == DialogResult.Yes && this.ForceChangePassword == false )
                {
                    this.exited = true;
                    this.Close();
                    pMdi.Logout();
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void textBox_TextChanged( object sender, EventArgs e )
        {
            if ( SenhaAtual.Text.Length >= 1 && NovaSenha.Text.Length >= 1 && ConfirmarSenha.Text.Length >= 1 )
                BtnAlterar.Enabled = true;
            else
                BtnAlterar.Enabled = false;

        }

        private void BtnAlterar_Click( object sender, EventArgs e )
        {
            try
            {
                if ( SenhaAtual.Text.Length == 0 || NovaSenha.Text.Length == 0 || ConfirmarSenha.Text.Length == 0 )
                {
                    MessageBox.Show( "Preencha todos os campos antes de alterar a password!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                    return;
                }
StartPosition:
                Users conta = new Users();

                if ( conta.CheckPassword( User, SenhaAtual.Text ) )
                {
                    if ( NovaSenha.Text == ConfirmarSenha.Text )
                    {
                        DialogResult res;
                        if ( conta.ChangePassword( User.UserID, NovaSenha.Text ) )
                            res = MessageBox.Show( "password alterada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information );
                        else
                            res = MessageBox.Show( "Ocurreu um erro ao alterar a password.", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error );

                        if ( res == DialogResult.Retry )
                            goto StartPosition;

                        if ( this.ForceChangePassword )
                        {
                            this.ForceChangePassword = false;
                            conta.SetForceChangePassword( User.UserID, false );
                            this.Close();
                        }
                    }
                    else
                    {
                        DialogResult res = MessageBox.Show( "A nova password não coincide com a confirmação da mesma.\nTente novamente.", "Erro",
                            MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error );

                        switch ( res )
                        {
                            case DialogResult.Abort:
                                SenhaAtual.Text = "";
                                NovaSenha.Text = "";
                                ConfirmarSenha.Text = "";
                                break;

                            case DialogResult.Retry:
                                NovaSenha.Text = "";
                                ConfirmarSenha.Text = "";
                                NovaSenha.Focus();
                                break;
                        }
                    }
                }
                else
                {
                    DialogResult res = MessageBox.Show( "A sua password atual está incorreta.\nTente novamente.", "Erro",
                        MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error );

                    switch ( res )
                    {
                        case DialogResult.Abort:
                            SenhaAtual.Text = "";
                            NovaSenha.Text = "";
                            ConfirmarSenha.Text = "";
                            break;

                        case DialogResult.Retry:
                            SenhaAtual.Text = "";
                            SenhaAtual.Focus();
                            break;
                    }

                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void Form_GerirConta_Load( object sender, EventArgs e )
        {

        }

        private void Form_GerirConta_FormClosing( object sender, FormClosingEventArgs e )
        {
            if ( this.ForceChangePassword )
            {
                MessageBox.Show( "A sua password tem de ser alterada para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                e.Cancel = true;
            }
        }
    }
}
