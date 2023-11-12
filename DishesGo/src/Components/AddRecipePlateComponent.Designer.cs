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
            this.ingredientsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addIngridientsButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addStepsButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.descriptionVal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.deleteStepButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.deleteIngridientButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.timePrepareLabel = new System.Windows.Forms.Label();
            this.timePrepareVal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.timeUnitLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.caloriesVal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.caloriesUnitLabel = new System.Windows.Forms.Label();
            this.kitchenLabel = new System.Windows.Forms.Label();
            this.kitchenComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.infoImg = new System.Windows.Forms.PictureBox();
            this.RecipeImg = new System.Windows.Forms.PictureBox();
            this.descriptionKitchen = new System.Windows.Forms.Label();
            this.warningTitle = new System.Windows.Forms.Label();
            this.warningKitchen = new System.Windows.Forms.Label();
            this.warningType = new System.Windows.Forms.Label();
            this.warningTime = new System.Windows.Forms.Label();
            this.warningCalories = new System.Windows.Forms.Label();
            this.warningSteps = new System.Windows.Forms.Label();
            this.warningIngredients = new System.Windows.Forms.Label();
            this.disableImageButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeImg)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.descriptionLabel.Location = new System.Drawing.Point(19, 440);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(54, 19);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Опис:";
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Russo One", 19F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(357, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(298, 31);
            this.title.TabIndex = 14;
            this.title.Text = "Додавання рецепту";
            // 
            // titleVal
            // 
            this.titleVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleVal.Location = new System.Drawing.Point(98, 392);
            this.titleVal.Name = "titleVal";
            this.titleVal.Size = new System.Drawing.Size(246, 31);
            this.titleVal.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.titleVal.StateActive.Content.Font = new System.Drawing.Font("Russo One", 12F);
            this.titleVal.StateCommon.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.titleVal.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.titleVal.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.titleVal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.titleVal.StateCommon.Border.Rounding = 5;
            this.titleVal.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.titleVal.StateCommon.Content.Font = new System.Drawing.Font("Russo One", 12F);
            this.titleVal.StateDisabled.Content.Color1 = System.Drawing.Color.DimGray;
            this.titleVal.StateDisabled.Content.Font = new System.Drawing.Font("Russo One", 12F);
            this.titleVal.StateNormal.Content.Color1 = System.Drawing.Color.Gray;
            this.titleVal.StateNormal.Content.Font = new System.Drawing.Font("Russo One", 12F);
            this.titleVal.TabIndex = 15;
            this.titleVal.TabStop = false;
            this.titleVal.Tag = "";
            this.titleVal.Text = "введіть назву";
            this.titleVal.Enter += new System.EventHandler(this.titleVal_Enter);
            this.titleVal.Leave += new System.EventHandler(this.titleVal_Leave);
            // 
            // addRecipeButton
            // 
            this.addRecipeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addRecipeButton.AutoSize = true;
            this.addRecipeButton.Location = new System.Drawing.Point(849, 13);
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
            this.addRecipeButton.Click += new System.EventHandler(this.addRecipeButton_Click);
            // 
            // stepsPanel
            // 
            this.stepsPanel.AllowDrop = true;
            this.stepsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepsPanel.AutoScroll = true;
            this.stepsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.stepsPanel.Location = new System.Drawing.Point(374, 69);
            this.stepsPanel.Name = "stepsPanel";
            this.stepsPanel.Size = new System.Drawing.Size(587, 239);
            this.stepsPanel.TabIndex = 32;
            this.stepsPanel.Tag = "Steps";
            this.stepsPanel.SizeChanged += new System.EventHandler(this.stepsPanel_SizeChanged);
            this.stepsPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Panel_ControlAdded);
            this.stepsPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Panel_ControlRemoved);
            // 
            // stepsLabels
            // 
            this.stepsLabels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepsLabels.AutoSize = true;
            this.stepsLabels.BackColor = System.Drawing.Color.Transparent;
            this.stepsLabels.Font = new System.Drawing.Font("Russo One", 14.25F);
            this.stepsLabels.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.stepsLabels.Location = new System.Drawing.Point(386, 43);
            this.stepsLabels.Name = "stepsLabels";
            this.stepsLabels.Size = new System.Drawing.Size(70, 23);
            this.stepsLabels.TabIndex = 33;
            this.stepsLabels.Text = "Кроки";
            // 
            // ingridientsLabel
            // 
            this.ingridientsLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.ingridientsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ingridientsLabel.AutoSize = true;
            this.ingridientsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ingridientsLabel.Font = new System.Drawing.Font("Russo One", 14.25F);
            this.ingridientsLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ingridientsLabel.Location = new System.Drawing.Point(390, 328);
            this.ingridientsLabel.Name = "ingridientsLabel";
            this.ingridientsLabel.Size = new System.Drawing.Size(126, 23);
            this.ingridientsLabel.TabIndex = 35;
            this.ingridientsLabel.Text = "Інгридієнти";
            // 
            // ingredientsPanel
            // 
            this.ingredientsPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.ingredientsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ingredientsPanel.AutoScroll = true;
            this.ingredientsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ingredientsPanel.Location = new System.Drawing.Point(374, 354);
            this.ingredientsPanel.Name = "ingredientsPanel";
            this.ingredientsPanel.Size = new System.Drawing.Size(587, 240);
            this.ingredientsPanel.TabIndex = 34;
            this.ingredientsPanel.Tag = "Ingredients";
            this.ingredientsPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Panel_ControlAdded);
            this.ingredientsPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Panel_ControlRemoved);
            // 
            // addIngridientsButton
            // 
            this.addIngridientsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addIngridientsButton.AutoSize = true;
            this.addIngridientsButton.Location = new System.Drawing.Point(520, 328);
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
            this.titleLabel.Location = new System.Drawing.Point(20, 392);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(72, 23);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Назва:";
            // 
            // addStepsButton
            // 
            this.addStepsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addStepsButton.AutoSize = true;
            this.addStepsButton.Location = new System.Drawing.Point(461, 46);
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
            // descriptionVal
            // 
            this.descriptionVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionVal.Location = new System.Drawing.Point(79, 440);
            this.descriptionVal.Name = "descriptionVal";
            this.descriptionVal.Size = new System.Drawing.Size(264, 24);
            this.descriptionVal.StateCommon.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.descriptionVal.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.descriptionVal.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.descriptionVal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.descriptionVal.StateCommon.Border.Rounding = 5;
            this.descriptionVal.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.descriptionVal.StateCommon.Content.Font = new System.Drawing.Font("Russo One", 8F);
            this.descriptionVal.TabIndex = 16;
            this.descriptionVal.TabStop = false;
            this.descriptionVal.Tag = "";
            this.descriptionVal.Text = "введіть опис";
            this.descriptionVal.Enter += new System.EventHandler(this.descriptionVal_Enter);
            this.descriptionVal.Leave += new System.EventHandler(this.descriptionVal_Leave);
            // 
            // deleteStepButton
            // 
            this.deleteStepButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteStepButton.AutoSize = true;
            this.deleteStepButton.Location = new System.Drawing.Point(497, 46);
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
            // deleteIngridientButton
            // 
            this.deleteIngridientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteIngridientButton.AutoSize = true;
            this.deleteIngridientButton.Location = new System.Drawing.Point(560, 328);
            this.deleteIngridientButton.Name = "deleteIngridientButton";
            this.deleteIngridientButton.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.deleteIngridientButton.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.deleteIngridientButton.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.deleteIngridientButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.deleteIngridientButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.deleteIngridientButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteIngridientButton.OverrideDefault.Border.Rounding = 1;
            this.deleteIngridientButton.OverrideDefault.Border.Width = 0;
            this.deleteIngridientButton.OverrideFocus.Back.Color1 = System.Drawing.Color.Silver;
            this.deleteIngridientButton.OverrideFocus.Back.Color2 = System.Drawing.Color.Silver;
            this.deleteIngridientButton.Size = new System.Drawing.Size(20, 20);
            this.deleteIngridientButton.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.deleteIngridientButton.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.deleteIngridientButton.StateCommon.Back.Image = global::DishesGo.Properties.Resources.Cansle;
            this.deleteIngridientButton.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.deleteIngridientButton.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.deleteIngridientButton.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.deleteIngridientButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteIngridientButton.StateCommon.Border.Rounding = 0;
            this.deleteIngridientButton.StateCommon.Border.Width = 0;
            this.deleteIngridientButton.TabIndex = 39;
            this.deleteIngridientButton.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.deleteIngridientButton.Values.Text = "";
            this.deleteIngridientButton.Visible = false;
            this.deleteIngridientButton.Click += new System.EventHandler(this.deleteIngridientButton_Click);
            // 
            // timePrepareLabel
            // 
            this.timePrepareLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timePrepareLabel.AutoSize = true;
            this.timePrepareLabel.BackColor = System.Drawing.Color.Transparent;
            this.timePrepareLabel.Font = new System.Drawing.Font("Russo One", 8F);
            this.timePrepareLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.timePrepareLabel.Location = new System.Drawing.Point(17, 557);
            this.timePrepareLabel.Name = "timePrepareLabel";
            this.timePrepareLabel.Size = new System.Drawing.Size(114, 13);
            this.timePrepareLabel.TabIndex = 40;
            this.timePrepareLabel.Text = "Час приготування:";
            // 
            // timePrepareVal
            // 
            this.timePrepareVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timePrepareVal.Location = new System.Drawing.Point(135, 555);
            this.timePrepareVal.Name = "timePrepareVal";
            this.timePrepareVal.Size = new System.Drawing.Size(78, 21);
            this.timePrepareVal.StateCommon.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.timePrepareVal.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.timePrepareVal.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.timePrepareVal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.timePrepareVal.StateCommon.Border.Rounding = 5;
            this.timePrepareVal.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.timePrepareVal.StateCommon.Content.Font = new System.Drawing.Font("Russo One", 6F);
            this.timePrepareVal.TabIndex = 41;
            this.timePrepareVal.TabStop = false;
            this.timePrepareVal.Tag = "Time";
            this.timePrepareVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputOnlyNumbers_KeyPress);
            this.timePrepareVal.Leave += new System.EventHandler(this.inputOnlyNumbers_Leave);
            // 
            // timeUnitLabel
            // 
            this.timeUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeUnitLabel.AutoSize = true;
            this.timeUnitLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeUnitLabel.Font = new System.Drawing.Font("Russo One", 8F);
            this.timeUnitLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.timeUnitLabel.Location = new System.Drawing.Point(219, 557);
            this.timeUnitLabel.Name = "timeUnitLabel";
            this.timeUnitLabel.Size = new System.Drawing.Size(23, 13);
            this.timeUnitLabel.TabIndex = 42;
            this.timeUnitLabel.Text = "хв.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Russo One", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(20, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Калорії:";
            // 
            // caloriesVal
            // 
            this.caloriesVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.caloriesVal.Location = new System.Drawing.Point(79, 582);
            this.caloriesVal.Name = "caloriesVal";
            this.caloriesVal.Size = new System.Drawing.Size(78, 21);
            this.caloriesVal.StateCommon.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.caloriesVal.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.caloriesVal.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.caloriesVal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.caloriesVal.StateCommon.Border.Rounding = 5;
            this.caloriesVal.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.caloriesVal.StateCommon.Content.Font = new System.Drawing.Font("Russo One", 6F);
            this.caloriesVal.TabIndex = 44;
            this.caloriesVal.TabStop = false;
            this.caloriesVal.Tag = "";
            this.caloriesVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputOnlyNumbers_KeyPress);
            this.caloriesVal.Leave += new System.EventHandler(this.inputOnlyNumbers_Leave);
            // 
            // caloriesUnitLabel
            // 
            this.caloriesUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.caloriesUnitLabel.AutoSize = true;
            this.caloriesUnitLabel.BackColor = System.Drawing.Color.Transparent;
            this.caloriesUnitLabel.Font = new System.Drawing.Font("Russo One", 8F);
            this.caloriesUnitLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.caloriesUnitLabel.Location = new System.Drawing.Point(163, 586);
            this.caloriesUnitLabel.Name = "caloriesUnitLabel";
            this.caloriesUnitLabel.Size = new System.Drawing.Size(38, 13);
            this.caloriesUnitLabel.TabIndex = 45;
            this.caloriesUnitLabel.Text = "ккал.";
            // 
            // kitchenLabel
            // 
            this.kitchenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kitchenLabel.AutoSize = true;
            this.kitchenLabel.BackColor = System.Drawing.Color.Transparent;
            this.kitchenLabel.Font = new System.Drawing.Font("Russo One", 10F);
            this.kitchenLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.kitchenLabel.Location = new System.Drawing.Point(20, 482);
            this.kitchenLabel.Name = "kitchenLabel";
            this.kitchenLabel.Size = new System.Drawing.Size(54, 17);
            this.kitchenLabel.TabIndex = 46;
            this.kitchenLabel.Text = "Кухня:";
            // 
            // kitchenComboBox
            // 
            this.kitchenComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kitchenComboBox.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.kitchenComboBox.DropDownWidth = 128;
            this.kitchenComboBox.Location = new System.Drawing.Point(80, 478);
            this.kitchenComboBox.Name = "kitchenComboBox";
            this.kitchenComboBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kitchenComboBox.Size = new System.Drawing.Size(199, 22);
            this.kitchenComboBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.kitchenComboBox.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Transparent;
            this.kitchenComboBox.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Transparent;
            this.kitchenComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kitchenComboBox.StateCommon.ComboBox.Border.Rounding = 5;
            this.kitchenComboBox.StateCommon.ComboBox.Content.Color1 = System.Drawing.SystemColors.WindowFrame;
            this.kitchenComboBox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Russo One", 8F);
            this.kitchenComboBox.StateCommon.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.kitchenComboBox.StateCommon.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.kitchenComboBox.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Russo One", 8F);
            this.kitchenComboBox.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kitchenComboBox.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.kitchenComboBox.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Russo One", 8F);
            this.kitchenComboBox.TabIndex = 47;
            this.kitchenComboBox.TabStop = false;
            this.kitchenComboBox.Text = "виберіть кухню";
            this.kitchenComboBox.SelectedIndexChanged += new System.EventHandler(this.kitchenComboBox_SelectedIndexChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeLabel.AutoSize = true;
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Font = new System.Drawing.Font("Russo One", 10F);
            this.typeLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.typeLabel.Location = new System.Drawing.Point(20, 522);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(38, 17);
            this.typeLabel.TabIndex = 48;
            this.typeLabel.Text = "Тип:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.typeComboBox.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.typeComboBox.DropDownWidth = 128;
            this.typeComboBox.Location = new System.Drawing.Point(80, 518);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.typeComboBox.Size = new System.Drawing.Size(199, 22);
            this.typeComboBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.typeComboBox.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Transparent;
            this.typeComboBox.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Transparent;
            this.typeComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.typeComboBox.StateCommon.ComboBox.Border.Rounding = 5;
            this.typeComboBox.StateCommon.ComboBox.Content.Color1 = System.Drawing.SystemColors.WindowFrame;
            this.typeComboBox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Russo One", 8F);
            this.typeComboBox.StateCommon.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.typeComboBox.StateCommon.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.typeComboBox.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Russo One", 8F);
            this.typeComboBox.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.typeComboBox.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.typeComboBox.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Russo One", 8F);
            this.typeComboBox.TabIndex = 49;
            this.typeComboBox.TabStop = false;
            this.typeComboBox.Text = "виберіть тип";
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // infoImg
            // 
            this.infoImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.infoImg.Image = global::DishesGo.Properties.Resources.Info;
            this.infoImg.Location = new System.Drawing.Point(285, 478);
            this.infoImg.Name = "infoImg";
            this.infoImg.Size = new System.Drawing.Size(20, 20);
            this.infoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoImg.TabIndex = 50;
            this.infoImg.TabStop = false;
            this.infoImg.Visible = false;
            this.infoImg.MouseEnter += new System.EventHandler(this.infoImg_MouseEnter);
            this.infoImg.MouseLeave += new System.EventHandler(this.infoImg_MouseLeave);
            // 
            // RecipeImg
            // 
            this.RecipeImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecipeImg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RecipeImg.Image = global::DishesGo.Properties.Resources.titlePhoto;
            this.RecipeImg.Location = new System.Drawing.Point(25, 60);
            this.RecipeImg.Name = "RecipeImg";
            this.RecipeImg.Size = new System.Drawing.Size(320, 323);
            this.RecipeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RecipeImg.TabIndex = 0;
            this.RecipeImg.TabStop = false;
            this.RecipeImg.Click += new System.EventHandler(this.RecipeImg_Click);
            // 
            // descriptionKitchen
            // 
            this.descriptionKitchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.descriptionKitchen.AutoSize = true;
            this.descriptionKitchen.BackColor = System.Drawing.Color.OldLace;
            this.descriptionKitchen.Font = new System.Drawing.Font("Russo One", 7F);
            this.descriptionKitchen.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.descriptionKitchen.Location = new System.Drawing.Point(311, 478);
            this.descriptionKitchen.Name = "descriptionKitchen";
            this.descriptionKitchen.Size = new System.Drawing.Size(28, 12);
            this.descriptionKitchen.TabIndex = 51;
            this.descriptionKitchen.Text = "опис";
            this.descriptionKitchen.Visible = false;
            // 
            // warningTitle
            // 
            this.warningTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.warningTitle.AutoSize = true;
            this.warningTitle.BackColor = System.Drawing.Color.Transparent;
            this.warningTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.warningTitle.ForeColor = System.Drawing.Color.Red;
            this.warningTitle.Location = new System.Drawing.Point(195, 420);
            this.warningTitle.Name = "warningTitle";
            this.warningTitle.Size = new System.Drawing.Size(148, 13);
            this.warningTitle.TabIndex = 53;
            this.warningTitle.Text = "Назва є обов\'язковим полем.";
            this.warningTitle.Visible = false;
            // 
            // warningKitchen
            // 
            this.warningKitchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.warningKitchen.AutoSize = true;
            this.warningKitchen.BackColor = System.Drawing.Color.Transparent;
            this.warningKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.warningKitchen.ForeColor = System.Drawing.Color.Red;
            this.warningKitchen.Location = new System.Drawing.Point(132, 500);
            this.warningKitchen.Name = "warningKitchen";
            this.warningKitchen.Size = new System.Drawing.Size(147, 13);
            this.warningKitchen.TabIndex = 54;
            this.warningKitchen.Text = "Кухня є обов\'язковим полем.";
            this.warningKitchen.Visible = false;
            // 
            // warningType
            // 
            this.warningType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.warningType.AutoSize = true;
            this.warningType.BackColor = System.Drawing.Color.Transparent;
            this.warningType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.warningType.ForeColor = System.Drawing.Color.Red;
            this.warningType.Location = new System.Drawing.Point(132, 539);
            this.warningType.Name = "warningType";
            this.warningType.Size = new System.Drawing.Size(136, 13);
            this.warningType.TabIndex = 55;
            this.warningType.Text = "Тип є обов\'язковим полем.";
            this.warningType.Visible = false;
            // 
            // warningTime
            // 
            this.warningTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.warningTime.AutoSize = true;
            this.warningTime.BackColor = System.Drawing.Color.Transparent;
            this.warningTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.warningTime.ForeColor = System.Drawing.Color.Red;
            this.warningTime.Location = new System.Drawing.Point(241, 561);
            this.warningTime.Name = "warningTime";
            this.warningTime.Size = new System.Drawing.Size(102, 9);
            this.warningTime.TabIndex = 56;
            this.warningTime.Text = "Час є обов\'язковим полем.";
            this.warningTime.Visible = false;
            // 
            // warningCalories
            // 
            this.warningCalories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.warningCalories.AutoSize = true;
            this.warningCalories.BackColor = System.Drawing.Color.Transparent;
            this.warningCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.warningCalories.ForeColor = System.Drawing.Color.Red;
            this.warningCalories.Location = new System.Drawing.Point(207, 589);
            this.warningCalories.Name = "warningCalories";
            this.warningCalories.Size = new System.Drawing.Size(115, 9);
            this.warningCalories.TabIndex = 57;
            this.warningCalories.Text = "Калорії є обов\'язковим полем.";
            this.warningCalories.Visible = false;
            // 
            // warningSteps
            // 
            this.warningSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.warningSteps.AutoSize = true;
            this.warningSteps.BackColor = System.Drawing.Color.Transparent;
            this.warningSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.warningSteps.ForeColor = System.Drawing.Color.Red;
            this.warningSteps.Location = new System.Drawing.Point(523, 51);
            this.warningSteps.Name = "warningSteps";
            this.warningSteps.Size = new System.Drawing.Size(231, 13);
            this.warningSteps.TabIndex = 58;
            this.warningSteps.Text = "Кроки приготування не можуть бути пустими.";
            this.warningSteps.Visible = false;
            // 
            // warningIngredients
            // 
            this.warningIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.warningIngredients.AutoSize = true;
            this.warningIngredients.BackColor = System.Drawing.Color.Transparent;
            this.warningIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.warningIngredients.ForeColor = System.Drawing.Color.Red;
            this.warningIngredients.Location = new System.Drawing.Point(586, 335);
            this.warningIngredients.Name = "warningIngredients";
            this.warningIngredients.Size = new System.Drawing.Size(210, 13);
            this.warningIngredients.TabIndex = 59;
            this.warningIngredients.Text = "Список інгридієнтів не може бути пустим.";
            this.warningIngredients.Visible = false;
            // 
            // disableImageButton
            // 
            this.disableImageButton.Location = new System.Drawing.Point(0, 0);
            this.disableImageButton.Name = "disableImageButton";
            this.disableImageButton.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.disableImageButton.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.disableImageButton.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.disableImageButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.disableImageButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.disableImageButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.disableImageButton.OverrideDefault.Border.Rounding = 1;
            this.disableImageButton.OverrideDefault.Border.Width = 0;
            this.disableImageButton.OverrideFocus.Back.Color1 = System.Drawing.Color.Silver;
            this.disableImageButton.OverrideFocus.Back.Color2 = System.Drawing.Color.Silver;
            this.disableImageButton.Size = new System.Drawing.Size(20, 20);
            this.disableImageButton.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.disableImageButton.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.disableImageButton.StateCommon.Back.Image = global::DishesGo.Properties.Resources.Cansle;
            this.disableImageButton.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.disableImageButton.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.disableImageButton.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.disableImageButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.disableImageButton.StateCommon.Border.Rounding = 0;
            this.disableImageButton.StateCommon.Border.Width = 0;
            this.disableImageButton.TabIndex = 60;
            this.disableImageButton.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.disableImageButton.Values.Text = "";
            this.disableImageButton.Click += new System.EventHandler(this.disableImageButton_Click);
            // 
            // AddRecipePlateComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.disableImageButton);
            this.Controls.Add(this.warningIngredients);
            this.Controls.Add(this.warningSteps);
            this.Controls.Add(this.warningCalories);
            this.Controls.Add(this.warningTime);
            this.Controls.Add(this.warningType);
            this.Controls.Add(this.warningKitchen);
            this.Controls.Add(this.warningTitle);
            this.Controls.Add(this.descriptionKitchen);
            this.Controls.Add(this.infoImg);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.kitchenComboBox);
            this.Controls.Add(this.kitchenLabel);
            this.Controls.Add(this.caloriesUnitLabel);
            this.Controls.Add(this.caloriesVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeUnitLabel);
            this.Controls.Add(this.timePrepareVal);
            this.Controls.Add(this.timePrepareLabel);
            this.Controls.Add(this.deleteIngridientButton);
            this.Controls.Add(this.deleteStepButton);
            this.Controls.Add(this.addStepsButton);
            this.Controls.Add(this.addIngridientsButton);
            this.Controls.Add(this.ingridientsLabel);
            this.Controls.Add(this.ingredientsPanel);
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
            this.Size = new System.Drawing.Size(986, 611);
            ((System.ComponentModel.ISupportInitialize)(this.kitchenComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoImg)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel ingredientsPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addIngridientsButton;
        private System.Windows.Forms.Label titleLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addStepsButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox descriptionVal;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteStepButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteIngridientButton;
        private System.Windows.Forms.Label timePrepareLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox timePrepareVal;
        private System.Windows.Forms.Label timeUnitLabel;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox caloriesVal;
        private System.Windows.Forms.Label caloriesUnitLabel;
        private System.Windows.Forms.Label kitchenLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kitchenComboBox;
        private System.Windows.Forms.Label typeLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox typeComboBox;
        private System.Windows.Forms.PictureBox infoImg;
        private System.Windows.Forms.Label descriptionKitchen;
        private System.Windows.Forms.Label warningTitle;
        private System.Windows.Forms.Label warningKitchen;
        private System.Windows.Forms.Label warningType;
        private System.Windows.Forms.Label warningTime;
        private System.Windows.Forms.Label warningCalories;
        private System.Windows.Forms.Label warningSteps;
        private System.Windows.Forms.Label warningIngredients;
        private ComponentFactory.Krypton.Toolkit.KryptonButton disableImageButton;
    }
}
