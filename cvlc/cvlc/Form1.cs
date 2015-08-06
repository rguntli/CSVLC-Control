using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cvlc
{
    public partial class Form1 : Form
    {
        AXVLC.VLCPlugin2 alxplugin1;
        public Form1()
        {
            alxplugin1 = new AXVLC.VLCPlugin2();
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            /*
            AXVLC.VLCPlugin2 alxplugin1 = new AXVLC.VLCPlugin2();
            alxplugin1.AutoPlay = true;
            alxplugin1.playlist.add(@"file:///C:\Users\Public\Videos\Sample Videos\Natur.wmv", null, null);
            alxplugin1.playlist.play();
            alxplugin1.video.fullscreen = true;
            */
            /*
            
            */
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var uri = new Uri(openFileDialog1.FileName);
                var convertedURI = uri.AbsoluteUri;
                alxplugin1.playlist.add(convertedURI);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alxplugin1.playlist.stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            alxplugin1.playlist.play();
        }
    }
}
