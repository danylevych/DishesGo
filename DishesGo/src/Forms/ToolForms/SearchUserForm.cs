using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
using DishesGo.src.Components;
using DishesGo.src.Components.ProfilePlates;
using DishesGo.src.Components.Recipe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DishesGo.src.Forms.ToolForms
{
    public partial class SearchUserForm : KryptonForm
    {
        private readonly Users caller;

        public SearchUserForm(Users caller)
        {
            InitializeComponent();
            this.caller = caller;

            searchTextBox.Enter += (sender, e) => {
                if ((searchTextBox.Text.Trim() == "Пошук..."))
                {
                    searchTextBox.Text = string.Empty;
                }
            };

            searchTextBox.Leave += (sender, e) => {
                if ((searchTextBox.Text.Trim() == string.Empty))
                {
                    searchTextBox.Text = "Пошук...";
                }
            };

            searchTextBox.KeyDown += (sender, e) => {
                if (e.KeyCode == Keys.Enter)
                {
                    if (searchTextBox.Text.Trim() != string.Empty && searchTextBox.Text.Trim() != "Пошук...")
                    {
                        using (DishesGo_dbEntities context = new DishesGo_dbEntities())
                        { 
                            var listOfUser = context.Users.Where(u => u.user_id != caller.user_id && u.nickname.Contains(searchTextBox.Text.Trim())).ToList();

                            foreach (var user in listOfUser)
                            {
                                UserComponent userComponent = new UserComponent(caller, user)
                                {
                                    Parent = this
                                };
                                usersPanel.Controls.Add(userComponent);
                            }
                        }
                    }
                    else
                    {
                        usersPanel.Controls.Clear();
                    }

                    this.ActiveControl = null;
                }
            };

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
