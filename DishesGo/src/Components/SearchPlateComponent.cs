using System;
using System.Drawing;
using DishesGo.Data;
using DishesGo.src.Components.Recipe;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DishesGo.src.Elements;
using DishesGo.src.Tools.Enums;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace DishesGo.src.Components
{
    public partial class SearchPlateComponent : UserControl
    {
        private readonly int userId;
        private readonly List<Recipes> recipes;

        private readonly Point startRecipePanelPos;

        private Expression<Func<Recipes, int>> predicat = r => r.Likes.Count; // For likes.
        private Expression<Func<Recipes, Recipes>> selector = r => r; // All recipes.

        public SearchPlateComponent(int userId)
        {
            this.userId = userId;

            InitializeComponent();

            startRecipePanelPos = recipePanel.Location;


            using (DishesGo_dbEntities context =  new DishesGo_dbEntities()) 
            {
                // Fill the kitchens.
                kitchenCheckBoxes.Items.AddRange(context.Kitchens.Select(k => k.title).ToArray());

                // Fill the recipe types.
                recipeTypesCheckBoxes.Items.AddRange(context.RecipeTypes.Select(t => t.title).ToArray());

                // Fill the ingredients.
                foreach (var ingredient in context.Ingredients.ToList())
                {
                    imageCheckedListBox1.Items.Add(new CustomListBoxItem(ingredient));
                }
            }

            LoadMoreRecipes(true, false);
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

        private void sortByButton_Click(object sender, EventArgs e)
        {
            KryptonButton button = sender as KryptonButton;
            
            if (button == null) 
            {
                return;
            }
            
            predicat = r => r.Likes.Count;

            if (button.Tag.ToString() == "Up")
            {
                sortByLikeButton.StateCommon.Back.Image = Properties.Resources.LikeDown;
                button.Tag = "Down";
                LoadMoreRecipes(true);
            }
            else
            {
                sortByLikeButton.StateCommon.Back.Image = Properties.Resources.LikeUp;
                button.Tag = "Up";
                LoadMoreRecipes(true, false);
            }
        }

        private async Task LoadAndDisplayRecipesAsync(Func<IQueryable<Recipes>, IQueryable<Recipes>> queryModifier)
        {
            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                var query = context.Recipes.AsQueryable();
                query = queryModifier(query);

                var loadedRecipes = await query.ToListAsync();

                recipePanel.Controls.Clear();

                foreach (var recipe in loadedRecipes)
                {
                    recipePanel.Controls.Add(new SearchRecipeComponent(recipe));
                }
            }
        }


        private async void LoadMoreRecipes(bool fromStart = false, bool isASC = true)
        {
            if (fromStart)
            {
                recipePanel.Controls.Clear();
            }

            int recipesToLoad = 20;

            int startIndex = recipePanel.Controls.Count;

            if (isASC)
            {
                await LoadAndDisplayRecipesAsync(query => query.Select(selector).OrderBy(predicat).Skip(startIndex).Take(recipesToLoad));
            }
            else
            {
                await LoadAndDisplayRecipesAsync(query => query.Select(selector).OrderByDescending(predicat).Skip(startIndex).Take(recipesToLoad));
            }
        }


        private void OnScroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.SmallIncrement && e.NewValue + e.NewValue >= recipePanel.VerticalScroll.Maximum)
            {
                LoadMoreRecipes();
            }
        }
    }
}
