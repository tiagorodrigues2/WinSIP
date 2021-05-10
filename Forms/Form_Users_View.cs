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
    public partial class Form_Users_View : Form
    {
        Users Users;

        public Form_Users_View()
        {
            InitializeComponent();
        }

        private void Form_Users_View_Load( object sender, EventArgs e )
        {
            try
            {
                Users = new Users();
                BtnAtualizar.PerformClick();
                BtnAjustarLargura.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void BtnAtualizar_Click( object sender, EventArgs e )
        {
            try
            {
                dataGridView1.DataSource = Users.LerUsers().Tables[0];
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

                DialogResult res = MessageBox.Show( "Tem a certeza que deseja eliminar " + dataGridView1.SelectedCells.Count + " utilizadores?", "Aviso",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation );

                if ( res != DialogResult.Yes )
                    return;

                List<int> AffectedRows = new List<int>();
                for ( int i = 0; i < dataGridView1.SelectedCells.Count; i++ )
                {
                    int rowIndex = dataGridView1.SelectedCells[i].RowIndex;

                    if ( AffectedRows.IndexOf( rowIndex ) != -1 ) continue;

                    AffectedRows.Add( rowIndex );

                    int UserID = ( int )dataGridView1.Rows[rowIndex].Cells["UserID"].Value;

                    if ( Users.DeleteUser( UserID ) == false )
                    {
                        MessageBox.Show( "Ocurreu um erro ao eliminar o Utilizador: " + UserID, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    }

                }
                AffectedRows.Clear();

                BtnAtualizar.PerformClick();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void BtnNewUser_Click( object sender, EventArgs e )
        {
            Form_Users_Insert NewUser = new Form_Users_Insert();

            NewUser.ShowDialog();

            this.Form_Users_View_Load( sender, e );
        }

        private void BtnEdit_Click( object sender, EventArgs e )
        {
            try
            {
                if ( dataGridView1.SelectedCells.Count == 0 )
                    return;

                List<int> AffectedRows = new List<int>();
                for ( int i = 0; i < dataGridView1.SelectedCells.Count; i++ )
                {
                    int rowIndex = dataGridView1.SelectedCells[i].RowIndex;

                    if ( AffectedRows.IndexOf( rowIndex ) != -1 ) continue;

                    AffectedRows.Add( rowIndex );

                    int UserID = ( int )dataGridView1.Rows[rowIndex].Cells["UserID"].Value;

                    Form_Users_Insert EditUser = new Form_Users_Insert( true, UserID );

                    EditUser.ShowDialog();

                    Form_Users_View_Load( sender, e );
                }
                AffectedRows.Clear();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
        }
    }
}
