﻿using DishesGo.Data;
using DishesGo.src.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishesGo.src.Components.ProfilePlates
{
    public class OwnProfilePlateComponent :
#if DEBUG
        MiddleProfilePlateComponent
#else
        ProfilePlateComponent
#endif
    {
        public OwnProfilePlateComponent(Users user, Image userPhoto) 
            : base(user, userPhoto)
        {
            profileImg.Click += profileImg_Click;
        }

        protected override void AddRecipe(Recipes recipe)
        {
            OwnRecipeComponent ownRecipe = new OwnRecipeComponent(recipe);
            ownRecipe.Parent = this;
            recipesPanel.Controls.Add(ownRecipe);
        }

        private void profileImg_Click(object sender, EventArgs e)
        {
            EditUserForm editUserForm = new EditUserForm(user);
            MainForm.Instance.Hide();
            editUserForm.ShowDialog(MainForm.Instance);
            MainForm.Instance.Show();
        }
    }
}