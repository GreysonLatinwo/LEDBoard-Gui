using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace bitmapToArray
{
    internal class UpdateBoard
    {
        string strMatrix = "";
        Socket sender;
        string[,] matrix = new string[20, 20];

        

        public void bitmapColorAssocator(Bitmap image1)
        {
            for (int x = 0; x < image1.Width; x++)
            {
                for (int y = 0; y < image1.Height; y++)
                {
                    Color pixel = image1.GetPixel(x, y);
                    if (pixel.Name == "ff000000" || pixel.R <= MyGlobalVars.blackThreashold && pixel.G <= MyGlobalVars.blackThreashold && pixel.B <= MyGlobalVars.blackThreashold)
                    {
                        matrix[x, y] = "-1 ";
                    }
                    else if (pixel.Name == "ffffffff")
                    {
                        matrix[x, y] = "-2 ";
                    }//check if the RGB values in the threashold
                    else if (pixel.R >= pixel.G - MyGlobalVars.whiteThreashold && pixel.R <= pixel.G + MyGlobalVars.whiteThreashold
                        && pixel.G >= pixel.B - MyGlobalVars.whiteThreashold && pixel.G <= pixel.B + MyGlobalVars.whiteThreashold
                        && pixel.B >= pixel.R - MyGlobalVars.whiteThreashold && pixel.B <= pixel.R + MyGlobalVars.whiteThreashold)
                    {
                        matrix[x, y] = "-3 ";
                    }
                    else
                    {
                        matrix[x, y] = (int)(pixel.GetHue() / 1.41176470588) + " ";
                    }
                }
            }
        }
        public void makeStrMatrix(Bitmap image1)
        {
            bitmapColorAssocator(image1);
            for (int x = 0; x < image1.Width; x++)
            {
                for (int y = 0; y < image1.Height; y++)
                {
                    Console.Write(matrix[y, x]);
                }
                Console.Write("\n");
            }
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    strMatrix += matrix[y, x];
                }
            }
        }
        public void sendData(Bitmap bmp)
        {
            makeStrMatrix(bmp);
            byte[] bytes = new byte[2048];
            

            // Connect to a remote device.  
            try
            {
                // Establish the remote endpoint for the socket.  
                // This example uses port 11000 on the local computer.  

                IPAddress ipAddress = IPAddress.Parse(MyGlobalVars.IP);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, MyGlobalVars.PORT);

                // Create a TCP/IP  socket.  
                Socket sender = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.  
                try
                {
                    sender.Connect(remoteEP);

                    //Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());

                    // Encode the data string into a byte array.  
                    byte[] msg = Encoding.ASCII.GetBytes(strMatrix);

                    // Send the data through the socket.  
                    int bytesSent = sender.Send(msg);
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                    return;
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                    return;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return;
            }
            strMatrix = "";
        }
    }
}
