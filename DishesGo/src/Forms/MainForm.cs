using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
using DishesGo.src.Elements;
using DishesGo.src.tools;
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

namespace DishesGo.src
{
    public partial class MainForm : KryptonForm
    {
        private Users user;

        public MainForm(Users user)
        {
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

            // Set user's info.
            /*profileImg.Image = userPhoto.Image;
            nicknameLabel.Text = user.nickname;
            profileNameLabel.Text = user?.last_name + " " + user?.first_name;*/
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void userPhoto_Click(object sender, EventArgs e)
        {
            if (photoLine.Visible)
            {
                photoLine.Visible = false;
                contextPanel.Controls.Clear();
            }
            else
            {
                photoLine.Visible = true;
                ProfilePlate profilePlate = new ProfilePlate(user, userPhoto.Image);
                profilePlate.Dock = DockStyle.Fill;
                contextPanel.Controls.Add(profilePlate);

            }
        }
    }
}
