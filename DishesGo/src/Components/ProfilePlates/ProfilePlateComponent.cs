using DishesGo.Data;
using DishesGo.src.Components;
using DishesGo.src.Forms;
using RashiUI;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DishesGo.src.Elements
{
    public abstract partial class ProfilePlateComponent : UserControl
    {
        protected readonly Users user;

        public string Nickname { get { return nicknameLabel.Text; } set { nicknameLabel.Text = value; } }
        public string ProfileName { get { return profileNameLabel.Text; } set { profileNameLabel.Text = value; } }
        public Image Image { get { return profileImg.Image; } set { profileImg.Image = value; } }


        public ProfilePlateComponent(Users user, Image userPhoto)
        {
            this.user = user;

            InitializeComponent();

            profileImg.Image = userPhoto;
            nicknameLabel.Text = user.nickname;
            profileNameLabel.Text = user?.last_name + " " + user?.first_name;

            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                var userRecipes = context.Recipes.Where(r => r.user_id == user.user_id).OrderByDescending(r => r.posting_date).ToList();
                
                // Add user's recipes.
                if (userRecipes.Count > 0)
                {
                    foreach (var recipe in userRecipes)
                    {
                        AddRecipe(recipe);
                    }
                }
            }
        }

        protected abstract void AddRecipe(Recipes recipe);
    }
}
