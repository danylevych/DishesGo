using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace DishesGo.src.tools
{
    static public class ImageRedactor
    {
        public static Image ResizeImage(Image image, int width, int height)
        {
            // Create a new Bitmap with the specified width and height
            Bitmap resizedImage = new Bitmap(width, height);

            // Create a Graphics object from the new Bitmap
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                // Set the interpolation mode and draw the original image onto the new Bitmap
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, width, height);
            }

            return resizedImage;
        }

        public static byte[] ToByteArray(Image image)
        {
            if (image == null) // If our image is not exist.
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray(); // Return the byte array.
            }
        }
    }
}
