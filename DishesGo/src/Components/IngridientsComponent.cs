using DishesGo.Data;
using DishesGo.src.Elements;
using DishesGo.src.Tools.Flyweights;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DishesGo.src.Components
{
    public partial class IngredientsComponent : UserControl
    {
        public string Quantity { get { return quantityVal.Text.Trim(); } }
        public int IngredientID { get { return IngredientsFactory.GetIngridientID(ingredientComboBox.SelectedItem.ToString().Trim()); } }

        public IngredientsComponent(int number)
        {
            InitializeComponent();

            // One feelling for all instance.
            if (IngredientsFactory.CanUpdate())
            {
                IngredientsFactory.FeelAndUpdateValues();
            }

            foreach (var item in IngredientsFactory.Pairs)
            {
                ingredientComboBox.AddItem(item.Key, item.Value);
            }

            this.Tag = number.ToString();
        }

        public void UpdateIngredients(int number)
        {
            this.Tag = number.ToString();
        }

        private void quantityVal_Enter(object sender, EventArgs e)
        {
            if (quantityVal.Text == "Кількість")
            {
                quantityVal.Text = string.Empty;
            }
        }

        private void quantityVal_Leave(object sender, EventArgs e)
        {
            if (quantityVal.Text == string.Empty)
            {
                quantityVal.Text = "Кількість";
            }
        }
    }
}
