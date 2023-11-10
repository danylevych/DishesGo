using System;
using System.Drawing;
using System.Windows.Forms;

namespace DishesGo.src.Components
{
    public partial class RecipeStepComponent : UserControl
    {
        public int StepNum { get; set; }
        public string Description { get { return stepVal.Text.Trim(); } set { stepVal.Text = value; } }
        public event EventHandler ClickSeparator;

        public RecipeStepComponent(int number)
        {
            StepNum = number;
            InitializeComponent();

            kryptonSeparator.Parent = this;

            kryptonSeparator.MouseDown += RecipeStepComponent_MouseDown;
            kryptonSeparator.MouseMove += RecipeStepComponent_MouseMove;
            kryptonSeparator.MouseUp += RecipeStepComponent_MouseUp;

            numLabel.Text = "Крок " + number.ToString() + ":";
            this.Tag = number.ToString();
        }

        public void UpdateNumber(int number)
        {
            StepNum = number;
            numLabel.Text = "Крок " + number.ToString() + ":";
            this.Tag = number.ToString();
        }

        private bool isDragging = false;
        private int originalIndex;


        private void RecipeStepComponent_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                originalIndex = this.Parent.Controls.GetChildIndex(this);
                ClickSeparator?.Invoke(kryptonSeparator, EventArgs.Empty);
                this.DoDragDrop(this, DragDropEffects.Move);
            }
        }

        private void RecipeStepComponent_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Refresh();
            }
        }

        private void RecipeStepComponent_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            //ClickSeparator(kryptonSeparator, EventArgs.Empty);
            this.Refresh();
        }
    }
}
