using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
using DishesGo.src.Components;
using DishesGo.src.Elements;
using DishesGo.src.Forms;
using DishesGo.src.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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

        private void settingsPanel_MouseLeave(object sender, EventArgs e)
        {
            settingsPanel.Visible = !settingsPanel.Visible;
        }

        // Exit from account.
        private void exitFromProfile_Click(object sender, EventArgs e)
        {
            File.WriteAllText(configs.userDataPath, string.Empty); // Rewrite user data file.
            MainForm.Instance.Close();                             // Close MainForm.
            Application.Run(new RegistrLoginForm());               // Run RegistrationForm.
        }

        private void editPtofileButton_Click(object sender, EventArgs e)
        {
            EditUserForm editUserForm = new EditUserForm(user);
            MainForm.Instance.Hide();
            editUserForm.ShowDialog(MainForm.Instance);
            MainForm.Instance.Show();
        }

        private void bookMarksButton_Click(object sender, EventArgs e)
        {
            BookmarksForm bookmarksForm = new BookmarksForm(user.user_id);
            MainForm.Instance.Hide();
            bookmarksForm.ShowDialog(MainForm.Instance);
            MainForm.Instance.Show();
        }

        private void HideLines()
        {
            photoLine.Visible = false;
            addLine.Visible = false;
        }

        private void userPhoto_Click(object sender, EventArgs e)
        {
            HideLines();
            contextPanel.Controls.Clear();

            if (!photoLine.Visible)
            {
                photoLine.Visible = true;
                ProfilePlateComponent profilePlate = new ProfilePlateComponent(user, userPhoto.Image);
                profilePlate.Dock = DockStyle.Fill;
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
                AddRecipePlateComponent addRecipePlate = new AddRecipePlateComponent();
                addRecipePlate.Dock = DockStyle.Fill;
                contextPanel.Controls.Add(addRecipePlate);
            }
        }
    }
}
