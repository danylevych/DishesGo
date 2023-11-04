namespace DishesGo.src
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.mainPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.addLine = new System.Windows.Forms.PictureBox();
            this.addRecipe = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.settings = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.photoLine = new System.Windows.Forms.PictureBox();
            this.userPhoto = new RashiUI.RashiCircularPictureBox();
            this.contextPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.settingsPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.bookMarksButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.exitFromProfile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.editPtofileButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.addLine);
            this.mainPanel.Controls.Add(this.addRecipe);
            this.mainPanel.Controls.Add(this.settings);
            this.mainPanel.Controls.Add(this.photoLine);
            this.mainPanel.Controls.Add(this.userPhoto);
            this.mainPanel.Location = new System.Drawing.Point(-3, -1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(992, 50);
            this.mainPanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.mainPanel.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.mainPanel.TabIndex = 1;
            // 
            // addLine
            // 
            this.addLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addLine.Location = new System.Drawing.Point(858, 45);
            this.addLine.Name = "addLine";
            this.addLine.Size = new System.Drawing.Size(60, 5);
            this.addLine.TabIndex = 34;
            this.addLine.TabStop = false;
            this.addLine.Visible = false;
            // 
            // addRecipe
            // 
            this.addRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addRecipe.Location = new System.Drawing.Point(872, 10);
            this.addRecipe.Name = "addRecipe";
            this.addRecipe.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.addRecipe.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.addRecipe.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.addRecipe.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.addRecipe.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.addRecipe.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addRecipe.OverrideFocus.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.addRecipe.OverrideFocus.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.addRecipe.Size = new System.Drawing.Size(30, 30);
            this.addRecipe.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.addRecipe.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.addRecipe.StateCommon.Back.Image = global::DishesGo.Properties.Resources.Add;
            this.addRecipe.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.addRecipe.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.addRecipe.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.addRecipe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addRecipe.TabIndex = 33;
            this.addRecipe.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.addRecipe.Values.Text = "";
            this.addRecipe.Click += new System.EventHandler(this.addRecipe_Click);
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.settings.Location = new System.Drawing.Point(10, 10);
            this.settings.Name = "settings";
            this.settings.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.settings.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.settings.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.settings.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.settings.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.settings.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.settings.OverrideFocus.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.settings.OverrideFocus.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.settings.Size = new System.Drawing.Size(30, 30);
            this.settings.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.settings.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.settings.StateCommon.Back.Image = global::DishesGo.Properties.Resources.Settings;
            this.settings.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.settings.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.settings.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.settings.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.settings.TabIndex = 32;
            this.settings.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.settings.Values.Text = "";
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // photoLine
            // 
            this.photoLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photoLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.photoLine.Location = new System.Drawing.Point(924, 45);
            this.photoLine.Name = "photoLine";
            this.photoLine.Size = new System.Drawing.Size(60, 5);
            this.photoLine.TabIndex = 2;
            this.photoLine.TabStop = false;
            this.photoLine.Visible = false;
            // 
            // userPhoto
            // 
            this.userPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userPhoto.Border = 1;
            this.userPhoto.BorderCap = System.Drawing.Drawing2D.DashCap.Round;
            this.userPhoto.Borderstyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.userPhoto.ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
            this.userPhoto.ColorBorder2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.userPhoto.Gradiant = 50F;
            this.userPhoto.Location = new System.Drawing.Point(933, 3);
            this.userPhoto.Name = "userPhoto";
            this.userPhoto.Size = new System.Drawing.Size(40, 40);
            this.userPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPhoto.TabIndex = 2;
            this.userPhoto.TabStop = false;
            this.userPhoto.Click += new System.EventHandler(this.userPhoto_Click);
            // 
            // contextPanel
            // 
            this.contextPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contextPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.contextPanel.Location = new System.Drawing.Point(0, 48);
            this.contextPanel.Name = "contextPanel";
            this.contextPanel.Size = new System.Drawing.Size(986, 608);
            this.contextPanel.StateCommon.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.contextPanel.StateCommon.Color2 = System.Drawing.SystemColors.Control;
            this.contextPanel.TabIndex = 2;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.bookMarksButton);
            this.settingsPanel.Controls.Add(this.exitFromProfile);
            this.settingsPanel.Controls.Add(this.editPtofileButton);
            this.settingsPanel.Location = new System.Drawing.Point(0, 47);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.settingsPanel.Size = new System.Drawing.Size(160, 120);
            this.settingsPanel.StateCommon.Color1 = System.Drawing.Color.Gainsboro;
            this.settingsPanel.TabIndex = 33;
            this.settingsPanel.Visible = false;
            this.settingsPanel.MouseEnter += new System.EventHandler(this.settingsPanel_MouseEnter);
            this.settingsPanel.MouseLeave += new System.EventHandler(this.settingsPanel_MouseLeave);
            // 
            // bookMarksButton
            // 
            this.bookMarksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bookMarksButton.Location = new System.Drawing.Point(2, 46);
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
            this.bookMarksButton.Click += new System.EventHandler(this.bookMarksButton_Click);
            // 
            // exitFromProfile
            // 
            this.exitFromProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitFromProfile.Location = new System.Drawing.Point(2, 79);
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
            this.editPtofileButton.Location = new System.Drawing.Point(2, 11);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.contextPanel);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DishesGo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel mainPanel;
        private System.Windows.Forms.PictureBox photoLine;
        private RashiUI.RashiCircularPictureBox userPhoto;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel contextPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton settings;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel settingsPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bookMarksButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton exitFromProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonButton editPtofileButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addRecipe;
        private System.Windows.Forms.PictureBox addLine;
    }
}