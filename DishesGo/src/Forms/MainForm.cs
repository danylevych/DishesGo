﻿using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
using DishesGo.src.Components;
using DishesGo.src.Components.ProfilePlates;
using DishesGo.src.Elements;
using DishesGo.src.Forms;
using DishesGo.src.Forms.ToolForms;
using DishesGo.src.tools;
using System;
using System.Drawing;
using System.IO;
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

            mainPanel.Click += HideSettings;
            contextPanel.Click += HideSettings;

            search_Click(this, EventArgs.Empty); // Start menu for user interface will be search panel.
        }

        public void Refresh(Users user)
        {
            if (user == null) // We heven't any changings.
            {
                return;
            }

            this.user = user;

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

            userPhoto_Click(this, EventArgs.Empty); // Update the profile plate.
        }



        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Settings section.
        private void settings_Click(object sender, System.EventArgs e)
        {
            settingsPanel.Visible = !settingsPanel.Visible;
        }

        private void HideSettings(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
        }

        // Exit from account.
        private void exitFromProfile_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте вийти?", "Підтвердження виходу", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.WriteAllText(configs.userDataPath, string.Empty); // Rewrite user data file.
                MainForm.Instance.Close();                             // Close MainForm.
                Application.Run(new RegistrLoginForm());               // Run RegistrationForm.
            }
        }

        private void editPtofileButton_Click(object sender, EventArgs e)
        {
            using (BackgroundForm backgroundForm = new BackgroundForm(MainForm.Instance))
            {
                EditUserForm editUserForm = new EditUserForm(user);
                editUserForm.ShowDialog(backgroundForm);
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
            settingsPanel.Visible = false; // We hide the setings panel.

            searchLine.Visible = false;
            photoLine.Visible = false;
            addLine.Visible = false;
        }

        public void userPhoto_Click(object sender, EventArgs e)
        {
            HideLines();
            contextPanel.Controls.Clear();

            if (!photoLine.Visible)
            {
                photoLine.Visible = true;

                ProfilePlateComponent profilePlate = new OwnProfilePlateComponent(user, userPhoto.Image);
                profilePlate.Dock = DockStyle.Fill;
                profilePlate.Click += HideSettings;
                contextPanel.Controls.Add(profilePlate);
            }
        }

        private void addRecipe_Click(object sender, EventArgs e)
        {
            HideLines();
            contextPanel.Controls.Clear();

            if (!addLine.Visible)
            {
                contextPanel.Controls.Clear();
                addLine.Visible = true;

                AddRecipePlateComponent addRecipePlate = new AddRecipePlateComponent(user.user_id);
                addRecipePlate.Dock = DockStyle.Fill;
                addRecipePlate.Click += HideSettings;
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
                searchPlateComponent.Click += HideSettings;
                contextPanel.Controls.Add(searchPlateComponent);
            }
        }
    }
}
