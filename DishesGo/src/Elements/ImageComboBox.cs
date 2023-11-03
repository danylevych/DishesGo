using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DishesGo.src.Elements
{
    public class ImageComboBox : ComboBox
    {
        // The list with components that, have a image and text.
        private List<ImageComboBoxItem> items = new List<ImageComboBoxItem>();

        public ImageComboBox()
        {
            //DrawMode = DrawMode.OwnerDrawFixed;
        }

        public void AddItem(string text, Image image)
        {
            items.Add(new ImageComboBoxItem(text, image));
            Items.Add(text);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            if (e.Index >= 0 && e.Index < items.Count)
            {
                ImageComboBoxItem item = items[e.Index];

                e.DrawBackground();
                e.Graphics.DrawImage(item.Image, e.Bounds.Left, e.Bounds.Top, 30, 30);
                e.Graphics.DrawString(item.Text, e.Font, Brushes.Black, e.Bounds.Left + 35, e.Bounds.Top + 11);

            }
        }
    }
}
