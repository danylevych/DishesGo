using DishesGo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DishesGo.src.Components
{
    public abstract partial class RecipeComponent : UserControl
    {
        protected Users user;

        public int ReceiptId { get; set; }
        public Image Image { get { return recipeImg.Image; } set { recipeImg.Image = value; } }

        public RecipeComponent()
        {
            InitializeComponent();
            border.Parent = recipeImg;
        }

        public RecipeComponent(Image image, int receiptId)
        {
            InitializeComponent();
            border.Parent = recipeImg;

            Image = image;
            ReceiptId = receiptId;
        }

        public RecipeComponent(Recipes recipe)
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
    }
}
