using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishesGo.src.dbClasses
{
    public class SQLConection
    {
        private static SqlConnection instance;

        private SQLConection() { }

        public static void SetInstance(string conectionString)
        {
            if (instance == null && conectionString != "") 
            {
                instance = new SqlConnection(conectionString);
                instance.Open();
            }
            else if (instance != null && conectionString != "")
            {
                instance.Close();
                instance = new SqlConnection(conectionString);
                instance.Open();
            }
        }

        public static void Close()
        {
            instance?.Close();
        }

        public static SqlConnection Instance { get { return instance; } set { instance = value; } }
    }
}
