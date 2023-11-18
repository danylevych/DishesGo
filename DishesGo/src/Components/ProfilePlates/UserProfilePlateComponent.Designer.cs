namespace DishesGo.src.Components.ProfilePlates
{
    partial class UserProfilePlateComponent
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
            this.backButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(3, 3);
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
            this.backButton.TabIndex = 31;
            this.backButton.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.backButton.Values.Text = "";
            // 
            // UserProfilePlateComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backButton);
            this.Name = "UserProfilePlateComponent";
            this.Controls.SetChildIndex(this.profileImg, 0);
            this.Controls.SetChildIndex(this.profileNameLabel, 0);
            this.Controls.SetChildIndex(this.nicknameLabel, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.backButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton backButton;
    }
}
