using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DishesGo.src.Components
{
    public partial class RecipeStepComponent : UserControl
    {
        public int StepNum { get; set; }
        public string Description { get { return stepVal.Text.Trim(); } }


        public RecipeStepComponent(int number)
        {
            StepNum = number;
            InitializeComponent();

            numLabel.Text = "Крок " + number.ToString() + ":";
            this.Tag = number.ToString();
        }

        public void UpdateNumber(int number)
        {
            StepNum = number;
            numLabel.Text = "Крок " + number.ToString() + ":";
            this.Tag = number.ToString();
        }
    }
}
