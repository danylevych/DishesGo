using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
using DishesGo.src.Components;
using DishesGo.src.Forms.ToolForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace DishesGo.src.Forms.ProfileForms
{
    public partial class EditRecipeForm : KryptonForm
    {
        private string previousText = string.Empty;

        private RecipeDetails recipeDetails;


        public EditRecipeForm(int recipeId)
        {
            InitializeComponent();

            List<Kitchens> kitchens;
            List<RecipeTypes> types;
            List<RecipeStepComponent> stepComponents = new List<RecipeStepComponent>();
            List<IngredientsComponent> ingredientComponents = new List<IngredientsComponent>();

            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                recipeDetails = context.RecipeDetails.FirstOrDefault(receipt => receipt.recipe_id == recipeId);
                kitchens = context.Kitchens.ToList();
                types = context.RecipeTypes.ToList();

                var steps = context.RecipeSteps.Where(s => s.id_recipe == recipeId).OrderBy(s => s.id_step).ToList();
                var ingredients = context.DishIngredients.Where(i => i.recipe_id == recipeId).ToList();

                // Add steps component.
                foreach (var step in steps)
                {
                    var stepComponent = new RecipeStepComponent(System.Convert.ToInt32(step?.step_order));
                    stepComponent.Description = step?.description;
                    stepComponents.Add(stepComponent);
                }

                // Add ingredients.
                for (int i = 0; i < ingredients.Count; i++)
                {
                    var ingredientComponent = new IngredientsComponent(i + 1, ingredients[i].Ingredients);
                    ingredientComponent.Quantity = ingredients[i].quantity;
                    ingredientComponents.Add(ingredientComponent);
                }
            }

            if (recipeDetails != null) 
            {
                // Set photo.
                if (recipeDetails.recipe_photo != null)
                {
                    using (MemoryStream ms = new MemoryStream(recipeDetails.recipe_photo))
                    {
                        recipeImg.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    recipeImg.Image = Properties.Resources.titlePhoto;
                }

                // Set the value for all labels.
                titleVal.Text = recipeDetails?.recipe_title;
                descriptionVal.Text = recipeDetails?.recipe_description;
                timePrepareVal.Text = recipeDetails?.time_prepare.ToString();
                caloriesVal.Text = recipeDetails?.calories.ToString();

                // Set all combobox values.
                kitchenComboBox.DataSource = kitchens;
                kitchenComboBox.ValueMember = "kitchen_id";
                kitchenComboBox.DisplayMember = "title";
                kitchenComboBox.SelectedItem = kitchens.Find(k => k.title == recipeDetails.kitchen_title);
                
                typeComboBox.DataSource = types;
                typeComboBox.ValueMember = "type_id";
                typeComboBox.DisplayMember = "title";
                typeComboBox.SelectedItem = types.Find(t => t.title == recipeDetails.recipe_type_title);

                descriptionKitchen.Text = recipeDetails?.kitchen_description;

                // Filling all Flow Panels.
                foreach (var stepComponent in stepComponents) 
                {
                    stepsPanel.Controls.Add(stepComponent);
                }

                foreach (var ingredientComponent in ingredientComponents)
                {
                    ingredientsPanel.Controls.Add(ingredientComponent);
                }
            }
        }

        private void backButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void recipeImg_Click(object sender, System.EventArgs e)
        {
            // Open dialog window where user can choose image.
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Файли зображень|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        System.Drawing.Image image = new System.Drawing.Bitmap(openFileDialog.FileName);
                        CropingImageForm cropingImgForm = new CropingImageForm(image);
                        cropingImgForm.ShowDialog(this);

                        if (cropingImgForm.SelectedButton == Tools.ImageCropingFormButton.SAVE)
                        {
                            recipeImg.Image = new Bitmap(cropingImgForm.GetCroppedImage());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка завантаження фото: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            previousText = (sender as KryptonTextBox).Text;
            (sender as KryptonTextBox).Text = string.Empty;
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            KryptonTextBox textBox = sender as KryptonTextBox;
            if (textBox.Text == string.Empty)
            {
                textBox.Text = previousText;
            }
        }

        private void infoImg_MouseEnter(object sender, EventArgs e)
        {
            descriptionKitchen.Text = (kitchenComboBox.SelectedItem as Kitchens).description;
            descriptionKitchen.Visible = true;
        }

        private void infoImg_MouseLeave(object sender, EventArgs e)
        {
            descriptionKitchen.Visible = false;
        }

        private void disabelRecipeImg_Click(object sender, EventArgs e)
        {
            if (recipeDetails.recipe_photo != null)
            {
                using (MemoryStream ms = new MemoryStream(recipeDetails.recipe_photo))
                {
                    recipeImg.Image = Image.FromStream(ms);
                }
            }
            else
            {
                recipeImg.Image = Properties.Resources.titlePhoto;
            }
        }
    }
}
