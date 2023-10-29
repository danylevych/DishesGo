namespace DishesGo.src.Elements
{
    partial class ProfilePlate
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
            this.settings = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.profileImg = new RashiUI.RashiCircularPictureBox();
            this.settingsPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.bookMarksButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.exitFromProfile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.editPtofileButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
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
            this.nicknameLabel.Location = new System.Drawing.Point(325, 67);
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
            this.profileNameLabel.Location = new System.Drawing.Point(325, 112);
            this.profileNameLabel.Name = "profileNameLabel";
            this.profileNameLabel.Size = new System.Drawing.Size(83, 19);
            this.profileNameLabel.TabIndex = 9;
            this.profileNameLabel.Text = "fullName";
            // 
            // settings
            // 
            this.settings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.settings.Image = global::DishesGo.Properties.Resources.Settings;
            this.settings.Location = new System.Drawing.Point(628, 63);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(50, 50);
            this.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settings.TabIndex = 12;
            this.settings.TabStop = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
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
            this.profileImg.Location = new System.Drawing.Point(175, 40);
            this.profileImg.Name = "profileImg";
            this.profileImg.Size = new System.Drawing.Size(124, 124);
            this.profileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileImg.TabIndex = 8;
            this.profileImg.TabStop = false;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.settingsPanel.Controls.Add(this.bookMarksButton);
            this.settingsPanel.Controls.Add(this.exitFromProfile);
            this.settingsPanel.Controls.Add(this.editPtofileButton);
            this.settingsPanel.Location = new System.Drawing.Point(517, 112);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.settingsPanel.Size = new System.Drawing.Size(161, 119);
            this.settingsPanel.StateCommon.Color1 = System.Drawing.Color.Gainsboro;
            this.settingsPanel.TabIndex = 13;
            this.settingsPanel.Visible = false;
            this.settingsPanel.MouseLeave += new System.EventHandler(this.settingsPanel_MouseLeave);
            // 
            // bookMarksButton
            // 
            this.bookMarksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bookMarksButton.Location = new System.Drawing.Point(3, 46);
            this.bookMarksButton.Name = "bookMarksButton";
            this.bookMarksButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.OverrideDefault.Back.ColorAngle = 45F;
            this.bookMarksButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.OverrideDefault.Border.ColorAngle = 45F;
            this.bookMarksButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bookMarksButton.OverrideDefault.Border.Rounding = 13;
            this.bookMarksButton.OverrideDefault.Border.Width = 1;
            this.bookMarksButton.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.OverrideFocus.Back.ColorAngle = 45F;
            this.bookMarksButton.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.OverrideFocus.Border.ColorAngle = 45F;
            this.bookMarksButton.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bookMarksButton.OverrideFocus.Border.Rounding = 13;
            this.bookMarksButton.OverrideFocus.Border.Width = 1;
            this.bookMarksButton.Size = new System.Drawing.Size(155, 27);
            this.bookMarksButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StateCommon.Back.ColorAngle = 45F;
            this.bookMarksButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StateCommon.Border.ColorAngle = 45F;
            this.bookMarksButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bookMarksButton.StateCommon.Border.Rounding = 13;
            this.bookMarksButton.StateCommon.Border.Width = 1;
            this.bookMarksButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Orbitron", 8F, System.Drawing.FontStyle.Bold);
            this.bookMarksButton.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StateDisabled.Back.ColorAngle = 45F;
            this.bookMarksButton.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StateDisabled.Border.ColorAngle = 45F;
            this.bookMarksButton.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bookMarksButton.StateDisabled.Border.Rounding = 13;
            this.bookMarksButton.StateDisabled.Border.Width = 1;
            this.bookMarksButton.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StateNormal.Back.ColorAngle = 45F;
            this.bookMarksButton.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StateNormal.Border.ColorAngle = 45F;
            this.bookMarksButton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bookMarksButton.StateNormal.Border.Rounding = 13;
            this.bookMarksButton.StateNormal.Border.Width = 1;
            this.bookMarksButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StatePressed.Back.ColorAngle = 45F;
            this.bookMarksButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StatePressed.Border.ColorAngle = 45F;
            this.bookMarksButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bookMarksButton.StatePressed.Border.Rounding = 13;
            this.bookMarksButton.StatePressed.Border.Width = 1;
            this.bookMarksButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StateTracking.Back.ColorAngle = 45F;
            this.bookMarksButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.bookMarksButton.StateTracking.Border.ColorAngle = 45F;
            this.bookMarksButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bookMarksButton.StateTracking.Border.Rounding = 13;
            this.bookMarksButton.StateTracking.Border.Width = 1;
            this.bookMarksButton.TabIndex = 16;
            this.bookMarksButton.Values.Text = "Закладки";
            // 
            // exitFromProfile
            // 
            this.exitFromProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitFromProfile.Location = new System.Drawing.Point(3, 79);
            this.exitFromProfile.Name = "exitFromProfile";
            this.exitFromProfile.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.OverrideDefault.Back.ColorAngle = 45F;
            this.exitFromProfile.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.OverrideDefault.Border.ColorAngle = 45F;
            this.exitFromProfile.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.exitFromProfile.OverrideDefault.Border.Rounding = 13;
            this.exitFromProfile.OverrideDefault.Border.Width = 1;
            this.exitFromProfile.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.OverrideFocus.Back.ColorAngle = 45F;
            this.exitFromProfile.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.OverrideFocus.Border.ColorAngle = 45F;
            this.exitFromProfile.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.exitFromProfile.OverrideFocus.Border.Rounding = 13;
            this.exitFromProfile.OverrideFocus.Border.Width = 1;
            this.exitFromProfile.Size = new System.Drawing.Size(155, 27);
            this.exitFromProfile.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StateCommon.Back.ColorAngle = 45F;
            this.exitFromProfile.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StateCommon.Border.ColorAngle = 45F;
            this.exitFromProfile.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.exitFromProfile.StateCommon.Border.Rounding = 13;
            this.exitFromProfile.StateCommon.Border.Width = 1;
            this.exitFromProfile.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Orbitron", 8F, System.Drawing.FontStyle.Bold);
            this.exitFromProfile.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StateDisabled.Back.ColorAngle = 45F;
            this.exitFromProfile.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StateDisabled.Border.ColorAngle = 45F;
            this.exitFromProfile.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.exitFromProfile.StateDisabled.Border.Rounding = 13;
            this.exitFromProfile.StateDisabled.Border.Width = 1;
            this.exitFromProfile.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StateNormal.Back.ColorAngle = 45F;
            this.exitFromProfile.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StateNormal.Border.ColorAngle = 45F;
            this.exitFromProfile.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.exitFromProfile.StateNormal.Border.Rounding = 13;
            this.exitFromProfile.StateNormal.Border.Width = 1;
            this.exitFromProfile.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StatePressed.Back.ColorAngle = 45F;
            this.exitFromProfile.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StatePressed.Border.ColorAngle = 45F;
            this.exitFromProfile.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.exitFromProfile.StatePressed.Border.Rounding = 13;
            this.exitFromProfile.StatePressed.Border.Width = 1;
            this.exitFromProfile.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StateTracking.Back.ColorAngle = 45F;
            this.exitFromProfile.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.exitFromProfile.StateTracking.Border.ColorAngle = 45F;
            this.exitFromProfile.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.exitFromProfile.StateTracking.Border.Rounding = 13;
            this.exitFromProfile.StateTracking.Border.Width = 1;
            this.exitFromProfile.TabIndex = 15;
            this.exitFromProfile.Values.Text = "Вихід";
            this.exitFromProfile.Click += new System.EventHandler(this.exitFromProfile_Click);
            // 
            // editPtofileButton
            // 
            this.editPtofileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editPtofileButton.Location = new System.Drawing.Point(3, 11);
            this.editPtofileButton.Name = "editPtofileButton";
            this.editPtofileButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.OverrideDefault.Back.ColorAngle = 45F;
            this.editPtofileButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.OverrideDefault.Border.ColorAngle = 45F;
            this.editPtofileButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editPtofileButton.OverrideDefault.Border.Rounding = 13;
            this.editPtofileButton.OverrideDefault.Border.Width = 1;
            this.editPtofileButton.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.OverrideFocus.Back.ColorAngle = 45F;
            this.editPtofileButton.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.OverrideFocus.Border.ColorAngle = 45F;
            this.editPtofileButton.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editPtofileButton.OverrideFocus.Border.Rounding = 13;
            this.editPtofileButton.OverrideFocus.Border.Width = 1;
            this.editPtofileButton.Size = new System.Drawing.Size(155, 27);
            this.editPtofileButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StateCommon.Back.ColorAngle = 45F;
            this.editPtofileButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StateCommon.Border.ColorAngle = 45F;
            this.editPtofileButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editPtofileButton.StateCommon.Border.Rounding = 13;
            this.editPtofileButton.StateCommon.Border.Width = 1;
            this.editPtofileButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Orbitron", 8F, System.Drawing.FontStyle.Bold);
            this.editPtofileButton.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StateDisabled.Back.ColorAngle = 45F;
            this.editPtofileButton.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StateDisabled.Border.ColorAngle = 45F;
            this.editPtofileButton.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editPtofileButton.StateDisabled.Border.Rounding = 13;
            this.editPtofileButton.StateDisabled.Border.Width = 1;
            this.editPtofileButton.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StateNormal.Back.ColorAngle = 45F;
            this.editPtofileButton.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StateNormal.Border.ColorAngle = 45F;
            this.editPtofileButton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editPtofileButton.StateNormal.Border.Rounding = 13;
            this.editPtofileButton.StateNormal.Border.Width = 1;
            this.editPtofileButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StatePressed.Back.ColorAngle = 45F;
            this.editPtofileButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StatePressed.Border.ColorAngle = 45F;
            this.editPtofileButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editPtofileButton.StatePressed.Border.Rounding = 13;
            this.editPtofileButton.StatePressed.Border.Width = 1;
            this.editPtofileButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StateTracking.Back.ColorAngle = 45F;
            this.editPtofileButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.editPtofileButton.StateTracking.Border.ColorAngle = 45F;
            this.editPtofileButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.editPtofileButton.StateTracking.Border.Rounding = 13;
            this.editPtofileButton.StateTracking.Border.Width = 1;
            this.editPtofileButton.TabIndex = 14;
            this.editPtofileButton.Values.Text = "Редагувати профіль";
            this.editPtofileButton.Click += new System.EventHandler(this.editPtofileButton_Click);
            // 
            // ProfilePlate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.recipesPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.profileNameLabel);
            this.Controls.Add(this.profileImg);
            this.Name = "ProfilePlate";
            this.Size = new System.Drawing.Size(832, 462);
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel recipesPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Label profileNameLabel;
        private RashiUI.RashiCircularPictureBox profileImg;
        private System.Windows.Forms.PictureBox settings;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel settingsPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton editPtofileButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton exitFromProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bookMarksButton;
    }
}
