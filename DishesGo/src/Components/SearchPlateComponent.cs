using DishesGo.Data;
using DishesGo.src.Components.Recipe;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DishesGo.src.Components
{
    public partial class SearchPlateComponent : UserControl
    {
        private readonly int userId;
        private readonly List<Recipes> recipes;
        public SearchPlateComponent(int userId)
        {
            this.userId = userId;

            InitializeComponent();
            
            using (DishesGo_dbEntities context =  new DishesGo_dbEntities()) 
            {
                recipes = context.Recipes/*.Where(r => r.user_id != userId)*/
                                 .OrderByDescending(r => r.Likes.ToList().Count) // Count of likes is greather.
                                 .ToList();

                foreach (var recipe in recipes) 
                {
                    recipePanel.Controls.Add(new SearchRecipeComponent(recipe));
                }
            }
        }
    }
}
