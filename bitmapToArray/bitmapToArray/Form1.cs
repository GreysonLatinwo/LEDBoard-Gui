using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitmapToArray
{
    public partial class Form1 : Form
    {
        Image currentImage;
        string picURL = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void DownloadRemoteImageFile(string uri, string fileName)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            //BS
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //IP
            MyGlobalVars.IP = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //port
            int tmpPort;
            Int32.TryParse(PortBox.Text, out tmpPort);
            MyGlobalVars.PORT = tmpPort;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //turn the screen off
            int x = 20, y = 20;
            //create a temp bitmap that has tha value of "-1" off
            Bitmap bmp = new Bitmap(x, y);
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle ImageSize = new Rectangle(0, 0, x, y);
                graph.FillRectangle(Brushes.Black, ImageSize);
            }

            UpdateBoard dataSender = new UpdateBoard();
            
            dataSender.sendData(bmp);
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            //change the current bmp selected
            openFileDialog1.Filter = "Image files |*.bmp;*.gif;*.jpg;*.jpeg;*.jpe;*.jfif;*.tif;*.tiff;|PNG (not-recommended) (*.png)|*.png|All Files (*.*)|*.*";
            openFileDialog1.InitialDirectory = @"C:\Users\"+ Environment.UserName+"\\Pictures";
            openFileDialog1.Title = "Please select an image file to use";
            openFileDialog1.FileName = "";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

            

            string file = openFileDialog1.FileName;
            Console.WriteLine(file);

            if (file == "")
                return;
            Image choosenImage = new Bitmap(@file);

            if (result == DialogResult.OK) // Test result.
            {
                if (choosenImage.Height != 20 || choosenImage.Width != 20)
                {
                    Bitmap Newbmp;
                    picCompress Comp = new picCompress();

                    Newbmp = Comp.compress(choosenImage);

                    currentImage = Newbmp;
                    bitmapDisplay.Image = currentImage;
                }
                else
                {
                    currentImage = choosenImage;
                    bitmapDisplay.Image = currentImage;
                }
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //send the current BMP
            if(currentImage == null){
                label3.Visible = true;
                return;
            } else {
                label3.Visible = false;
            }

            UpdateBoard dataSender = new UpdateBoard();
            Bitmap bmp = new Bitmap(currentImage);
            dataSender.sendData(bmp);
        }

        private void whiteThreasholdLabel_Click(object sender, EventArgs e)
        {

        }

        private void WhiteThreashold_Scroll(object sender, EventArgs e)
        {
            MyGlobalVars.whiteThreashold = WhiteThreashold.Value;
            whiteThreasholdLabel.Text = "White Threashold: " + MyGlobalVars.whiteThreashold;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            MyGlobalVars.blackThreashold = BlackThreashold.Value;
            blackThreasholdLabel.Text = "Black Threashold: " + MyGlobalVars.blackThreashold;
        }

        private void label4_Click(object sender, EventArgs e){}

        private void URL_TextChanged(object sender, EventArgs e)
        {
            picURL = URL.Text;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Bitmap Newbmp;

            string filename = "tempURLpic.bmp";
            DownloadRemoteImageFile d = new DownloadRemoteImageFile(picURL, filename);
           
            Image URLpic = new Bitmap(filename);
            picCompress Comp = new picCompress();
            Newbmp = Comp.compress(URLpic);

            currentImage = Newbmp;
            bitmapDisplay.Image = currentImage;
        }

        private void bitmapDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
