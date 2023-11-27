using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
using DishesGo.src.Components;
using DishesGo.src.Forms.ToolForms;
using DishesGo.src.tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DishesGo.src.Forms.ProfileForms
{
    public partial class EditRecipeForm : KryptonForm
    {
        private readonly RecipeDetails recipeDetails;
        private string previousText = string.Empty;

        private int countOfSteps = 0;
        private string stepDeleting = string.Empty;

        private int countOfIngredients = 0;
        private string ingredientDeleting = string.Empty;


        private readonly List<Kitchens> kitchens;
        private readonly List<RecipeTypes> types;
        private readonly List<RecipeStepComponent> stepComponents = new List<RecipeStepComponent>();
        private readonly List<IngredientsComponent> ingredientComponents = new List<IngredientsComponent>();


        public EditRecipeForm(int recipeId)
        {
            this.DialogResult = DialogResult.No;

            InitializeComponent();

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
                isDeletedPreviousPhoto = false;
                if (recipeDetails.recipe_photo != null)
                {
                    using (MemoryStream ms = new MemoryStream(recipeDetails.recipe_photo))
                    {
                        recipeImg.Image = Image.FromStream(ms);
                        recipeImg.Tag = "userImg";
                    }
                }
                else
                {
                    recipeImg.Image = Properties.Resources.titlePhoto;
                    recipeImg.Tag = "without";
                }

                // Set all combobox values.
                kitchenComboBox.DataSource = kitchens;
                kitchenComboBox.ValueMember = "kitchen_id";
                kitchenComboBox.DisplayMember = "title";

                typeComboBox.DataSource = types;
                typeComboBox.ValueMember = "type_id";
                typeComboBox.DisplayMember = "title";

                // Set all labels.
                disableLabelsButton_Click(this, EventArgs.Empty);

                // Filling all Flow Panels.
                disableStepsButton_Click(this, EventArgs.Empty);
                disableIngredientsButton_Click(this, EventArgs.Empty);
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
                            recipeImg.Tag = "newUserImg";
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
            //(sender as KryptonTextBox).Text = string.Empty;
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

        // Methods for prepare time and calories.
        private void inputOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Here the methods for diabeling changing are.
        #region Disable Changings
        private DateTime lastClickTime = DateTime.Now;
        private bool isDeletedPreviousPhoto = false;
        private void disabelRecipeImg_Click(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - lastClickTime;

            if (elapsed.TotalMilliseconds < SystemInformation.DoubleClickTime) // Two clicks delete previous image.
            {
                recipeImg.Image = Properties.Resources.titlePhoto;
                recipeImg.Tag = "without";
                isDeletedPreviousPhoto = true; // We could not have an ability to set the ptrevious img again.
            }
            else
            {
                // Reset the image for the recipe.
                if (recipeDetails.recipe_photo != null && !isDeletedPreviousPhoto)
                {
                    using (MemoryStream ms = new MemoryStream(recipeDetails.recipe_photo))
                    {
                        recipeImg.Image = Image.FromStream(ms);
                        recipeImg.Tag = "userImg";
                    }
                }
                else
                {
                    recipeImg.Image = Properties.Resources.titlePhoto;
                    recipeImg.Tag = "without";
                }
            }

            lastClickTime = DateTime.Now;
        }

        private void disableLabelsButton_Click(object sender, EventArgs e)
        {
            // Set the value for all labels.
            titleVal.Text = recipeDetails?.recipe_title;
            descriptionVal.Text = recipeDetails?.recipe_description;
            timePrepareVal.Text = recipeDetails?.time_prepare.ToString();
            caloriesVal.Text = recipeDetails?.calories.ToString();

            kitchenComboBox.SelectedItem = kitchens.Find(k => k.title == recipeDetails.kitchen_title);
            typeComboBox.SelectedItem = types.Find(t => t.title == recipeDetails.recipe_type_title);

            descriptionKitchen.Text = recipeDetails?.kitchen_description;
        }

        private void disableIngredientsButton_Click(object sender, EventArgs e)
        {
            ingredientsPanel.Controls.Clear(); // Clear previous user's changing.

            foreach (var ingredientComponent in ingredientComponents)
            {
                var newIingredientComponent = new IngredientsComponent(ingredientComponent);
                newIingredientComponent.Click += SelectDeletingIngredient;
                ingredientsPanel.Controls.Add(newIingredientComponent);
            }

            countOfIngredients = ingredientComponents.Count;
        }

        private void disableStepsButton_Click(object sender, EventArgs e)
        {
            stepsPanel.Controls.Clear(); // Clear previous user's changing.

            foreach (var stepComponent in stepComponents)
            {
                var newStepComponent = new RecipeStepComponent(stepComponent);

                // Add events for user ability to make changings.
                newStepComponent.Click += SelectDeletingStep;
                newStepComponent.ClickSeparator += SelectDeletingStep;

                newStepComponent.DragEnter += RecipeStepComponent_DragEnter;
                newStepComponent.DragDrop += RecipeStepComponent_DragDrop;

                stepsPanel.Controls.Add(newStepComponent);
            }

            countOfSteps = stepComponents.Count;
        }
        #endregion Disable Changings

        // Here we store all methods for steps.
        #region Step`s Componets 
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
            if (stepDeleting != string.Empty)
            {
                // Removing item.
                var deletingItem = stepsPanel.Controls[System.Convert.ToInt32(stepDeleting) - 1];
                stepsPanel.Controls.Remove(deletingItem);

                // Set and update all things that we need.
                countOfSteps--;
                if (countOfSteps == 0) // We haven't elements.
                {
                    deleteStepButton.Visible = false;
                }

                stepDeleting = string.Empty;

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
        #endregion Step`s Componets

        // Here we store the methods for ingredients.
        #region Ingredient's Components
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
        #endregion Ingredient's Components

        // Methods for two panels.
        #region For two panels
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

        #endregion For two panels

        private void saveChanging_Click(object sender, EventArgs e)
        {
            if (warningIngredients.Visible) // User delete all ingredients and did not add new one.
            {
                MessageBox.Show("Ви не можете залишити страву без інгридієнтів!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (warningSteps.Visible) // User delete all steps and did not add new one.
            {
                MessageBox.Show("Ви не можете залишити страву без кроків приготування!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // User have not created the steps.
            if (countOfSteps == 0)
            {
                warningSteps.Visible = true;
                return;
            }

            // User have not created the list of ingridients.
            if (countOfIngredients == 0)
            {
                warningIngredients.Visible = true;
                return;
            }

            // Check if we do not have step components without values.
            foreach (RecipeStepComponent item in stepsPanel.Controls)
            {
                if (item.Description == string.Empty)
                {
                    MessageBox.Show("Деякі із кроків приготування не містять опису.\nБудь ласка заповніть їх.",
                                    "Iнформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
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

            RecipeDetails newRecipeDetails = new RecipeDetails
            {
                recipe_title = titleVal.Text.Trim(),
                recipe_description = descriptionVal.Text.Trim(),
                kitchen_id = (kitchenComboBox.SelectedItem as Kitchens).kitchen_id,
                type_id = (typeComboBox.SelectedItem as RecipeTypes).type_id,
                calories = Convert.ToInt32(caloriesVal.Text.Trim()),
                time_prepare = Convert.ToInt32(timePrepareVal.Text.Trim())
            };

            string imgTag = recipeImg.Tag.ToString();
            newRecipeDetails.recipe_photo = (imgTag == "without" ? null : (imgTag == "newUserImg" ? ImageRedactor.ToByteArray(recipeImg.Image) : recipeDetails.recipe_photo));


            if (CompareTwoRecipe(newRecipeDetails, recipeDetails) && (imgTag == "without" || imgTag == "userImg") &&
                // If user made changings in steps.
                CompareTwoListOf<RecipeStepComponent>(stepComponents, stepsPanel.Controls.OfType<RecipeStepComponent>().ToList(),
                (leftItem, rightItem) => leftItem.StepNum == rightItem.StepNum && leftItem.Description == rightItem.Description) &&
                // User made changings in the ingridient list.
                CompareTwoListOf<IngredientsComponent>(ingredientComponents, ingredientsPanel.Controls.OfType<IngredientsComponent>().ToList(),
                (leftItem, rightItem) => leftItem.IngredientID == rightItem.IngredientID && leftItem.Quantity == rightItem.Quantity))
            {
                MessageBox.Show("Ви не можете здійснити збереження, оскільки не змінили нічого!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // If we are here it means that user made all action right.
            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                Recipes recipe = context.Recipes.FirstOrDefault(r => r.recipe_id == recipeDetails.recipe_id);

                recipe.title = newRecipeDetails.recipe_title;
                recipe.description = newRecipeDetails.recipe_description;
                recipe.recipe_photo = newRecipeDetails.recipe_photo;
                recipe.time_prepare = Convert.ToInt32(timePrepareVal.Text.Trim());
                recipe.calories = Convert.ToInt32(caloriesVal.Text.Trim());
                recipe.kitchen_id = newRecipeDetails.kitchen_id;
                recipe.type_id = newRecipeDetails.type_id;


                context.SaveChanges();

                // Update the recipe steps.
                foreach (RecipeStepComponent stepComponent in stepsPanel.Controls.OfType<RecipeStepComponent>())
                {
                    RecipeSteps step = context.RecipeSteps
                                              .FirstOrDefault(s => s.id_recipe == recipeDetails.recipe_id && s.step_order == stepComponent.StepNum);

                    if (step != null)
                    {
                        // Updating existing steps.
                        step.description = stepComponent.Description;
                    }
                    else
                    {
                        // Add new step.
                        context.RecipeSteps.Add(new RecipeSteps
                        {
                            id_recipe = recipeDetails.recipe_id,
                            step_order = stepComponent.StepNum,
                            description = stepComponent.Description
                        });
                    }
                }
                context.SaveChanges();

                // Update and add ingredients.
                foreach (IngredientsComponent ingredientComponent in ingredientsPanel.Controls.OfType<IngredientsComponent>())
                {
                    DishIngredients ingredient = context.DishIngredients
                                                        .FirstOrDefault(i => i.recipe_id == recipeDetails.recipe_id && i.ingredient_id == ingredientComponent.IngredientID);

                    if (ingredient != null)
                    {
                        // Update an existing element.
                        ingredient.quantity = ingredientComponent.Quantity;
                        ingredient.ingredient_id = ingredientComponent.IngredientID;
                    }
                    else
                    {
                        // Add new ingredient.
                        context.DishIngredients.Add(new DishIngredients
                        {
                            recipe_id = recipeDetails.recipe_id,
                            ingredient_id = ingredientComponent.IngredientID,
                            quantity = ingredientComponent.Quantity
                        });
                    }
                }
                context.SaveChanges();

                // Deleting steps
                var existingSteps = context.RecipeSteps
                                           .Where(s => s.id_recipe == recipeDetails.recipe_id)
                                           .ToList();

                foreach (var existingStep in existingSteps)
                {
                    if (!stepsPanel.Controls.OfType<RecipeStepComponent>().Any(s => s.StepNum == existingStep.step_order))
                    {
                        context.RecipeSteps.Remove(existingStep);
                    }
                }

                context.SaveChanges();

                // Deleting ingredients.
                var existingIngredients = context.DishIngredients
                                                 .Where(i => i.recipe_id == recipeDetails.recipe_id)
                                                 .ToList();

                foreach (var existingIngredient in existingIngredients)
                {
                    if (!ingredientsPanel.Controls.OfType<IngredientsComponent>().Any(i => i.IngredientID == existingIngredient.ingredient_id))
                    {
                        // Якщо існуючий інгредієнт не знаходиться в новому списку, видаляємо його.
                        context.DishIngredients.Remove(existingIngredient);
                    }
                }

                context.SaveChanges();
                
                MessageBox.Show("Ви успішно оновили рецепт.", "Iнформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Yes;
            }
        }


        private bool CompareTwoRecipe(RecipeDetails left, RecipeDetails right)
        {
            return (left.recipe_title == right.recipe_title && left.recipe_description == right.recipe_description &&
                    left.kitchen_id == right.kitchen_id && left.type_id == right.type_id &&
                    left.calories == right.calories && left.time_prepare == right.time_prepare);
        }

        private bool CompareTwoListOf<T>(List<T> left, List<T> right, Func<T, T, bool> compareFunction)
        {
            if (left.Count != right.Count)
            {
                return false;
            }

            HashSet<T> rightSet = new HashSet<T>(right, EqualityComparer<T>.Default);

            return left.All(item => rightSet.Any(otherItem => compareFunction(item, otherItem)));
        }
    }
}
