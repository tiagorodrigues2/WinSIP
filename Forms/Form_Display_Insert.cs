using MySql.Data.MySqlClient;
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
    public partial class Form_Display_Insert : Form
    {
        Form_Display_View TableForm;

        int m_IdDisplay;
        string m_Descritivo;
        int m_IdGrupo;

        /// <summary>
        /// </summary>
        /// <param name="_this">Valor do Form Viewer</param>
        /// <param name="id">ID do registo a editar. 0 se for inserir</param>
        /// <param name="desc"></param>
        public Form_Display_Insert( Form_Display_View _this, int id, string desc, int grupo )
        {
            InitializeComponent();
            TableForm = _this;

            m_IdDisplay = id;
            m_Descritivo = desc;
            m_IdGrupo = grupo;
        }

        private void Form_InserirDisplay_Load( object sender, EventArgs e )
        {

            try
            {
                BtnDuplicar.Visible = false;

                TableForm.status.Text = "Aguardando novo registo...";
                this.Text = "Display: Novo Registo";
                BtnSave.Text = "Inserir";

                PreencheGrupos();

                if ( this.m_IdDisplay > 0 )
                {
                    BtnDuplicar.Visible = true;

                    this.Text = "Display: Editar Registo";
                    TableForm.status.Text = "Aguardando edição...";
                    BtnSave.Text = "Atualizar";

                    DescritivoBox.Text = m_Descritivo;
                    GrupoBox.SelectedValue = m_IdGrupo;
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void PreencheGrupos()
        {
            GrupoBox.Items.Clear();

            DataTable Grupos = new Grupos().LerGrupos().Tables[0];

            Grupos.Columns.Add( "CustomDescritivo" );

            DataRow new_row = Grupos.NewRow();
            new_row["IdGrupo"] = 0;
            new_row["Descritivo"] = "Vazio";

            Grupos.Rows.InsertAt( new_row, 0 );

            for ( int i = 0; i < Grupos.Rows.Count; i++ )
            {
                int id = int.Parse( Grupos.Rows[i]["IdGrupo"].ToString() );
                string desc = Grupos.Rows[i]["Descritivo"].ToString();

                Grupos.Rows[i]["CustomDescritivo"] = id + " <" + desc + ">";
            }

            GrupoBox.DataSource = Grupos;
            GrupoBox.ValueMember = "IdGrupo";
            GrupoBox.DisplayMember = "CustomDescritivo";
        }

        private void BtnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void BtnSave_Click( object sender, EventArgs e )
        {
            Save();
        }


        private void Save()
        {
            try
            {
                DataTable Grupos = new Grupos().LerGrupos().Tables[0];
                Display table = new Display();

                if ( DescritivoBox.Text.Trim() == "" )
                {
                    MessageBox.Show( "Preencha o campo Descritivo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                    return;
                }

                if ( GrupoBox.SelectedValue == null )
                {
                    MessageBox.Show( "Preencha o campo Grupo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                    return;
                }

                table.Descritivo = DescritivoBox.Text;
                table.IdGrupo = int.Parse( GrupoBox.SelectedValue.ToString() );

                if ( this.m_IdDisplay == 0 )
                {
                    int iInserted = table.InsertDisplay( table );

                    TableForm.BtnRefresh.PerformClick();
                    TableForm.status.Text = "Inserido registo com IdDisplay: " + iInserted;
                }
                else
                {
                    table.IdDisplay = m_IdDisplay;

                    int iChanged = table.UpdateDisplay( table );

                    TableForm.BtnRefresh.PerformClick();
                    TableForm.status.Text = "Editado " + iChanged + "registos com sucesso.";
                }

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
                m_IdDisplay = 0;
                TableForm.status.Text = "Aguardando novo registo...";
                this.Text = "Display: Novo Registo";
                BtnSave.Text = "Inserir";
                BtnDuplicar.Visible = false;
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void btnSelect_Click( object sender, EventArgs e )
        {
            try
            {
                Form_Grupos_View formChoose = new Form_Grupos_View();
                formChoose.SelectGrupo += this.Frm_SelectGrupo;
                formChoose.ShowDialog();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void Frm_SelectGrupo( int IdGrupo, string descritivo )
        {
            try
            {
                PreencheGrupos();
                GrupoBox.SelectedIndex = GrupoBox.Items.IndexOf( IdGrupo );

            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }
    }
}
