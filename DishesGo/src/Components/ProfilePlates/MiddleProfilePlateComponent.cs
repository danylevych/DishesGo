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
        public MiddleProfilePlateComponent(Users user = null, Image userPhoto = null) 
            : base(user, userPhoto)
        {
            InitializeComponent();
        }

        private void InitializeComponent() {    }

        protected override void AddRecipe(Recipes recipe)
        {
            throw new System.NotImplementedException();
        }
    }
}
