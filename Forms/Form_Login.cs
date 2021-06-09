using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using WinSIP.Dados;
using WinSIP.Forms;

namespace WinSIP
{
    
    public partial class Form_Login : Form
    {
        public bool _LoginSucesso = false;

        private Users Dados = null;

        public User_t LoggedUser;

        public Form_Login()
        {
            InitializeComponent();
            Dados = new Users();

            txtLogPass.PasswordChar = '*';
        }

        private void btnLogEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                CheckUserReturn_t Check = Dados.CheckUser( txtLogUser.Text, txtLogPass.Text );

                _LoginSucesso = Check.Success;

                if ( _LoginSucesso == false )
                {
                    MessageBox.Show( "Nao foi possivel encontrar um utilizador com os dados fornecidos.\nTente novamente.", "Erro", MessageBoxButtons.OK );
                    return;
                }

                LoggedUser = Check.user;
                Properties.Settings.Default.Username = txtLogUser.Text;

                if ( RememberMe.Checked == true )
                {
                    Properties.Settings.Default.Password = txtLogPass.Text;
                    Properties.Settings.Default.RememberMe = true;
                    Properties.Settings.Default.Save();
                }

                if ( Check.ForceChangePassword )
                {
                    Form_GerirConta change = new Form_GerirConta( LoggedUser, null, true );
                    MessageBox.Show( "Terá de alterar a sua senha para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    change.ShowDialog();
                }

                this.Close();

            }
            catch ( Exception ex )
            {
                MessageBox.Show( "Ocurreu um erro ao efetuar o Login:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void EsqueceuSenha_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            MessageBox.Show( "Contacto o administrador/desenvolvedor do programa para repor a sua senha.", "Aviso", MessageBoxButtons.OK );
        }

        private void FormLogin_Shown( object sender, EventArgs e )
        {
            try
            {
                txtLogPass.Text = Properties.Settings.Default.Password;
                txtLogUser.Text = Properties.Settings.Default.Username;

                if ( Properties.Settings.Default.RememberMe )
                {
                    CheckUserReturn_t Check = Dados.CheckUser( txtLogUser.Text, txtLogPass.Text );

                    _LoginSucesso = Check.Success;

                    if ( _LoginSucesso == true )
                    {
                        LoggedUser = Check.user;
                        this.Close();
                    }
                }

                txtLogUser_TextChanged( this, new EventArgs() );
            }
            catch ( Exception ex )
            {
                MessageBox.Show( "Ocurreu um erro no Login automatico:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void CriarContaLabel_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            FormRegistar reg = new FormRegistar();
            reg.ShowDialog();

            this.txtLogUser.Text = reg.RegistedUser.username;

            txtLogUser_TextChanged( this, new EventArgs() );
        }

        private void txtLogUser_TextChanged( object sender, EventArgs e )
        {
            if ( txtLogUser.Text.Length > 0 && txtLogPass.Text.Length > 0 )
                btnLogEntrar.Enabled = true;
            else
                btnLogEntrar.Enabled = false;
        }

        private void Form_Login_Load( object sender, EventArgs e )
        {

        }
    }
}