using DishesGo.Data;
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

namespace DishesGo.src.Elements
{
    public partial class OwnDishViewer : UserControl
    {
        public int ReceiptId { get; set; }

        public OwnDishViewer()
        {
            InitializeComponent();
        }

        public OwnDishViewer(int id)
        {
            ReceiptId = id;
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            using(DishesGo_dbEntities db =  new DishesGo_dbEntities()) 
            {
                Recipes receiptObj = db.Recipes.FirstOrDefault(receipt => receipt.recipe_id == ReceiptId);
                // Set all info about receipt.
                if (receiptObj != null) 
                {
                    if(receiptObj.recipe_photo != null)
                    {
                        using(MemoryStream ms = new MemoryStream(receiptObj.recipe_photo))
                        { 
                            dishImg.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        dishImg.Image = Properties.Resources.titlePhoto;
                        dishImg.BackColor = Color.Black;
                    }

                    // Set the header panel.
                    Users currentUser = db.Users.FirstOrDefault(user => user.user_id == receiptObj.user_id);
                    if (currentUser != null) 
                    {
                        if (currentUser.user_photo != null)
                        {
                            using (MemoryStream ms = new MemoryStream(currentUser.user_photo))
                            {
                                profileImg.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            profileImg.Image = Properties.Resources.withoutPhoto;
                        }
                        nicknameLabel.Text = currentUser.nickname;
                    }
                    
                    // Set all fields.
                    receiptName.Text = receiptObj.title;
                    kitchenVal.Text = db.Kitchens.FirstOrDefault(kitchen => kitchen.kitchen_id == receiptObj.kitchen_id)?.title;
                    timeVal.Text = receiptObj.time_prepare.ToString() + " хв.";
                    caloriesVal.Text = receiptObj.calories.ToString() + " ккал.";
                    descriptionVal.Text = receiptObj.description;
                    dateVal.Text = receiptObj.posting_date?.ToString("yyyy-MM-dd");

                    // Add steps.
                    using (var context = new DishesGo_dbEntities())
                    {
                        var recipeSteps = context.RecipeSteps.Where(rs => rs.id_recipe == ReceiptId).ToList();
                        StringBuilder formattedSteps = new StringBuilder();

                        // Here we split our step description to words and than make a string.
                        foreach (var step in recipeSteps)
                        {
                            formattedSteps.AppendLine($"- Крок {step.step_order}");

                            string description = step.description;
                            string[] words = description.Split(' ');

                            string currentLine = "";

                            foreach (var word in words)
                            {
                                if ((currentLine + word).Length > 45)
                                {
                                    formattedSteps.AppendLine($"  {currentLine}");
                                    currentLine = word + " ";
                                }
                                else
                                {
                                    currentLine += word + " ";
                                }
                            }

                            if (!string.IsNullOrWhiteSpace(currentLine))
                            {
                                formattedSteps.AppendLine($"  {currentLine}");
                            }

                            formattedSteps.AppendLine();
                        }

                        stepsVal.Text = formattedSteps.ToString();
                    } 
                }
            }
        }
    }
}
