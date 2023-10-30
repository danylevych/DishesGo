using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
using DishesGo.src.Elements;


namespace DishesGo.src.Forms
{
    public partial class RecipeViewerForm : KryptonForm
    {
        public RecipeViewerForm()
        {
            InitializeComponent();
        }

        public RecipeViewerForm(int idRecipe, Users user, bool isOwn)
        {
            InitializeComponent();
            context.Controls.Add(new DishViewer(idRecipe, user, isOwn));
        }

        private void backButtonImg_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
