using DishesGo.Data;
using DishesGo.src.Components.Recipe;
using DishesGo.src.Elements;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;

namespace DishesGo.src.Components.ProfilePlates
{
    public partial class UserProfilePlateComponent :
#if DEBUG
        MiddleProfilePlateComponent
#else
        ProfilePlateComponent
#endif
    {
        public EventHandler BackButtonClick { set { backButton.Click += value; } }

        public UserProfilePlateComponent(Users user, Image userPhoto, Users caller)
            : base(user, userPhoto)
        {
            InitializeComponent();

            if (caller.user_id == user.user_id) // User cannot follow by himself.
            {
                followingEvent.Visible = false;
            }

            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                if (context.Subscriptions.Any(s => s.subscriber_id == caller.user_id && s.target_user_id == user.user_id))
                {
                    followingEvent.ForeColor = SystemColors.ControlDarkDark;
                    followingEvent.Text = "Підписаний";
                    followingEvent.Tag = true;
                }
                else
                {
                    followingEvent.ForeColor = Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
                    followingEvent.Text = "Підписатися";
                    followingEvent.Tag = false;
                }
            }

            followingEvent.Click += (sender, e) => {
                bool isSub = (bool)followingEvent.Tag;
                using (DishesGo_dbEntities context = new DishesGo_dbEntities())
                {
                    if (isSub)
                    {
                        followingEvent.Tag = false;
                        followingEvent.ForeColor = Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
                        followingEvent.Text = "Підписатися";

                        var deleteSub = context.Subscriptions.FirstOrDefault(s => s.subscriber_id == caller.user_id && s.target_user_id == user.user_id);
                        if (deleteSub != null)
                        { 
                            context.Subscriptions.Remove(deleteSub);
                        }
                    }
                    else
                    {
                        followingEvent.Tag = true;
                        followingEvent.ForeColor = SystemColors.ControlDarkDark;
                        followingEvent.Text = "Підписаний";

                        Subscription subscription = new Subscription()
                        {
                            subscriber_id = caller.user_id,
                            target_user_id = user.user_id
                        };
                        context.Subscriptions.Add(subscription);
                    }

                    context.SaveChanges();
                }
            };
        }

        protected override void AddRecipe(Recipes recipe)
        {
            RecipeComponent ownRecipe = new UserRecipeComponent(recipe, user);
            ownRecipe.Parent = this;
            recipesPanel.Controls.Add(ownRecipe);
        }
    }
}
