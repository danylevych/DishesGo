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
            this.components = new System.ComponentModel.Container();
            this.ingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishesGo_dbDataSet = new DishesGo.Data.DishesGo_dbDataSet();
            this.ingredientsTableAdapter = new DishesGo.Data.DishesGo_dbDataSetTableAdapters.IngredientsTableAdapter();
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
            // ingredientComboBox
            // 
            this.ingredientComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ingredientComboBox.BackColor = System.Drawing.Color.LightYellow;
            this.ingredientComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ingredientComboBox.DropDownHeight = 150;
            this.ingredientComboBox.DropDownWidth = 170;
            this.ingredientComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ingredientComboBox.Font = new System.Drawing.Font("Russo One", 8F);
            this.ingredientComboBox.FormattingEnabled = true;
            this.ingredientComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ingredientComboBox.IntegralHeight = false;
            this.ingredientComboBox.ItemHeight = 30;
            this.ingredientComboBox.Location = new System.Drawing.Point(3, 3);
            this.ingredientComboBox.Name = "ingredientComboBox";
            this.ingredientComboBox.Size = new System.Drawing.Size(170, 36);
            this.ingredientComboBox.TabIndex = 1;
            // 
            // IngridientsComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.ingredientComboBox);
            this.Name = "IngridientsComponent";
            this.Size = new System.Drawing.Size(480, 45);
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesGo_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ingredientsBindingSource;
        private Data.DishesGo_dbDataSet dishesGo_dbDataSet;
        private Data.DishesGo_dbDataSetTableAdapters.IngredientsTableAdapter ingredientsTableAdapter;
        private Elements.ImageComboBox ingredientComboBox;
    }
}
