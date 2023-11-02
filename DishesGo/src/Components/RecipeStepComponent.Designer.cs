namespace DishesGo.src.Components
{
    partial class RecipeStepComponent
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
            this.numLabel = new System.Windows.Forms.Label();
            this.stepVal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // numLabel
            // 
            this.numLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numLabel.AutoSize = true;
            this.numLabel.BackColor = System.Drawing.Color.Transparent;
            this.numLabel.Font = new System.Drawing.Font("Russo One", 10F);
            this.numLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.numLabel.Location = new System.Drawing.Point(14, 14);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(53, 17);
            this.numLabel.TabIndex = 14;
            this.numLabel.Text = "Крок 1";
            // 
            // stepVal
            // 
            this.stepVal.Location = new System.Drawing.Point(80, 8);
            this.stepVal.Name = "stepVal";
            this.stepVal.Size = new System.Drawing.Size(384, 28);
            this.stepVal.StateCommon.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.stepVal.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.stepVal.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.stepVal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.stepVal.StateCommon.Border.Rounding = 5;
            this.stepVal.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.stepVal.StateCommon.Content.Font = new System.Drawing.Font("Russo One", 10F);
            this.stepVal.TabIndex = 16;
            this.stepVal.Tag = "";
            this.stepVal.Text = "\r\n";
            // 
            // RecipeStepComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.stepVal);
            this.Name = "RecipeStepComponent";
            this.Size = new System.Drawing.Size(480, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox stepVal;
    }
}
