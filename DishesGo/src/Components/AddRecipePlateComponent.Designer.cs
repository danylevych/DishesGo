namespace DishesGo.src.Components
{
    partial class AddRecipePlateComponent
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
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.titleVal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.addRecipeButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.stepsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.stepsLabels = new System.Windows.Forms.Label();
            this.ingridientsLabel = new System.Windows.Forms.Label();
            this.ingrigientsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addIngridientsButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addStepsButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.RecipeImg = new System.Windows.Forms.PictureBox();
            this.descriptionVal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.deleteStepButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeImg)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Russo One", 14.25F);
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.descriptionLabel.Location = new System.Drawing.Point(280, 75);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 23);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Опис:";
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Russo One", 27F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(177, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(409, 43);
            this.title.TabIndex = 14;
            this.title.Text = "Додавання рецепту";
            // 
            // titleVal
            // 
            this.titleVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleVal.Location = new System.Drawing.Point(92, 326);
            this.titleVal.Name = "titleVal";
            this.titleVal.Size = new System.Drawing.Size(171, 34);
            this.titleVal.StateCommon.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.titleVal.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.titleVal.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.titleVal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.titleVal.StateCommon.Border.Rounding = 5;
            this.titleVal.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.titleVal.StateCommon.Content.Font = new System.Drawing.Font("Russo One", 14.25F);
            this.titleVal.TabIndex = 15;
            this.titleVal.Tag = "";
            this.titleVal.Text = "title";
            // 
            // addRecipeButton
            // 
            this.addRecipeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addRecipeButton.AutoSize = true;
            this.addRecipeButton.Location = new System.Drawing.Point(60, 370);
            this.addRecipeButton.Name = "addRecipeButton";
            this.addRecipeButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.OverrideDefault.Back.ColorAngle = 45F;
            this.addRecipeButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.OverrideDefault.Border.ColorAngle = 45F;
            this.addRecipeButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addRecipeButton.OverrideDefault.Border.Rounding = 13;
            this.addRecipeButton.OverrideDefault.Border.Width = 1;
            this.addRecipeButton.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.OverrideFocus.Back.ColorAngle = 45F;
            this.addRecipeButton.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.OverrideFocus.Border.ColorAngle = 45F;
            this.addRecipeButton.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addRecipeButton.OverrideFocus.Border.Rounding = 13;
            this.addRecipeButton.OverrideFocus.Border.Width = 1;
            this.addRecipeButton.Size = new System.Drawing.Size(112, 27);
            this.addRecipeButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StateCommon.Back.ColorAngle = 45F;
            this.addRecipeButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StateCommon.Border.ColorAngle = 45F;
            this.addRecipeButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addRecipeButton.StateCommon.Border.Rounding = 13;
            this.addRecipeButton.StateCommon.Border.Width = 1;
            this.addRecipeButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Orbitron", 8F, System.Drawing.FontStyle.Bold);
            this.addRecipeButton.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StateDisabled.Back.ColorAngle = 45F;
            this.addRecipeButton.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StateDisabled.Border.ColorAngle = 45F;
            this.addRecipeButton.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addRecipeButton.StateDisabled.Border.Rounding = 13;
            this.addRecipeButton.StateDisabled.Border.Width = 1;
            this.addRecipeButton.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StateNormal.Back.ColorAngle = 45F;
            this.addRecipeButton.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StateNormal.Border.ColorAngle = 45F;
            this.addRecipeButton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addRecipeButton.StateNormal.Border.Rounding = 13;
            this.addRecipeButton.StateNormal.Border.Width = 1;
            this.addRecipeButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StatePressed.Back.ColorAngle = 45F;
            this.addRecipeButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StatePressed.Border.ColorAngle = 45F;
            this.addRecipeButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addRecipeButton.StatePressed.Border.Rounding = 13;
            this.addRecipeButton.StatePressed.Border.Width = 1;
            this.addRecipeButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StateTracking.Back.ColorAngle = 45F;
            this.addRecipeButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.addRecipeButton.StateTracking.Border.ColorAngle = 45F;
            this.addRecipeButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addRecipeButton.StateTracking.Border.Rounding = 13;
            this.addRecipeButton.StateTracking.Border.Width = 1;
            this.addRecipeButton.TabIndex = 19;
            this.addRecipeButton.Values.Text = "Додати";
            // 
            // stepsPanel
            // 
            this.stepsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepsPanel.AutoScroll = true;
            this.stepsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.stepsPanel.Location = new System.Drawing.Point(284, 280);
            this.stepsPanel.Name = "stepsPanel";
            this.stepsPanel.Size = new System.Drawing.Size(487, 113);
            this.stepsPanel.TabIndex = 32;
            // 
            // stepsLabels
            // 
            this.stepsLabels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepsLabels.AutoSize = true;
            this.stepsLabels.BackColor = System.Drawing.Color.Transparent;
            this.stepsLabels.Font = new System.Drawing.Font("Russo One", 14.25F);
            this.stepsLabels.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.stepsLabels.Location = new System.Drawing.Point(280, 250);
            this.stepsLabels.Name = "stepsLabels";
            this.stepsLabels.Size = new System.Drawing.Size(70, 23);
            this.stepsLabels.TabIndex = 33;
            this.stepsLabels.Text = "Кроки";
            // 
            // ingridientsLabel
            // 
            this.ingridientsLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.ingridientsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ingridientsLabel.AutoSize = true;
            this.ingridientsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ingridientsLabel.Font = new System.Drawing.Font("Russo One", 14.25F);
            this.ingridientsLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ingridientsLabel.Location = new System.Drawing.Point(280, 118);
            this.ingridientsLabel.Name = "ingridientsLabel";
            this.ingridientsLabel.Size = new System.Drawing.Size(131, 23);
            this.ingridientsLabel.TabIndex = 35;
            this.ingridientsLabel.Text = "Інгридієнти:";
            // 
            // ingrigientsPanel
            // 
            this.ingrigientsPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.ingrigientsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ingrigientsPanel.AutoScroll = true;
            this.ingrigientsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ingrigientsPanel.Location = new System.Drawing.Point(284, 144);
            this.ingrigientsPanel.Name = "ingrigientsPanel";
            this.ingrigientsPanel.Size = new System.Drawing.Size(487, 94);
            this.ingrigientsPanel.TabIndex = 34;
            // 
            // addIngridientsButton
            // 
            this.addIngridientsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addIngridientsButton.AutoSize = true;
            this.addIngridientsButton.Location = new System.Drawing.Point(411, 119);
            this.addIngridientsButton.Name = "addIngridientsButton";
            this.addIngridientsButton.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.addIngridientsButton.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.addIngridientsButton.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.addIngridientsButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.addIngridientsButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.addIngridientsButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addIngridientsButton.OverrideDefault.Border.Rounding = 1;
            this.addIngridientsButton.OverrideDefault.Border.Width = 0;
            this.addIngridientsButton.OverrideFocus.Back.Color1 = System.Drawing.Color.Silver;
            this.addIngridientsButton.OverrideFocus.Back.Color2 = System.Drawing.Color.Silver;
            this.addIngridientsButton.Size = new System.Drawing.Size(20, 20);
            this.addIngridientsButton.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.addIngridientsButton.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.addIngridientsButton.StateCommon.Back.Image = global::DishesGo.Properties.Resources.Add;
            this.addIngridientsButton.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.addIngridientsButton.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.addIngridientsButton.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.addIngridientsButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addIngridientsButton.StateCommon.Border.Rounding = 0;
            this.addIngridientsButton.StateCommon.Border.Width = 0;
            this.addIngridientsButton.TabIndex = 36;
            this.addIngridientsButton.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.addIngridientsButton.Values.Text = "";
            this.addIngridientsButton.Click += new System.EventHandler(this.addIngridientsButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Russo One", 14.25F);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.titleLabel.Location = new System.Drawing.Point(20, 329);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(72, 23);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Назва:";
            // 
            // addStepsButton
            // 
            this.addStepsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addStepsButton.AutoSize = true;
            this.addStepsButton.Location = new System.Drawing.Point(355, 253);
            this.addStepsButton.Name = "addStepsButton";
            this.addStepsButton.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.addStepsButton.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.addStepsButton.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.addStepsButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.addStepsButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.addStepsButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addStepsButton.OverrideDefault.Border.Rounding = 1;
            this.addStepsButton.OverrideDefault.Border.Width = 0;
            this.addStepsButton.OverrideFocus.Back.Color1 = System.Drawing.Color.Silver;
            this.addStepsButton.OverrideFocus.Back.Color2 = System.Drawing.Color.Silver;
            this.addStepsButton.Size = new System.Drawing.Size(20, 20);
            this.addStepsButton.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.addStepsButton.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.addStepsButton.StateCommon.Back.Image = global::DishesGo.Properties.Resources.Add;
            this.addStepsButton.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.addStepsButton.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.addStepsButton.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.addStepsButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addStepsButton.StateCommon.Border.Rounding = 0;
            this.addStepsButton.StateCommon.Border.Width = 0;
            this.addStepsButton.TabIndex = 37;
            this.addStepsButton.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.addStepsButton.Values.Text = "";
            this.addStepsButton.Click += new System.EventHandler(this.addStepsButton_Click);
            // 
            // RecipeImg
            // 
            this.RecipeImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecipeImg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RecipeImg.Image = global::DishesGo.Properties.Resources.titlePhoto;
            this.RecipeImg.Location = new System.Drawing.Point(24, 72);
            this.RecipeImg.Name = "RecipeImg";
            this.RecipeImg.Size = new System.Drawing.Size(240, 240);
            this.RecipeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RecipeImg.TabIndex = 0;
            this.RecipeImg.TabStop = false;
            // 
            // descriptionVal
            // 
            this.descriptionVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionVal.Location = new System.Drawing.Point(355, 72);
            this.descriptionVal.Name = "descriptionVal";
            this.descriptionVal.Size = new System.Drawing.Size(416, 34);
            this.descriptionVal.StateCommon.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.descriptionVal.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.descriptionVal.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.descriptionVal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.descriptionVal.StateCommon.Border.Rounding = 5;
            this.descriptionVal.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.descriptionVal.StateCommon.Content.Font = new System.Drawing.Font("Russo One", 14.25F);
            this.descriptionVal.TabIndex = 16;
            this.descriptionVal.Tag = "";
            this.descriptionVal.Text = "description";
            // 
            // deleteStepButton
            // 
            this.deleteStepButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteStepButton.AutoSize = true;
            this.deleteStepButton.Location = new System.Drawing.Point(391, 254);
            this.deleteStepButton.Name = "deleteStepButton";
            this.deleteStepButton.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.deleteStepButton.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.deleteStepButton.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.deleteStepButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.deleteStepButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.deleteStepButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteStepButton.OverrideDefault.Border.Rounding = 1;
            this.deleteStepButton.OverrideDefault.Border.Width = 0;
            this.deleteStepButton.OverrideFocus.Back.Color1 = System.Drawing.Color.Silver;
            this.deleteStepButton.OverrideFocus.Back.Color2 = System.Drawing.Color.Silver;
            this.deleteStepButton.Size = new System.Drawing.Size(20, 20);
            this.deleteStepButton.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.deleteStepButton.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.deleteStepButton.StateCommon.Back.Image = global::DishesGo.Properties.Resources.Cansle;
            this.deleteStepButton.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.deleteStepButton.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.deleteStepButton.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.deleteStepButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteStepButton.StateCommon.Border.Rounding = 0;
            this.deleteStepButton.StateCommon.Border.Width = 0;
            this.deleteStepButton.TabIndex = 38;
            this.deleteStepButton.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.deleteStepButton.Values.Text = "";
            this.deleteStepButton.Visible = false;
            this.deleteStepButton.Click += new System.EventHandler(this.deleteStepButton_Click);
            // 
            // AddRecipePlateComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteStepButton);
            this.Controls.Add(this.addStepsButton);
            this.Controls.Add(this.addIngridientsButton);
            this.Controls.Add(this.ingridientsLabel);
            this.Controls.Add(this.ingrigientsPanel);
            this.Controls.Add(this.stepsLabels);
            this.Controls.Add(this.stepsPanel);
            this.Controls.Add(this.addRecipeButton);
            this.Controls.Add(this.descriptionVal);
            this.Controls.Add(this.titleVal);
            this.Controls.Add(this.title);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.RecipeImg);
            this.Name = "AddRecipePlateComponent";
            this.Size = new System.Drawing.Size(786, 408);
            ((System.ComponentModel.ISupportInitialize)(this.RecipeImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RecipeImg;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label title;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox titleVal;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addRecipeButton;
        private System.Windows.Forms.FlowLayoutPanel stepsPanel;
        private System.Windows.Forms.Label stepsLabels;
        private System.Windows.Forms.Label ingridientsLabel;
        private System.Windows.Forms.FlowLayoutPanel ingrigientsPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addIngridientsButton;
        private System.Windows.Forms.Label titleLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addStepsButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox descriptionVal;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteStepButton;
    }
}
