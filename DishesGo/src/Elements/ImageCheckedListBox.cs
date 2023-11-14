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
        private int hoveredIndex = -1;

        public ImageCheckedListBox() : base()
        {
            DrawMode = DrawMode.OwnerDrawVariable;
            MeasureItem += OnMeasureItem;
            DrawItem += OnDrawItem;
            MouseDown += OnMouseDown;

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            int index = IndexFromPoint(e.Location);

            if (index >= 0 && index < Items.Count)
            {
                CustomListBoxItem item = (CustomListBoxItem)Items[index];
                item.IsChecked = !item.IsChecked;

                // Redraw the ListBox to reflect the updated state
                Invalidate();
            }
        }

        private void OnMeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 35;
        }

        private void OnDrawItem(object sender, DrawItemEventArgs e)
        {
            // Draving elements.
            if (e.Index >= 0 && e.Index < Items.Count)
            {
                CustomListBoxItem item = (CustomListBoxItem)Items[e.Index];

                if (e.Index == hoveredIndex)
                {
                    e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds);
                }

                CheckBoxRenderer.DrawCheckBox(e.Graphics, new Point(e.Bounds.Left + 5, e.Bounds.Top + 10), item.IsChecked ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal);

                e.Graphics.DrawImage(item.Photo, new Rectangle(e.Bounds.Left + 25, e.Bounds.Top, 30, 30));

                e.Graphics.DrawString(item.Name, Font, Brushes.Black, new PointF(e.Bounds.Left + 60, e.Bounds.Top + 10));
            }
        }
    }
}
