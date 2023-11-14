using System;
using System.Drawing;
using DishesGo.Data;
using DishesGo.src.Components.Recipe;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DishesGo.src.Elements;

namespace DishesGo.src.Components
{
    public partial class SearchPlateComponent : UserControl
    {
        private readonly int userId;
        private readonly List<Recipes> recipes;

        private readonly Point startRecipePanelPos;

        public SearchPlateComponent(int userId)
        {
            this.userId = userId;

            InitializeComponent();

            startRecipePanelPos = recipePanel.Location;

            using (DishesGo_dbEntities context =  new DishesGo_dbEntities()) 
            {
                recipes = context.Recipes/*.Where(r => r.user_id != userId)*/
                                 .OrderByDescending(r => r.Likes.ToList().Count) // Count of likes is greather.
                                 .ToList();

                foreach (var recipe in recipes) 
                {
                    recipePanel.Controls.Add(new SearchRecipeComponent(recipe));
                }

                kitchenCheckBoxes.Items.AddRange(context.Kitchens.Select(k => k.title).ToArray());
                ingredientsCheckBoxes.Items.AddRange(context.Ingredients.Select(i => i.ingredient_name).ToArray());

                foreach (var ingredient in context.Ingredients.ToList())
                {
                    imageCheckedListBox1.Items.Add(new CustomListBoxItem(ingredient));
                }
            }

        }

        private void filtersButton_Click(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(filtersButton.Tag))
            {
                recipePanel.Location = new Point(filtersPanel.Width + startRecipePanelPos.X, startRecipePanelPos.Y);
                filtersPanel.Visible = true;

                filtersButton.Tag = true; // We have opened the filters panel.
            }
            else
            {
                recipePanel.Location = startRecipePanelPos;
                filtersPanel.Visible = false;

                filtersButton.Tag = false; // We have closed the filters panel.
            }
        }
    }
}
