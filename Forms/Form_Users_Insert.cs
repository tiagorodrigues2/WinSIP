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

namespace WinSIP.Forms
{
    public partial class Form_Users_Insert : Form
    {
        public User_t RegistedUser = new User_t(0, "", "", false );

        private bool bEdit;
        private int iUserID;

        public Form_Users_Insert(bool bEdit = false, int UserID = 0)
        {
            InitializeComponent();

            this.bEdit = bEdit;
            this.iUserID = UserID;

            if ( bEdit == false )
            {
                CustomPassword.Checked = false;
                Admin.Checked = false;
                Password.Text = "#1234";
                ForceChangePassword.Checked = true;

                Password.Enabled = false;
                ForceChangePassword.Enabled = false;
            }
            else
            {
                this.Text = "Editar Utilizador";
                button1.Text = "Guardar";
                Username.Enabled = false;
                CustomPassword.Text = "Alterar Palavra-passe";
                CustomPassword.Checked = false;

                Password.Enabled = false;
                ForceChangePassword.Enabled = false;

                try
                {
                    Users users = new Users();

                    CheckUserReturn_t Check = users.GetUserByID( UserID );

                    if ( Check.Success == false )
                        throw new System.Exception( "Ocorreu um erro ao verificar as informaçoes do utilizador." );

                    Username.Text = Check.user.username;

                    Admin.CheckedChanged -= Admin_CheckedChanged;
                    Admin.Checked = Check.user.IsAdmin;
                    Admin.CheckedChanged += Admin_CheckedChanged;

                    ForceChangePassword.Checked = Check.ForceChangePassword;

                }
                catch ( Exception ex )
                {
                    MessageBox.Show( ex.Message );
                    this.Close();
                }
            }
        }


        private void CustomPassword_CheckedChanged( object sender, EventArgs e )
        {
            Password.Enabled = CustomPassword.Checked;
            ForceChangePassword.Enabled = CustomPassword.Checked;

            if ( CustomPassword.Checked == false && Password.Text != "#1234" )
                Password.Text = "#1234";
        }

        private void button2_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            try
            {
                Users users = new Users();

                if ( this.bEdit )
                {

                    if ( users.SetAdmin( this.iUserID, Admin.Checked ) == false || users.SetForceChangePassword( this.iUserID, ForceChangePassword.Checked ) == false)
                    {
                        MessageBox.Show( "Erro ao guardar novas informaçoes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                        return;
                    }

                    if (CustomPassword.Checked)
                    {
                        users.ChangePassword( this.iUserID, Password.Text );
                    }

                    this.Close();
                    return;
                }


                if ( Username.Text.Length <= 3 )
                {
                    MessageBox.Show( "Username não pode ter menos que 4 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    return;
                }


                User_t ReturnedUser = users.NewUser( Username.Text, Password.Text, ForceChangePassword.Checked, Admin.Checked );

                this.RegistedUser = ReturnedUser;
                this.Close();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void Admin_CheckedChanged( object sender, EventArgs e )
        {
            if ( Admin.Checked == true )
            {
                DialogResult res = MessageBox.Show( "Tem a certeza que deseja tornar este utilizador Administrador?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );

                if ( res != DialogResult.Yes )
                    Admin.Checked = false;
            }
        }
    }
}
