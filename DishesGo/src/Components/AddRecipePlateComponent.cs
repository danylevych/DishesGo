using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
using DishesGo.Properties;
using DishesGo.src.Forms.ToolForms;
using DishesGo.src.tools;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DishesGo.src.Components
{
    public partial class AddRecipePlateComponent : UserControl
    {
        private int userId;

        private int countOfSteps = 0;
        private string stepDeleting = string.Empty;

        private int countOfIngredients = 0;
        private string ingredientDeleting = string.Empty;

        private bool isPhotoSetted = false;


        public AddRecipePlateComponent(int userId)
        {
            this.userId = userId;

            InitializeComponent();

            disableImageButton.Parent = RecipeImg;

            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                // Set data for kitchen comboBox.
                var kitchenList = context.Kitchens.ToList();
                
                kitchenComboBox.DataSource = kitchenList;
                kitchenComboBox.ValueMember = "kitchen_id";
                kitchenComboBox.DisplayMember = "title";
                kitchenComboBox.SelectedIndex = -1;
                kitchenComboBox.Text = "виберіть кухню";

                // Set data for type comboBox.
                var typeList = context.RecipeTypes.ToList();

                typeComboBox.DataSource = typeList;
                typeComboBox.ValueMember = "type_id";
                typeComboBox.DisplayMember = "title";
                typeComboBox.SelectedIndex = -1;
                typeComboBox.Text = "виберіть тип";
            }
        }

        // Resizing of steps panel's elements. 
        private void stepsPanel_SizeChanged(object sender, EventArgs e)
        {
            stepsPanel.SuspendLayout();
            foreach (var ctrl in stepsPanel.Controls)
            {
                if (ctrl is RecipeStepComponent)
                {
                    (ctrl as RecipeStepComponent).Width = stepsPanel.ClientSize.Width - 7;
                }
            }
            stepsPanel.ResumeLayout();
        }


        // Select steps that user want to delete.
        private void SelectDeletingStep(object sender, EventArgs e)
        {
            RecipeStepComponent senderComponent;

            if (sender is KryptonSeparator)
            {
                senderComponent = ((sender as KryptonSeparator).Parent as RecipeStepComponent);
            }
            else
            {
                senderComponent = (sender as RecipeStepComponent);
            }

            if (stepDeleting == senderComponent.Tag.ToString() && !(sender is KryptonSeparator)) // We chose the same element.
            {
                (stepsPanel.Controls[System.Convert.ToInt32(stepDeleting) - 1] as RecipeStepComponent).BackColor = System.Drawing.SystemColors.ButtonHighlight;
                stepDeleting = string.Empty;
                return;
            }
            
            if (stepDeleting != string.Empty) // We have selected some values.
            {
                (stepsPanel.Controls[System.Convert.ToInt32(stepDeleting) - 1] as RecipeStepComponent).BackColor = System.Drawing.SystemColors.ButtonHighlight;
            }
           
            stepDeleting = senderComponent.Tag.ToString();
            senderComponent.BackColor = Color.Aqua;
        }

        private void addStepsButton_Click(object sender, EventArgs e)
        {
            countOfSteps++;
            deleteStepButton.Visible = true;

            RecipeStepComponent recipeStepComponent = new RecipeStepComponent(countOfSteps);
            recipeStepComponent.Click += SelectDeletingStep;
            recipeStepComponent.ClickSeparator += SelectDeletingStep;

            recipeStepComponent.AllowDrop = true;
            recipeStepComponent.DragEnter += RecipeStepComponent_DragEnter;
            recipeStepComponent.DragDrop += RecipeStepComponent_DragDrop;

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

                ReorderStepNumbers();
            }
        }


        private void RecipeStepComponent_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void RecipeStepComponent_DragDrop(object sender, DragEventArgs e)
        {
            RecipeStepComponent draggedItem = (RecipeStepComponent)e.Data.GetData(typeof(RecipeStepComponent));

            int newIndex = this.stepsPanel.Controls.GetChildIndex((Control)sender);

            if (newIndex != -1)
            {
                this.stepsPanel.Controls.SetChildIndex(draggedItem, newIndex);
                ReorderStepNumbers();
            }
        }

        private void ReorderStepNumbers() // Update numder of steps.
        {
            for (int i = 0; i < countOfSteps; i++)
            {
                ((RecipeStepComponent)stepsPanel.Controls[i]).UpdateNumber(i + 1);
            }
        }


        // Deleting ingredients.
        private void SelectDeletingIngredient(object sender, EventArgs e)
        {
            if (ingredientDeleting == (sender as IngredientsComponent).Tag.ToString())
            {
                (ingredientsPanel.Controls[System.Convert.ToInt32(ingredientDeleting) - 1] as IngredientsComponent).BackColor = System.Drawing.SystemColors.ButtonHighlight;
                ingredientDeleting = string.Empty;
                return;
            }

            if (ingredientDeleting != string.Empty) // We have selected some values.
            {
                (ingredientsPanel.Controls[System.Convert.ToInt32(ingredientDeleting) - 1] as IngredientsComponent).BackColor = System.Drawing.SystemColors.ButtonHighlight;
            }

            ingredientDeleting = (sender as IngredientsComponent).Tag.ToString();
            (sender as IngredientsComponent).BackColor = Color.Aqua;
        }

        private void addIngridientsButton_Click(object sender, EventArgs e)
        {
            // Create an instance of ingredient component.
            countOfIngredients++;
            deleteIngridientButton.Visible = true;

            IngredientsComponent ingredientComponent = new IngredientsComponent(countOfIngredients);
            ingredientComponent.Click += SelectDeletingIngredient;
            ingredientsPanel.Controls.Add(ingredientComponent);
        }

        private void deleteIngridientButton_Click(object sender, EventArgs e)
        {
            if (ingredientDeleting != string.Empty)
            {
                // Removing item.
                var deletingItem = ingredientsPanel.Controls[System.Convert.ToInt32(ingredientDeleting) - 1];
                ingredientsPanel.Controls.Remove(deletingItem);

                // Set and update all things that we need.
                countOfIngredients--;
                if (countOfIngredients == 0) // We haven't elements.
                {
                    deleteIngridientButton.Visible = false;
                }

                ingredientDeleting = string.Empty;
            }
        }


        // Methods for both panels.
        private void Panel_ControlAdded(object sender, ControlEventArgs e)
        {
            CheckIfPanelIsEmpty(sender);
        }

        private void Panel_ControlRemoved(object sender, ControlEventArgs e)
        {
            CheckIfPanelIsEmpty(sender);
        }

        private void CheckIfPanelIsEmpty(object sender)
        {
            FlowLayoutPanel panel = (sender as FlowLayoutPanel);

            if (panel.Controls.Count == 0) // Our panel is empty.
            {
                // Known which panel is it.
                if (panel.Tag.ToString() == "Steps")
                {
                    warningSteps.Visible = true;
                }
                else
                {
                    warningIngredients.Visible = true;
                }
            }
            else
            {
                // Known which panel is it.
                if (panel.Tag.ToString() == "Steps")
                {
                    warningSteps.Visible = false;
                }
                else
                {
                    warningIngredients.Visible = false;
                }
            }
        }



        // Choose the recipe image.
        private void RecipeImg_Click(object sender, EventArgs e)
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
                            RecipeImg.Image = new Bitmap(cropingImgForm.GetCroppedImage());
                            isPhotoSetted = true; // User setted the photo.
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка завантаження фото: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Disabeling the image for the recipe.
        private void disableImageButton_Click(object sender, EventArgs e)
        {
            if (isPhotoSetted)
            {
                // Set the default photo for wallpapers.
                RecipeImg.Image = Properties.Resources.titlePhoto;

                isPhotoSetted = false;
            }
        }

        // Title's methods.
        private void titleVal_Enter(object sender, EventArgs e)
        {
            if (titleVal.Text == "введіть назву")
            {
                titleVal.Text = string.Empty;
                warningTitle.Visible = false;
            }
        }

        private void titleVal_Leave(object sender, EventArgs e)
        {
            if (titleVal.Text == string.Empty)
            {
                titleVal.Text = "введіть назву";
                warningTitle.Visible = true;
            }
        }

        private void descriptionVal_Enter(object sender, EventArgs e)
        {
            if (descriptionVal.Text == "введіть опис")
            {
                descriptionVal.Text = string.Empty;
            }
        }

        private void descriptionVal_Leave(object sender, EventArgs e)
        {
            if (descriptionVal.Text == string.Empty)
            {
                descriptionVal.Text = "введіть опис";
            }
        }


        // Kitchen's methods.
        private void kitchenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kitchenComboBox.SelectedIndex == -1)
            {
                infoImg.Visible = false;
            }
            else
            {
                infoImg.Visible = true;
                warningKitchen.Visible = false;
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


        // Type's method.
        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedIndex != -1)
            {
                warningType.Visible = false;
            }
        }

        // Methods for prepare time and calories.
        private void inputOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inputOnlyNumbers_Leave(object sender, EventArgs e)
        {
            KryptonTextBox textBox = (sender as KryptonTextBox);

            // The sender is the time prepare object.
            if (textBox.Tag.ToString() == "Time")
            {
                if (textBox.Text.Trim() == string.Empty)
                {
                    warningTime.Visible = true;
                }
                else
                {
                    warningTime.Visible = false;
                }
            }
            else // The sender is the calories object.
            {
                if (textBox.Text.Trim() == string.Empty)
                {
                    warningCalories.Visible = true;
                }
                else
                {
                    warningCalories.Visible = false;
                }
            }
        }



        private void addRecipeButton_Click(object sender, EventArgs e)
        {
            bool canSave = true;

            // User have not entered title of recipe.
            if (titleVal.Text.Trim() == "введіть назву" || titleVal.Text.Trim() == string.Empty)
            {
                warningTitle.Visible = true;
                canSave = false;
            }

            // User have not chosen kinchen of recipe.
            if (kitchenComboBox.SelectedIndex == -1)
            {
                warningKitchen.Visible = true;
                canSave = false;
            }

            // User have not chosen type of recipe.
            if (typeComboBox.SelectedIndex == -1)
            {
                warningType.Visible = true;
                canSave = false;
            }

            // User have not entered the prepare time.
            if (timePrepareVal.Text.Trim() == string.Empty)
            {
                warningTime.Visible = true;
                canSave = false;
            }

            // User have not entered the calories.
            if (caloriesVal.Text.Trim() == string.Empty)
            {
                warningCalories.Visible = true;
                canSave = false;
            }

            // User have not created the steps.
            if (countOfSteps == 0)
            {
                warningSteps.Visible = true;
                canSave = false;
            }

            // Check if we do not have step components without values.
            foreach(RecipeStepComponent item in stepsPanel.Controls)
            {
                if (item.Description == string.Empty)
                {
                    MessageBox.Show("Деякі із кроків приготування не містять опису.\nБудь ласка заповніть їх.",
                                    "Iнформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // User have not created the list of ingridients.
            if (countOfIngredients == 0)
            {
                warningIngredients.Visible = true;
                canSave = false;
            }

            // Chech if all of the ingredients component has all needed info.
            foreach (IngredientsComponent item in ingredientsPanel.Controls)
            {
                try
                {
                    if (item.Quantity == string.Empty)
                    {
                        throw new Exception(); // We throw the exception, because the info message is in catch block.
                    }

                    int _ = item.IngredientID; // Here we can get an exception.
                }
                catch
                {
                    MessageBox.Show("Деякі із інгридієнтів приготування не містять усіх потрібних даних.\nБудь ласка заповніть їх.",
                                    "Iнформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // return;

            if (!canSave) // So, if we here we cannot to add the recepe.
            {
                return;
            }

            // Adding recipe.
            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                // Creating new recipe.
                Recipes recipe = new Recipes
                {
                    title = titleVal.Text.Trim(),
                    description = (descriptionVal.Text.Trim() == "введіть опис" ? null : descriptionVal.Text.Trim()),
                    recipe_photo = (isPhotoSetted ? ImageRedactor.ToByteArray(RecipeImg.Image) : null),
                    time_prepare = Convert.ToInt32(timePrepareVal.Text.Trim()),
                    calories = Convert.ToInt32(caloriesVal.Text.Trim()),
                    user_id = userId,
                    kitchen_id = (kitchenComboBox.SelectedItem as Kitchens).kitchen_id,
                    type_id = (typeComboBox.SelectedItem as RecipeTypes).type_id,
                    posting_date = DateTime.Now
                };

                context.Recipes.Add(recipe);
                context.SaveChanges();

                // Add the recipe steps.
                foreach (RecipeStepComponent item in stepsPanel.Controls)
                {
                    RecipeSteps recipeStep = new RecipeSteps
                    {
                        id_recipe = recipe.recipe_id,
                        step_order = item.StepNum,
                        description = item.Description.Trim()
                    };

                    context.RecipeSteps.Add(recipeStep);
                }

                foreach (IngredientsComponent item in ingredientsPanel.Controls)
                {
                    DishIngredients dishIngredient = new DishIngredients
                    {
                        recipe_id = recipe.recipe_id,
                        ingredient_id = item.IngredientID,
                        quantity = item.Quantity
                    };

                    context.DishIngredients.Add(dishIngredient);
                }

                context.SaveChanges();

                MessageBox.Show("Ви успішно створили рецепт.", "Iнформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
