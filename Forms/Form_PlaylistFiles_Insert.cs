using MySql.Data.MySqlClient;
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
    public partial class Form_PlaylistFiles_Insert : Form
    {
        Form_PlaylistFiles_View Viewer;

        int IdPlaylistFiles;
        int IdPlaylist;
        int IdFile;
        int NrOrdem;

        DataTable Playlist;
        DataTable Files;

        public Form_PlaylistFiles_Insert( Form_PlaylistFiles_View _this, int id, int playlist, int file, int order )
        {
            InitializeComponent();

            Viewer = _this;
            IdPlaylistFiles = id;
            IdPlaylist = playlist;
            IdFile = file;
            NrOrdem = order;
        }

        private void Form_PlaylistFiles_Insert_Load( object sender, EventArgs e )
        {
            this.Text = "PlaylistFiles: Inserir";

            TableName.Visible = false;
            TableAnterior.Visible = false;
            TableNext.Visible = false;
            dataGridView1.Visible = false;

            if ( IdPlaylistFiles != 0 )
            {
                this.Text = "PlaylistFiles: Editar";
            }

            Playlist = new Playlist().LerPlaylist().Tables[0];
            Files = new Files().LerFiles().Tables[0];

            PlaylistBox.Items.Clear();
            for ( int i = 0; i < Playlist.Rows.Count; i++ )
            {
                int id = ( int )Playlist.Rows[i]["IdPlaylist"];
                string desc = Playlist.Rows[i]["Descritivo"].ToString();

                PlaylistBox.Items.Add( id + " <" + desc + ">" );

                if ( IdPlaylistFiles != 0 && id == IdPlaylist ) PlaylistBox.SelectedIndex = i;
            }

            FileBox.Items.Clear();
            for ( int i = 0; i < Files.Rows.Count; i++ )
            {
                int id = ( int )Files.Rows[i]["IdFile"];
                string desc = Files.Rows[i]["Descritivo"].ToString();

                FileBox.Items.Add( id + " <" + desc + ">" );

                if ( IdPlaylistFiles != 0 && id == IdFile ) FileBox.SelectedIndex = i;
            }

            NrOrdemBox.Value = NrOrdem;

            ChkViewtables.Checked = true;
        }

        private void BtnCancel_Click( object sender, EventArgs e )
        {
            Viewer.BtnRefresh.PerformClick();
            this.Close();
        }

        private void BtnSave_Click( object sender, EventArgs e )
        {
            PlaylistFiles dados = new PlaylistFiles();

            dados.IdFile = ( int )Files.Rows[FileBox.SelectedIndex]["IdFile"];
            dados.IdPlaylist = ( int )Playlist.Rows[PlaylistBox.SelectedIndex]["IdPlaylist"];
            dados.NrOrdem = ( int )NrOrdemBox.Value;

            MySqlConnection connection = AcessoBD.Connection;
            MySqlCommand cmd = new MySqlCommand( "select COUNT(*) as ret from playlistfiles where IdFile=@IdFile and IdPlaylist=@IdPlaylist and NrOrdem=@NrOrdem", connection );
            cmd.Parameters.Add( "IdFile", MySqlDbType.Int32 ).Value = dados.IdFile;
            cmd.Parameters.Add( "IdPlaylist", MySqlDbType.Int32 ).Value = dados.IdPlaylist;
            cmd.Parameters.Add( "NrOrdem", MySqlDbType.Int32 ).Value = dados.NrOrdem;

            try
            {
                connection.Open();
                MySqlDataReader result = cmd.ExecuteReader();

                if ( result.Read() )
                {
                    if ( result.GetInt32( 0 ) > 0 )
                    {
                        MessageBox.Show( "Já existe um ficheiro na playlist " + dados.IdPlaylist + " na NrOrdem " + dados.NrOrdem );
                        return;
                    }
                }
            }
            catch ( Exception ex )
            {
                throw ex;
                return;
            }
            finally
            {
                connection.Close();
            }

            if ( IdPlaylistFiles != 0 )
            {
                dados.IdPlaylistFiles = IdPlaylistFiles;
                Viewer.status.Text = "Atualizando dados...";

                int iChanged = dados.UpdatePlaylistFiles( dados );

                Viewer.BtnRefresh.PerformClick();
                Viewer.status.Text = "Atualizado " + iChanged + " registos com sucesso.";
            }
            else
            {
                Viewer.status.Text = "Inserindo dados...";
                int iInserted = dados.InsertPlaylistFiles( dados );

                Viewer.BtnRefresh.PerformClick();
                Viewer.status.Text = "Inserido registo com o ID: " + iInserted;
            }

            this.Close();
        }

        private void AjustarColunas()
        {
            for ( int i = 0; i < dataGridView1.Columns.Count; i++ )
            {
                dataGridView1.Columns[i].Width = ( dataGridView1.Width / dataGridView1.Columns.Count ) - ( dataGridView1.RowHeadersWidth / dataGridView1.Columns.Count ) - 1;
            }
        }

        private void ChkViewtables_CheckedChanged( object sender, EventArgs e )
        {
            dataGridView1.Visible = ChkViewtables.Checked;
            TableName.Visible = ChkViewtables.Checked;
            TableNext.Visible = ChkViewtables.Checked;
            TableAnterior.Visible = ChkViewtables.Checked;

            if ( ChkViewtables.Checked )
            {

                TableNext.Enabled = true;
                TableAnterior.Enabled = false;
                TableName.Text = "Playlist";

                dataGridView1.DataSource = new Playlist().LerPlaylist().Tables[0];

                AjustarColunas();
            }
        }

        private void TableAnterior_Click( object sender, EventArgs e )
        {
            TableNext.Enabled = true;

            if ( TableName.Text == "PlaylistFiles" )
            {
                TableAnterior.Enabled = true;
                TableName.Text = "Files";

                dataGridView1.DataSource = new Files().LerFiles().Tables[0];
                AjustarColunas();
            }
            else if ( TableName.Text == "Files" )
            {
                TableAnterior.Enabled = false;
                TableName.Text = "Playlist";

                dataGridView1.DataSource = new Playlist().LerPlaylist().Tables[0];
                AjustarColunas();
            }
        }

        private void TableNext_Click( object sender, EventArgs e )
        {
            TableAnterior.Enabled = true;

            if ( TableName.Text == "Playlist" )
            {
                TableName.Text = "Files";
                TableNext.Enabled = true;

                dataGridView1.DataSource = new Files().LerFiles().Tables[0];

                AjustarColunas();
            }
            else if ( TableName.Text == "Files" )
            {
                TableNext.Enabled = false;
                TableName.Text = "PlaylistFiles";

                dataGridView1.DataSource = new PlaylistFiles().LerPlaylistFiles().Tables[0];
                AjustarColunas();
            }
        }
    }
}
