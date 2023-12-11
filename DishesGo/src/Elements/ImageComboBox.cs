using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DishesGo.src.Elements
{
    public class ImageComboBox : ComboBox
    {
        // The list with components that have an image and text.
        private List<ImageComboBoxItem> items = new List<ImageComboBoxItem>();

        public ImageComboBox()
        {
            DrawMode = DrawMode.OwnerDrawVariable; // Змінено режим відображення
        }

        public void AddItem(string text, Image image)
        {
            items.Add(new ImageComboBoxItem(text, image));
            Items.Add(text);

            items = items.OrderBy(r => r.Text, StringComparer.InvariantCultureIgnoreCase).ToList();
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            var cbo = this as ComboBox;
            Color foreColor = e.ForeColor;

            if (e.State.HasFlag(DrawItemState.Selected) && !(e.State.HasFlag(DrawItemState.ComboBoxEdit)))
            {
                e.DrawBackground();
                //e.DrawFocusRectangle(); // <= could be removed for a cleaner rendering
            }
            else
            {
                using (var brush = new SolidBrush(cbo.BackColor))
                {
                    var rect = e.Bounds;
                    rect.Inflate(1, 1);
                    e.Graphics.FillRectangle(brush, rect);
                }
                foreColor = cbo.ForeColor;
            }
            TextRenderer.DrawText(e.Graphics, cbo.GetItemText(items[e.Index].Text), e.Font, new Point(e.Bounds.Height + 5, e.Bounds.Y + 7), foreColor);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawImage(items[e.Index].Image, new Rectangle(e.Bounds.Location, new Size(e.Bounds.Height - 2, e.Bounds.Height - 2)));
        }
    }
}
