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
    public partial class Form_AccessCodes_View : Form
    {
        private AccessCodes Codes;

        public Form_AccessCodes_View()
        {
            InitializeComponent();
        }

        private void Form_AccessCodes_View_Load( object sender, EventArgs e )
        {
            try
            {
                Codes = new AccessCodes();
                BtnAtualizar.PerformClick();
                BtnAjustarLargura.PerformClick();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void BtnAtualizar_Click( object sender, EventArgs e )
        {
            try
            {
                dataGridView1.DataSource = Codes.LerAcessCodes().Tables[0];
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void BtnAjustarLargura_Click( object sender, EventArgs e )
        {
            dataGridView1.AjustarColunas();
        }

        private void BtnDelete_Click( object sender, EventArgs e )
        {
            try
            {
                if ( dataGridView1.SelectedCells.Count == 0 )
                    return;

                List<int> AffectedRows = new List<int>();
                for (int i = 0; i< dataGridView1.SelectedCells.Count; i++ )
                {
                    int index = dataGridView1.SelectedCells[i].RowIndex;

                    if ( AffectedRows.IndexOf( index ) != -1 ) continue;
                    AffectedRows.Add( index );

                    DataGridViewRow row = dataGridView1.Rows[index];

                    DialogResult res = MessageBox.Show( "Tem a certeza que pretende eliminar o código com ID: " + (int)row.Cells["CodeID"].Value, "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );
                    
                    if ( res == DialogResult.Yes)
                    {
                        Codes.DeleteCode( (int)row.Cells["CodeID"].Value );
                    }

                    if ( res == DialogResult.Cancel ) break;
                }
                AffectedRows.Clear();

                BtnAtualizar.PerformClick();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void BtnNewCode_Click( object sender, EventArgs e )
        {
            try
            {
                if ( Codes.CreateCode() )
                    BtnAtualizar.PerformClick();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }
    }
}
