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
            this.bookmarks = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.homeLine = new System.Windows.Forms.PictureBox();
            this.home = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.findUserLine = new System.Windows.Forms.PictureBox();
            this.findUser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.search = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.searchLine = new System.Windows.Forms.PictureBox();
            this.addLine = new System.Windows.Forms.PictureBox();
            this.addRecipe = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.settings = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.photoLine = new System.Windows.Forms.PictureBox();
            this.userPhoto = new RashiUI.RashiCircularPictureBox();
            this.contextPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findUserLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextPanel)).BeginInit();
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
            this.mainPanel.Controls.Add(this.bookmarks);
            this.mainPanel.Controls.Add(this.homeLine);
            this.mainPanel.Controls.Add(this.home);
            this.mainPanel.Controls.Add(this.findUserLine);
            this.mainPanel.Controls.Add(this.findUser);
            this.mainPanel.Controls.Add(this.search);
            this.mainPanel.Controls.Add(this.searchLine);
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
            // bookmarks
            // 
            this.bookmarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bookmarks.Location = new System.Drawing.Point(59, 12);
            this.bookmarks.Name = "bookmarks";
            this.bookmarks.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.bookmarks.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.bookmarks.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.bookmarks.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.bookmarks.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.bookmarks.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bookmarks.OverrideFocus.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.bookmarks.OverrideFocus.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.bookmarks.Size = new System.Drawing.Size(30, 30);
            this.bookmarks.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.bookmarks.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.bookmarks.StateCommon.Back.Image = global::DishesGo.Properties.Resources.BookmarkButton;
            this.bookmarks.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.bookmarks.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.bookmarks.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.bookmarks.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bookmarks.TabIndex = 41;
            this.bookmarks.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.bookmarks.Values.Text = "";
            this.bookmarks.Click += new System.EventHandler(this.bookMarksButton_Click);
            // 
            // homeLine
            // 
            this.homeLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.homeLine.Location = new System.Drawing.Point(659, 45);
            this.homeLine.Name = "homeLine";
            this.homeLine.Size = new System.Drawing.Size(60, 5);
            this.homeLine.TabIndex = 40;
            this.homeLine.TabStop = false;
            this.homeLine.Visible = false;
            // 
            // home
            // 
            this.home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.home.Location = new System.Drawing.Point(672, 10);
            this.home.Name = "home";
            this.home.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.home.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.home.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.home.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.home.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.home.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.home.OverrideFocus.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.home.OverrideFocus.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.home.Size = new System.Drawing.Size(30, 30);
            this.home.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.home.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.home.StateCommon.Back.Image = global::DishesGo.Properties.Resources.Home;
            this.home.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.home.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.home.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.home.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.home.TabIndex = 39;
            this.home.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.home.Values.Text = "";
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // findUserLine
            // 
            this.findUserLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findUserLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.findUserLine.Location = new System.Drawing.Point(726, 45);
            this.findUserLine.Name = "findUserLine";
            this.findUserLine.Size = new System.Drawing.Size(60, 5);
            this.findUserLine.TabIndex = 38;
            this.findUserLine.TabStop = false;
            this.findUserLine.Visible = false;
            // 
            // findUser
            // 
            this.findUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findUser.Location = new System.Drawing.Point(739, 10);
            this.findUser.Name = "findUser";
            this.findUser.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.findUser.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.findUser.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.findUser.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.findUser.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.findUser.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.findUser.OverrideFocus.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.findUser.OverrideFocus.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.findUser.Size = new System.Drawing.Size(30, 30);
            this.findUser.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.findUser.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.findUser.StateCommon.Back.Image = global::DishesGo.Properties.Resources.FindUser;
            this.findUser.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.findUser.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.findUser.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.findUser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.findUser.TabIndex = 37;
            this.findUser.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.findUser.Values.Text = "";
            this.findUser.Click += new System.EventHandler(this.findUser_Click);
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search.Location = new System.Drawing.Point(807, 10);
            this.search.Name = "search";
            this.search.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.search.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.search.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.search.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.search.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.search.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.search.OverrideFocus.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.search.OverrideFocus.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.search.Size = new System.Drawing.Size(30, 30);
            this.search.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.search.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.search.StateCommon.Back.Image = global::DishesGo.Properties.Resources.Search;
            this.search.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.search.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.search.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.search.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.search.TabIndex = 36;
            this.search.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.search.Values.Text = "";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchLine
            // 
            this.searchLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.searchLine.Location = new System.Drawing.Point(792, 45);
            this.searchLine.Name = "searchLine";
            this.searchLine.Size = new System.Drawing.Size(60, 5);
            this.searchLine.TabIndex = 35;
            this.searchLine.TabStop = false;
            this.searchLine.Visible = false;
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
            this.settings.StateCommon.Back.Image = global::DishesGo.Properties.Resources.Exit;
            this.settings.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.settings.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.settings.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.settings.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.settings.TabIndex = 32;
            this.settings.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.settings.Values.Text = "";
            this.settings.Click += new System.EventHandler(this.exitFromProfile_Click);
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
            this.contextPanel.Size = new System.Drawing.Size(986, 616);
            this.contextPanel.StateCommon.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.contextPanel.StateCommon.Color2 = System.Drawing.SystemColors.Control;
            this.contextPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.contextPanel);
            this.Controls.Add(this.mainPanel);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "MainForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DishesGo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findUserLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel mainPanel;
        private System.Windows.Forms.PictureBox photoLine;
        private RashiUI.RashiCircularPictureBox userPhoto;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel contextPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton settings;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addRecipe;
        private System.Windows.Forms.PictureBox addLine;
        private ComponentFactory.Krypton.Toolkit.KryptonButton search;
        private System.Windows.Forms.PictureBox searchLine;
        private System.Windows.Forms.PictureBox findUserLine;
        private ComponentFactory.Krypton.Toolkit.KryptonButton findUser;
        private System.Windows.Forms.PictureBox homeLine;
        private ComponentFactory.Krypton.Toolkit.KryptonButton home;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bookmarks;
    }
}