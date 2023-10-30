namespace DishesGo.src.Elements
{
    partial class BookmarksComponent
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
            this.dishPhoto = new System.Windows.Forms.PictureBox();
            this.borderPhoto = new System.Windows.Forms.PictureBox();
            this.userPhoto = new RashiUI.RashiCircularPictureBox();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.recipeNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dishPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dishPhoto
            // 
            this.dishPhoto.Image = global::DishesGo.Properties.Resources.titlePhoto;
            this.dishPhoto.Location = new System.Drawing.Point(0, 0);
            this.dishPhoto.Name = "dishPhoto";
            this.dishPhoto.Size = new System.Drawing.Size(50, 50);
            this.dishPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dishPhoto.TabIndex = 0;
            this.dishPhoto.TabStop = false;
            // 
            // borderPhoto
            // 
            this.borderPhoto.BackColor = System.Drawing.Color.Transparent;
            this.borderPhoto.Image = global::DishesGo.Properties.Resources.border;
            this.borderPhoto.Location = new System.Drawing.Point(0, 0);
            this.borderPhoto.Name = "borderPhoto";
            this.borderPhoto.Size = new System.Drawing.Size(50, 50);
            this.borderPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.borderPhoto.TabIndex = 0;
            this.borderPhoto.TabStop = false;
            this.borderPhoto.Click += new System.EventHandler(this.BookmarksComponent_Click);
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
            this.userPhoto.Location = new System.Drawing.Point(53, 24);
            this.userPhoto.Name = "userPhoto";
            this.userPhoto.Size = new System.Drawing.Size(25, 25);
            this.userPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPhoto.TabIndex = 4;
            this.userPhoto.TabStop = false;
            this.userPhoto.Click += new System.EventHandler(this.BookmarksComponent_Click);
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nicknameLabel.Font = new System.Drawing.Font("Russo One", 7F);
            this.nicknameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.nicknameLabel.Location = new System.Drawing.Point(84, 32);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(52, 12);
            this.nicknameLabel.TabIndex = 16;
            this.nicknameLabel.Text = "nickname";
            this.nicknameLabel.Click += new System.EventHandler(this.BookmarksComponent_Click);
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recipeNameLabel.AutoSize = true;
            this.recipeNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.recipeNameLabel.Font = new System.Drawing.Font("Russo One", 10F);
            this.recipeNameLabel.Location = new System.Drawing.Point(56, 4);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(90, 17);
            this.recipeNameLabel.TabIndex = 17;
            this.recipeNameLabel.Text = "recipeName";
            this.recipeNameLabel.Click += new System.EventHandler(this.BookmarksComponent_Click);
            // 
            // BookmarksComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.recipeNameLabel);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.userPhoto);
            this.Controls.Add(this.borderPhoto);
            this.Controls.Add(this.dishPhoto);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "BookmarksComponent";
            this.Size = new System.Drawing.Size(225, 50);
            this.Click += new System.EventHandler(this.BookmarksComponent_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dishPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dishPhoto;
        private System.Windows.Forms.PictureBox borderPhoto;
        private RashiUI.RashiCircularPictureBox userPhoto;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Label recipeNameLabel;
    }
}
