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
    public partial class AddRecipePlateComponent : UserControl
    {
        private int countOfSteps = 0;
        private string stepDeleting = string.Empty;

        public AddRecipePlateComponent()
        {
            InitializeComponent();
        }

        // Select steps that user want to delete.
        private void SelectDeletingStep(object sender, EventArgs e)
        {
            if (stepDeleting != string.Empty) // We have selected some values.
            {
                (stepsPanel.Controls[System.Convert.ToInt32(stepDeleting) - 1] as RecipeStepComponent).BackColor = System.Drawing.SystemColors.ButtonHighlight;
            }

            stepDeleting = (sender as RecipeStepComponent).Tag.ToString();
            (sender as RecipeStepComponent).BackColor = Color.Aqua;
        }

        private void addStepsButton_Click(object sender, EventArgs e)
        {
            countOfSteps++;
            deleteStepButton.Visible = true;

            RecipeStepComponent recipeStepComponent = new RecipeStepComponent(countOfSteps);
            recipeStepComponent.Click += SelectDeletingStep;
            stepsPanel.Controls.Add(recipeStepComponent);
        }

        private void deleteStepButton_Click(object sender, EventArgs e)
        {
            if(stepDeleting != string.Empty)
            {
                // Removing item.
                var deletingItem = stepsPanel.Controls[System.Convert.ToInt32(stepDeleting) - 1];
                stepsPanel.Controls.Remove(deletingItem);

                // Set and update all things that we need.
                countOfSteps--;
                if(countOfSteps == 0) // We haven't elements.
                {
                    deleteStepButton.Visible = false;
                }

                stepDeleting = string.Empty;
                
                for(int i = 1;  i <= countOfSteps; i++)
                {
                    (stepsPanel.Controls[i - 1] as RecipeStepComponent).UpdateNumber(i);
                }
            }
        }

        private void addIngridientsButton_Click(object sender, EventArgs e)
        {
            ingrigientsPanel.Controls.Add(new IngridientsComponent());
        }

        private void RecipeImg_Click(object sender, EventArgs e)
        {

        }
    }
}
