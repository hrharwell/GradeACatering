﻿namespace GradeACatering
{
    partial class frmShowAllRecipes
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
            this.lsvAllRecipes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpenRecipe = new System.Windows.Forms.Button();
            this.btnReturnToMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvAllRecipes
            // 
            this.lsvAllRecipes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvAllRecipes.FullRowSelect = true;
            this.lsvAllRecipes.Location = new System.Drawing.Point(41, 55);
            this.lsvAllRecipes.Name = "lsvAllRecipes";
            this.lsvAllRecipes.Size = new System.Drawing.Size(548, 347);
            this.lsvAllRecipes.TabIndex = 0;
            this.lsvAllRecipes.UseCompatibleStateImageBehavior = false;
            this.lsvAllRecipes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Servings";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 57;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cost/Serving";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Prep Time";
            this.columnHeader5.Width = 64;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cook Time";
            this.columnHeader6.Width = 73;
            // 
            // btnOpenRecipe
            // 
            this.btnOpenRecipe.Location = new System.Drawing.Point(541, 417);
            this.btnOpenRecipe.Name = "btnOpenRecipe";
            this.btnOpenRecipe.Size = new System.Drawing.Size(84, 44);
            this.btnOpenRecipe.TabIndex = 1;
            this.btnOpenRecipe.Text = "Display Recipe";
            this.btnOpenRecipe.UseVisualStyleBackColor = true;
            this.btnOpenRecipe.Click += new System.EventHandler(this.btnOpenRecipe_Click);
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.Location = new System.Drawing.Point(12, 417);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(84, 44);
            this.btnReturnToMenu.TabIndex = 3;
            this.btnReturnToMenu.Text = "Return to Main Menu";
            this.btnReturnToMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMenu.Click += new System.EventHandler(this.btnReturnToMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a recipe to either display or delete.";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(268, 417);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 44);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Recipe";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmShowAllRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 483);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturnToMenu);
            this.Controls.Add(this.btnOpenRecipe);
            this.Controls.Add(this.lsvAllRecipes);
            this.Name = "frmShowAllRecipes";
            this.Text = "All Recipes";
            this.Load += new System.EventHandler(this.frmShowAllRecipes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvAllRecipes;
        private System.Windows.Forms.Button btnOpenRecipe;
        private System.Windows.Forms.Button btnReturnToMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnDelete;

    }
}