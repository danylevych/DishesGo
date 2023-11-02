using DishesGo.Data;
using DishesGo.src.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DishesGo.src.Elements
{
    public partial class OwnRecipeComponent : UserControl
    {
        private Users user;


        public OwnRecipeComponent()
        {
            InitializeComponent();
            border.Parent = recipeImg;
        }

        public OwnRecipeComponent(Image image, int receiptId)
        {
            InitializeComponent();
            border.Parent = recipeImg;

            Image = image;
            ReceiptId = receiptId;
        }

        public OwnRecipeComponent(Recipes recipe)
        {
            InitializeComponent();
            border.Parent = recipeImg;

            ReceiptId = recipe.recipe_id;

            if (recipe.recipe_photo == null)
            {
                this.Image = Properties.Resources.titlePhoto;
            }
            else
            {
                // When user's recipe has image, we try to show it,
                // but this action can throw exeption, when the format
                // or else image data is wrong.
                try
                {
                    using (MemoryStream ms = new MemoryStream(recipe.recipe_photo))
                    {
                        this.Image = Image.FromStream(ms);
                    }
                }
                catch
                {
                    this.Image = Properties.Resources.titlePhoto;
                }
            }

            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                user = context.Users.FirstOrDefault(userdb => userdb.user_id == recipe.user_id);
            }
        }

        public int ReceiptId { get; set; }
        public Image Image { get { return recipeImg.Image; } set { recipeImg.Image = value; } }


        private void border_Click(object sender, EventArgs e)
        {
            // Show the information about reciept.
            RecipeViewerForm recipeViewerForm = new RecipeViewerForm(ReceiptId, user, true);
            MainForm.Instance.Hide();
            recipeViewerForm.ShowDialog(MainForm.Instance);
            MainForm.Instance.Show();
        }
    }
}
