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
    public delegate void Form_Files_ViewEventHandler( int IdFile, string Descritivo );

    public partial class Form_Files_View : Form
    {
        public event Form_Files_ViewEventHandler SelectFile;

        public Form_Files_View()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click( object sender, EventArgs e )
        {
            dataGridView1.AjustarColunas();
        }

        private void Form_Files_View_Load( object sender, EventArgs e )
        {
            BtnRefresh.PerformClick();
            toolStripButton2_Click( sender, e );
        }

        private void BtnRefresh_Click( object sender, EventArgs e )
        {
            try
            {
                Files dados = new Files();
                status.Text = "Atualizando dados...";
                dataGridView1.DataSource = dados.LerFiles().Tables[0];
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
                Files dados = new Files();
                status.Text = "Eliminando " + dataGridView1.SelectedRows.Count + " registos...";
                int iDeleted = 0;

                List<int> AffectedRows = new List<int>();
                for ( int i = 0; i < dataGridView1.SelectedCells.Count; i++ )
                {
                    int index = dataGridView1.SelectedCells[i].RowIndex;

                    if ( AffectedRows.IndexOf( index ) != -1 ) continue;
                    AffectedRows.Add( index );

                    DataGridViewRow row = dataGridView1.Rows[index];

                    dados.IdFile = ( int )row.Cells["IdFile"].Value;
                    dados.Descritivo = row.Cells["Descritivo"].Value.ToString();

                    DialogResult result = MessageBox.Show( string.Format( "Tem a certeza que deseja apagar o registo?\r\n{0}-{1}", dados.IdFile, dados.Descritivo ), "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );

                    if ( result == DialogResult.Yes )
                        iDeleted += dados.DeleteFile( dados.IdFile );

                    if ( result == DialogResult.Cancel )
                        break;
                }
                AffectedRows.Clear();

                BtnRefresh_Click( sender, e );
                status.Text = "Eliminado " + iDeleted + " registos com sucesso.";
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation );
            }
        }

        private void toolStripButton1_Click( object sender, EventArgs e ) /* Inserir */
        {
            try
            {
                Form_Files_Insert ins = new Form_Files_Insert( this, 0, "", "", 0 );
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
                    int id = ( int )dataGridView1.SelectedRows[i].Cells["IdFile"].Value;
                    string desc = dataGridView1.SelectedRows[i].Cells["Descritivo"].Value.ToString();
                    string path = dataGridView1.SelectedRows[i].Cells["Path"].Value.ToString();
                    int time = ( int )dataGridView1.SelectedRows[i].Cells["Tempo"].Value;

                    Form_Files_Insert edit = new Form_Files_Insert( this, id, desc, path, time );
                    edit.MdiParent = this.MdiParent;
                    edit.Show();
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

                        int id = ( int )row.Cells["IdFile"].Value;
                        string desc = row.Cells["Descritivo"].Value.ToString();
                        string path = row.Cells["Path"].Value.ToString();
                        int time = ( int )row.Cells["Tempo"].Value;

                        Form_Files_Insert edit = new Form_Files_Insert( this, id, desc, path, time );
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

        private void toolStripButton3_Click( object sender, EventArgs e )
        {
            try
            {
                Form_Files_Upload up = new Form_Files_Upload();
                up.MdiParent = this.MdiParent;
                up.Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void Form_Files_View_FormClosing( object sender, FormClosingEventArgs e )
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

                    int id = ( int )row.Cells["IdFile"].Value;
                    string desc = row.Cells["Descritivo"].Value.ToString();

                    if ( SelectFile != null )
                    {
                        SelectFile( id, desc );
                        this.Close();
                    }
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

    }
}
