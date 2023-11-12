namespace DishesGo.src.Forms.ProfileForms
{
    partial class EditRecipeForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.saveChanging = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.recipeImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleVal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.labelsGroup = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.descriptionKitchen = new System.Windows.Forms.Label();
            this.infoImg = new System.Windows.Forms.PictureBox();
            this.caloriesUnitLabel = new System.Windows.Forms.Label();
            this.caloriesVal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timeUnitLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.kitchenComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kitchenLabel = new System.Windows.Forms.Label();
            this.timePrepareVal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.timePrepareLabel = new System.Windows.Forms.Label();
            this.descriptionVal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.backButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.warningSteps = new System.Windows.Forms.Label();
            this.deleteStepButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addStepsButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.stepsLabels = new System.Windows.Forms.Label();
            this.stepsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.warningIngredients = new System.Windows.Forms.Label();
            this.deleteIngridientButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addIngridientsButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ingridientsLabel = new System.Windows.Forms.Label();
            this.ingredientsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.disableLabelsButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.disabelRecipeImg = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.disableIngredientsButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.disableStepsButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.recipeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelsGroup.Panel)).BeginInit();
            this.labelsGroup.Panel.SuspendLayout();
            this.labelsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenComboBox)).BeginInit();
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
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Russo One", 23F);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.titleLabel.Location = new System.Drawing.Point(440, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(251, 38);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Зміна рецепту";
            // 
            // saveChanging
            // 
            this.saveChanging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveChanging.Location = new System.Drawing.Point(996, 15);
            this.saveChanging.Name = "saveChanging";
            this.saveChanging.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.OverrideDefault.Back.ColorAngle = 45F;
            this.saveChanging.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.OverrideDefault.Border.ColorAngle = 45F;
            this.saveChanging.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.saveChanging.OverrideDefault.Border.Rounding = 13;
            this.saveChanging.OverrideDefault.Border.Width = 1;
            this.saveChanging.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.OverrideFocus.Back.ColorAngle = 45F;
            this.saveChanging.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.OverrideFocus.Border.ColorAngle = 45F;
            this.saveChanging.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.saveChanging.OverrideFocus.Border.Rounding = 13;
            this.saveChanging.OverrideFocus.Border.Width = 1;
            this.saveChanging.Size = new System.Drawing.Size(90, 30);
            this.saveChanging.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.StateCommon.Back.ColorAngle = 45F;
            this.saveChanging.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.StateCommon.Border.ColorAngle = 45F;
            this.saveChanging.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.saveChanging.StateCommon.Border.Rounding = 13;
            this.saveChanging.StateCommon.Border.Width = 1;
            this.saveChanging.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Orbitron", 8F, System.Drawing.FontStyle.Bold);
            this.saveChanging.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.StateDisabled.Back.ColorAngle = 45F;
            this.saveChanging.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.StateDisabled.Border.ColorAngle = 45F;
            this.saveChanging.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.saveChanging.StateDisabled.Border.Rounding = 13;
            this.saveChanging.StateDisabled.Border.Width = 1;
            this.saveChanging.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.StateNormal.Back.ColorAngle = 45F;
            this.saveChanging.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.StateNormal.Border.ColorAngle = 45F;
            this.saveChanging.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.saveChanging.StateNormal.Border.Rounding = 13;
            this.saveChanging.StateNormal.Border.Width = 1;
            this.saveChanging.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.StatePressed.Back.ColorAngle = 45F;
            this.saveChanging.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.saveChanging.StatePressed.Border.ColorAngle = 45F;
            this.saveChanging.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.saveChanging.StatePressed.Border.Rounding = 13;
            this.saveChanging.StatePressed.Border.Width = 1;
            this.saveChanging.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.saveChanging.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.saveChanging.StateTracking.Back.ColorAngle = 45F;
            this.saveChanging.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.saveChanging.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(148)))));
            this.saveChanging.StateTracking.Border.ColorAngle = 45F;
            this.saveChanging.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.saveChanging.StateTracking.Border.Rounding = 13;
            this.saveChanging.StateTracking.Border.Width = 1;
            this.saveChanging.TabIndex = 31;
            this.saveChanging.Values.Text = "Зберегти";
            this.saveChanging.Click += new System.EventHandler(this.saveChanging_Click);
            // 
            // recipeImg
            // 
            this.recipeImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recipeImg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.recipeImg.Image = global::DishesGo.Properties.Resources.titlePhoto;
            this.recipeImg.Location = new System.Drawing.Point(40, 95);
            this.recipeImg.Name = "recipeImg";
            this.recipeImg.Size = new System.Drawing.Size(392, 354);
            this.recipeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recipeImg.TabIndex = 32;
            this.recipeImg.TabStop = false;
            this.recipeImg.Click += new System.EventHandler(this.recipeImg_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Russo One", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Назва:";
            // 
            // titleVal
            // 
            this.titleVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleVal.Location = new System.Drawing.Point(94, 17);
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
            this.titleVal.TabIndex = 34;
            this.titleVal.TabStop = false;
            this.titleVal.Tag = "";
            this.titleVal.Enter += new System.EventHandler(this.textBox_Enter);
            this.titleVal.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // labelsGroup
            // 
            this.labelsGroup.Location = new System.Drawing.Point(447, 69);
            this.labelsGroup.Name = "labelsGroup";
            // 
            // labelsGroup.Panel
            // 
            this.labelsGroup.Panel.Controls.Add(this.descriptionKitchen);
            this.labelsGroup.Panel.Controls.Add(this.infoImg);
            this.labelsGroup.Panel.Controls.Add(this.caloriesUnitLabel);
            this.labelsGroup.Panel.Controls.Add(this.caloriesVal);
            this.labelsGroup.Panel.Controls.Add(this.label2);
            this.labelsGroup.Panel.Controls.Add(this.timeUnitLabel);
            this.labelsGroup.Panel.Controls.Add(this.typeComboBox);
            this.labelsGroup.Panel.Controls.Add(this.typeLabel);
            this.labelsGroup.Panel.Controls.Add(this.kitchenComboBox);
            this.labelsGroup.Panel.Controls.Add(this.kitchenLabel);
            this.labelsGroup.Panel.Controls.Add(this.timePrepareVal);
            this.labelsGroup.Panel.Controls.Add(this.timePrepareLabel);
            this.labelsGroup.Panel.Controls.Add(this.descriptionVal);
            this.labelsGroup.Panel.Controls.Add(this.descriptionLabel);
            this.labelsGroup.Panel.Controls.Add(this.label1);
            this.labelsGroup.Panel.Controls.Add(this.titleVal);
            this.labelsGroup.Size = new System.Drawing.Size(630, 176);
            this.labelsGroup.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.labelsGroup.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.labelsGroup.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.labelsGroup.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.labelsGroup.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.labelsGroup.StateCommon.Border.Rounding = 8;
            this.labelsGroup.StateCommon.Border.Width = 5;
            this.labelsGroup.TabIndex = 35;
            // 
            // descriptionKitchen
            // 
            this.descriptionKitchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.descriptionKitchen.BackColor = System.Drawing.Color.OldLace;
            this.descriptionKitchen.Font = new System.Drawing.Font("Russo One", 7F);
            this.descriptionKitchen.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.descriptionKitchen.Location = new System.Drawing.Point(335, 0);
            this.descriptionKitchen.Name = "descriptionKitchen";
            this.descriptionKitchen.Size = new System.Drawing.Size(189, 93);
            this.descriptionKitchen.TabIndex = 63;
            this.descriptionKitchen.Text = "опис";
            this.descriptionKitchen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.descriptionKitchen.Visible = false;
            // 
            // infoImg
            // 
            this.infoImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.infoImg.Image = global::DishesGo.Properties.Resources.Info;
            this.infoImg.Location = new System.Drawing.Point(309, 86);
            this.infoImg.Name = "infoImg";
            this.infoImg.Size = new System.Drawing.Size(20, 20);
            this.infoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoImg.TabIndex = 62;
            this.infoImg.TabStop = false;
            this.infoImg.MouseEnter += new System.EventHandler(this.infoImg_MouseEnter);
            this.infoImg.MouseLeave += new System.EventHandler(this.infoImg_MouseLeave);
            // 
            // caloriesUnitLabel
            // 
            this.caloriesUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caloriesUnitLabel.AutoSize = true;
            this.caloriesUnitLabel.BackColor = System.Drawing.Color.Transparent;
            this.caloriesUnitLabel.Font = new System.Drawing.Font("Russo One", 8F);
            this.caloriesUnitLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.caloriesUnitLabel.Location = new System.Drawing.Point(178, 119);
            this.caloriesUnitLabel.Name = "caloriesUnitLabel";
            this.caloriesUnitLabel.Size = new System.Drawing.Size(38, 13);
            this.caloriesUnitLabel.TabIndex = 61;
            this.caloriesUnitLabel.Text = "ккал.";
            // 
            // caloriesVal
            // 
            this.caloriesVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caloriesVal.Location = new System.Drawing.Point(94, 115);
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
            this.caloriesVal.TabIndex = 60;
            this.caloriesVal.TabStop = false;
            this.caloriesVal.Tag = "";
            this.caloriesVal.Enter += new System.EventHandler(this.textBox_Enter);
            this.caloriesVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputOnlyNumbers_KeyPress);
            this.caloriesVal.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Russo One", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(35, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Калорії:";
            // 
            // timeUnitLabel
            // 
            this.timeUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeUnitLabel.AutoSize = true;
            this.timeUnitLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeUnitLabel.Font = new System.Drawing.Font("Russo One", 8F);
            this.timeUnitLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.timeUnitLabel.Location = new System.Drawing.Point(573, 115);
            this.timeUnitLabel.Name = "timeUnitLabel";
            this.timeUnitLabel.Size = new System.Drawing.Size(23, 13);
            this.timeUnitLabel.TabIndex = 58;
            this.timeUnitLabel.Text = "хв.";
            // 
            // typeComboBox
            // 
            this.typeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeComboBox.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.typeComboBox.DropDownWidth = 128;
            this.typeComboBox.Location = new System.Drawing.Point(410, 17);
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
            this.typeComboBox.TabIndex = 57;
            this.typeComboBox.TabStop = false;
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeLabel.AutoSize = true;
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Font = new System.Drawing.Font("Russo One", 10F);
            this.typeLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.typeLabel.Location = new System.Drawing.Point(366, 22);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(38, 17);
            this.typeLabel.TabIndex = 56;
            this.typeLabel.Text = "Тип:";
            // 
            // kitchenComboBox
            // 
            this.kitchenComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kitchenComboBox.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.kitchenComboBox.DropDownWidth = 128;
            this.kitchenComboBox.Location = new System.Drawing.Point(94, 87);
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
            this.kitchenComboBox.TabIndex = 55;
            this.kitchenComboBox.TabStop = false;
            // 
            // kitchenLabel
            // 
            this.kitchenLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kitchenLabel.AutoSize = true;
            this.kitchenLabel.BackColor = System.Drawing.Color.Transparent;
            this.kitchenLabel.Font = new System.Drawing.Font("Russo One", 10F);
            this.kitchenLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.kitchenLabel.Location = new System.Drawing.Point(34, 87);
            this.kitchenLabel.Name = "kitchenLabel";
            this.kitchenLabel.Size = new System.Drawing.Size(54, 17);
            this.kitchenLabel.TabIndex = 54;
            this.kitchenLabel.Text = "Кухня:";
            // 
            // timePrepareVal
            // 
            this.timePrepareVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timePrepareVal.Location = new System.Drawing.Point(489, 113);
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
            this.timePrepareVal.TabIndex = 53;
            this.timePrepareVal.TabStop = false;
            this.timePrepareVal.Tag = "Time";
            this.timePrepareVal.Enter += new System.EventHandler(this.textBox_Enter);
            this.timePrepareVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputOnlyNumbers_KeyPress);
            this.timePrepareVal.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // timePrepareLabel
            // 
            this.timePrepareLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timePrepareLabel.AutoSize = true;
            this.timePrepareLabel.BackColor = System.Drawing.Color.Transparent;
            this.timePrepareLabel.Font = new System.Drawing.Font("Russo One", 8F);
            this.timePrepareLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.timePrepareLabel.Location = new System.Drawing.Point(371, 115);
            this.timePrepareLabel.Name = "timePrepareLabel";
            this.timePrepareLabel.Size = new System.Drawing.Size(114, 13);
            this.timePrepareLabel.TabIndex = 52;
            this.timePrepareLabel.Text = "Час приготування:";
            // 
            // descriptionVal
            // 
            this.descriptionVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionVal.Location = new System.Drawing.Point(94, 56);
            this.descriptionVal.Name = "descriptionVal";
            this.descriptionVal.Size = new System.Drawing.Size(515, 24);
            this.descriptionVal.StateCommon.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.descriptionVal.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.descriptionVal.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.descriptionVal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.descriptionVal.StateCommon.Border.Rounding = 5;
            this.descriptionVal.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.descriptionVal.StateCommon.Content.Font = new System.Drawing.Font("Russo One", 8F);
            this.descriptionVal.TabIndex = 51;
            this.descriptionVal.TabStop = false;
            this.descriptionVal.Tag = "";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.descriptionLabel.Location = new System.Drawing.Point(34, 56);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(54, 19);
            this.descriptionLabel.TabIndex = 50;
            this.descriptionLabel.Text = "Опис:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 15);
            this.backButton.Name = "backButton";
            this.backButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.backButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.backButton.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.backButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.backButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.backButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.backButton.OverrideDefault.Border.Rounding = 1;
            this.backButton.OverrideDefault.Border.Width = 0;
            this.backButton.OverrideFocus.Back.Color1 = System.Drawing.Color.Transparent;
            this.backButton.OverrideFocus.Back.Color2 = System.Drawing.Color.Transparent;
            this.backButton.Size = new System.Drawing.Size(30, 30);
            this.backButton.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.backButton.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.backButton.StateCommon.Back.Image = global::DishesGo.Properties.Resources.Back;
            this.backButton.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.backButton.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.backButton.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.backButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.backButton.StateCommon.Border.Rounding = 0;
            this.backButton.StateCommon.Border.Width = 0;
            this.backButton.TabIndex = 36;
            this.backButton.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.backButton.Values.Text = "";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // warningSteps
            // 
            this.warningSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.warningSteps.AutoSize = true;
            this.warningSteps.BackColor = System.Drawing.Color.Transparent;
            this.warningSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.warningSteps.ForeColor = System.Drawing.Color.Red;
            this.warningSteps.Location = new System.Drawing.Point(596, 256);
            this.warningSteps.Name = "warningSteps";
            this.warningSteps.Size = new System.Drawing.Size(231, 13);
            this.warningSteps.TabIndex = 63;
            this.warningSteps.Text = "Кроки приготування не можуть бути пустими.";
            this.warningSteps.Visible = false;
            // 
            // deleteStepButton
            // 
            this.deleteStepButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteStepButton.AutoSize = true;
            this.deleteStepButton.Location = new System.Drawing.Point(570, 251);
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
            this.deleteStepButton.TabIndex = 62;
            this.deleteStepButton.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.deleteStepButton.Values.Text = "";
            this.deleteStepButton.Click += new System.EventHandler(this.deleteStepButton_Click);
            // 
            // addStepsButton
            // 
            this.addStepsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addStepsButton.AutoSize = true;
            this.addStepsButton.Location = new System.Drawing.Point(534, 251);
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
            this.addStepsButton.TabIndex = 61;
            this.addStepsButton.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.addStepsButton.Values.Text = "";
            this.addStepsButton.Click += new System.EventHandler(this.addStepsButton_Click);
            // 
            // stepsLabels
            // 
            this.stepsLabels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepsLabels.AutoSize = true;
            this.stepsLabels.BackColor = System.Drawing.Color.Transparent;
            this.stepsLabels.Font = new System.Drawing.Font("Russo One", 14.25F);
            this.stepsLabels.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.stepsLabels.Location = new System.Drawing.Point(459, 248);
            this.stepsLabels.Name = "stepsLabels";
            this.stepsLabels.Size = new System.Drawing.Size(70, 23);
            this.stepsLabels.TabIndex = 60;
            this.stepsLabels.Text = "Кроки";
            // 
            // stepsPanel
            // 
            this.stepsPanel.AllowDrop = true;
            this.stepsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepsPanel.AutoScroll = true;
            this.stepsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.stepsPanel.Location = new System.Drawing.Point(447, 274);
            this.stepsPanel.Name = "stepsPanel";
            this.stepsPanel.Size = new System.Drawing.Size(630, 205);
            this.stepsPanel.TabIndex = 59;
            this.stepsPanel.Tag = "Steps";
            this.stepsPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Panel_ControlAdded);
            this.stepsPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Panel_ControlRemoved);
            // 
            // warningIngredients
            // 
            this.warningIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.warningIngredients.AutoSize = true;
            this.warningIngredients.BackColor = System.Drawing.Color.Transparent;
            this.warningIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.warningIngredients.ForeColor = System.Drawing.Color.Red;
            this.warningIngredients.Location = new System.Drawing.Point(250, 482);
            this.warningIngredients.Name = "warningIngredients";
            this.warningIngredients.Size = new System.Drawing.Size(210, 13);
            this.warningIngredients.TabIndex = 68;
            this.warningIngredients.Text = "Список інгридієнтів не може бути пустим.";
            this.warningIngredients.Visible = false;
            // 
            // deleteIngridientButton
            // 
            this.deleteIngridientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteIngridientButton.AutoSize = true;
            this.deleteIngridientButton.Location = new System.Drawing.Point(224, 475);
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
            this.deleteIngridientButton.TabIndex = 67;
            this.deleteIngridientButton.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.deleteIngridientButton.Values.Text = "";
            this.deleteIngridientButton.Click += new System.EventHandler(this.deleteIngridientButton_Click);
            // 
            // addIngridientsButton
            // 
            this.addIngridientsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addIngridientsButton.AutoSize = true;
            this.addIngridientsButton.Location = new System.Drawing.Point(184, 475);
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
            this.addIngridientsButton.TabIndex = 66;
            this.addIngridientsButton.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.addIngridientsButton.Values.Text = "";
            this.addIngridientsButton.Click += new System.EventHandler(this.addIngridientsButton_Click);
            // 
            // ingridientsLabel
            // 
            this.ingridientsLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.ingridientsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ingridientsLabel.AutoSize = true;
            this.ingridientsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ingridientsLabel.Font = new System.Drawing.Font("Russo One", 14.25F);
            this.ingridientsLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ingridientsLabel.Location = new System.Drawing.Point(54, 475);
            this.ingridientsLabel.Name = "ingridientsLabel";
            this.ingridientsLabel.Size = new System.Drawing.Size(126, 23);
            this.ingridientsLabel.TabIndex = 65;
            this.ingridientsLabel.Text = "Інгридієнти";
            // 
            // ingredientsPanel
            // 
            this.ingredientsPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.ingredientsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ingredientsPanel.AutoScroll = true;
            this.ingredientsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ingredientsPanel.Location = new System.Drawing.Point(38, 501);
            this.ingredientsPanel.Name = "ingredientsPanel";
            this.ingredientsPanel.Size = new System.Drawing.Size(1038, 150);
            this.ingredientsPanel.TabIndex = 64;
            this.ingredientsPanel.Tag = "Ingredients";
            this.ingredientsPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Panel_ControlAdded);
            this.ingredientsPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Panel_ControlRemoved);
            // 
            // disableLabelsButton
            // 
            this.disableLabelsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.disableLabelsButton.AutoSize = true;
            this.disableLabelsButton.Location = new System.Drawing.Point(1077, 79);
            this.disableLabelsButton.Name = "disableLabelsButton";
            this.disableLabelsButton.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.disableLabelsButton.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.disableLabelsButton.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.disableLabelsButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.disableLabelsButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.disableLabelsButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.disableLabelsButton.OverrideDefault.Border.Rounding = 1;
            this.disableLabelsButton.OverrideDefault.Border.Width = 0;
            this.disableLabelsButton.OverrideFocus.Back.Color1 = System.Drawing.Color.Silver;
            this.disableLabelsButton.OverrideFocus.Back.Color2 = System.Drawing.Color.Silver;
            this.disableLabelsButton.Size = new System.Drawing.Size(20, 20);
            this.disableLabelsButton.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.disableLabelsButton.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.disableLabelsButton.StateCommon.Back.Image = global::DishesGo.Properties.Resources.Cansle;
            this.disableLabelsButton.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.disableLabelsButton.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.disableLabelsButton.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.disableLabelsButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.disableLabelsButton.StateCommon.Border.Rounding = 0;
            this.disableLabelsButton.StateCommon.Border.Width = 0;
            this.disableLabelsButton.TabIndex = 69;
            this.disableLabelsButton.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.disableLabelsButton.Values.Text = "";
            this.disableLabelsButton.Click += new System.EventHandler(this.disableLabelsButton_Click);
            // 
            // disabelRecipeImg
            // 
            this.disabelRecipeImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.disabelRecipeImg.AutoSize = true;
            this.disabelRecipeImg.Location = new System.Drawing.Point(38, 95);
            this.disabelRecipeImg.Name = "disabelRecipeImg";
            this.disabelRecipeImg.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.disabelRecipeImg.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.disabelRecipeImg.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.disabelRecipeImg.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.disabelRecipeImg.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.disabelRecipeImg.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.disabelRecipeImg.OverrideDefault.Border.Rounding = 1;
            this.disabelRecipeImg.OverrideDefault.Border.Width = 0;
            this.disabelRecipeImg.OverrideFocus.Back.Color1 = System.Drawing.Color.Silver;
            this.disabelRecipeImg.OverrideFocus.Back.Color2 = System.Drawing.Color.Silver;
            this.disabelRecipeImg.Size = new System.Drawing.Size(20, 20);
            this.disabelRecipeImg.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.disabelRecipeImg.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.disabelRecipeImg.StateCommon.Back.Image = global::DishesGo.Properties.Resources.Cansle;
            this.disabelRecipeImg.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.disabelRecipeImg.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.disabelRecipeImg.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.disabelRecipeImg.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.disabelRecipeImg.StateCommon.Border.Rounding = 0;
            this.disabelRecipeImg.StateCommon.Border.Width = 0;
            this.disabelRecipeImg.TabIndex = 70;
            this.disabelRecipeImg.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.disabelRecipeImg.Values.Text = "";
            this.disabelRecipeImg.Click += new System.EventHandler(this.disabelRecipeImg_Click);
            // 
            // disableIngredientsButton
            // 
            this.disableIngredientsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.disableIngredientsButton.AutoSize = true;
            this.disableIngredientsButton.Location = new System.Drawing.Point(1077, 511);
            this.disableIngredientsButton.Name = "disableIngredientsButton";
            this.disableIngredientsButton.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.disableIngredientsButton.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.disableIngredientsButton.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.disableIngredientsButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.disableIngredientsButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.disableIngredientsButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.disableIngredientsButton.OverrideDefault.Border.Rounding = 1;
            this.disableIngredientsButton.OverrideDefault.Border.Width = 0;
            this.disableIngredientsButton.OverrideFocus.Back.Color1 = System.Drawing.Color.Silver;
            this.disableIngredientsButton.OverrideFocus.Back.Color2 = System.Drawing.Color.Silver;
            this.disableIngredientsButton.Size = new System.Drawing.Size(20, 20);
            this.disableIngredientsButton.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.disableIngredientsButton.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.disableIngredientsButton.StateCommon.Back.Image = global::DishesGo.Properties.Resources.Cansle;
            this.disableIngredientsButton.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.disableIngredientsButton.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.disableIngredientsButton.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.disableIngredientsButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.disableIngredientsButton.StateCommon.Border.Rounding = 0;
            this.disableIngredientsButton.StateCommon.Border.Width = 0;
            this.disableIngredientsButton.TabIndex = 71;
            this.disableIngredientsButton.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.disableIngredientsButton.Values.Text = "";
            this.disableIngredientsButton.Click += new System.EventHandler(this.disableIngredientsButton_Click);
            // 
            // disableStepsButton
            // 
            this.disableStepsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.disableStepsButton.AutoSize = true;
            this.disableStepsButton.Location = new System.Drawing.Point(1077, 284);
            this.disableStepsButton.Name = "disableStepsButton";
            this.disableStepsButton.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.disableStepsButton.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.disableStepsButton.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.disableStepsButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.disableStepsButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.disableStepsButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.disableStepsButton.OverrideDefault.Border.Rounding = 1;
            this.disableStepsButton.OverrideDefault.Border.Width = 0;
            this.disableStepsButton.OverrideFocus.Back.Color1 = System.Drawing.Color.Silver;
            this.disableStepsButton.OverrideFocus.Back.Color2 = System.Drawing.Color.Silver;
            this.disableStepsButton.Size = new System.Drawing.Size(20, 20);
            this.disableStepsButton.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.disableStepsButton.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.disableStepsButton.StateCommon.Back.Image = global::DishesGo.Properties.Resources.Cansle;
            this.disableStepsButton.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.disableStepsButton.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.disableStepsButton.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.disableStepsButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.disableStepsButton.StateCommon.Border.Rounding = 0;
            this.disableStepsButton.StateCommon.Border.Width = 0;
            this.disableStepsButton.TabIndex = 72;
            this.disableStepsButton.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.disableStepsButton.Values.Text = "";
            this.disableStepsButton.Click += new System.EventHandler(this.disableStepsButton_Click);
            // 
            // EditRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 682);
            this.Controls.Add(this.disableStepsButton);
            this.Controls.Add(this.disableIngredientsButton);
            this.Controls.Add(this.disabelRecipeImg);
            this.Controls.Add(this.disableLabelsButton);
            this.Controls.Add(this.warningIngredients);
            this.Controls.Add(this.deleteIngridientButton);
            this.Controls.Add(this.addIngridientsButton);
            this.Controls.Add(this.ingridientsLabel);
            this.Controls.Add(this.ingredientsPanel);
            this.Controls.Add(this.warningSteps);
            this.Controls.Add(this.deleteStepButton);
            this.Controls.Add(this.addStepsButton);
            this.Controls.Add(this.stepsLabels);
            this.Controls.Add(this.stepsPanel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.labelsGroup);
            this.Controls.Add(this.recipeImg);
            this.Controls.Add(this.saveChanging);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditRecipeForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditRecipeForm";
            ((System.ComponentModel.ISupportInitialize)(this.recipeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelsGroup.Panel)).EndInit();
            this.labelsGroup.Panel.ResumeLayout(false);
            this.labelsGroup.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelsGroup)).EndInit();
            this.labelsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenComboBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label titleLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton saveChanging;
        private System.Windows.Forms.PictureBox recipeImg;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox titleVal;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup labelsGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox typeComboBox;
        private System.Windows.Forms.Label typeLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kitchenComboBox;
        private System.Windows.Forms.Label kitchenLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox timePrepareVal;
        private System.Windows.Forms.Label timePrepareLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox descriptionVal;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label timeUnitLabel;
        private System.Windows.Forms.Label caloriesUnitLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox caloriesVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label descriptionKitchen;
        private System.Windows.Forms.PictureBox infoImg;
        private ComponentFactory.Krypton.Toolkit.KryptonButton backButton;
        private System.Windows.Forms.Label warningSteps;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteStepButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addStepsButton;
        private System.Windows.Forms.Label stepsLabels;
        private System.Windows.Forms.FlowLayoutPanel stepsPanel;
        private System.Windows.Forms.Label warningIngredients;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteIngridientButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addIngridientsButton;
        private System.Windows.Forms.Label ingridientsLabel;
        private System.Windows.Forms.FlowLayoutPanel ingredientsPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton disableLabelsButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton disabelRecipeImg;
        private ComponentFactory.Krypton.Toolkit.KryptonButton disableIngredientsButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton disableStepsButton;
    }
}