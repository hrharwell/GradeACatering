namespace GradeACatering
{
    partial class frmStart
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
            this.btnSearchfrm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeeAllRecipes = new System.Windows.Forms.Button();
            this.btnNewRecipe = new System.Windows.Forms.Button();
            this.btnTestfrm = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bbtnShowAllIngredient = new System.Windows.Forms.Button();
            this.btnAddIngr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Welcome!  Please select from the following menu options.";
            // 
            // btnSearchfrm
            // 
            this.btnSearchfrm.Location = new System.Drawing.Point(24, 31);
            this.btnSearchfrm.Name = "btnSearchfrm";
            this.btnSearchfrm.Size = new System.Drawing.Size(124, 51);
            this.btnSearchfrm.TabIndex = 2;
            this.btnSearchfrm.Text = "Search Recipes";
            this.btnSearchfrm.UseVisualStyleBackColor = true;
            this.btnSearchfrm.Click += new System.EventHandler(this.btnSearchfrm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeeAllRecipes);
            this.groupBox1.Controls.Add(this.btnNewRecipe);
            this.groupBox1.Controls.Add(this.btnSearchfrm);
            this.groupBox1.Location = new System.Drawing.Point(26, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 106);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recipes";
            // 
            // btnSeeAllRecipes
            // 
            this.btnSeeAllRecipes.Location = new System.Drawing.Point(304, 31);
            this.btnSeeAllRecipes.Name = "btnSeeAllRecipes";
            this.btnSeeAllRecipes.Size = new System.Drawing.Size(124, 51);
            this.btnSeeAllRecipes.TabIndex = 4;
            this.btnSeeAllRecipes.Text = "Show All Recipes";
            this.btnSeeAllRecipes.UseVisualStyleBackColor = true;
            this.btnSeeAllRecipes.Click += new System.EventHandler(this.btnSeeAllRecipes_Click);
            // 
            // btnNewRecipe
            // 
            this.btnNewRecipe.Location = new System.Drawing.Point(164, 31);
            this.btnNewRecipe.Name = "btnNewRecipe";
            this.btnNewRecipe.Size = new System.Drawing.Size(124, 51);
            this.btnNewRecipe.TabIndex = 3;
            this.btnNewRecipe.Text = "Enter New Recipe";
            this.btnNewRecipe.UseVisualStyleBackColor = true;
            this.btnNewRecipe.Click += new System.EventHandler(this.btnNewRecipe_Click);
            // 
            // btnTestfrm
            // 
            this.btnTestfrm.Location = new System.Drawing.Point(536, 424);
            this.btnTestfrm.Name = "btnTestfrm";
            this.btnTestfrm.Size = new System.Drawing.Size(124, 51);
            this.btnTestfrm.TabIndex = 7;
            this.btnTestfrm.Text = "Our Test Form";
            this.btnTestfrm.UseVisualStyleBackColor = true;
            this.btnTestfrm.Click += new System.EventHandler(this.btnTestfrm_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bbtnShowAllIngredient);
            this.groupBox3.Controls.Add(this.btnAddIngr);
            this.groupBox3.Location = new System.Drawing.Point(26, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 88);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingredients";
            // 
            // bbtnShowAllIngredient
            // 
            this.bbtnShowAllIngredient.Location = new System.Drawing.Point(175, 19);
            this.bbtnShowAllIngredient.Name = "bbtnShowAllIngredient";
            this.bbtnShowAllIngredient.Size = new System.Drawing.Size(123, 51);
            this.bbtnShowAllIngredient.TabIndex = 3;
            this.bbtnShowAllIngredient.Text = "Show All Ingredients";
            this.bbtnShowAllIngredient.UseVisualStyleBackColor = true;
            this.bbtnShowAllIngredient.Click += new System.EventHandler(this.bbtnShowAllIngredient_Click);
            // 
            // btnAddIngr
            // 
            this.btnAddIngr.Location = new System.Drawing.Point(20, 19);
            this.btnAddIngr.Name = "btnAddIngr";
            this.btnAddIngr.Size = new System.Drawing.Size(123, 51);
            this.btnAddIngr.TabIndex = 2;
            this.btnAddIngr.Text = "Add New Ingredient ";
            this.btnAddIngr.UseVisualStyleBackColor = true;
            this.btnAddIngr.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GradeACatering.Properties.Resources.GradeAlogo;
            this.pictureBox1.Location = new System.Drawing.Point(31, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 158);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 396);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnTestfrm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmStart";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchfrm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTestfrm;
        private System.Windows.Forms.Button btnNewRecipe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddIngr;
        private System.Windows.Forms.Button btnSeeAllRecipes;
        private System.Windows.Forms.Button bbtnShowAllIngredient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}