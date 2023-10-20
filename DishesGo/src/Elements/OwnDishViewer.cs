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

namespace DishesGo.src.Elements
{
    public partial class OwnDishViewer : UserControl
    {
        public int ReceiptId { get; set; }

        public OwnDishViewer(int id)
        {
            ReceiptId = id;
            InitializeComponent();
        }

        public void Init()
        {
            using(DishesGo_dbEntities db =  new DishesGo_dbEntities()) 
            {
                Recipes receiptObj = db.Recipes.FirstOrDefault(receipt => receipt.recipe_id == ReceiptId);
                if (receiptObj != null) 
                {
                    if(receiptObj.recipe_photo != null)
                    {
                        using (MemoryStream ms = new MemoryStream(receiptObj.recipe_photo))
                        { 
                            dishImg.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        dishImg.Image = Properties.Resources.titlePhoto;
                        dishImg.BackColor = Color.Black;
                    }
                }
            }
        }
    }
}
