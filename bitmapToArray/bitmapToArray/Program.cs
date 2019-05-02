using System;
using System.Windows.Forms;

namespace bitmapToArray
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //ConverterBitmap c = new ConverterBitmap();
            //c.updateBoard();
            

            //BitmapAnimations b = new BitmapAnimations();
            //for(int count = 0; true; count++)
            //    b.updateBoard();
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
