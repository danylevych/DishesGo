using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishesGo.src.Elements
{
    public class ImageComboBoxItem
    {
        public string Text { get; }
        public Image Image { get; }

        public ImageComboBoxItem(string text, Image image)
        {
            Text = text;
            Image = image;
        }
    }
}
