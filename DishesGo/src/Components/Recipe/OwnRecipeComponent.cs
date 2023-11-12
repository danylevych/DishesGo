using DishesGo.Data;
using DishesGo.src.Components.Recipe;
using DishesGo.src.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public OwnRecipeComponent(Image image, int receiptId) : base(image, receiptId) 
        {
            InitializeComponent();
        }

        public OwnRecipeComponent(Recipes recipe) : base(recipe) 
        {
            InitializeComponent();
        }

        protected override void border_Click(object sender, EventArgs e)
        {
            // Show the information about reciept.
            RecipeViewerForm recipeViewerForm = new RecipeViewerForm(ReceiptId, user, true);
            MainForm.Instance.Hide();
            recipeViewerForm.ShowDialog(MainForm.Instance);
            MainForm.Instance.Show();
        }
    }
}
