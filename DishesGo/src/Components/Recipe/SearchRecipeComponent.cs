using DishesGo.Data;
using DishesGo.src.Components.ProfilePlates;
using DishesGo.src.Forms;
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
        private readonly Recipes recipe;


        public SearchRecipeComponent() : base()
        {
            InitializeComponent();
        }

        public SearchRecipeComponent(Image image, int receiptId) : base(image, receiptId) 
        {
            InitializeComponent();
            
            // Find the recipe.
            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                recipe = context.Recipes.FirstOrDefault(r => r.recipe_id == receiptId);
            }
            Init();
        }

        public SearchRecipeComponent(Recipes recipe) : base(recipe)
        {
            InitializeComponent();
            this.recipe = recipe;
            Init();
        }

        private void Init()
        {
            recipeNameLabel.Text = (recipe.title.Length > 40 ? recipe.title.Substring(0, 45) + "..." : recipe.title);
            
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
            RecipeViewerForm recipeViewerForm = new RecipeViewerForm(ReceiptId, user, false);
            MainForm.Instance.Hide();
            recipeViewerForm.ShowDialog(MainForm.Instance);
            MainForm.Instance.Show();
        }

        // User click the profile photo or the name of the profile.
        protected void userProfile_Click(object sender, EventArgs e)
        {
            UserProfilePlateComponent userProfilePanel = new UserProfilePlateComponent(user, userPhoto.Image);
            
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
