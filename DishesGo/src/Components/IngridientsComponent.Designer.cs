namespace DishesGo.src.Components
{
    partial class IngredientsComponent
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
            this.ingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishesGo_dbDataSet = new DishesGo.Data.DishesGo_dbDataSet();
            this.ingredientsTableAdapter = new DishesGo.Data.DishesGo_dbDataSetTableAdapters.IngredientsTableAdapter();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.quantityVal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ingredientComboBox = new DishesGo.src.Elements.ImageComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGo_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ingredientsBindingSource
            // 
            this.ingredientsBindingSource.DataMember = "Ingredients";
            this.ingredientsBindingSource.DataSource = this.dishesGo_dbDataSet;
            // 
            // dishesGo_dbDataSet
            // 
            this.dishesGo_dbDataSet.DataSetName = "DishesGo_dbDataSet";
            this.dishesGo_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingredientsTableAdapter
            // 
            this.ingredientsTableAdapter.ClearBeforeFill = true;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Russo One", 10F);
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.descriptionLabel.Location = new System.Drawing.Point(10, 6);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(130, 17);
            this.descriptionLabel.TabIndex = 13;
            this.descriptionLabel.Text = "Оберіть продукт:";
            // 
            // quantityVal
            // 
            this.quantityVal.Location = new System.Drawing.Point(13, 83);
            this.quantityVal.Name = "quantityVal";
            this.quantityVal.Size = new System.Drawing.Size(161, 28);
            this.quantityVal.StateCommon.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.quantityVal.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.quantityVal.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.quantityVal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.quantityVal.StateCommon.Border.Rounding = 5;
            this.quantityVal.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.quantityVal.StateCommon.Content.Font = new System.Drawing.Font("Russo One", 10F);
            this.quantityVal.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.quantityVal.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.quantityVal.TabIndex = 17;
            this.quantityVal.Tag = "";
            this.quantityVal.Text = "Кількість";
            this.quantityVal.Enter += new System.EventHandler(this.quantityVal_Enter);
            this.quantityVal.Leave += new System.EventHandler(this.quantityVal_Leave);
            // 
            // ingredientComboBox
            // 
            this.ingredientComboBox.BackColor = System.Drawing.Color.LightYellow;
            this.ingredientComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ingredientComboBox.DropDownHeight = 120;
            this.ingredientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ingredientComboBox.DropDownWidth = 260;
            this.ingredientComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingredientComboBox.Font = new System.Drawing.Font("Russo One", 10F);
            this.ingredientComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ingredientComboBox.IntegralHeight = false;
            this.ingredientComboBox.ItemHeight = 30;
            this.ingredientComboBox.Location = new System.Drawing.Point(13, 26);
            this.ingredientComboBox.Name = "ingredientComboBox";
            this.ingredientComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ingredientComboBox.Size = new System.Drawing.Size(161, 36);
            this.ingredientComboBox.Sorted = true;
            this.ingredientComboBox.TabIndex = 18;
            this.ingredientComboBox.TabStop = false;
            // 
            // IngredientsComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.ingredientComboBox);
            this.Controls.Add(this.quantityVal);
            this.Controls.Add(this.descriptionLabel);
            this.Name = "IngredientsComponent";
            this.Size = new System.Drawing.Size(189, 125);
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGo_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource ingredientsBindingSource;
        private Data.DishesGo_dbDataSet dishesGo_dbDataSet;
        private Data.DishesGo_dbDataSetTableAdapters.IngredientsTableAdapter ingredientsTableAdapter;
        private System.Windows.Forms.Label descriptionLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox quantityVal;
        private Elements.ImageComboBox ingredientComboBox;
    }
}
