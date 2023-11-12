using DishesGo.Data;
using System;
using System.Drawing;

namespace DishesGo.src.Components.Recipe
{
    // This class exist only because of the designer in DEBUG state does
    // not show the components, that has realiszed the RecipeComponent.
    public class MiddleRecipeConponent : RecipeComponent
    {
        public MiddleRecipeConponent() : base() { }

        public MiddleRecipeConponent(Image image, int receiptId) : base(image, receiptId) { }

        public MiddleRecipeConponent(Recipes recipe) : base(recipe) { }

        protected override void border_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
