using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinSIP.Forms
{
    public delegate void Form_ChoseMonitor_EventHandler( string DeviceName );

    public partial class Form_ChoseMonitor : Form
    {

        FormMDI pMDI;
        public event Form_ChoseMonitor_EventHandler SelectMonitor;

        public Form_ChoseMonitor(FormMDI fMDI)
        {

            this.pMDI = fMDI;

            InitializeComponent();
        }

        private void Form_ChoseMonitor_Load( object sender, EventArgs e )
        {
            try
            {
                foreach ( Screen monitor in Screen.AllScreens )
                {

                    int iIndex = listBox1.Items.Add( monitor.DeviceName );

                    if ( pMDI.DisplayMonitor.DeviceName.Equals( monitor.DeviceName ) )
                        listBox1.SelectedIndex = iIndex;

                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show( this, ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void button1_Click( object sender, EventArgs e )
        {
            SelectMonitor( listBox1.Items[listBox1.SelectedIndex].ToString() );
        }
    }
}
