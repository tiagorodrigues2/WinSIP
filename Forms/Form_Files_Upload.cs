using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSIP.Forms
{
    public partial class Form_Files_Upload : Form
    {
        public Form_Files_Upload()
        {
            InitializeComponent();
        }

        private void Form_Files_Upload_Load( object sender, EventArgs e )
        {
            status.Text = "Aguardando ficheiro...";
            BtnBrowse.PerformClick();
        }

        private void BtnBrowse_Click( object sender, EventArgs e )
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Ficheiros de Multimédia|*.png;*.jpeg;*.jpg;*.gif;*.mp4";

            if ( openFile.ShowDialog() == DialogResult.OK )
            {

                if ( Path.GetExtension( openFile.FileName ) == ".mp4" )
                {

                }
                else
                {
                    Image img = Image.FromFile( openFile.FileName );

                    float newWidth = img.Width;
                    float newHeight = img.Height;

                    if ( newWidth > pictureBox1.Width )
                    {
                        float multiplier = pictureBox1.Width / newWidth;

                        newWidth *= multiplier;
                        newHeight *= multiplier;
                    }

                    if ( newHeight > pictureBox1.Height )
                    {
                        float multiplier = pictureBox1.Height / newHeight;

                        newHeight *= multiplier;
                        newWidth *= multiplier;
                    }

                    img = new Bitmap( img, new Size( (int)Math.Floor(newWidth), (int)Math.Floor(newHeight) ) );

                    pictureBox1.BackgroundImage = img;
                }

                status.Text = "Selecionado " + openFile.FileName + ".";
            }
        }
    }
}
