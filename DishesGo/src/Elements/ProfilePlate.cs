using DishesGo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DishesGo.src.Elements
{
    public partial class ProfilePlate : UserControl
    {
        public ProfilePlate(Users user, Image userPhoto)
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
                        OwnRecipe ownRecipe = new OwnRecipe(recipe);
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
