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
    public delegate void Form_Grupos_ViewEventHandler(int IdGrupo, string descritivo);

    public partial class Form_Grupos_View : Form
    {
        public event Form_Grupos_ViewEventHandler SelectGrupo;

        public Form_Grupos_View()
        {
            InitializeComponent();
        }

        private void toolStripButton5_Click( object sender, EventArgs e )
        {
            dataGridView1.AjustarColunas();
        }

        private void BtnRefresh_Click( object sender, EventArgs e )
        {
            status.Text = "Atualizando lista...";
            dataGridView1.DataSource = new Grupos().LerGrupos().Tables[0];
            status.Text = "Atualizado com sucesso.";
        }

        private void BtnDelete_Click( object sender, EventArgs e )
        {
            try
            {
                Grupos dados = new Grupos();
                status.Text = "Eliminando " + dataGridView1.SelectedRows.Count + " registos...";
                int iDeleted = 0;

                List<int> AffectedRows = new List<int>();
                for ( int i = 0; i < dataGridView1.SelectedCells.Count; i++ )
                {
                    int index = dataGridView1.SelectedCells[i].RowIndex;

                    if ( AffectedRows.IndexOf( index ) != -1 ) continue;
                    AffectedRows.Add( index );

                    DataGridViewRow row = dataGridView1.Rows[index];

                    dados.IdGrupo = ( int )row.Cells["IdGrupo"].Value;
                    dados.Descritivo = row.Cells["Descritivo"].Value.ToString();

                    DialogResult result = MessageBox.Show( string.Format( "Tem a certeza que deseja apagar o registo?\r\n{0}-{1}", dados.IdGrupo, dados.Descritivo ), "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );

                    if ( result == DialogResult.Yes )
                        iDeleted += dados.DeleteGrupo( dados.IdGrupo );

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

        private void BtnNovo_Click( object sender, EventArgs e )
        {
            try
            {
                Form_Grupos_Insert ins = new Form_Grupos_Insert( this, 0, "" );
                ins.MdiParent = this.MdiParent;
                ins.Show();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }        
        }

        private void BtnEdit_Click( object sender, EventArgs e )
        {
            Grupos dados = new Grupos();
            
            for ( int i = 0; i < dataGridView1.SelectedRows.Count; i++ )
            {
                dados.IdGrupo = ( int )dataGridView1.SelectedRows[i].Cells["IdGrupo"].Value;
                dados.Descritivo = dataGridView1.SelectedRows[i].Cells["Descritivo"].Value.ToString();

                Form_Grupos_Insert edit = new Form_Grupos_Insert( this, dados.IdGrupo, dados.Descritivo );
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

                    dados.IdGrupo = ( int )row.Cells["IdGrupo"].Value;
                    dados.Descritivo = row.Cells["Descritivo"].Value.ToString();

                    Form_Grupos_Insert edit = new Form_Grupos_Insert( this, dados.IdGrupo, dados.Descritivo );
                    edit.MdiParent = this.MdiParent;
                    edit.Show();

                }
                AffectedRows.Clear();
            }
        }

        private void Form_Grupos_View_Load( object sender, EventArgs e )
        {
            BtnRefresh.PerformClick();
            toolStripButton5_Click( sender, e );
        }

        private void Form_Grupos_View_FormClosing( object sender, FormClosingEventArgs e )
        {
            this.Hide();
            e.Cancel = true;
        }

        private void dataGridView1_MouseDoubleClick( object sender, MouseEventArgs e )
        {
            if ( dataGridView1.SelectedCells.Count > 0 )
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;


                DataGridViewRow row = dataGridView1.Rows[index];

                Grupos dados = new Grupos();

                dados.IdGrupo = ( int )row.Cells["IdGrupo"].Value;
                dados.Descritivo = row.Cells["Descritivo"].Value.ToString();


                if ( SelectGrupo != null )
                {
                    SelectGrupo( dados.IdGrupo, dados.Descritivo );
                    this.Close();
                }
            }
        }

        private void Form_Grupos_View_ResizeEnd( object sender, EventArgs e )
        {
            dataGridView1.AjustarColunas();
        }

       
    }
}
