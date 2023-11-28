using DishesGo.Data;
using DishesGo.src.Elements;
using System;
using System.Drawing;

namespace DishesGo.src.Components.ProfilePlates
{
    // There is the class, that provide to us ability to 
    // work with the designer.
    public class MiddleProfilePlateComponent : ProfilePlateComponent
    {
        public MiddleProfilePlateComponent()
            : base()
        {
        }

        public MiddleProfilePlateComponent(Users user, Image userPhoto) 
            : base(user, userPhoto)
        {
        }

        protected override void AddRecipe(Recipes recipe)
        {
            throw new System.NotImplementedException();
        }
    }
}
