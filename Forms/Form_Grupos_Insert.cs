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
    public partial class Form_Grupos_Insert : Form
    {
        Form_Grupos_View Viewer;

        int m_IdGrupo;
        string m_Descritivo;
        DataGridView m_gridToRefresh;

        public Form_Grupos_Insert( Form_Grupos_View main, int id, string desc, DataGridView gtr = null )
        {
            InitializeComponent();
            Viewer = main;

            m_IdGrupo = id;
            m_Descritivo = desc;
            m_gridToRefresh = gtr;
        }

        private void Form_Grupos_Insert_Load( object sender, EventArgs e )
        {
            try
            {
                Viewer.status.Text = "Aguardando novo registo...";
                this.Text = "Grupos: Novo registo";
                BtnSave.Text = "Inserir";
                BtnDuplicar.Visible = false;

                PreencherPlaylists();

                if ( m_IdGrupo != 0 )
                {
                    Viewer.status.Text = "Aguardando edição...";
                    this.Text = "Grupos: Editar registo";
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

        private void PreencherPlaylists()
        {
            try
            {
                dataGridView1.Columns.Add( "IdPlaylist", "IdPlaylist" );
                dataGridView1.Columns.Add( "PlaylistName", "Descritivo" );
                dataGridView1.Columns.Add( "Active", "Ativa" );
                dataGridView1.Columns.Add( "NrOrdem", "Ordem de Reproduçao" );

                dataGridView1.AjustarColunas();

                if ( this.m_IdGrupo != 0 )
                {
                    DataTable Rel = new GruposPlaylist().GetGruposPlaylistsByGrupo( m_IdGrupo ).Tables[0];

                    foreach ( DataRow row in Rel.Rows )
                    {
                        string Active = ( int )row["Ativo"] == 1 ? true.ToStringPT() : false.ToStringPT();
                        int IdPlaylist = ( int )row["IdPlaylist"];

                        DataRow Playlist = new Playlist().GetPlaylist( IdPlaylist ).Tables[0].Rows[0];
                        string Descritivo = Playlist["Descritivo"].ToString();

                        dataGridView1.Rows.Add( row["IdPlaylist"], Descritivo, Active, row["NrOrdem"] );
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
            this.Close();
        }

        private void BtnSave_Click( object sender, EventArgs e )
        {
            try
            {
                if ( dataGridView1.Rows.Count == 0 )
                {
                    DialogResult res = MessageBox.Show( "O seu grupo está vazio, pretende continuar?", "Aviso",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );

                    if ( res != DialogResult.Yes )
                        return;
                }

                Grupos dbGrupos = new Grupos();
                Playlist dbPlaylists = new Playlist();
                GruposPlaylist dbRel = new GruposPlaylist();

                if ( this.m_IdGrupo != 0 ) /* editar */
                {
                    dbGrupos.IdGrupo = this.m_IdGrupo;
                    dbGrupos.Descritivo = DescritivoBox.Text;

                    if ( dbGrupos.UpdateGrupo( dbGrupos ) != 1 )
                        throw new System.AggregateException( "Nao foi possivel atualizar registo na tabela Grupos." );

                    DataTable rel = dbRel.GetGruposPlaylistsByGrupo( this.m_IdGrupo ).Tables[0];

                    foreach ( DataRow row in rel.Rows )
                    {
                        if ( dbRel.DeleteGruposPlaylist( ( int )row["IdGrupoPlaylist"] ) != 1 )
                            throw new System.AggregateException( "Nao foi possivel eliminar registo na tabela de relacao Grupos-Playlist" );
                    }

                    for ( int i = 0; i < dataGridView1.Rows.Count; i++ )
                    {
                        DataGridViewRow row = dataGridView1.Rows[i];

                        dbRel.IdPlaylist = ( int )row.Cells["IdPlaylist"].Value;
                        dbRel.IdGrupo = this.m_IdGrupo;
                        dbRel.Ativo = row.Cells["Active"].Value.ToString() == true.ToStringPT() ? 1 : 0;
                        dbRel.NrOrdem = ( int )row.Cells["NrOrdem"].Value;

                        dbRel.IdGruposPlaylist = dbRel.InsertGruposPlaylist( dbRel );

                        if ( dbRel.IdGruposPlaylist == -1 )
                            throw new System.AggregateException( "Nao foi possivel inserir registo na tabela de relaçao Grupos-Playlist" );
                    }
                }
                else /* inserir */
                {
                    dbGrupos.IdGrupo = 0;
                    dbGrupos.Descritivo = DescritivoBox.Text;

                    this.m_IdGrupo = dbGrupos.InsertGrupo( dbGrupos );

                    if ( this.m_IdGrupo == -1 )
                        throw new System.AggregateException( "Nao foi possivel inserir registo na tabela Grupos." );

                    for ( int i = 0; i < dataGridView1.Rows.Count; i++ )
                    {
                        DataGridViewRow row = dataGridView1.Rows[i];

                        dbRel.IdGruposPlaylist = 0;
                        dbRel.IdPlaylist = ( int )row.Cells["IdPlaylist"].Value;
                        dbRel.IdGrupo = this.m_IdGrupo;
                        dbRel.Ativo = row.Cells["Active"].Value.ToString() == true.ToStringPT() ? 1 : 0;
                        dbRel.NrOrdem = ( int )row.Cells["NrOrdem"].Value;

                        dbRel.IdGruposPlaylist = dbRel.InsertGruposPlaylist( dbRel );

                        if ( dbRel.IdGruposPlaylist == -1 )
                        {
                            /* nao foi possivel inserir relaçao. remover registo do grupo para tentar novamente */
                            dbGrupos.DeleteGrupo( this.m_IdGrupo );

                            throw new System.AggregateException( "Nao foi possivel inserir registo na tabela de relaçao Grupos-Playlist" );
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
                this.m_IdGrupo = 0;
                Viewer.status.Text = "Aguardando novo registo...";
                this.Text = "Grupos: Novo registo";
                BtnSave.Text = "Inserir";
                BtnDuplicar.Visible = false;
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void btnGridAddPlaylist_Click( object sender, EventArgs e )
        {
            try
            {
                Form_Playlist_View Picker = new Form_Playlist_View();
                //Picker.MdiParent = this.MdiParent;
                Picker.SelectPlaylist += this.Picker_SelectPlaylist;
                Picker.ShowDialog();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void Picker_SelectPlaylist( int IdPlaylist, string Descritivo )
        {
            try
            {
                dataGridView1.Rows.Add( IdPlaylist, Descritivo, false.ToStringPT(), 0 );

                OrderPlaylists();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void OrderPlaylists()
        {
            try
            {
                for ( int i = 0; i < dataGridView1.Rows.Count; i++ )
                {
                    dataGridView1.Rows[i].Cells["NrOrdem"].Value = i + 1;
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void BtnToggleActive_Click( object sender, EventArgs e )
        {
            try
            {
                if ( dataGridView1.SelectedCells.Count >= 1 )
                {
                    List<int> AffectedRows = new List<int>();
                    for ( int i = 0; i < dataGridView1.SelectedCells.Count; i++ )
                    {
                        DataGridViewRow row = dataGridView1.SelectedCells[i].OwningRow;
                        if ( AffectedRows.IndexOf( row.Index ) != -1 ) continue;
                        AffectedRows.Add( row.Index );

                        if ( row.Cells["Active"].Value.ToString() == true.ToStringPT() )
                            row.Cells["Active"].Value = false.ToStringPT();
                        else
                            row.Cells["Active"].Value = true.ToStringPT();
                    }
                    AffectedRows.Clear();
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void btnGridItemUp_Click( object sender, EventArgs e )
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

                int IdPlaylist = ( int )dataGridView1.Rows[iSelectedRow].Cells["IdPlaylist"].Value;
                string Descritivo = dataGridView1.Rows[iSelectedRow].Cells["PlaylistName"].Value.ToString();
                string Ativo = dataGridView1.Rows[iSelectedRow].Cells["Active"].Value.ToString();
                int NrOrdem = ( int )dataGridView1.Rows[iSelectedRow].Cells["NrOrdem"].Value;

                dataGridView1.Rows.RemoveAt( iSelectedRow );
                dataGridView1.Rows.Insert( iSelectedRow - 1, IdPlaylist, Descritivo, Ativo, NrOrdem );
                dataGridView1.ClearSelection();
                dataGridView1.Rows[iSelectedRow - 1].Selected = true;

                OrderPlaylists();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void btnGridItemDown_Click( object sender, EventArgs e )
        {
            try
            {
                int iSelectedRow = 0;
                for ( int i = 0; i < dataGridView1.SelectedCells.Count; i++ )
                {
                    iSelectedRow = dataGridView1.SelectedCells[i].RowIndex;
                    i = dataGridView1.SelectedCells.Count;
                }

                if ( iSelectedRow == dataGridView1.Rows.Count - 1 )
                    return;

                int IdPlaylist = ( int )dataGridView1.Rows[iSelectedRow].Cells["IdPlaylist"].Value;
                string Descritivo = dataGridView1.Rows[iSelectedRow].Cells["PlaylistName"].Value.ToString();
                string Ativo = dataGridView1.Rows[iSelectedRow].Cells["Active"].Value.ToString();
                int NrOrdem = ( int )dataGridView1.Rows[iSelectedRow].Cells["NrOrdem"].Value;

                dataGridView1.Rows.RemoveAt( iSelectedRow );
                dataGridView1.Rows.Insert( iSelectedRow + 1, IdPlaylist, Descritivo, Ativo, NrOrdem );
                dataGridView1.ClearSelection();
                dataGridView1.Rows[iSelectedRow + 1].Selected = true;

                OrderPlaylists();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void btnGridDelPlaylist_Click( object sender, EventArgs e )
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

                OrderPlaylists();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }
    }
}
