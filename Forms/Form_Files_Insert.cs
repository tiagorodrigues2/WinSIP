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
using WMPLib;

namespace WinSIP.Forms
{
    public partial class Form_Files_Insert : Form
    {
        Form_Files_View Viewer;

        int IdFile;
        string Descritivo;
        string Path;
        int Tempo;

        public Form_Files_Insert( Form_Files_View _this, int id, string desc, string path, int time )
        {
            InitializeComponent();

            Viewer = _this;

            IdFile = id;
            Descritivo = desc;
            Path = path;
            Tempo = time;
        }

        private void Form_Files_Insert_Load( object sender, EventArgs e )
        {
            try
            {
                CalcBtn.Enabled = false;
                BtnDuplicar.Visible = false;
                Viewer.status.Text = "Aguardando novo registo...";
                this.Text = "Files: Inserir registo";
                BtnSave.Text = "Inserir";

                if ( IdFile != 0 )
                {
                    BtnDuplicar.Visible = true;

                    Viewer.status.Text = "Aguardando edição...";
                    this.Text = "Files: Editar registo";
                    BtnSave.Text = "Atualizar";

                    DescritivoBox.Text = Descritivo;
                    PathBox.Text = Path;
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void PathBox_TextChanged( object sender, EventArgs e )
        {
            CalcBtn.Enabled = PathBox.Text.Contains( ".mp4" );
        }

        private void CalcBtn_Click( object sender, EventArgs e )
        {
            try
            {
                WindowsMediaPlayer Player = new WindowsMediaPlayer();
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Ficheiros MP4|*mp4";

                if ( openFile.ShowDialog() == DialogResult.OK )
                {
                    try
                    {
                        IWMPMedia Clip = Player.newMedia( openFile.FileName );
                        TempoBox.Value = Math.Ceiling( ( decimal )Clip.duration );
                    }
                    catch ( Exception ex )
                    {
                        MessageBox.Show( ex.Message );
                    }
                }

                Player.close();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void BtnCancel_Click( object sender, EventArgs e )
        {
            Viewer.BtnRefresh.PerformClick();
            this.Close();
        }

        private void BtnSave_Click( object sender, EventArgs e )
        {
            try
            {
                Files dados = new Files();

                dados.Descritivo = DescritivoBox.Text;
                dados.Path = PathBox.Text;
                dados.Tempo = ( int )TempoBox.Value;

                if ( IdFile != 0 )
                {
                    dados.IdFile = IdFile;

                    int iChanged = dados.UpdateFile( dados );

                    Viewer.BtnRefresh.PerformClick();
                    Viewer.status.Text = "Atualizado " + iChanged + " registos com sucesso.";
                }
                else
                {
                    int iInserted = dados.InsertFile( dados );

                    Viewer.BtnRefresh.PerformClick();
                    Viewer.status.Text = "Inserido registo com ID: " + iInserted;
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
                BtnDuplicar.Visible = false;
                Viewer.status.Text = "Aguardando novo registo...";
                this.Text = "Files: Inserir registo";
                BtnSave.Text = "Inserir";
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void btnBrowse_Click( object sender, EventArgs e )
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Media Files|*.png;*.jpg;*.mp4;*.jpeg;*.bmp;*.gif";

                if ( openFile.ShowDialog() == DialogResult.OK )
                {
                    PathBox.Text = openFile.FileName;
                }
                
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }
    }
}
