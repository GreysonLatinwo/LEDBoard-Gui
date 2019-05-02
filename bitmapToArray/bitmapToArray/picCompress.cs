using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace bitmapToArray
{
    internal class picCompress
    {

       public Bitmap compress(Image image1)
        {
            Image oBitmap2 = new Bitmap(image1);
            Bitmap fBitmap = new Bitmap(oBitmap2, 20, 20);
            return fBitmap;
        }
    }
}