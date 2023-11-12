﻿namespace DishesGo.src.Components.Recipe
{
    partial class SearchRecipeComponent
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
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.userPhoto = new RashiUI.RashiCircularPictureBox();
            this.recipeNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recipeImg)).BeginInit();
            this.recipeImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.border)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // recipeImg
            // 
            this.recipeImg.Size = new System.Drawing.Size(220, 197);
            // 
            // border
            // 
            this.border.Size = new System.Drawing.Size(220, 198);
            this.border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.SystemColors.Control;
            this.bottomPanel.Controls.Add(this.recipeNameLabel);
            this.bottomPanel.Controls.Add(this.nicknameLabel);
            this.bottomPanel.Controls.Add(this.userPhoto);
            this.bottomPanel.Location = new System.Drawing.Point(0, 184);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(220, 56);
            this.bottomPanel.TabIndex = 1;
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nicknameLabel.Font = new System.Drawing.Font("Russo One", 7F);
            this.nicknameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.nicknameLabel.Location = new System.Drawing.Point(39, 35);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(52, 12);
            this.nicknameLabel.TabIndex = 18;
            this.nicknameLabel.Text = "nickname";
            // 
            // userPhoto
            // 
            this.userPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.userPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userPhoto.Border = 1;
            this.userPhoto.BorderCap = System.Drawing.Drawing2D.DashCap.Round;
            this.userPhoto.Borderstyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.userPhoto.ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
            this.userPhoto.ColorBorder2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.userPhoto.Gradiant = 50F;
            this.userPhoto.Location = new System.Drawing.Point(8, 28);
            this.userPhoto.Name = "userPhoto";
            this.userPhoto.Size = new System.Drawing.Size(25, 25);
            this.userPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPhoto.TabIndex = 17;
            this.userPhoto.TabStop = false;
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recipeNameLabel.AutoSize = true;
            this.recipeNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.recipeNameLabel.Font = new System.Drawing.Font("Russo One", 10F);
            this.recipeNameLabel.Location = new System.Drawing.Point(5, 10);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(90, 17);
            this.recipeNameLabel.TabIndex = 19;
            this.recipeNameLabel.Text = "recipeName";
            // 
            // SearchRecipeComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bottomPanel);
            this.Name = "SearchRecipeComponent";
            this.Controls.SetChildIndex(this.recipeImg, 0);
            this.Controls.SetChildIndex(this.bottomPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.recipeImg)).EndInit();
            this.recipeImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.border)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label nicknameLabel;
        private RashiUI.RashiCircularPictureBox userPhoto;
        private System.Windows.Forms.Label recipeNameLabel;
    }
}
