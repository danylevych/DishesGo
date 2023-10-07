using DishesGo.src.dbClasses;
using DishesGo.src.tools;
using System;
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
            SQLConection.SetInstance(configs.conectionString); // Create the instance of sql con.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegistrLoginForm());
        }
    }
}
