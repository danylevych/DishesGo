using DishesGo.Data;
using DishesGo.src.Components.Recipe;
using System;
using System.Drawing;

namespace DishesGo.src.Components.ProfilePlates
{
    public partial class UserProfilePlateComponent : 
#if DEBUG
        MiddleProfilePlateComponent
#else
        ProfilePlateComponent
#endif
    {
        public EventHandler BackButtonClick { set { backButton.Click += value; } }


        public UserProfilePlateComponent(Users user, Image userPhoto)
            : base(user, userPhoto)
        {
            InitializeComponent();
        }

        protected override void AddRecipe(Recipes recipe)
        {
            RecipeComponent ownRecipe = new UserRecipeComponent(recipe);
            ownRecipe.Parent = this;
            recipesPanel.Controls.Add(ownRecipe);
        }
    }
}
