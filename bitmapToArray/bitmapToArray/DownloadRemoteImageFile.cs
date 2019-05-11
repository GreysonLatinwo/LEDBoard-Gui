using System;
using System.IO;
using System.Net;

namespace bitmapToArray
{
    internal class DownloadRemoteImageFile
    {
        public DownloadRemoteImageFile(string uri, string fileName)
        {
            HttpWebResponse response = null;
            HttpWebRequest request = null;
            if (uri == "")
                return;
            try
            {
                request = (HttpWebRequest)WebRequest.Create(uri);
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }

            // Check that the remote file was found. The ContentType
            // check is performed since a request for a non-existent
            // image file might be redirected to a 404-page, which would
            // yield the StatusCode "OK", even though the image was not
            // found.
            if ((response.StatusCode == HttpStatusCode.OK ||
                response.StatusCode == HttpStatusCode.Moved ||
                response.StatusCode == HttpStatusCode.Redirect) &&
                response.ContentType.StartsWith("image", StringComparison.OrdinalIgnoreCase))
            {
                //if (File.Exists(fileName))
                //{
                //    File.Delete(fileName);
                //}
                // if the remote file was found, download it
                try
                {
                    using (Stream inputStream = response.GetResponseStream())
                    using (Stream outputStream = File.Create(fileName))
                    {
                        byte[] buffer = new byte[4096];
                        int bytesRead;
                        do
                        {
                            bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                            outputStream.Write(buffer, 0, bytesRead);
                        } while (bytesRead != 0);
                        inputStream.Close();
                        outputStream.Close();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                }
            }
        }
    }
}