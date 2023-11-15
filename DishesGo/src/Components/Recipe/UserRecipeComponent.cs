using DishesGo.Data;
using DishesGo.src.Forms;
using System;
using System.Drawing;

namespace DishesGo.src.Components.Recipe
{
    public partial class UserRecipeComponent :
#if DEBUG
        MiddleRecipeConponent
#else
        RecipeComponent
#endif
    {
        public UserRecipeComponent() : base()
        {
            InitializeComponent();
        }

        public UserRecipeComponent(Image image, int receiptId) : base(image, receiptId)
        {
            InitializeComponent();
        }

        public UserRecipeComponent(Recipes recipe) : base(recipe)
        {
            InitializeComponent();
        }

        protected override void border_Click(object sender, EventArgs e)
        {
            // Show the information about reciept.
            RecipeViewerForm recipeViewerForm = new RecipeViewerForm(ReceiptId, user, false);
            MainForm.Instance.Hide();
            recipeViewerForm.ShowDialog(MainForm.Instance);
            MainForm.Instance.Show();
        }
    }
}
