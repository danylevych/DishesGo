using DishesGo.Data;
using DishesGo.src.Components.Recipe;
using DishesGo.src.Forms;
using DishesGo.src.Forms.ToolForms;
using System;
using System.Drawing;
using System.Linq;

namespace DishesGo.src.Components
{
    public partial class OwnRecipeComponent :
#if DEBUG
        MiddleRecipeConponent
#else
        RecipeComponent
#endif
    {
        public OwnRecipeComponent() : base()
        {
            InitializeComponent();
        }

        public OwnRecipeComponent(Recipes recipe) : base(recipe) 
        {
            caller = user = recipe.Users;
            InitializeComponent();
        }

        protected override void border_Click(object sender, EventArgs e)
        {
            // Show the information about reciept.
            using (BackgroundForm backgroundForm = new BackgroundForm(MainForm.Instance))
            {
                RecipeViewerForm recipeViewerForm = new RecipeViewerForm(ReceiptId, caller, true);
                recipeViewerForm.ShowDialog(backgroundForm);
            }
        }
    }
}
