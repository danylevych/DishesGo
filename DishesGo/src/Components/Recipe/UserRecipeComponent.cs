using DishesGo.Data;
using DishesGo.src.Forms;
using DishesGo.src.Forms.ToolForms;
using System;
using System.Drawing;
using System.Windows.Forms.VisualStyles;

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

        public UserRecipeComponent(Recipes recipe, Users user) : base(recipe)
        {
            InitializeComponent();
            this.user = user;
        }

        protected override void border_Click(object sender, EventArgs e)
        {
            // Show the information about reciept.
            using (BackgroundForm backgroundForm = new BackgroundForm(MainForm.Instance))
            {
                RecipeViewerForm recipeViewerForm = new RecipeViewerForm(ReceiptId, user, false);
                recipeViewerForm.ShowDialog(backgroundForm);
            }
        }
    }
}
