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
    public delegate void Form_Playlist_ViewEventHandler( int IdPlaylist, string Descritivo );

    public partial class Form_Playlist_View : Form
    {

        public event Form_Playlist_ViewEventHandler SelectPlaylist;

        public Form_Playlist_View()
        {
            InitializeComponent();
        }

        private void Form_Playlist_View_Load( object sender, EventArgs e )
        {
            BtnRefresh.PerformClick();
            toolStripButton2.PerformClick();
        }

        private void toolStripButton2_Click( object sender, EventArgs e )
        {
            dataGridView1.AjustarColunas();
        }

        private void BtnRefresh_Click( object sender, EventArgs e )
        {
            try
            {
                status.Text = "Atualizando lista...";
                dataGridView1.DataSource = new Playlist().LerPlaylist().Tables[0];
                status.Text = "Atualizado com sucesso.";
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void BtnDelete_Click( object sender, EventArgs e )
        {
            try
            {
                Playlist dados = new Playlist();
                status.Text = "Eliminando " + dataGridView1.SelectedRows.Count + " registos...";
                int iDeleted = 0;

                List<int> AffectedRows = new List<int>();
                for ( int i = 0; i < dataGridView1.SelectedCells.Count; i++ )
                {
                    int index = dataGridView1.SelectedCells[i].RowIndex;

                    if ( AffectedRows.IndexOf( index ) != -1 ) continue;
                    AffectedRows.Add( index );

                    DataGridViewRow row = dataGridView1.Rows[index];

                    dados.IdPlaylist = ( int )row.Cells["IdPlaylist"].Value;
                    dados.Descritivo = row.Cells["Descritivo"].Value.ToString();

                    DialogResult result = MessageBox.Show( string.Format( "Tem a certeza que deseja apagar o registo?\r\n{0}-{1}", dados.IdPlaylist, dados.Descritivo ), "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );

                    if ( result == DialogResult.Yes )
                        iDeleted += dados.DeletePlaylist( dados.IdPlaylist );

                    if ( result == DialogResult.Cancel )
                        break;
                }
                AffectedRows.Clear();

                BtnRefresh_Click( sender, e );
                status.Text = "Eliminado " + iDeleted + " registos com sucesso.";
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void toolStripButton1_Click( object sender, EventArgs e )
        {
            try
            {
                Form_Playlist_Insert ins = new Form_Playlist_Insert( this, 0, "" );
                ins.MdiParent = this.MdiParent;
                ins.Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void BtnUpdate_Click( object sender, EventArgs e )
        {
            try
            {
                for ( int i = 0; i < dataGridView1.SelectedRows.Count; i++ )
                {
                    int id = ( int )dataGridView1.SelectedRows[i].Cells["IdPlaylist"].Value;
                    string desc = dataGridView1.SelectedRows[i].Cells["Descritivo"].Value.ToString();

                    Form_Playlist_Insert edit = new Form_Playlist_Insert( this, id, desc );
                    edit.MdiParent = this.MdiParent;
                    edit.Close();
                }

                if ( dataGridView1.SelectedRows.Count == 0 )
                {
                    List<int> AffectedRows = new List<int>();

                    for ( int i = 0; i < dataGridView1.SelectedCells.Count; i++ )
                    {
                        int index = dataGridView1.SelectedCells[i].RowIndex;

                        if ( AffectedRows.IndexOf( index ) != -1 ) continue;

                        AffectedRows.Add( index );

                        DataGridViewRow row = dataGridView1.Rows[index];

                        int id = ( int )row.Cells["IdPlaylist"].Value;
                        string desc = row.Cells["Descritivo"].Value.ToString();

                        Form_Playlist_Insert edit = new Form_Playlist_Insert( this, id, desc );
                        edit.MdiParent = this.MdiParent;
                        edit.Show();
                    }

                    AffectedRows.Clear();
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void Form_Playlist_View_FormClosing( object sender, FormClosingEventArgs e )
        {
            this.Hide();
            e.Cancel = true;
        }

        private void dataGridView1_MouseDoubleClick( object sender, MouseEventArgs e )
        {
            try
            {
                if ( dataGridView1.SelectedCells.Count > 0 )
                {
                    DataGridViewRow row = dataGridView1.SelectedCells[0].OwningRow;

                    int id = ( int )row.Cells["IdPlaylist"].Value;
                    string desc = row.Cells["Descritivo"].Value.ToString();

                    if ( SelectPlaylist != null )
                    {
                        SelectPlaylist( id, desc );
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }
    }
}
