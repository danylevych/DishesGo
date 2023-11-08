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
    public partial class DishViewer : UserControl
    {
        private RecipeDetails recipeDetails;
        private bool isOwn;
        private Users user;


        public int ReceiptId { get; set; }
        

        public DishViewer()
        {
            InitializeComponent();
        }

        public DishViewer(int id, Users user, bool isOwn = true)
        {
            this.isOwn = isOwn;
            this.user = user;
            ReceiptId = id;
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            using (DishesGo_dbEntities db = new DishesGo_dbEntities())
            {
                recipeDetails = db.RecipeDetails.FirstOrDefault(receipt => receipt.recipe_id == ReceiptId);

                // Set all info about receipt.
                if (recipeDetails != null)
                {
                    if (recipeDetails.recipe_photo != null)
                    {
                        using (MemoryStream ms = new MemoryStream(recipeDetails.recipe_photo))
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
                    if (recipeDetails.user_photo != null)
                    {
                        using (MemoryStream ms = new MemoryStream(recipeDetails.user_photo))
                        {
                            profileImg.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        profileImg.Image = Properties.Resources.withoutPhoto;
                    }
                    nicknameLabel.Text = recipeDetails.nickname;

                    // Set all fields.
                    receiptName.Text = recipeDetails.recipe_title;
                    kitchenVal.Text = recipeDetails.kitchen_title;
                    timeVal.Text = recipeDetails.time_prepare.ToString() + " хв.";
                    caloriesVal.Text = recipeDetails.calories.ToString() + " ккал.";
                    descriptionVal.Text = recipeDetails.recipe_description;
                    dateVal.Text = recipeDetails.posting_date?.ToString("yyyy-MM-dd");

                    // Add steps and bottom panel elements.
                    using (var context = new DishesGo_dbEntities())
                    {
                        // Set the recipe ingredients.
                        var recipeIngredients = context.RecipeIngredientsViews.Where(recipeIng => recipeIng.recipe_id == ReceiptId).ToList();
                        if (recipeIngredients != null)
                        {
                            StringBuilder formattedIngredients = new StringBuilder();

                            foreach (var ingredient in recipeIngredients)
                            {
                                formattedIngredients.AppendLine($"◍ {ingredient.ingredient_name} - {ingredient.quantity}");
                                formattedIngredients.AppendLine();
                            }

                            ingredientsVal.Text = formattedIngredients.ToString();
                        }

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




                        // Set bookmark button.
                        
                        bool isOwnBookmark = (context.Bookmarks.FirstOrDefault(bookmark => bookmark.id_recipe == recipeDetails.recipe_id &&
                                                                                           bookmark.id_user == user.user_id) != null);

                        if (isOwnBookmark)
                        {
                            bookmarkButtonImage.Image = Properties.Resources.FullBookmark;
                            bookmarkButtonImage.Tag = "FullBookmark";
                        }
                        else
                        {
                            bookmarkButtonImage.Image = Properties.Resources.EmptyBookmark;
                            bookmarkButtonImage.Tag = "EmptyBookmark";
                        }

                        // Set like button.
                        var likes = context.Likes
                                           .Where(like => like.id_recipe == ReceiptId &&
                                                          like.id_user == user.user_id)
                                           .ToList();

                        bool isOwnerLikes = (likes.Find(like => like.id_user == user.user_id) != null);

                        if (isOwnerLikes)
                        {
                            likeButtonImg.Image = Properties.Resources.FullLike;
                            likeButtonImg.Tag = "FullLike";
                        }
                        else
                        {
                            likeButtonImg.Image = Properties.Resources.EmptyLike;
                            likeButtonImg.Tag = "EmptyLike";
                        }

                        countOfLikeLabel.Text = likes.Count.ToString();
                        
                        if (!isOwn)
                        {
                            moreButton.Visible = false;
                        }
                    }
                }
            }
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                // Owner does not liked his post.
                if (likeButtonImg.Tag.ToString() == "EmptyLike")
                {
                    countOfLikeLabel.Text = (Convert.ToInt64(countOfLikeLabel.Text) + 1).ToString();
                    likeButtonImg.Tag = "FullLike";
                    likeButtonImg.Image = Properties.Resources.FullLike;

                    // Save like.
                    Likes like = new Likes
                    {
                        id_user = user.user_id,
                        id_recipe = recipeDetails.recipe_id
                    };
                    context.Likes.Add(like);
                }
                else
                {
                    countOfLikeLabel.Text = (Convert.ToInt64(countOfLikeLabel.Text) - 1).ToString();
                    likeButtonImg.Tag = "EmptyLike";
                    likeButtonImg.Image = Properties.Resources.EmptyLike;

                    // Delete like.
                    Likes likeToDelete = context.Likes.FirstOrDefault(like => like.id_user == recipeDetails.user_id && like.id_recipe == ReceiptId);
                    if (likeToDelete != null)
                    {
                        context.Likes.Remove(likeToDelete);
                    }
                }
                context.SaveChanges();
            }
        }

        private void bookmarkButtonImage_Click(object sender, EventArgs e)
        {
            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                // Owner does not saved his post.
                if (bookmarkButtonImage.Tag.ToString() == "EmptyBookmark")
                {
                    bookmarkButtonImage.Tag = "FullBookmark";
                    bookmarkButtonImage.Image = Properties.Resources.FullBookmark;

                    // Save to bookmarks.
                    Bookmarks bookmark = new Bookmarks
                    {
                        id_user = user.user_id,
                        id_recipe = recipeDetails.recipe_id
                    };

                    context.Bookmarks.Add(bookmark);
                }
                else
                {
                    bookmarkButtonImage.Tag = "EmptyBookmark";
                    bookmarkButtonImage.Image = Properties.Resources.EmptyBookmark;

                    // Delete from bookmarks.
                    Bookmarks bookmarkToDelete = context.Bookmarks
                                                        .FirstOrDefault(bookmark => bookmark.id_user == recipeDetails.user_id &&
                                                                                    bookmark.id_recipe == ReceiptId);

                    if (bookmarkToDelete != null)
                    {
                        context.Bookmarks.Remove(bookmarkToDelete);
                    }
                }
                context.SaveChanges();
            }
        }

        private void moreButton_Click(object sender, EventArgs e)
        {
            moreOptionPanel.Visible = true;
        }

        private void moreOptionPanel_MouseLeave(object sender, EventArgs e)
        {
            if (!moreOptionPanel.Bounds.Contains(PointToClient(MousePosition)))
            {
                moreOptionPanel.Visible = false;
            }
        }

        // Deleting recipe.
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте видалити цей рецепт?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (DishesGo_dbEntities context = new DishesGo_dbEntities())
                {
                    context.Recipes.Remove(context.Recipes.FirstOrDefault(receipt => receipt.recipe_id == ReceiptId));

                    context.SaveChanges();
                }
            }
        }
    }
}
