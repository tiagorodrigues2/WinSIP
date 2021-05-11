using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSIP.Forms;
using WinSIP.Dados;


namespace WinSIP
{
    public partial class FormMDI : Form
    {

        public Form_Display_View DisplayViewer;
        public Form_Files_View FilesViewer;
        public Form_Grupos_View GruposViewer;
        public Form_Playlist_View PlaylistViewer;

        public Form_PlaylistFiles_View PlaylistFilesViewer;
        public Form_GruposPlaylist_View GruposPlaylistViewer;

        public Form_Users_View UsersViewer;
        public Form_AccessCodes_View CodesViewer;

        public User_t LoggedUser;

        public Screen DisplayMonitor;

        public FormMDI()
        {
            InitializeComponent();
        }

        private void FormMDI_Load( object sender, EventArgs e )
        {

            Properties.Settings.Default.Reload();

            DisplayViewer = new Form_Display_View();
            FilesViewer = new Form_Files_View();
            GruposViewer = new Form_Grupos_View();
            PlaylistViewer = new Form_Playlist_View();
            PlaylistFilesViewer = new Form_PlaylistFiles_View();
            GruposPlaylistViewer = new Form_GruposPlaylist_View();
            UsersViewer = new Form_Users_View();
            CodesViewer = new Form_AccessCodes_View();

            DisplayViewer.MdiParent = this;
            FilesViewer.MdiParent = this;
            GruposViewer.MdiParent = this;
            PlaylistViewer.MdiParent = this;
            PlaylistFilesViewer.MdiParent = this;
            GruposPlaylistViewer.MdiParent = this;
            UsersViewer.MdiParent = this;
            CodesViewer.MdiParent = this;

            DisplayMonitor = null;

            for ( int i = 0; i < Screen.AllScreens.Count(); i++ )
            {
                if ( Screen.AllScreens[i].DeviceName.Equals( Properties.Settings.Default.DisplayMonitor ) )
                    DisplayMonitor = Screen.AllScreens[i];
            }

            if ( DisplayMonitor == null )
            {
                DisplayMonitor = Screen.AllScreens[0];
            }

            Form_Login Login = new Form_Login();
            Login.ShowDialog();

            if ( Login._LoginSucesso == false )
            {
                this.Close();
            }

            this.LoggedUser = Login.LoggedUser;
            this.menuStrip1.Visible = true;

            this.administraçaoToolStripMenuItem.Visible = LoggedUser.IsAdmin;

        }

        private void displaysToolStripMenuItem_Click( object sender, EventArgs e )
        {
            DisplayViewer.Show();
        }

        private void gruposToolStripMenuItem_Click( object sender, EventArgs e )
        {
            GruposViewer.Show();
        }

        private void filesToolStripMenuItem_Click( object sender, EventArgs e )
        {
            FilesViewer.Show();
        }

        private void playlistToolStripMenuItem_Click( object sender, EventArgs e )
        {
            PlaylistViewer.Show();
        }

        private void template1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Template1 FRM = new Form_Template1();
            FRM.Show();
        }


        private void Choser_SelectDisplay( int IdDisplay )
        {
            Form_Template2 Template2 = new Form_Template2( IdDisplay );
            Template2.MdiParent = this;
            Template2.Show();
        }

        private void gerenciarContaToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Form_GerirConta Manager = new Form_GerirConta(LoggedUser, this, false);
            Manager.Show();
        }

        public void Logout()
        {
            DisplayViewer.Hide();
            FilesViewer.Hide();
            GruposViewer.Hide();
            PlaylistViewer.Hide();
            PlaylistFilesViewer.Hide();
            GruposPlaylistViewer.Hide();
            UsersViewer.Hide();

            this.LoggedUser.UserID = 0;
            this.LoggedUser.username = "";
            this.LoggedUser.password = "";
            this.LoggedUser.IsAdmin = false;

            administraçaoToolStripMenuItem.Visible = false;
            menuStrip1.Visible = false;

            Properties.Settings.Default.Password = "";
            Properties.Settings.Default.RememberMe = false;
            Properties.Settings.Default.Save();

            FormMDI_Load( this, new EventArgs() );
        }

        private void gerirUtilizadoresToolStripMenuItem_Click( object sender, EventArgs e )
        {
            UsersViewer.Show();
        }

        private void gerirCódigosDeAcessoToolStripMenuItem_Click( object sender, EventArgs e )
        {
            CodesViewer.Show();
        }

        private void browserToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Form_Display_View Choser = new Form_Display_View();
            Choser.SelectDisplay += this.Choser_SelectDisplay;
            Choser.ShowDialog();
        }

        private void selecionarMonitorToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Form_ChoseMonitor choseMonitor = new Form_ChoseMonitor( this );
            choseMonitor.SelectMonitor += this.ChoseMonitor_SelectMonitor;
            choseMonitor.ShowDialog();

        }

        private void ChoseMonitor_SelectMonitor( string DeviceName )
        {
           
            for ( int i = 0; i < Screen.AllScreens.Count(); i++ )
            {

            }
        }
    }
}
