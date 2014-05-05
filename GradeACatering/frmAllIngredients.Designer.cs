namespace GradeACatering
{
    partial class frmAllIngredients
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturnToMenu = new System.Windows.Forms.Button();
            this.btnOpenIngredient = new System.Windows.Forms.Button();
            this.lsvAllRecipes = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select an Ingredient to either display or edit.";
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.Location = new System.Drawing.Point(22, 404);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(84, 44);
            this.btnReturnToMenu.TabIndex = 7;
            this.btnReturnToMenu.Text = "Return to Main Menu";
            this.btnReturnToMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMenu.Click += new System.EventHandler(this.btnReturnToMenu_Click);
            // 
            // btnOpenIngredient
            // 
            this.btnOpenIngredient.Location = new System.Drawing.Point(522, 404);
            this.btnOpenIngredient.Name = "btnOpenIngredient";
            this.btnOpenIngredient.Size = new System.Drawing.Size(84, 44);
            this.btnOpenIngredient.TabIndex = 6;
            this.btnOpenIngredient.Text = "Display Ingredient";
            this.btnOpenIngredient.UseVisualStyleBackColor = true;
            // 
            // lsvAllRecipes
            // 
            this.lsvAllRecipes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colCount});
            this.lsvAllRecipes.Location = new System.Drawing.Point(22, 41);
            this.lsvAllRecipes.Name = "lsvAllRecipes";
            this.lsvAllRecipes.Size = new System.Drawing.Size(548, 347);
            this.lsvAllRecipes.TabIndex = 5;
            this.lsvAllRecipes.UseCompatibleStateImageBehavior = false;
            this.lsvAllRecipes.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 253;
            // 
            // colCount
            // 
            this.colCount.Text = "Used In";
            this.colCount.Width = 289;
            // 
            // frmAllIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturnToMenu);
            this.Controls.Add(this.btnOpenIngredient);
            this.Controls.Add(this.lsvAllRecipes);
            this.Name = "frmAllIngredients";
            this.Text = "frmAllIngredients";
            this.Load += new System.EventHandler(this.frmAllIngredients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturnToMenu;
        private System.Windows.Forms.Button btnOpenIngredient;
        private System.Windows.Forms.ListView lsvAllRecipes;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCount;
    }
}