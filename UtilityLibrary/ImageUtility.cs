using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Drawing;
using System.Web.UI.HtmlControls;
using System.Web;

namespace UtilityLibrary
{
    public class ImageUtility : IDisposable
    {
        public  byte[] imageToByteArray(string path)
        {
            //MemoryStream ms = new MemoryStream();
            //imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            //return ms.ToArray();

            FileInfo fileInfo = new FileInfo(path);

            // The byte[] to save the data in
            byte[] data = new byte[fileInfo.Length];

            // Load a filestream and put its content into the byte[]
            using (FileStream fs = fileInfo.OpenRead())
            {
                fs.Read(data, 0, data.Length);
            }

            // Delete the temporary file
            fileInfo.Delete();

            // Post byte[] to database
            return data;
        }

        public  Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public string byteArrayToBase64String(byte[] byteArrayIn)
        {
            if (byteArrayIn.Length > 0)
            {
                string base64String = Convert.ToBase64String(byteArrayIn, 0, byteArrayIn.Length);
                return "data:image/png;base64," + base64String;
            }
            else return string.Empty;
        }

        public  string getImageUsingHandler(string path)
        {
            if (path.Length > 0)
            {
                string str = "ImageHandler.ashx?image=" + path + "&param=" + DateTime.Now.Ticks.ToString();
                return str;
            }
            return "ImageHandler.ashx?image=img/blog/blog-thumb-1.jpg" + path + "&param=" + DateTime.Now.Ticks.ToString();
        }

        public  string getBase64String(string path)
        {
            string base64String = string.Empty;
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (Image original = Image.FromStream(fs))
                    {


                        byte[] imageBytes = imageToByteArray(original);
                        base64String = Convert.ToBase64String(imageBytes, 0, imageBytes.Length);
                        original.Dispose();
                        fs.Dispose();
                        fs.Close();
                      
                    }

                }
               // File.Delete(path);
            }
            
            return "data:image/png;base64," + base64String;
        }

        public  byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public  string getBase64StringFromInputFile(string path,HtmlInputFile file)
        { 
            
            using (file)
            {   
                Image img = Image.FromFile(path + file.PostedFile.FileName);
                byte[] imageBytes = imageToByteArray(img);
                string base64String = Convert.ToBase64String(imageBytes, 0, imageBytes.Length);
                return "data:image/png;base64," + base64String;
            }
        }


        public void Dispose()
        {
           
            GC.SuppressFinalize(this);
        }
    }
}
