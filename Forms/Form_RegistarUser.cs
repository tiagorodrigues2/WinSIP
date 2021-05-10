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
    public partial class FormRegistar : Form
    {
        public User_t RegistedUser = new User_t( 0, "", "", false );

        private Users Users;

        public FormRegistar()
        {
            InitializeComponent();

            Users = new Users();
        }

        private void btnRegistar_Click( object sender, EventArgs e )
        {
            try
            {
                if ( Username.Text.Length < 3 )
                {
                    MessageBox.Show( "Username tem de ter pelo menos 3 caracteres.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    return;
                }

                if ( Password.Text.Length < 3 )
                {
                    MessageBox.Show( "Password tem de ter pelo menos 3 caracteres.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    return;
                }

                if ( Password.Text != ConfirmarPassword.Text )
                {
                    MessageBox.Show( "Confirmação da palavra-passe falhou. Verifique que introduziu corretamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    return;
                }

                int Id = Users.RegisterUser( Username.Text, Password.Text, Code.Text ).UserID;

                if ( Id > 0 )
                {
                    RegistedUser = new User_t( Id, Username.Text, Password.Text, false );
                }
                else
                {
                    throw new Exception( "Ocurreu um erro ao registar o utilizador." );
                }

                this.Close();

            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void ConfirmarPassword_TextChanged( object sender, EventArgs e )
        {

        }
    }
}
