using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvlc
{
    class VlcController
    {
        AXVLC.VLCPlugin2 axvlc = new AXVLC.VLCPlugin2();
        Uri fileUri = null;

        public void setFile(String myFile)
        {
            //fileUri = new Uri();
            //axvlc.playlist.add();
        }

        public void playFile()
        {

        }

        public void stopFile()
        {

        }
    }
}
