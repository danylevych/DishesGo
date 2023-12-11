using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
using DishesGo.src.Components;
using DishesGo.src.Components.ProfilePlates;
using DishesGo.src.Components.Recipe;
using DishesGo.src.Elements;
using DishesGo.src.Forms;
using DishesGo.src.Forms.ToolForms;
using DishesGo.src.tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DishesGo.src
{
    public partial class MainForm : KryptonForm
    {
        private static MainForm instance;
        public static MainForm Instance
        {
            get
            {
                return instance;
            }
        }

        public KryptonPanel Context
        {
            get
            {
                return contextPanel;
            }
        }

        private Users user;


        public MainForm(Users user)
        {
            instance = this;

            this.user = user;
            InitializeComponent();

            if (this.user.user_photo == null)
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

            home_Click(this, EventArgs.Empty); // Start menu for user interface will be search panel.
        }

        public void Refresh(bool refresh = true) 
        {
            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                user = context.Users.FirstOrDefault(u => u.user_id == user.user_id);
            }

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

            userPhoto_Click(this, EventArgs.Empty); // Update the profile plate.
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Exit from account.
        private void exitFromProfile_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте вийти?", "Підтвердження виходу", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.WriteAllText(configs.userDataPath, string.Empty); // Rewrite user data file.
                MainForm.Instance.Close();                             // Close MainForm.
                Application.Restart();                                 // Run RegistrationForm.
            }
        }

        private Users GetUser()
        {
            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                return context.Users.FirstOrDefault(u => u.user_id == user.user_id);
            }
        }

        private void bookMarksButton_Click(object sender, EventArgs e)
        {
            using (BackgroundForm backgroundForm = new BackgroundForm(MainForm.Instance))
            {
                BookmarksForm bookmarksForm = new BookmarksForm(user.user_id);
                bookmarksForm.ShowDialog(backgroundForm);
            }
        }

        private void HideLines()
        {
            searchLine.Visible = false;
            photoLine.Visible = false;
            addLine.Visible = false;
            findUserLine.Visible = false;
            homeLine.Visible = false;
        }

        public void userPhoto_Click(object sender, EventArgs e)
        {
            HideLines();
            contextPanel.Controls.Clear();

            if (!photoLine.Visible)
            {
                photoLine.Visible = true;

                ProfilePlateComponent profilePlate = new OwnProfilePlateComponent(GetUser(), userPhoto.Image);
                profilePlate.Dock = DockStyle.Fill;

                contextPanel.Controls.Add(profilePlate);
            }
        }

        public void addRecipe_Click(object sender, EventArgs e)
        {
            HideLines();
            contextPanel.Controls.Clear();

            if (!addLine.Visible)
            {
                contextPanel.Controls.Clear();
                addLine.Visible = true;

                AddRecipePlateComponent addRecipePlate = new AddRecipePlateComponent(user.user_id);
                addRecipePlate.Dock = DockStyle.Fill;

                contextPanel.Controls.Add(addRecipePlate);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            HideLines();
            contextPanel.Controls.Clear();

            if (!searchLine.Visible)
            {
                contextPanel.Controls.Clear();
                searchLine.Visible = true;

                SearchPlateComponent searchPlateComponent = new SearchPlateComponent(user.user_id);
                searchPlateComponent.Dock = DockStyle.Fill;

                contextPanel.Controls.Add(searchPlateComponent);
            }
        }

        private void findUser_Click(object sender, EventArgs e)
        {            
            findUserLine.Visible = true;
            using (BackgroundForm background = new BackgroundForm(this))
            {
                using (SearchUserForm searchuserForm = new SearchUserForm(GetUser()))
                {
                    searchuserForm.ShowDialog(background);
                }
            }
            findUserLine.Visible = false;
        }

        private void home_Click(object sender, EventArgs e)
        {
            HideLines();

            if (!homeLine.Visible)
            {
                contextPanel.Controls.Clear();

                homeLine.Visible = true;

                FlowLayoutPanel flowLayout = new FlowLayoutPanel();
                flowLayout.Dock = DockStyle.Fill;
                flowLayout.AutoScroll = true;  // Enable automatic scrolling
                flowLayout.BackColor = SystemColors.ControlLight;

                contextPanel.Controls.Add(flowLayout);

                LoadRecipes(flowLayout);
            }
        }

        private void LoadRecipes(FlowLayoutPanel flowLayout)
        {
            List<Subscription> followings;
            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                followings = context.Users.FirstOrDefault(u => u.user_id == user.user_id)?.Following.ToList();

                if (followings == null) // Set empty list if user doesn't have followings.
                {
                    followings = new List<Subscription>();
                }


                List<Recipes> allRecipes = new List<Recipes>();
                foreach (var followingUser in followings)
                {
                    allRecipes.AddRange(followingUser.User1.Recipes.OrderByDescending(r => r.posting_date));
                }

                // Set a certain number of recipes to initially display
                int recipesToShow = 30;

                foreach (var recipe in allRecipes.Take(recipesToShow))
                {
                    AddRecipeToFlowLayout(flowLayout, recipe);
                }

                // Add a Scroll event handler to load additional recipes when scrolling to the bottom
                flowLayout.Scroll += (s, e) =>
                {
                    if (flowLayout.VerticalScroll.Value + flowLayout.Height >= flowLayout.VerticalScroll.Maximum)
                    {
                        // The user has scrolled to the bottom, load additional recipes
                        int additionalRecipesToShow = 5;
                        int nextIndex = flowLayout.Controls.Count;
                        foreach (var recipe in allRecipes.Skip(nextIndex).Take(additionalRecipesToShow))
                        {
                            AddRecipeToFlowLayout(flowLayout, recipe);
                        }
                    }
                };
            }
        }

        // Add a recipe to FlowLayoutPanel
        private void AddRecipeToFlowLayout(FlowLayoutPanel flowLayout, Recipes recipe)
        {
            // Create a control for displaying the recipe (e.g., UserControl or Panel)
            SearchRecipeComponent recipeControl = new SearchRecipeComponent(recipe, recipe.Users, GetUser());

            // Add the control to FlowLayoutPanel
            flowLayout.Controls.Add(recipeControl);
        }
    }
}
