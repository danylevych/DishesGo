namespace DishesGo.src.Elements
{
    partial class OwnRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnRecipe));
            this.recipeImg = new System.Windows.Forms.PictureBox();
            this.recipeName = new System.Windows.Forms.Label();
            this.recipeDescription = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.recipeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // recipeImg
            // 
            this.recipeImg.Location = new System.Drawing.Point(15, 15);
            this.recipeImg.Name = "recipeImg";
            this.recipeImg.Size = new System.Drawing.Size(152, 120);
            this.recipeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recipeImg.TabIndex = 0;
            this.recipeImg.TabStop = false;
            // 
            // recipeName
            // 
            this.recipeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recipeName.AutoSize = true;
            this.recipeName.Font = new System.Drawing.Font("Russo One", 13F);
            this.recipeName.Location = new System.Drawing.Point(210, 15);
            this.recipeName.Name = "recipeName";
            this.recipeName.Size = new System.Drawing.Size(60, 22);
            this.recipeName.TabIndex = 6;
            this.recipeName.Text = "name";
            // 
            // recipeDescription
            // 
            this.recipeDescription.Font = new System.Drawing.Font("Russo One", 9F);
            this.recipeDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recipeDescription.Location = new System.Drawing.Point(211, 54);
            this.recipeDescription.Name = "recipeDescription";
            this.recipeDescription.Size = new System.Drawing.Size(419, 81);
            this.recipeDescription.TabIndex = 8;
            this.recipeDescription.Text = resources.GetString("recipeDescription.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.pictureBox1.Location = new System.Drawing.Point(185, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(7, 130);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // OwnRecipe
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.recipeDescription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.recipeName);
            this.Controls.Add(this.recipeImg);
            this.Name = "OwnRecipe";
            this.Size = new System.Drawing.Size(648, 150);
            ((System.ComponentModel.ISupportInitialize)(this.recipeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox recipeImg;
        private System.Windows.Forms.Label recipeName;
        private System.Windows.Forms.Label recipeDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
