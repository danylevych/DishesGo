using DishesGo.Data;
using DishesGo.src;
using DishesGo.src.dbClasses;
using DishesGo.src.tools;
using Newtonsoft.Json;
using System;
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
        }
    }
}
