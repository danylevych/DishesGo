using System;

namespace DishesGo.src.Components
{
    abstract partial class RecipeComponent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.border = new System.Windows.Forms.PictureBox();
            this.recipeImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeImg)).BeginInit();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.Transparent;
            this.border.Image = global::DishesGo.Properties.Resources.border;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(220, 240);
            this.border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.border.TabIndex = 1;
            this.border.TabStop = false;
            this.border.Click += new System.EventHandler(this.border_Click);
            // 
            // recipeImg
            // 
            this.recipeImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recipeImg.BackColor = System.Drawing.Color.Black;
            this.recipeImg.Image = global::DishesGo.Properties.Resources.titlePhoto;
            this.recipeImg.Location = new System.Drawing.Point(0, 0);
            this.recipeImg.Name = "recipeImg";
            this.recipeImg.Size = new System.Drawing.Size(220, 240);
            this.recipeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recipeImg.TabIndex = 0;
            this.recipeImg.TabStop = false;
            // 
            // RecipeComponent
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cell;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.border);
            this.Controls.Add(this.recipeImg);
            this.Name = "RecipeComponent";
            this.Size = new System.Drawing.Size(220, 240);
            ((System.ComponentModel.ISupportInitialize)(this.border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.PictureBox recipeImg;
        protected System.Windows.Forms.PictureBox border;

        abstract protected void border_Click(object sender, EventArgs e);
    }
}
