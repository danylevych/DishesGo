using DishesGo.Data;
using DishesGo.src.Components.Recipe;
using System.Drawing;

namespace DishesGo.src.Components.ProfilePlates
{
    public class UserProfilePlateComponent :
#if DEBUG
        MiddleProfilePlateComponent
#else
        ProfilePlateComponent
#endif
    {
        public UserProfilePlateComponent(Users user, Image userPhoto)
            : base(user, userPhoto)
        {   }

        protected override void AddRecipe(Recipes recipe)
        {
            RecipeComponent ownRecipe = new UserRecipeComponent(recipe);
            ownRecipe.Parent = this;
            recipesPanel.Controls.Add(ownRecipe);
        }
    }
}
