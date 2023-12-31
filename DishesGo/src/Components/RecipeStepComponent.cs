﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace DishesGo.src.Components
{
    public partial class RecipeStepComponent : UserControl
    {
        public int StepNum { get; set; }
        public string Description { get { return stepVal.Text.Trim(); } set { stepVal.Text = value; } }
        public event EventHandler ClickSeparator;

        public RecipeStepComponent(RecipeStepComponent other)
        {
            InitializeComponent();

            StepNum = other.StepNum;
            Description = other.Description;

            kryptonSeparator.Parent = this;

            kryptonSeparator.MouseDown += RecipeStepComponent_MouseDown;
            kryptonSeparator.MouseMove += RecipeStepComponent_MouseMove;
            kryptonSeparator.MouseUp += RecipeStepComponent_MouseUp;

            numLabel.Text = "Крок " + StepNum.ToString() + ":";
            this.Tag = StepNum.ToString();
        }

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


        // Comparing mhetods.
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            RecipeStepComponent other = (RecipeStepComponent)obj;

            // Порівнюємо об'єкти за значенням
            return StepNum == other.StepNum && Description == other.Description;
        }

        public override int GetHashCode()
        {
            // Генеруємо унікальний хеш-код на основі полів, які використовуються у Equals
            return StepNum.GetHashCode() ^ Description?.GetHashCode() ?? 0;
        }

        public static bool operator ==(RecipeStepComponent left, RecipeStepComponent right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (left is null || right is null)
            {
                return false;
            }

            return left.Equals(right);
        }

        public static bool operator !=(RecipeStepComponent left, RecipeStepComponent right)
        {
            return !(left == right);
        }
    }
}
