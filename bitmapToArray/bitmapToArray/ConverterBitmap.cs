using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace bitmapToArray
{
    internal class ConverterBitmap
    {
        string [,] matrix = new string[20,20];
        string strMatrix = "";
        int whiteThreashold = 12;
        int blackThreashold = 48;
        public void updateBoard()
        {
            Bitmap image1 = new Bitmap(@"C:\Users\xxins\Pictures\bitmapAnimation\kingBoo.bmp", true);
            for(int x = 0; x < image1.Width; x++)
            {
                for (int y = 0; y < image1.Height; y++)
                {
                    Color pixel = image1.GetPixel(x, y);
                    if (pixel.Name == "ff000000" || pixel.R <= blackThreashold && pixel.G <= blackThreashold && pixel.B <= blackThreashold) {
                        matrix[x, y] = "-1 ";
                    }
                    else if (pixel.Name == "ffffffff")
                    {
                        matrix[x, y] = "-2 ";
                    }
                    else if ( pixel.R >= pixel.G - whiteThreashold && pixel.R <= pixel.G + whiteThreashold
                        && pixel.G >= pixel.B - whiteThreashold && pixel.G <= pixel.B + whiteThreashold
                        && pixel.B >= pixel.R - whiteThreashold && pixel.B <= pixel.R + whiteThreashold)
                    {
                        matrix[x, y] = "-5 ";
                    }
                    else
                    {
                        matrix[x, y] = (int)(pixel.GetHue()/1.41176470588) + " ";
                    }
                }
            }
            for (int x = 0; x < image1.Width; x++)
            {
                for (int y = 0; y < image1.Height; y++)
                {
                    Console.Write(matrix[y, x]);
                } 
                Console.Write("\n");
            }
            sendData();
        }

        public void makeStrMatrix()
        {
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    strMatrix += matrix[y, x];
                }
            }
        }
        public void sendData()
        {
            makeStrMatrix();
            byte[] bytes = new byte[2048];

            // Connect to a remote device.  
            try
            {
                // Establish the remote endpoint for the socket.  
                // This example uses port 11000 on the local computer.  
                IPAddress ipAddress = IPAddress.Parse("192.168.1.25");
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 6969);

                // Create a TCP/IP  socket.  
                Socket sender = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.  
                try
                {
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        sender.RemoteEndPoint.ToString());

                    // Encode the data string into a byte array.  
                    byte[] msg = Encoding.ASCII.GetBytes(strMatrix);

                    // Send the data through the socket.  
                    int bytesSent = sender.Send(msg);
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}