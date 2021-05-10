using CefSharp;
using CefSharp.WinForms;
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

namespace WinSIP
{
    public partial class Form_Template1 : Form
    {
        public ChromiumWebBrowser browser;
        public int Id_display = 23;

        public Form_Template1()
        {
            InitializeComponent();

            InitBrowser();
        }

        public void InitBrowser()
        {
            Cef.Initialize( new CefSettings() );

            browser = new ChromiumWebBrowser();

            this.splitContainer2.Panel1.Controls.Add( browser );

            
            browser.ImeMode = ImeMode.NoControl;
            browser.Dock = DockStyle.Fill;
        }


        private void FormTemplate1_Load( object sender, EventArgs e )
        {
            MostraProximoFicheiro();
        }

        private void MostraProximoFicheiro()
        {
            try
            {
                PlaylistFiles plf = new PlaylistFiles();

                DataSet dsFile = plf.CalculaProximoFicheiro( Id_display );
                timer1.Stop();

                if ( dsFile.Tables[0].Rows.Count > 0 )
                {
                    DataRow dr = dsFile.Tables[0].Rows[0];

                    browser.Load( dr["Path"].ToString() );
                    int tempo = ( int )dr["Tempo"];
                    timer1.Interval = tempo * 1000;
                    timer1.Start();

                    plf.MarcaComoMostrado( ( int )dr["IdPlayListFiles"] );
                }
                else
                {
                    //
                    plf.ResetMostrouPlaylist( Id_display );
                    plf.ResetMostrouGrupoPlaylist( Id_display );

                    dsFile = plf.CalculaProximoFicheiro( Id_display );

                    if ( dsFile.Tables[0].Rows.Count > 0 )
                        MostraProximoFicheiro();
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show( this, ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void timer1_Tick( object sender, EventArgs e )
        {
            //next file
            MostraProximoFicheiro();
        }

        private void webBrowser1_DocumentCompleted_1( object sender, WebBrowserDocumentCompletedEventArgs e )
        {

        }
    }
}
