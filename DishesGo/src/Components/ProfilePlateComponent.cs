using DishesGo.Data;
using DishesGo.src.Forms;
using DishesGo.src.tools;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DishesGo.src.Elements
{
    public partial class ProfilePlateComponent : UserControl
    {
        public ProfilePlateComponent(Users user, Image userPhoto)
        {
            InitializeComponent();

            profileImg.Image = userPhoto;
            nicknameLabel.Text = user.nickname;
            profileNameLabel.Text = user?.last_name + " " + user?.first_name;

            using (DishesGo_dbEntities db = new DishesGo_dbEntities())
            {
                var userRecipes = db.Recipes.Where(r => r.user_id == user.user_id).ToList();
                if (userRecipes.Count > 0)
                {
                    foreach (var recipe in userRecipes)
                    {
                        OwnRecipeComponent ownRecipe = new OwnRecipeComponent(recipe);
                        ownRecipe.Parent = this;
                        recipesPanel.Controls.Add(ownRecipe);
                    }
                }
            }
        }

        public string Nickname { get { return nicknameLabel.Text; } set { nicknameLabel.Text = value; } }
        public string ProfileName { get { return profileNameLabel.Text; } set { profileNameLabel.Text = value; } }
        public Image Image { get { return profileImg.Image; } set { profileImg.Image = value; } }
    }
}
