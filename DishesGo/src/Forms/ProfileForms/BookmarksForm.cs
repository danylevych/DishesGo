using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
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

namespace DishesGo.src.Forms
{
    public partial class BookmarksForm : KryptonForm
    {
        public BookmarksForm(int userId)
        {
            InitializeComponent();
            using (DishesGo_dbEntities context = new DishesGo_dbEntities()) 
            {
                List<Bookmarks> bookmarks = context.Bookmarks.Where(bookmark => bookmark.id_user == userId).ToList();

                if (bookmarks.Count > 0) // User have some bookmarks.
                {
                    foreach (var bookmark in bookmarks)
                    {
                        BookmarksComponent bookmarksComponent = new BookmarksComponent(bookmark);
                        bookmarksComponent.Parent = this;
                        bookmarksPanel.Controls.Add(bookmarksComponent);
                        bookmarksPanel.Controls.Add(new BookmarksComponent(bookmark));
                        bookmarksPanel.Controls.Add(new BookmarksComponent(bookmark));
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
