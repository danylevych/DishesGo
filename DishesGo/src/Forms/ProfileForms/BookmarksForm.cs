using ComponentFactory.Krypton.Toolkit;
using DishesGo.Data;
using DishesGo.src.Elements;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
                        BookmarksComponent bookmarksComponent = new BookmarksComponent(bookmark)
                        {
                            Parent = this
                        };
                        bookmarksPanel.Controls.Add(bookmarksComponent);
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
