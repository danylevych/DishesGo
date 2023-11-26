using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DishesGo.src.Forms.ToolForms
{
    // Is the background beetwen two forms.
    public partial class BackgroundForm : Form
    {
        public BackgroundForm(Form baseForm)
        {
            InitializeComponent();

            ControlBox = false;
            MinimizeBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Text = "";
            Size = baseForm.Size;
            BackColor = Color.Black;
            Opacity = 0.8f;

            Location = new Point(baseForm.Left, baseForm.Top);

            Show(baseForm);
        }

    }
}
