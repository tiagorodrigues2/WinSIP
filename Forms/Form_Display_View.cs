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
    public delegate void Form_Display_EventHandler( int IdDisplay );

    public partial class Form_Display_View : Form
    {
        public event Form_Display_EventHandler SelectDisplay;

        public Form_Display_View()
        {
            InitializeComponent();
        }

        private void DisplayTableView_Load( object sender, EventArgs e )
        {
            BtnRefresh.PerformClick();
            toolStripButton2_Click( sender, e );
        }

        private void BtnRefresh_Click( object sender, EventArgs e )
        {
            try
            {
                Display display = new Display();

                dataGridView1.DataSource = display.LerDisplay().Tables[0];

                status.Text = "Atualizado com sucesso.";
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation );
            }
        }

        private void toolStripButton1_Click( object sender, EventArgs e )
        {
            try
            {
                Form_Display_Insert ins = new Form_Display_Insert( this, 0, "", 0 );

                ins.MdiParent = this.MdiParent;
                ins.Show();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation );
            }
        }

        private void toolStripButton2_Click( object sender, EventArgs e )
        {
            dataGridView1.AjustarColunas();
        }

        private void BtnDelete_Click( object sender, EventArgs e )
        {
            try
            {
                Display dados = new Display();
                status.Text = "Eliminando " + dataGridView1.SelectedRows.Count + " registos...";
                int iDeleted = 0;

                List<int> AffectedRows = new List<int>();
                for ( int i = 0; i < dataGridView1.SelectedCells.Count; i++ )
                {
                    int index = dataGridView1.SelectedCells[i].RowIndex;

                    if ( AffectedRows.IndexOf( index ) != -1 ) continue;
                    AffectedRows.Add( index );

                    DataGridViewRow row = dataGridView1.Rows[index];

                    dados.IdGrupo = ( int )row.Cells["IdDisplay"].Value;
                    dados.Descritivo = row.Cells["Descritivo"].Value.ToString();

                    DialogResult result = MessageBox.Show( string.Format( "Tem a certeza que deseja apagar o registo?\r\n{0}-{1}", dados.IdGrupo, dados.Descritivo ), "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );

                    if ( result == DialogResult.Yes )
                        iDeleted += dados.DeleteDisplay( dados.IdGrupo );

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

        private void BtnUpdate_Click( object sender, EventArgs e )
        {
            try
            {
                for ( int i = 0; i < dataGridView1.SelectedRows.Count; i++ )
                {
                    int id = ( int )dataGridView1.SelectedRows[i].Cells["IdDisplay"].Value;
                    string desc = dataGridView1.SelectedRows[i].Cells["Descritivo"].Value.ToString();
                    int grupo = ( int )dataGridView1.SelectedRows[i].Cells["IdGrupo"].Value;

                    Form_Display_Insert edit = new Form_Display_Insert( this, id, desc, grupo );
                    edit.MdiParent = this.MdiParent;
                    edit.Show();
                }

                if ( dataGridView1.SelectedRows.Count == 0 )
                {
                    List<int> AffectedRows = new List<int>();
                    for ( int i = 0; i < dataGridView1.SelectedCells.Count; i++ )
                    {
                        int index = dataGridView1.SelectedCells[i].RowIndex;

                        if ( AffectedRows.IndexOf( index ) != -1 ) continue; /* podem estar 2 celulas selecionadas na mesma row */

                        AffectedRows.Add( index );
                        DataGridViewRow row = dataGridView1.Rows[index];

                        int id = ( int )row.Cells["IdDisplay"].Value;
                        string desc = row.Cells["Descritivo"].Value.ToString();
                        int grupo = ( int )row.Cells["IdGrupo"].Value;

                        Form_Display_Insert edit = new Form_Display_Insert( this, id, desc, grupo );
                        edit.MdiParent = this.MdiParent;
                        edit.Show();
                    }
                    AffectedRows.Clear();
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation );

            }
        }

        private void Form_Display_View_FormClosing( object sender, FormClosingEventArgs e )
        {
            this.Hide();
            e.Cancel = true;
        }

        private void dataGridView1_CellMouseDoubleClick( object sender, DataGridViewCellMouseEventArgs e )
        {
            try
            {
                if ( dataGridView1.SelectedCells.Count > 0 )
                {
                    DataGridViewRow row = dataGridView1.SelectedCells[0].OwningRow;

                    int id = ( int )row.Cells["IdDisplay"].Value;

                    if ( SelectDisplay != null )
                    {
                        SelectDisplay( id );
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

