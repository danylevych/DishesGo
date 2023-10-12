using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        public static Region CropAsElips(PictureBox photo)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, photo.Width, photo.Height);

            Region region = new Region(path);

            return region;
        }
    }
}
