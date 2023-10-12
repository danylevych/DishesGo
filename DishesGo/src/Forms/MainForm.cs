using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
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

            //userPhoto.Image = ImageRedactor.ResizeImage(userPhoto.Image, 30, 30);
            
            //userPhoto.Region = ImageRedactor.CropAsElips(userPhoto);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void userPhoto_Click(object sender, EventArgs e)
        {
            photoLine.Visible = true;
        }
    }
}
