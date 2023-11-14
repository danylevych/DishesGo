using DishesGo.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishesGo.src.Elements
{
    public class CustomListBoxItem
    {
        public bool IsChecked { get; set; }
        public string Name { get; set; }
        public Image Photo { get; set; }

        public CustomListBoxItem(bool isChecked, string name, Image photo)
        {
            IsChecked = isChecked;
            Name = name;
            Photo = photo;
        }

        public CustomListBoxItem(Ingredients ingredient, bool isChecked = false)
        {
            if (ingredient == null)
            {
                throw new NullReferenceException("The ingredient cannot be null");
            }

            Name = ingredient.ingredient_name;

            if (ingredient.ingredient_photo != null)
            {
                using (MemoryStream ms = new MemoryStream(ingredient.ingredient_photo))
                {
                    Photo = Image.FromStream(ms);
                }
            }
            else
            {
                Photo = Properties.Resources.titlePhoto;
            }

            IsChecked = isChecked;
        }
    }
}
