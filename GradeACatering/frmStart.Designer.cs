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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutRecipeMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearchfrm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNewMeal = new System.Windows.Forms.Button();
            this.btnMealOrders = new System.Windows.Forms.Button();
            this.btnTestfrm = new System.Windows.Forms.Button();
            this.btnNewRecipe = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRawIngr = new System.Windows.Forms.Button();
            this.btnAddIngr = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Welcome! Please select from the following forms";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreenToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.fullScreenToolStripMenuItem.Text = "Full Screen";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutRecipeMeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutRecipeMeToolStripMenuItem
            // 
            this.aboutRecipeMeToolStripMenuItem.Name = "aboutRecipeMeToolStripMenuItem";
            this.aboutRecipeMeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.aboutRecipeMeToolStripMenuItem.Text = "About RecipeMe";
            // 
            // btnSearchfrm
            // 
            this.btnSearchfrm.Location = new System.Drawing.Point(25, 31);
            this.btnSearchfrm.Name = "btnSearchfrm";
            this.btnSearchfrm.Size = new System.Drawing.Size(124, 51);
            this.btnSearchfrm.TabIndex = 2;
            this.btnSearchfrm.Text = "Search Recipes";
            this.btnSearchfrm.UseVisualStyleBackColor = true;
            this.btnSearchfrm.Click += new System.EventHandler(this.btnSearchfrm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewRecipe);
            this.groupBox1.Controls.Add(this.btnSearchfrm);
            this.groupBox1.Location = new System.Drawing.Point(41, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recipes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNewMeal);
            this.groupBox2.Controls.Add(this.btnMealOrders);
            this.groupBox2.Location = new System.Drawing.Point(41, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meals";
            // 
            // btnNewMeal
            // 
            this.btnNewMeal.Location = new System.Drawing.Point(165, 30);
            this.btnNewMeal.Name = "btnNewMeal";
            this.btnNewMeal.Size = new System.Drawing.Size(124, 51);
            this.btnNewMeal.TabIndex = 3;
            this.btnNewMeal.Text = "Create New Order List";
            this.btnNewMeal.UseVisualStyleBackColor = true;
            this.btnNewMeal.Click += new System.EventHandler(this.btnNewMeal_Click);
            // 
            // btnMealOrders
            // 
            this.btnMealOrders.Location = new System.Drawing.Point(25, 30);
            this.btnMealOrders.Name = "btnMealOrders";
            this.btnMealOrders.Size = new System.Drawing.Size(124, 51);
            this.btnMealOrders.TabIndex = 2;
            this.btnMealOrders.Text = "View Meal Orders";
            this.btnMealOrders.UseVisualStyleBackColor = true;
            // 
            // btnTestfrm
            // 
            this.btnTestfrm.Location = new System.Drawing.Point(441, 232);
            this.btnTestfrm.Name = "btnTestfrm";
            this.btnTestfrm.Size = new System.Drawing.Size(124, 51);
            this.btnTestfrm.TabIndex = 7;
            this.btnTestfrm.Text = "Our Test Form";
            this.btnTestfrm.UseVisualStyleBackColor = true;
            this.btnTestfrm.Click += new System.EventHandler(this.btnTestfrm_Click);
            // 
            // btnNewRecipe
            // 
            this.btnNewRecipe.Location = new System.Drawing.Point(179, 31);
            this.btnNewRecipe.Name = "btnNewRecipe";
            this.btnNewRecipe.Size = new System.Drawing.Size(124, 51);
            this.btnNewRecipe.TabIndex = 3;
            this.btnNewRecipe.Text = "Enter Recipe";
            this.btnNewRecipe.UseVisualStyleBackColor = true;
            this.btnNewRecipe.Click += new System.EventHandler(this.btnNewRecipe_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRawIngr);
            this.groupBox3.Controls.Add(this.btnAddIngr);
            this.groupBox3.Location = new System.Drawing.Point(423, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 156);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recipes";
            // 
            // btnRawIngr
            // 
            this.btnRawIngr.Location = new System.Drawing.Point(18, 83);
            this.btnRawIngr.Name = "btnRawIngr";
            this.btnRawIngr.Size = new System.Drawing.Size(124, 51);
            this.btnRawIngr.TabIndex = 3;
            this.btnRawIngr.Text = "Add Basic Ingredients";
            this.btnRawIngr.UseVisualStyleBackColor = true;
            // 
            // btnAddIngr
            // 
            this.btnAddIngr.Location = new System.Drawing.Point(18, 26);
            this.btnAddIngr.Name = "btnAddIngr";
            this.btnAddIngr.Size = new System.Drawing.Size(124, 51);
            this.btnAddIngr.TabIndex = 2;
            this.btnAddIngr.Text = "Add Ingredient ";
            this.btnAddIngr.UseVisualStyleBackColor = true;
            this.btnAddIngr.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 347);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnTestfrm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStart";
            this.Text = "StartForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnSearchfrm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNewMeal;
        private System.Windows.Forms.Button btnMealOrders;
        private System.Windows.Forms.Button btnTestfrm;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutRecipeMeToolStripMenuItem;
        private System.Windows.Forms.Button btnNewRecipe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRawIngr;
        private System.Windows.Forms.Button btnAddIngr;
    }
}