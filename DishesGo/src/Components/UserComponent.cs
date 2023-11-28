using DishesGo.Data;
using DishesGo.src.Forms.ToolForms;
using DishesGo.src.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DishesGo.src.Components
{
    public partial class UserComponent : UserControl
    {
        private Users caller;
        private Users user;

        public UserComponent(Subscription subscription)
        {
            InitializeComponent();
            this.user = subscription.User1;
            this.caller = subscription.User;

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

            this.Click += OpenProfileClick;
            userPhoto.Click += OpenProfileClick;
            this.nicknameLabel.Click += OpenProfileClick;

        }

        private void OpenProfileClick(object sender, EventArgs e) 
        {
            using (BackgroundForm background = new BackgroundForm(MainForm.Instance))
            {
                using (ViewUserForm viewUserForm = new ViewUserForm(user, caller))
                {
                    viewUserForm.ShowDialog(background);
                }
            }
        }
    }
}
