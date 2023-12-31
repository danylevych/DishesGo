﻿using DishesGo.Data;
using DishesGo.src.Components.ProfilePlates;
using DishesGo.src.Forms;
using DishesGo.src.Forms.ToolForms;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DishesGo.src.Components.Recipe
{
    public partial class SearchRecipeComponent :
#if DEBUG
        MiddleRecipeConponent
#else
        RecipeComponent
#endif
    {
        //private readonly Users caller;
        private readonly Recipes recipe;

        public SearchRecipeComponent() : base()
        {
            InitializeComponent();
        }

        public SearchRecipeComponent(Recipes recipe, Users user, Users caller) : base(recipe)
        {
            this.user = user;
            this.recipe = recipe;
            InitializeComponent();
            Init();
            this.caller = caller;
        }

        private void Init()
        {
            recipeNameLabel.Text = (recipe.title.Length > 25 ? recipe.title.Substring(0, 25) + "..." : recipe.title);

            // Set the user photo;
            if (recipe.Users.user_photo != null)
            {
                using (MemoryStream ms = new MemoryStream(recipe.Users.user_photo))
                {
                    userPhoto.Image = Image.FromStream(ms);
                }
            }
            else
            {
                userPhoto.Image = Properties.Resources.withoutPhoto;
            }

            nicknameLabel.Text = recipe?.Users?.nickname;
        }

        protected override void border_Click(object sender, EventArgs e)
        {
            // Show the information about reciept.
            using (BackgroundForm backgroundForm = new BackgroundForm(MainForm.Instance))
            {
                RecipeViewerForm recipeViewerForm = new RecipeViewerForm(ReceiptId, caller, false);
                recipeViewerForm.ShowDialog(backgroundForm);
            }
        }

        // User click the profile photo or the name of the profile.
        protected void userProfile_Click(object sender, EventArgs e)
        {
            UserProfilePlateComponent userProfilePanel = new UserProfilePlateComponent(user, userPhoto.Image, caller);
            
            userProfilePanel.BackButtonClick = (sender1, e1) =>
            {
                MainForm.Instance.Context.Controls.Remove(userProfilePanel); // Delete profile panel from components.
            };

            userProfilePanel.Dock = DockStyle.Fill;
            MainForm.Instance.Context.Controls.Add(userProfilePanel);
            userProfilePanel.BringToFront();
        }
    }
}
