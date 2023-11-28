using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
using DishesGo.src.Components.ProfilePlates;
using DishesGo.src.Elements;
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

namespace DishesGo.src.Forms.ToolForms
{
    public partial class ViewUserForm : KryptonForm
    {
        public ViewUserForm(Users user, Users caller)
        {
            InitializeComponent();
            Image image;
            if (user.user_photo == null)
            {
                image = Properties.Resources.withoutPhoto;
            }
            else
            {
                using (MemoryStream ms = new MemoryStream(user.user_photo))
                {
                    image = Image.FromStream(ms);
                }
            }

            var userProfile = new UserProfilePlateComponent(user, image, caller);
            userProfile.BackButtonClick = (sender, e) => this.Close();
            userProfile.Dock = DockStyle.Fill;

            context.Controls.Add(userProfile);
        }
    }
}
