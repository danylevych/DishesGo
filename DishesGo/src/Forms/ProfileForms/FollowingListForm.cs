using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
using DishesGo.src.Components;
using DishesGo.src.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DishesGo.src.Forms.ProfileForms
{
    public partial class FollowingListForm : KryptonForm
    {
        public FollowingListForm(int userId)
        {
            InitializeComponent();
            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                List<Subscription> subscriptions = context.Subscriptions.Where(sub => sub.subscriber_id == userId).ToList();

                if (subscriptions.Count > 0) // User have some bookmarks.
                {
                    foreach (var subscription in subscriptions)
                    {
                        UserComponent userComponent = new UserComponent(subscription)
                        {
                            Parent = this
                        };
                        usersPanel.Controls.Add(userComponent);
                    }
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
