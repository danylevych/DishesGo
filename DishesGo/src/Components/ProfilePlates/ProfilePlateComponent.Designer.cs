namespace DishesGo.src.Elements
{
    abstract partial class ProfilePlateComponent
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
            this.recipesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.profileImg = new RashiUI.RashiCircularPictureBox();
            this.followersLabel = new System.Windows.Forms.Label();
            this.followingLabel = new System.Windows.Forms.Label();
            this.followersCount = new System.Windows.Forms.Label();
            this.followingCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).BeginInit();
            this.SuspendLayout();
            // 
            // recipesPanel
            // 
            this.recipesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recipesPanel.AutoScroll = true;
            this.recipesPanel.Location = new System.Drawing.Point(36, 199);
            this.recipesPanel.Name = "recipesPanel";
            this.recipesPanel.Size = new System.Drawing.Size(760, 223);
            this.recipesPanel.TabIndex = 11;
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nicknameLabel.Font = new System.Drawing.Font("Russo One", 14.25F);
            this.nicknameLabel.Location = new System.Drawing.Point(243, 74);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(101, 23);
            this.nicknameLabel.TabIndex = 10;
            this.nicknameLabel.Text = "nickname";
            // 
            // profileNameLabel
            // 
            this.profileNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.profileNameLabel.AutoSize = true;
            this.profileNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.profileNameLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.profileNameLabel.Location = new System.Drawing.Point(243, 116);
            this.profileNameLabel.Name = "profileNameLabel";
            this.profileNameLabel.Size = new System.Drawing.Size(83, 19);
            this.profileNameLabel.TabIndex = 9;
            this.profileNameLabel.Text = "fullName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.pictureBox1.Location = new System.Drawing.Point(36, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 5);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // profileImg
            // 
            this.profileImg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.profileImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profileImg.Border = 1;
            this.profileImg.BorderCap = System.Drawing.Drawing2D.DashCap.Round;
            this.profileImg.Borderstyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.profileImg.ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
            this.profileImg.ColorBorder2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.profileImg.Gradiant = 50F;
            this.profileImg.Location = new System.Drawing.Point(93, 40);
            this.profileImg.Name = "profileImg";
            this.profileImg.Size = new System.Drawing.Size(124, 124);
            this.profileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileImg.TabIndex = 8;
            this.profileImg.TabStop = false;
            // 
            // followersLabel
            // 
            this.followersLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.followersLabel.AutoSize = true;
            this.followersLabel.BackColor = System.Drawing.Color.Transparent;
            this.followersLabel.Font = new System.Drawing.Font("Russo One", 8F);
            this.followersLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.followersLabel.Location = new System.Drawing.Point(442, 111);
            this.followersLabel.Name = "followersLabel";
            this.followersLabel.Size = new System.Drawing.Size(75, 13);
            this.followersLabel.TabIndex = 12;
            this.followersLabel.Text = "Підписники";
            // 
            // followingLabel
            // 
            this.followingLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.followingLabel.AutoSize = true;
            this.followingLabel.BackColor = System.Drawing.Color.Transparent;
            this.followingLabel.Font = new System.Drawing.Font("Russo One", 8F);
            this.followingLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.followingLabel.Location = new System.Drawing.Point(537, 111);
            this.followingLabel.Name = "followingLabel";
            this.followingLabel.Size = new System.Drawing.Size(61, 13);
            this.followingLabel.TabIndex = 13;
            this.followingLabel.Text = "Підписка";
            // 
            // followersCount
            // 
            this.followersCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.followersCount.BackColor = System.Drawing.Color.Transparent;
            this.followersCount.Font = new System.Drawing.Font("Russo One", 10F);
            this.followersCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.followersCount.Location = new System.Drawing.Point(442, 91);
            this.followersCount.Name = "followersCount";
            this.followersCount.Size = new System.Drawing.Size(81, 17);
            this.followersCount.TabIndex = 15;
            this.followersCount.Text = "1";
            this.followersCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // followingCount
            // 
            this.followingCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.followingCount.BackColor = System.Drawing.Color.Transparent;
            this.followingCount.Font = new System.Drawing.Font("Russo One", 10F);
            this.followingCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.followingCount.Location = new System.Drawing.Point(527, 91);
            this.followingCount.Name = "followingCount";
            this.followingCount.Size = new System.Drawing.Size(81, 17);
            this.followingCount.TabIndex = 16;
            this.followingCount.Text = "1";
            this.followingCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProfilePlateComponent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.followingCount);
            this.Controls.Add(this.followersCount);
            this.Controls.Add(this.followingLabel);
            this.Controls.Add(this.followersLabel);
            this.Controls.Add(this.recipesPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.profileNameLabel);
            this.Controls.Add(this.profileImg);
            this.Name = "ProfilePlateComponent";
            this.Size = new System.Drawing.Size(832, 462);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.FlowLayoutPanel recipesPanel;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Label nicknameLabel;
        protected System.Windows.Forms.Label profileNameLabel;
        protected RashiUI.RashiCircularPictureBox profileImg;
        protected System.Windows.Forms.Label followersLabel;
        protected System.Windows.Forms.Label followingLabel;
        protected System.Windows.Forms.Label followersCount;
        protected System.Windows.Forms.Label followingCount;
    }
}
