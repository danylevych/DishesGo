using DishesGo.Data;
using DishesGo.src.Elements;
using DishesGo.src.Forms;
using DishesGo.src.Forms.ProfileForms;
using DishesGo.src.Forms.ToolForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DishesGo.src.Components.ProfilePlates
{
    public partial class OwnProfilePlateComponent :
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
            InitializeComponent();
        }

        protected override void AddRecipe(Recipes recipe)
        {
            OwnRecipeComponent ownRecipe = new OwnRecipeComponent(recipe);
            ownRecipe.Parent = this;
            recipesPanel.Controls.Add(ownRecipe);
        }

        private void profileImg_Click(object sender, EventArgs e)
        {
            using (BackgroundForm background = new BackgroundForm(MainForm.Instance))
            {
                using (EditUserForm editUserForm = new EditUserForm(user))
                {
                    editUserForm.ShowDialog(background);
                }
            }
        }

        private void viewFollowing(object sender, EventArgs e)
        {
            using (BackgroundForm background = new BackgroundForm(MainForm.Instance))
            {
                using (FollowingListForm followingListForm = new FollowingListForm(user.user_id))
                {
                    followingListForm.ShowDialog(background);
                }
            }
        }
    }
}
