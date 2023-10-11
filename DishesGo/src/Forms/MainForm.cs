using ComponentFactory.Krypton.Toolkit;
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
                    Image image = Image.FromStream(ms);

                    userPhoto.Image = image;
                }
            }

            System.Drawing.Drawing2D.GraphicsPath obj = new System.Drawing.Drawing2D.GraphicsPath();
            obj.AddEllipse(0, 0, userPhoto.Width, userPhoto.Height);
            userPhoto.Region = new Region(obj);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CropeImage()
        {
            System.Drawing.Drawing2D.GraphicsPath obj = new System.Drawing.Drawing2D.GraphicsPath();
            obj.AddEllipse(0, 0, userPhoto.Width, userPhoto.Height);

        }

        private void userPhoto_Click(object sender, EventArgs e)
        {
            photoLine.Visible = true;
        }
    }
}
