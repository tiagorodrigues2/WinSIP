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
    public partial class Form_PlaylistFiles_View : Form
    {
        public Form_PlaylistFiles_View()
        {
            InitializeComponent();
        }

        private void BtnAjustarCol_Click( object sender, EventArgs e )
        {
            for ( int i = 0; i < dataGridView1.Columns.Count; i++ )
            {
                dataGridView1.Columns[i].Width = ( dataGridView1.Width / dataGridView1.Columns.Count ) - ( dataGridView1.RowHeadersWidth / dataGridView1.Columns.Count ) - 1;
            }
        }

        private void BtnRefresh_Click( object sender, EventArgs e )
        {
            status.Text = "Atualizando lista...";
            dataGridView1.DataSource = new PlaylistFiles().LerPlaylistFiles().Tables[0];
            status.Text = "Lista atualizada com sucesso.";
        }

        private void BtnDelete_Click( object sender, EventArgs e )
        {
            PlaylistFiles dados = new PlaylistFiles();
            int iDeleted = 0;

            for ( int i = 0; i < dataGridView1.SelectedRows.Count; i++ )
            {
                int id = ( int )dataGridView1.SelectedRows[i].Cells["IdPlaylistFiles"].Value;

                iDeleted += dados.DeletePlaylistFiles( id );
            }

            BtnRefresh.PerformClick();
            status.Text = "Eliminado " + iDeleted + " registos com sucesso.";
        }

        private void BtnUpdate_Click( object sender, EventArgs e )
        {
            for ( int i = 0; i < dataGridView1.SelectedRows.Count; i++ )
            {
                int id = ( int )dataGridView1.SelectedRows[i].Cells["IdPlaylistFiles"].Value;
                int playlist = ( int )dataGridView1.SelectedRows[i].Cells["IdPlaylist"].Value;
                int file = ( int )dataGridView1.SelectedRows[i].Cells["IdFile"].Value;
                int order = ( int )dataGridView1.SelectedRows[i].Cells["NrOrdem"].Value;

                Form_PlaylistFiles_Insert edit = new Form_PlaylistFiles_Insert( this, id, playlist, file, order );
                edit.MdiParent = this.MdiParent;
                edit.Show();
            }
        }

        private void BtnNew_Click( object sender, EventArgs e )
        {
            Form_PlaylistFiles_Insert ins = new Form_PlaylistFiles_Insert( this, 0, 0, 0, 0 );
            ins.MdiParent = this.MdiParent;
            ins.Show();
        }

        private void Form_PlaylistFiles_View_Load( object sender, EventArgs e )
        {
            BtnRefresh.PerformClick();
            BtnAjustarCol.PerformClick();
        }

        private void Form_PlaylistFiles_View_FormClosing( object sender, FormClosingEventArgs e )
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
