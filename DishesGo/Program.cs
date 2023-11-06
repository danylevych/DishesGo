using DishesGo.Data;
using DishesGo.src;
using DishesGo.src.dbClasses;
using DishesGo.src.Forms.ToolForms;
using DishesGo.src.tools;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DishesGo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if false
            Image image = Image.FromFile("D:\\OneDrive\\Pictures\\Знімки екрана\\Знімок екрана (1).png");
            
            var form = new CropingImage(image);
            Application.Run(form);
            Image image1 = form.OutImage;
            image = image1;

            

#else
            JsonUserData userData = new JsonUserData()
            {
                email = "",
                nickname = "",
                isLogined = false
            };

            // If the file with user data exists and it is not empty.
            if (File.Exists(configs.userDataPath))
            {
                string jsonText = File.ReadAllText(configs.userDataPath);
                if (jsonText != "")
                {
                    userData = JsonConvert.DeserializeObject<JsonUserData>(jsonText);
                }
            }

            if (userData.isLogined)
            {
                using (DishesGo_dbEntities db = new DishesGo_dbEntities())
                {
                    Users currentUser = db.Users.FirstOrDefault(user => user.email == userData.email || user.nickname == userData.nickname);
                    if (currentUser != null)
                    {
                        Application.Run(new MainForm(currentUser));
                    }
                    else
                    {
                        Application.Run(new RegistrLoginForm());
                    }
                }
            }
            else
            {
                Application.Run(new RegistrLoginForm());
            }
#endif
        }
    }
}
