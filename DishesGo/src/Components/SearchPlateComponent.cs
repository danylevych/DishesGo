using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
using DishesGo.src.Components.Recipe;
using DishesGo.src.Elements;
using DishesGo.src.Tools.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DishesGo.src.Components
{
    public partial class SearchPlateComponent : UserControl
    {
        private readonly int userId;
        private readonly List<Recipes> recipes;
        private SortTags sortTag;

        private readonly Point startRecipePanelPos;

        private Expression<Func<Recipes, bool>> predicat = r => r.recipe_id == r.recipe_id; // For likes.

        

        public SearchPlateComponent(int userId)
        {
            this.userId = userId;

            InitializeComponent();

            //clearUserImput.Parent = searchTextBox;
            startRecipePanelPos = recipePanel.Location;

            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                // Fill the kitchens.
                kitchenCheckBoxes.Items.AddRange(context.Kitchens.Select(k => k.title).ToArray());

                // Fill the recipe types.
                recipeTypesCheckBoxes.Items.AddRange(context.RecipeTypes.Select(t => t.title).ToArray());

                // Fill the ingredients.
                foreach (var ingredient in context.Ingredients.OrderBy(i => i.ingredient_name).ToList())
                {
                    ingredientsCheckBoxes.Items.Add(new CustomListBoxItem(ingredient));
                }
            }

            // Set option for search.
            searchTextBox.Enter += (sender, e) => {
                if ((searchTextBox.Text.Trim() == "Пошук..."))
                {
                    searchTextBox.Text = string.Empty;
                    clearUserImput.Visible = false;
                }
                else
                {
                    clearUserImput.Visible = true;
                }
            };

            searchTextBox.Leave += (sender, e) => {
                if ((searchTextBox.Text.Trim() == string.Empty))
                {
                    searchTextBox.Text = "Пошук...";
                    clearUserImput.Visible = false;
                }
                else
                {
                    clearUserImput.Visible = true;
                }
            };

            searchTextBox.KeyDown += (sender, e) => {
                if (e.KeyCode == Keys.Enter)
                {
                    if (searchTextBox.Text.Trim() != string.Empty && searchTextBox.Text.Trim() != "Пошук...")
                    {
                        string searchTerm = searchTextBox.Text.Trim().ToLower();
                        string[] searchTerms = searchTerm.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

                        LoadMoreRecipes(true, r => searchTerms.All(term => r.title.ToLower().Contains(term)));
                    }
                    else
                    {
                        LoadMoreRecipes(true);
                    }

                    this.ActiveControl = null;
                }
            };


            // Set the events for showing cancel butons.
            kitchenCheckBoxes.SelectedIndexChanged += (sender, e) => cancleKitchens.Visible = kitchenCheckBoxes.CheckedItems.Count > 0;
            recipeTypesCheckBoxes.SelectedIndexChanged += (sender, e) => cancelTypes.Visible = recipeTypesCheckBoxes.CheckedItems.Count > 0;
            ingredientsCheckBoxes.SelectedIndexChanged += (sender, e) => cancelIngredients.Visible = ingredientsCheckBoxes.CheckedItems.Count > 0;

            // Show recipes.
            sortTag = SortTags.UpByLikes;
            predicat = r => r.recipe_id == r.recipe_id;
            LoadMoreRecipes(true);
        }


        private void clearUserImput_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "Пошук...";
            LoadMoreRecipes(true);

            this.ActiveControl = null;
            clearUserImput.Visible = false;
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

            bool isASC;

            if (button.Tag.ToString() == "Up")
            {
                button.Tag = "Down";
                isASC = true;
            }
            else
            {
                button.Tag = "Up";
                isASC = false;
            }

            if (button.Name == "sortByLikeButton")
            {
                button.StateCommon.Back.Image = isASC ? Properties.Resources.LikeUp : Properties.Resources.LikeDown;
                sortTag = !isASC ? SortTags.DownByLikes : SortTags.UpByLikes;

                // Reset the other button to its default state
                sortByDateButton.Tag = "Up";
                sortByDateButton.StateCommon.Back.Image = Properties.Resources.TimeUp;
            }
            else if (button.Name == "sortByDateButton")
            {
                button.StateCommon.Back.Image = isASC ? Properties.Resources.TimeUp : Properties.Resources.TimeDown;
                sortTag = !isASC ? SortTags.DownByDate : SortTags.UpByDate;

                // Reset the other button to its default state
                sortByLikeButton.Tag = "Up";
                sortByLikeButton.StateCommon.Back.Image = Properties.Resources.LikeUp;
            }

            LoadMoreRecipes(true);
        }

        private void applyFiltersButton_Click(object sender, EventArgs e)
        {
            // User did not select any filters.
            //if (kitchenCheckBoxes.CheckedItems.Count == 0 && recipeTypesCheckBoxes.CheckedItems.Count == 0 &&
            //    ingredientsCheckBoxes.CheckedItems.Count == 0)
            //{
            //    // TODO: Show the message.
            //    return;
            //}

            // Make a sql query for user's selections.
            var selectedKitchens = kitchenCheckBoxes.CheckedItems.OfType<string>().ToList();
            var selectedRecipeTypes = recipeTypesCheckBoxes.CheckedItems.OfType<string>().ToList();
            var selectedIngredients = ingredientsCheckBoxes.CheckedItems.OfType<CustomListBoxItem>().Select(item => item.Name).ToList();

            // Check if any values are selected, if not, consider all values
            predicat = r =>
                (!selectedKitchens.Any() || selectedKitchens.Contains(r.Kitchens.title)) &&
                (!selectedRecipeTypes.Any() || selectedRecipeTypes.Contains(r.RecipeTypes.title)) &&
                (!selectedIngredients.Any() || r.DishIngredients.Any(i => selectedIngredients.Contains(i.Ingredients.ingredient_name)));

            LoadMoreRecipes(true);
        }

        private void cancleKitchens_Click(object sender, EventArgs e)
        {
            foreach (int index in kitchenCheckBoxes.CheckedIndices)
            {
                kitchenCheckBoxes.SetItemCheckState(index, CheckState.Unchecked);
            }
        }

        private void cancelTypes_Click(object sender, EventArgs e)
        {
            foreach (int index in recipeTypesCheckBoxes.CheckedIndices)
            {
                recipeTypesCheckBoxes.SetItemCheckState(index, CheckState.Unchecked);
            }
        }

        private void cancelIngredients_Click(object sender, EventArgs e)
        {
            foreach (var item in ingredientsCheckBoxes.CheckedItems)
            {
                item.IsChecked = false;
            }

            ingredientsCheckBoxes.Refresh();
        }

        private void recipePanel_Scroll(object sender, ScrollEventArgs e)
        {
            // User scrolled all recipes.
            if (e.Type == ScrollEventType.SmallIncrement && e.NewValue + recipePanel.Height >= recipePanel.VerticalScroll.Maximum)
            {
                // Loading new recipes.
                LoadMoreRecipes(false);
            }
        }


        private async void LoadMoreRecipes(bool fromStart, Expression<Func<Recipes, bool>> condition = null)
        {
            if (condition == null)
            {
                condition = r => r.recipe_id == r.recipe_id;
            }

            if (fromStart)
            {
                recipePanel.Controls.Clear();
            }

            int recipesToLoad = 20;
            int startIndex = recipePanel.Controls.Count;

            switch (sortTag)
            {
                case SortTags.UpByLikes:
                    await LoadAndDisplayRecipesAsync(query => query.Where(predicat).Where(condition).OrderByDescending(r => r.Likes.Count).Skip(startIndex).Take(recipesToLoad));
                break;
                
                case SortTags.DownByLikes:
                    await LoadAndDisplayRecipesAsync(query => query.Where(predicat).Where(condition).OrderBy(r => r.Likes.Count).Skip(startIndex).Take(recipesToLoad));
                    break;

                case SortTags.UpByDate:
                    await LoadAndDisplayRecipesAsync(query => query.Where(predicat).Where(condition).OrderByDescending(r => r.posting_date).Skip(startIndex).Take(recipesToLoad));
                    break;

                case SortTags.DownByDate:
                    await LoadAndDisplayRecipesAsync(query => query.Where(predicat).Where(condition).OrderBy(r => r.posting_date).Skip(startIndex).Take(recipesToLoad));
                    break;
            }
        }

        private async Task LoadAndDisplayRecipesAsync(Func<IQueryable<Recipes>, IQueryable<Recipes>> queryModifier)
        {
            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                var query = context.Recipes.AsQueryable();
                query = queryModifier(query);

                var loadedRecipes = await query.ToListAsync();

                foreach (var recipe in loadedRecipes)
                {
                    recipePanel.Controls.Add(new SearchRecipeComponent(recipe));
                }
            }
        }
    }
}
