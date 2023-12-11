namespace DishesGo.src.Forms
{
    partial class BookmarksForm
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
            this.backButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bookmarksPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainLabel = new System.Windows.Forms.Label();
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
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.backButton.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.backButton.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.backButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.backButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.backButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.backButton.OverrideDefault.Border.Rounding = 1;
            this.backButton.OverrideDefault.Border.Width = 0;
            this.backButton.OverrideFocus.Back.Color1 = System.Drawing.Color.Silver;
            this.backButton.OverrideFocus.Back.Color2 = System.Drawing.Color.Silver;
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
            this.backButton.TabIndex = 30;
            this.backButton.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.backButton.Values.Text = "";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // bookmarksPanel
            // 
            this.bookmarksPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookmarksPanel.AutoScroll = true;
            this.bookmarksPanel.Location = new System.Drawing.Point(24, 50);
            this.bookmarksPanel.Name = "bookmarksPanel";
            this.bookmarksPanel.Size = new System.Drawing.Size(251, 380);
            this.bookmarksPanel.TabIndex = 31;
            // 
            // mainLabel
            // 
            this.mainLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainLabel.AutoSize = true;
            this.mainLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainLabel.Font = new System.Drawing.Font("Russo One", 14.25F);
            this.mainLabel.Location = new System.Drawing.Point(99, 17);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(103, 23);
            this.mainLabel.TabIndex = 11;
            this.mainLabel.Text = "Закладки";
            // 
            // BookmarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(298, 450);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.bookmarksPanel);
            this.Controls.Add(this.backButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookmarksForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BookmarksForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton backButton;
        private System.Windows.Forms.FlowLayoutPanel bookmarksPanel;
        private System.Windows.Forms.Label mainLabel;
    }
}