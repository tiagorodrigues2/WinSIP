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
    public partial class Form_GruposPlaylist_View : Form
    {
        public Form_GruposPlaylist_View()
        {
            InitializeComponent();
        }

        private void BtnAjustarColunas_Click( object sender, EventArgs e )
        {
            for ( int i = 0; i < dataGridView1.Columns.Count; i++ )
            {
                dataGridView1.Columns[i].Width = ( dataGridView1.Width / dataGridView1.Columns.Count ) - ( dataGridView1.RowHeadersWidth / dataGridView1.Columns.Count ) - 1;
            }
        }

        private void BtnRefresh_Click( object sender, EventArgs e )
        {
            dataGridView1.DataSource = new GruposPlaylist().LerGruposPlaylist().Tables[0];
        }

        private void BtnDelete_Click( object sender, EventArgs e )
        {
            GruposPlaylist dados = new GruposPlaylist();
            int iDeleted = 0;

            for ( int i = 0; i < dataGridView1.SelectedRows.Count; i++ )
            {
                iDeleted += dados.DeleteGruposPlaylist( ( int )dataGridView1.SelectedRows[i].Cells["IdGrupoPlaylist"].Value );
            }

            BtnRefresh.PerformClick();
            status.Text = "Eliminado " + iDeleted + " registos com sucesso.";
        }

        private void BtnNew_Click( object sender, EventArgs e )
        {
            Form_GruposPlaylist_Insert ins = new Form_GruposPlaylist_Insert( this, 0, 0, 0 );
            ins.MdiParent = ins.MdiParent;
            ins.Show();
        }

        private void BtnUpdate_Click( object sender, EventArgs e )
        {
            for ( int i = 0; i < dataGridView1.SelectedRows.Count; i++ )
            {
                int id = ( int )dataGridView1.SelectedRows[i].Cells["IdGrupoPlaylist"].Value;
                int grupo = ( int )dataGridView1.SelectedRows[i].Cells["IdGrupo"].Value;
                int playlist = ( int )dataGridView1.SelectedRows[i].Cells["IdPlaylist"].Value;

                Form_GruposPlaylist_Insert edit = new Form_GruposPlaylist_Insert( this, id, grupo, playlist );
                edit.MdiParent = this.MdiParent;
                edit.Show();
            }
        }

        private void Form_GruposPlaylist_View_Load( object sender, EventArgs e )
        {
            this.BtnRefresh.PerformClick();
            this.BtnAjustarColunas.PerformClick();
        }

        private void Form_GruposPlaylist_View_FormClosing( object sender, FormClosingEventArgs e )
        {
            this.Hide();
            e.Cancel = true;
        }

        private void dataGridView1_CellClick( object sender, DataGridViewCellEventArgs e )
        {
            if ( e.ColumnIndex == 1 )
            {
                CheckBox chk = (CheckBox)dataGridView1[e.ColumnIndex, e.RowIndex].Value;
                chk.Checked = true;
            }
        }
    }
}
