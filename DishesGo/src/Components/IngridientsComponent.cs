using DishesGo.Data;
using DishesGo.src.Tools.Flyweights;
using System;
using System.Windows.Forms;

namespace DishesGo.src.Components
{
    public partial class IngredientsComponent : UserControl
    {
        public string Quantity { get { return quantityVal.Text.Trim(); } set { quantityVal.Text = value; } }
        public int IngredientID { get 
            {
                try
                {
                    string name = ingredientComboBox.SelectedItem.ToString().Trim();
                    if (name == null || name == string.Empty)
                    {
                        return -1;
                    }

                    return IngredientsFactory.GetIngridientID(name);
                }
                catch
                {
                    return -1;
                }
            }
        }

        public IngredientsComponent(int number, Ingredients ingredient = null)
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

            if (ingredient != null)
            {
                ingredientComboBox.SelectedItem = ingredient.ingredient_name;
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

        // Comparing methods.
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            IngredientsComponent other = (IngredientsComponent)obj;
            
            if (this.Quantity == string.Empty || other.Quantity == string.Empty)
            {
                return base.Equals(obj);
            }
            else if (IngredientID == -1 || other.IngredientID == -1)
            {
                return base.Equals(obj);
            }

            return Quantity == other.Quantity && IngredientID == other.IngredientID;
        }

        public override int GetHashCode()
        {
            return Quantity.GetHashCode() ^ IngredientID;
        }
    }
}
