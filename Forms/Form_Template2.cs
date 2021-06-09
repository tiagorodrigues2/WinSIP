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
using AxWMPLib;
using System.IO;
using CefSharp.WinForms;
using CefSharp;

namespace WinSIP
{
    public partial class Form_Template2 : Form
    {

        ChromiumWebBrowser picBox;
        AxWindowsMediaPlayer player;

        int iDisplay = 0;

        public Form_Template2( int IdDisplay )
        {
            try
            {
                iDisplay = IdDisplay;

                InitializeComponent();

                if ( Cef.IsInitialized == false )
                    Cef.Initialize( new CefSettings() );

                picBox = new ChromiumWebBrowser();

                picBox.ImeMode = ImeMode.NoControl;
                picBox.Dock = DockStyle.Fill;

                player = new AxWindowsMediaPlayer();
                player.Dock = DockStyle.Fill;

                picBox.Visible = false;
                player.Visible = false;

                this.Controls.Add( picBox );
                this.Controls.Add( player );

            }
            catch ( Exception ex )
            {
                MessageBox.Show( this, ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void FormTemplate2_Load( object sender, EventArgs e )
        {
            ProximoFicheiro();
        }

        private void ProximoFicheiro()
        {
            try
            {
                PlaylistFiles plf = new PlaylistFiles();

                DataSet dsFile = plf.CalculaProximoFicheiro( iDisplay );

                //string footer = plf.GetCurrentFooterPath( iDisplay );

                timer1.Stop();

                if ( dsFile.Tables[0].Rows.Count > 0 )
                {
                    DataRow dr = dsFile.Tables[0].Rows[0];

                    string path = dr["Path"].ToString();

                    if ( path.Contains( ".mp4" ) )
                    {
                        picBox.Visible = false;
                        player.Visible = true;
                        player.Dock = DockStyle.Fill;
                        player.Size = this.ClientSize;
                        player.uiMode = "none";
                        player.URL = path;
                        
                    }
                    else
                    {
                        picBox.Visible = true;
                        player.Visible = false;

                        picBox.Load( path );
                    }

            /*      if ( footer.Length > 0 )
                    {
                        footerBox.Visible = true;
                        footerBox.Load( footer );
                    }
                    else
                    {
                        footerBox.Visible = false;
                    } */

                    int tempo = ( int )dr["Tempo"];
                    timer1.Interval = tempo * 1000;
                    timer1.Start();

                    plf.MarcaComoMostrado( ( int )dr["IdPlayListFiles"] );
                }
                else
                {
                    
                    plf.ResetMostrouPlaylist( iDisplay );
                    plf.ResetMostrouGrupoPlaylist( iDisplay );

                    dsFile = plf.CalculaProximoFicheiro( iDisplay );

                    if ( dsFile.Tables[0].Rows.Count > 0 )
                        ProximoFicheiro();
                }

            }
            catch ( Exception ex )
            {
                MessageBox.Show( this, ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void timer1_Tick( object sender, EventArgs e )
        {
            ProximoFicheiro();
        }

        public static Image resizeImage( Image imgToResize, Size size )
        {
            return ( Image )( new Bitmap( imgToResize, size ) );
        }
    }
}
