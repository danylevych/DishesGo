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
            border.Parent = recipeImg;
        }

        public OwnRecipe(Image image, int receiptId)
        {
            InitializeComponent();
            border.Parent = recipeImg;

            Image = image;
            ReceiptId = receiptId;
        }

        public OwnRecipe(Recipes recipe)
        {
            InitializeComponent();
            border.Parent = recipeImg;

            ReceiptId = recipe.recipe_id;

            if (recipe.recipe_photo == null)
            {
                Image temp = Properties.Resources.titlePhoto;
                Image = temp;
            }
            else
            {
                using (MemoryStream ms = new MemoryStream(recipe.recipe_photo))
                {
                    Image = Image.FromStream(ms);
                }
            }
        }

        public int ReceiptId { get; set; }
        public Image Image { get { return recipeImg.Image; } set { recipeImg.Image = value; } }


        private void border_Click(object sender, EventArgs e)
        {

        }
    }
}
