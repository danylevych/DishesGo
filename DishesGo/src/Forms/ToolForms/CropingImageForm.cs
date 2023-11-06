using ComponentFactory.Krypton.Toolkit;
using DishesGo.src.Tools;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DishesGo.src.Forms.ToolForms
{
    public partial class CropingImageForm : KryptonForm
    {
        private Image OutImage { get; set; }

        public ImageCropingFormButton SelectedButton { get; private set; }

        private bool isDraggingImage;
        private Point lastMousePos;

        private float zoomFactor = 1.0f; // Image scale.
        private const float ZoomIncrement = 0.1f; 
        private Point imageOffset = Point.Empty; // Image offset.
        private float originalZoomFactor; // A start scale.


        public CropingImageForm(Image image)
        {
            InitializeComponent();

            SelectedButton = ImageCropingFormButton.CANCLE;

            isDraggingImage = false;

            // Finding the start scale.
            float maxWidthScale = (float)photo.ClientSize.Width / image.Width;
            float maxHeightScale = (float)photo.ClientSize.Height / image.Height;
            zoomFactor = Math.Max(maxWidthScale, maxHeightScale);
            
            originalZoomFactor = zoomFactor;

            photo.Image = image;
            photo.Paint += Photo_Paint;
            photo.MouseDown += Photo_MouseDown;
            photo.MouseMove += Photo_MouseMove;
            photo.MouseUp += Photo_MouseUp;
            photo.MouseWheel += Photo_MouseWheel;
            photo.MouseClick += Photo_MouseClick;
        }

        private void Photo_Paint(object sender, PaintEventArgs e)
        {
            // Culcuating of size image.
            float displayWidth = photo.Width;
            float displayHeight = photo.Height;
            float imageWidth = photo.Image.Width * zoomFactor;
            float imageHeight = photo.Image.Height * zoomFactor;

            // Lower and upper bounds for image.
            int minY = (int)Math.Min(0, displayHeight - imageHeight);
            int maxY = 0;
            int minX = (int)Math.Min(0, displayWidth - imageWidth);
            int maxX = 0;

            // Set the limits of draging image.
            imageOffset.X = Math.Max(minX, Math.Min(maxX, imageOffset.X));
            imageOffset.Y = Math.Max(minY, Math.Min(maxY, imageOffset.Y));

            float imageX = imageOffset.X;
            float imageY = imageOffset.Y;

            // Drawing the image.
            e.Graphics.DrawImage(photo.Image, imageX, imageY, imageWidth, imageHeight);
        }

        private void Photo_MouseDown(object sender, MouseEventArgs e)
        {
            isDraggingImage = true;
            lastMousePos = e.Location;
        }

        private void Photo_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggingImage)
            {
                int dx = e.X - lastMousePos.X;
                int dy = e.Y - lastMousePos.Y;
                imageOffset.X += dx;
                imageOffset.Y += dy;
                lastMousePos = e.Location;
                photo.Invalidate();
            }
        }

        private void Photo_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggingImage = false;
        }

        private void Photo_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                zoomFactor += ZoomIncrement;
            }
            else
            {
                zoomFactor -= ZoomIncrement;
                if (zoomFactor < originalZoomFactor)
                {
                    zoomFactor = originalZoomFactor;
                }
            }

            // Розрахунок максимальних меж зображення
            int minX = (int)Math.Min(0, photo.ClientSize.Width - photo.Image.Width * zoomFactor);
            int maxX = 0;
            int minY = (int)Math.Min(0, photo.ClientSize.Height - photo.Image.Height * zoomFactor);
            int maxY = 0;

            // Обмеження зміщення, щоб не виходити за межі
            imageOffset.X = Math.Max(minX, Math.Min(maxX, imageOffset.X));
            imageOffset.Y = Math.Max(minY, Math.Min(maxY, imageOffset.Y));

            photo.Invalidate();
        }

        private void Photo_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Reset the scale.
                zoomFactor = originalZoomFactor;
                imageOffset = Point.Empty;
                photo.Invalidate();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Saving the image.
            if (photo.Image != null)
            {
                using (Bitmap croppedBitmap = new Bitmap(photo.Width, photo.Height))
                {
                    using (Graphics g = Graphics.FromImage(croppedBitmap))
                    {
                        g.DrawImage(photo.Image, new Rectangle(0, 0, photo.Width, photo.Height),
                                    new Rectangle((int)Math.Abs(imageOffset.X / zoomFactor), (int)Math.Abs(imageOffset.Y / zoomFactor),
                                    (int)(photo.Width / zoomFactor), (int)(photo.Height / zoomFactor)), GraphicsUnit.Pixel);
                    }

                    OutImage = new Bitmap(croppedBitmap); // Deep copying of cropped image.
                    SelectedButton = ImageCropingFormButton.SAVE;
                }

            }
            this.Close();
        }

        public Image GetCroppedImage()
        {
            return OutImage;
        }
    }
}
