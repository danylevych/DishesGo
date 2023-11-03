using DishesGo.Data;
using DishesGo.src.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DishesGo.src.Components
{
    public partial class IngridientsComponent : UserControl
    {
        public IngridientsComponent()
        {
            InitializeComponent();

            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                var ingredients = context.Ingredients.ToList();

                foreach (var item in ingredients)
                {
                    if (item.ingredient_photo != null)
                    {
                        using (MemoryStream ms = new MemoryStream(item.ingredient_photo))
                        {
                            ingredientComboBox.AddItem(item.ingredient_name, Image.FromStream(ms));
                        }
                    }
                    else
                    {
                        ingredientComboBox.AddItem(item.ingredient_name, Properties.Resources.titlePhoto);
                    }
                }
            }
        }

        private void quantityVal_Enter(object sender, EventArgs e)
        {
            if (quantityVal.Text == "Кількість")
            {
                quantityVal.Text = string.Empty;
            }
        }

        private void quantityVal_Leave(object sender, EventArgs e)
        {
            if (quantityVal.Text == string.Empty)
            {
                quantityVal.Text = "Кількість";
            }
        }
    }
}
