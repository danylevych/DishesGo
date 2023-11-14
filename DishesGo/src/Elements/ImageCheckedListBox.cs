using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DishesGo.src.Elements
{
    public class ImageCheckedListBox : ListBox
    {
        public ImageCheckedListBox() : base()
        {
            DrawMode = DrawMode.OwnerDrawVariable;
            MeasureItem += OnMeasureItem;
            DrawItem += OnDrawItem;
        }

        private void OnMeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 80;  // Встановлюємо висоту елемента
        }

        private void OnDrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0 && e.Index < Items.Count)
            {
                CustomListBoxItem item = (CustomListBoxItem)Items[e.Index];

                CheckBoxRenderer.DrawCheckBox(e.Graphics, new Point(e.Bounds.Left + 5, e.Bounds.Top + 5),
                                              item.IsChecked ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal);

                e.Graphics.DrawString(item.Name, Font, Brushes.Black,
                                      new PointF(e.Bounds.Left + 30, e.Bounds.Top + 5));

                e.Graphics.DrawImage(item.Photo, new Rectangle(e.Bounds.Left + 150, e.Bounds.Top + 5, 60, 60));
            }
        }
    }
}
