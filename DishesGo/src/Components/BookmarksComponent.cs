using DishesGo.Data;
using DishesGo.src.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace DishesGo.src.Elements
{
    public partial class BookmarksComponent : UserControl
    {
        private Bookmarks bookmark;

        public BookmarksComponent(Bookmarks bookmark)
        {
            InitializeComponent();
            this.bookmark = bookmark;

            // Border become unvisiable.
            borderPhoto.Parent = dishPhoto;

            if(bookmark != null) 
            {
                using (DishesGo_dbEntities context = new DishesGo_dbEntities())
                {
                    // Set reciept info.
                    Recipes receipt = context.Recipes.FirstOrDefault(receiptdb => receiptdb.recipe_id == bookmark.id_recipe);

                    if (receipt != null)
                    {
                        if (receipt.recipe_photo == null)
                        {
                            dishPhoto.Image = Properties.Resources.titlePhoto;
                        }
                        else
                        {
                            using (MemoryStream ms = new MemoryStream(receipt.recipe_photo))
                            {
                                dishPhoto.Image = Image.FromStream(ms);
                            }
                        }

                        // Set the title of the recipe.
                        recipeNameLabel.Text = (receipt.title.Length > 40 ? receipt.title.Substring(0, 45) + "..." : receipt.title);

                        // Set info about user, that has added this recipe.
                        Users user = context.Users.FirstOrDefault(userdb => userdb.user_id == receipt.user_id);

                        if (user != null)
                        {
                            if (user.user_photo == null)
                            {
                                userPhoto.Image = Properties.Resources.withoutPhoto;
                            }
                            else
                            {
                                using (MemoryStream ms = new MemoryStream(user.user_photo))
                                {
                                    userPhoto.Image = Image.FromStream(ms);
                                }
                            }

                            nicknameLabel.Text = user.nickname;
                        }
                    }
                }
            }
        }

        private void BookmarksComponent_Click(object sender, EventArgs e)
        {
            Users user;
            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                user = context.Users.FirstOrDefault(userdb => userdb.user_id == bookmark.id_user);
            }

            RecipeViewerForm recipeViewerForm = new RecipeViewerForm((int)bookmark.id_recipe, user, false);
            recipeViewerForm.ShowDialog();
        }
    }
}
