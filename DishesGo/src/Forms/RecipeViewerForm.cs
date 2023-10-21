using ComponentFactory.Krypton.Toolkit;
using DishesGo.src.Elements;


namespace DishesGo.src.Forms
{
    public partial class RecipeViewerForm : KryptonForm
    {
        public RecipeViewerForm()
        {
            InitializeComponent();
        }

        public RecipeViewerForm(int idRecipe, bool isOwn)
        {
            InitializeComponent();
            if (isOwn)
            {
               context.Controls.Add(new OwnDishViewer(idRecipe));
            }
        }
    }
}
