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
    public partial class Form_GruposPlaylist_Insert : Form
    {
        Form_GruposPlaylist_View Viewer;

        int IdGruposPlaylist;
        int IdGrupo;
        int IdPlaylist;

        DataTable Grupos;
        DataTable Playlists;

        public Form_GruposPlaylist_Insert( Form_GruposPlaylist_View _this, int id, int grupo, int playlist )
        {
            InitializeComponent();

            Viewer = _this;
            IdGruposPlaylist = id;
            IdGrupo = grupo;
            IdPlaylist = playlist;
        }

        private void Form_GruposPlaylist_Insert_Load( object sender, EventArgs e )
        {
            Viewer.status.Text = "Aguardando inserção...";
            this.Text = "GruposPlaylist: Inserir";

            dataGridView1.Visible = false;
            TableName.Visible = false;
            TableNext.Visible = false;
            TableAnterior.Visible = false;

            Grupos = new Grupos().LerGrupos().Tables[0];
            Playlists = new Playlist().LerPlaylist().Tables[0];

            GrupoBox.Items.Clear();
            for ( int i = 0; i < Grupos.Rows.Count; i++ )
            {
                int id = ( int )Grupos.Rows[i]["IdGrupo"];
                string desc = Grupos.Rows[i]["Descritivo"].ToString();

                GrupoBox.Items.Add( id + "<" + desc + ">" );

                if ( IdGruposPlaylist != 0 && id == IdGrupo ) 
                    GrupoBox.SelectedIndex = i;
            }

            PlaylistBox.Items.Clear();
            for ( int i = 0; i < Playlists.Rows.Count; i++ )
            {
                int id = ( int )Playlists.Rows[i]["IdPlaylist"];
                string desc = Playlists.Rows[i]["Descritivo"].ToString();

                PlaylistBox.Items.Add( id + "<" + desc + ">" );

                if ( IdGruposPlaylist != 0 && id == IdPlaylist )
                    PlaylistBox.SelectedIndex = i;
            }

            if ( IdGruposPlaylist != 0 ) this.Text = "GruposPlaylist: Editar";
        }

        private void BtnCancel_Click( object sender, EventArgs e )
        {
            Viewer.BtnRefresh.PerformClick();
            this.Close();
        }

        private void BtnSave_Click( object sender, EventArgs e )
        {
            GruposPlaylist dados = new GruposPlaylist();

            dados.IdGrupo = ( int )Grupos.Rows[GrupoBox.SelectedIndex]["IdGrupo"];
            dados.IdPlaylist = ( int )Playlists.Rows[PlaylistBox.SelectedIndex]["IdPlaylist"];

            if ( IdGruposPlaylist != 0 ) /* Atualizar */
            {
                dados.IdGruposPlaylist = IdGruposPlaylist;

                int iChanged = dados.UpdateGruposPlaylist( dados );

                Viewer.BtnRefresh.PerformClick();
                Viewer.status.Text = "Atualizado " + iChanged + " registos com sucesso.";
            }
            else
            {
                int iInserted = dados.InsertGruposPlaylist( dados );

                Viewer.BtnRefresh.PerformClick();
                Viewer.status.Text = "Inserido registo com ID: " + iInserted;
            }

            this.Close();
        }

        private void AjustarLargura()
        {
            for ( int i = 0; i < dataGridView1.Columns.Count; i++ )
            {
                dataGridView1.Columns[i].Width = ( dataGridView1.Width / dataGridView1.Columns.Count ) - ( dataGridView1.RowHeadersWidth / dataGridView1.Columns.Count ) - 1;
            }
        }

        private void ChkViewTables_CheckedChanged( object sender, EventArgs e )
        {
            dataGridView1.Visible = ChkViewTables.Checked;
            TableName.Visible = ChkViewTables.Checked;
            TableNext.Visible = ChkViewTables.Checked;
            TableAnterior.Visible = ChkViewTables.Checked;

            if ( ChkViewTables.Checked )
            {
                TableName.Text = "Grupos";
                TableAnterior.Enabled = false;
                TableNext.Enabled = true;

                dataGridView1.DataSource = new Grupos().LerGrupos().Tables[0];

                AjustarLargura();
            }
        }

        private void TableNext_Click( object sender, EventArgs e )
        {
            TableAnterior.Enabled = true;
            TableNext.Enabled = false;
            TableName.Text = "Playlist";

            dataGridView1.DataSource = new Playlist().LerPlaylist().Tables[0];

            AjustarLargura();
        }

        private void TableAnterior_Click( object sender, EventArgs e )
        {
            TableAnterior.Enabled = false;
            TableNext.Enabled = true;
            TableName.Text = "Grupos";

            dataGridView1.DataSource = new Grupos().LerGrupos().Tables[0];

            AjustarLargura();
        }
    }
}
