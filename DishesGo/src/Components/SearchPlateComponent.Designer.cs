namespace DishesGo.src.Components
{
    partial class SearchPlateComponent
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
            this.components = new System.ComponentModel.Container();
            this.recipePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.filtersButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.filtersPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ingredientsCheckBoxes = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kitchenCheckBoxes = new System.Windows.Forms.CheckedListBox();
            this.line1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.imageCheckedListBox1 = new DishesGo.src.Elements.ImageCheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.filtersPanel)).BeginInit();
            this.filtersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).BeginInit();
            this.SuspendLayout();
            // 
            // recipePanel
            // 
            this.recipePanel.AllowDrop = true;
            this.recipePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recipePanel.AutoScroll = true;
            this.recipePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.recipePanel.Location = new System.Drawing.Point(15, 15);
            this.recipePanel.Name = "recipePanel";
            this.recipePanel.Size = new System.Drawing.Size(960, 560);
            this.recipePanel.TabIndex = 33;
            this.recipePanel.Tag = "Steps";
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
            // filtersButton
            // 
            this.filtersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filtersButton.Location = new System.Drawing.Point(15, 581);
            this.filtersButton.Name = "filtersButton";
            this.filtersButton.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.filtersButton.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.filtersButton.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.filtersButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.filtersButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.filtersButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.filtersButton.OverrideDefault.Border.Rounding = 1;
            this.filtersButton.OverrideDefault.Border.Width = 0;
            this.filtersButton.OverrideFocus.Back.Color1 = System.Drawing.Color.Transparent;
            this.filtersButton.OverrideFocus.Back.Color2 = System.Drawing.Color.Transparent;
            this.filtersButton.Size = new System.Drawing.Size(20, 20);
            this.filtersButton.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.filtersButton.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.filtersButton.StateCommon.Back.Image = global::DishesGo.Properties.Resources.Filter;
            this.filtersButton.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.filtersButton.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.filtersButton.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.filtersButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.filtersButton.StateCommon.Border.Rounding = 0;
            this.filtersButton.StateCommon.Border.Width = 0;
            this.filtersButton.TabIndex = 37;
            this.filtersButton.Tag = "false";
            this.filtersButton.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.filtersButton.Values.Text = "";
            this.filtersButton.Click += new System.EventHandler(this.filtersButton_Click);
            // 
            // filtersPanel
            // 
            this.filtersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filtersPanel.AutoScroll = true;
            this.filtersPanel.Controls.Add(this.imageCheckedListBox1);
            this.filtersPanel.Controls.Add(this.ingredientsCheckBoxes);
            this.filtersPanel.Controls.Add(this.label2);
            this.filtersPanel.Controls.Add(this.label1);
            this.filtersPanel.Controls.Add(this.kitchenCheckBoxes);
            this.filtersPanel.Controls.Add(this.line1);
            this.filtersPanel.Controls.Add(this.titleLabel);
            this.filtersPanel.Location = new System.Drawing.Point(0, 15);
            this.filtersPanel.Name = "filtersPanel";
            this.filtersPanel.Size = new System.Drawing.Size(345, 560);
            this.filtersPanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.filtersPanel.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.filtersPanel.TabIndex = 38;
            this.filtersPanel.Visible = false;
            // 
            // ingredientsCheckBoxes
            // 
            this.ingredientsCheckBoxes.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ingredientsCheckBoxes.FormattingEnabled = true;
            this.ingredientsCheckBoxes.Location = new System.Drawing.Point(6, 254);
            this.ingredientsCheckBoxes.Name = "ingredientsCheckBoxes";
            this.ingredientsCheckBoxes.Size = new System.Drawing.Size(326, 166);
            this.ingredientsCheckBoxes.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Russo One", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(9, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Інгридієнти";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Russo One", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Тип кухні";
            // 
            // kitchenCheckBoxes
            // 
            this.kitchenCheckBoxes.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kitchenCheckBoxes.FormattingEnabled = true;
            this.kitchenCheckBoxes.Location = new System.Drawing.Point(6, 65);
            this.kitchenCheckBoxes.Name = "kitchenCheckBoxes";
            this.kitchenCheckBoxes.Size = new System.Drawing.Size(326, 166);
            this.kitchenCheckBoxes.TabIndex = 37;
            // 
            // line1
            // 
            this.line1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            this.line1.Location = new System.Drawing.Point(0, 25);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(320, 5);
            this.line1.TabIndex = 36;
            this.line1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Russo One", 15F);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.titleLabel.Location = new System.Drawing.Point(114, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(98, 25);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Фільтри";
            // 
            // imageCheckedListBox1
            // 
            this.imageCheckedListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.imageCheckedListBox1.FormattingEnabled = true;
            this.imageCheckedListBox1.Location = new System.Drawing.Point(3, 430);
            this.imageCheckedListBox1.Name = "imageCheckedListBox1";
            this.imageCheckedListBox1.Size = new System.Drawing.Size(329, 122);
            this.imageCheckedListBox1.TabIndex = 41;
            // 
            // SearchPlateComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.filtersPanel);
            this.Controls.Add(this.filtersButton);
            this.Controls.Add(this.recipePanel);
            this.Name = "SearchPlateComponent";
            this.Size = new System.Drawing.Size(986, 611);
            ((System.ComponentModel.ISupportInitialize)(this.filtersPanel)).EndInit();
            this.filtersPanel.ResumeLayout(false);
            this.filtersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel recipePanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton filtersButton;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel filtersPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox line1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox kitchenCheckBoxes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ingredientsCheckBoxes;
        private Elements.ImageCheckedListBox imageCheckedListBox1;
    }
}
