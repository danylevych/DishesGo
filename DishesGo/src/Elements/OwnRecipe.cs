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

namespace DishesGo.src.Elements
{
    public partial class OwnRecipe : UserControl
    {
        public OwnRecipe()
        {
            InitializeComponent();
        }

        public OwnRecipe(Image image, string recipeName, int receptId)
        {
            InitializeComponent();

            Image = image;
            RecipeName = recipeName;
            ReceptId = receptId;
        }

        public OwnRecipe(Recipes recipe)
        {
            InitializeComponent();

            ReceptId = recipe.recipe_id;

            if (recipe.recipe_photo == null)
            {
                Image temp = Properties.Resources.withoutPhoto;
                Image = temp;
            }
            else
            {
                using (MemoryStream ms = new MemoryStream(recipe.recipe_photo))
                {
                    Image = Image.FromStream(ms);
                }
            }

            RecipeName = recipe.title;
            RecipeDescription = recipe.description.Substring(0, 150);
        }

        public int ReceptId { get; set; }
        public Image Image { get { return recipeImg.Image; } set { recipeImg.Image = value; } }
        public string RecipeName { get { return recipeName.Text; } set { recipeName.Text = value; } }
        public string RecipeDescription { get { return recipeDescription.Text; } set { recipeDescription.Text =  value; } }
    }
}
