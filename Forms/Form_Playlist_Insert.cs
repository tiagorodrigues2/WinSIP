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
    public partial class Form_Playlist_Insert : Form
    {
        Form_Playlist_View Viewer;

        int m_IdPlaylist;
        string m_Descritivo;

        public Form_Playlist_Insert( Form_Playlist_View _this, int id, string desc )
        {
            InitializeComponent();
            Viewer = _this;

            m_IdPlaylist = id;
            m_Descritivo = desc;
        }

        private void Form_Playlist_Insert_Load( object sender, EventArgs e )
        {
            try
            {
                Viewer.status.Text = "Aguardando novo registo...";
                this.Text = "Playlist: Novo registo";
                BtnSave.Text = "Inserir";
                BtnDuplicar.Visible = false;

                PreencherFiles();

                if ( m_IdPlaylist != 0 )
                {
                    Viewer.status.Text = "Aguardando edição...";
                    this.Text = "Playlist: Atualizar registo";
                    BtnSave.Text = "Atualizar";
                    BtnDuplicar.Visible = true;

                    DescritivoBox.Text = m_Descritivo;
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        void PreencherFiles()
        {
            try
            {

                dataGridView1.Columns.Add( "IdFile", "IdFile" );
                dataGridView1.Columns.Add( "FileName", "Nome do Ficheiro" );
                dataGridView1.Columns.Add( "NrOrdem", "Ordem de reproduçao" );

                dataGridView1.AjustarColunas();

                if ( this.m_IdPlaylist > 0 )
                {
                    DataSet PlaylistRel = new PlaylistFiles().GetPlaylistFilesByPlaylist( this.m_IdPlaylist );


                    for ( int i = 0; i < PlaylistRel.Tables[0].Rows.Count; i++ )
                    {
                        DataRow row = PlaylistRel.Tables[0].Rows[i];

                        int IdFile = ( int )row["IdFile"];
                        int NrOrdem = ( int )row["NrOrdem"];

                        DataSet Files = new Files().LerFiles();
                        string Descritivo = "";

                        foreach ( DataRow File in Files.Tables[0].Rows )
                        {
                            if ( ( int )File["IdFile"] == IdFile )
                            {
                                Descritivo = File["Descritivo"].ToString();
                                break;
                            }
                        }

                        dataGridView1.Rows.Insert( NrOrdem - 1, IdFile, Descritivo, NrOrdem );
                    }

                }

            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void BtnCancel_Click( object sender, EventArgs e )
        {
            Viewer.status.Text = "Ação cancelada.";
            this.Close();
        }

        private void BtnSave_Click( object sender, EventArgs e )
        {
            try
            {
                if ( dataGridView1.Rows.Count == 0 )
                {
                    DialogResult res = MessageBox.Show( "A sua playlist está vazia, pretende continuar?", "Aviso",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );

                    if ( res != DialogResult.Yes )
                        return;
                }

                Playlist dbPlaylist = new Playlist();
                Files dbFiles = new Files();
                PlaylistFiles dbRel = new PlaylistFiles();

                if ( this.m_IdPlaylist != 0 ) /* editar */
                {
                    dbPlaylist.IdPlaylist = this.m_IdPlaylist;
                    dbPlaylist.Descritivo = DescritivoBox.Text;

                    if ( dbPlaylist.UpdatePlaylist( dbPlaylist ) != 1 )
                        throw new System.AggregateException( "Nao foi possivel atualizar registo na tabela Playlist" );

                    DataTable PlaylistRel = dbRel.GetPlaylistFilesByPlaylist( this.m_IdPlaylist ).Tables[0];

                    foreach ( DataRow Rel in PlaylistRel.Rows )
                    {
                        if ( dbRel.DeletePlaylistFiles( ( int )Rel["IdPlaylistFiles"] ) != 1 )
                            throw new System.AggregateException( "Nao foi possivel eliminar registo na tabela de relacao Playlist-Files" );
                    }

                    for ( int i = 0; i < dataGridView1.Rows.Count; i++ )
                    {
                        DataGridViewRow row = dataGridView1.Rows[i];

                        dbRel.IdPlaylistFiles = 0;
                        dbRel.IdFile = ( int )row.Cells["IdFile"].Value;
                        dbRel.NrOrdem = ( int )row.Cells["NrOrdem"].Value;
                        dbRel.IdPlaylist = this.m_IdPlaylist;

                        if ( dbRel.InsertPlaylistFiles( dbRel ) == -1 )
                            throw new System.AggregateException( "Nao foi possivel inserir registo na tabela PlaylistFiles" );

                    }
                }
                else /* inserir */
                {
                    dbPlaylist.IdPlaylist = 0;
                    dbPlaylist.Descritivo = DescritivoBox.Text;
                    int IdPlaylist = dbPlaylist.InsertPlaylist( dbPlaylist );

                    if ( IdPlaylist == -1 )
                        throw new System.AggregateException( "Nao foi possivel inserir registo na tabela Playlist" );

                    for ( int i = 0; i < dataGridView1.Rows.Count; i++ )
                    {
                        DataGridViewRow row = dataGridView1.Rows[i];

                        dbRel.IdPlaylistFiles = 0;
                        dbRel.IdFile = ( int )row.Cells["IdFile"].Value;
                        dbRel.NrOrdem = ( int )row.Cells["NrOrdem"].Value;
                        dbRel.IdPlaylist = IdPlaylist;

                        if ( dbRel.InsertPlaylistFiles( dbRel ) == -1 )
                        {
                            /* nao foi possivel inserir relaçao. remover registo da playlist para tentar novamente */
                            dbPlaylist.DeletePlaylist( IdPlaylist );

                            throw new System.AggregateException( "Nao foi possivel inserir registo na tabela PlaylistFiles" );
                        }

                    }
                }

                Viewer.BtnRefresh.PerformClick();
                this.Close();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void BtnDuplicar_Click( object sender, EventArgs e )
        {
            try
            {
                Viewer.status.Text = "Aguardando novo registo...";
                this.Text = "Playlist: Novo registo";
                BtnSave.Text = "Inserir";
                BtnDuplicar.Visible = false;
                this.m_IdPlaylist = 0;
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void BtnBrowseFiles_Click( object sender, EventArgs e )
        {
            try
            {
                Form_Files_View Viewer = new Form_Files_View();
                Viewer.SelectFile += this.Viewer_SelectFile;
                Viewer.ShowDialog();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void Viewer_SelectFile( int IdFile, string Descritivo )
        {
            try
            {
                dataGridView1.Rows.Add( IdFile, Descritivo );

                UpdateFileOrder();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void btnGridDelFile_Click( object sender, EventArgs e )
        {
            try
            {
                List<int> AffectedRows = new List<int>();
                for ( int i = 0; i < dataGridView1.SelectedCells.Count; i++ )
                {
                    int iRowIndex = dataGridView1.SelectedCells[i].RowIndex;
                    if ( AffectedRows.IndexOf( iRowIndex ) > 0 ) continue;
                    AffectedRows.Add( iRowIndex );

                    dataGridView1.Rows.RemoveAt( iRowIndex );
                }
                AffectedRows.Clear();

                UpdateFileOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void UpdateFileOrder()
        {
            for ( int i = 0; i < dataGridView1.Rows.Count; i++ )
            {
                dataGridView1.Rows[i].Cells["NrOrdem"].Value = i + 1;
            }
        }

        private void btnGridAddFile_Click( object sender, EventArgs e )
        {
            try
            {
                Form_Files_View Picker = new Form_Files_View();
                //Picker.MdiParent = this.MdiParent;
                Picker.SelectFile += Viewer_SelectFile;
                Picker.ShowDialog();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void dataGridView1_UserDeletedRow( object sender, DataGridViewRowEventArgs e )
        {
            UpdateFileOrder();
        }

        private void btnOrderDown_Click( object sender, EventArgs e )
        {
            try
            {
                int iSelectedRow = 0;
                for ( int i = 0; i < dataGridView1.SelectedCells.Count; i++ )
                {
                    iSelectedRow = dataGridView1.SelectedCells[i].RowIndex;
                    i = dataGridView1.SelectedCells.Count;
                }

                if ( iSelectedRow == dataGridView1.Rows.Count - 1)
                    return;

                int IdFile = ( int )dataGridView1.Rows[iSelectedRow].Cells["IdFile"].Value;
                int NrOrdem = ( int )dataGridView1.Rows[iSelectedRow].Cells["NrOrdem"].Value;
                string Descritivo = dataGridView1.Rows[iSelectedRow].Cells["FileName"].Value.ToString();

                dataGridView1.Rows.RemoveAt( iSelectedRow );
                dataGridView1.Rows.Insert( iSelectedRow + 1, IdFile, Descritivo, NrOrdem );
                dataGridView1.ClearSelection();
                dataGridView1.Rows[iSelectedRow + 1].Selected = true;

                UpdateFileOrder();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void btnOrderUp_Click( object sender, EventArgs e )
        {
            try
            {
                int iSelectedRow = 0;
                for ( int i = 0; i < dataGridView1.SelectedCells.Count; i++ )
                {
                    iSelectedRow = dataGridView1.SelectedCells[i].RowIndex;
                    i = dataGridView1.SelectedCells.Count;
                }

                if ( iSelectedRow > 0 == false )
                    return;

                int IdFile = ( int )dataGridView1.Rows[iSelectedRow].Cells["IdFile"].Value;
                int NrOrdem = ( int )dataGridView1.Rows[iSelectedRow].Cells["NrOrdem"].Value;
                string Descritivo = dataGridView1.Rows[iSelectedRow].Cells["FileName"].Value.ToString();

                dataGridView1.Rows.RemoveAt( iSelectedRow );
                dataGridView1.Rows.Insert( iSelectedRow - 1, IdFile, Descritivo, NrOrdem );
                dataGridView1.ClearSelection();
                dataGridView1.Rows[iSelectedRow - 1].Selected = true;

                UpdateFileOrder();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }
    }
}
