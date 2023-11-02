namespace DishesGo.src.Components
{
    partial class IngridientsComponent
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
            this.ingridientsComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ingridientsComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ingridientsComboBox
            // 
            this.ingridientsComboBox.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.ingridientsComboBox.DropDownWidth = 121;
            this.ingridientsComboBox.Location = new System.Drawing.Point(14, 12);
            this.ingridientsComboBox.Name = "ingridientsComboBox";
            this.ingridientsComboBox.Size = new System.Drawing.Size(121, 21);
            this.ingridientsComboBox.TabIndex = 0;
            this.ingridientsComboBox.Text = "kryptonComboBox1";
            // 
            // IngridientsComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.ingridientsComboBox);
            this.Name = "IngridientsComponent";
            this.Size = new System.Drawing.Size(480, 45);
            ((System.ComponentModel.ISupportInitialize)(this.ingridientsComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ingridientsComboBox;
    }
}
