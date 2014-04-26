namespace GradeACatering
{
    partial class frmSearchRecipes
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
            this.lsvSearch = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnResetSearch = new System.Windows.Forms.Button();
            this.txtPricePerServing = new System.Windows.Forms.TextBox();
            this.txtServingSize = new System.Windows.Forms.TextBox();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkPrice = new System.Windows.Forms.CheckBox();
            this.chkSvSize = new System.Windows.Forms.CheckBox();
            this.chkTags = new System.Windows.Forms.CheckBox();
            this.btnDisplayRecipe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvSearch
            // 
            this.lsvSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvSearch.FullRowSelect = true;
            this.lsvSearch.GridLines = true;
            this.lsvSearch.Location = new System.Drawing.Point(272, 45);
            this.lsvSearch.Name = "lsvSearch";
            this.lsvSearch.Size = new System.Drawing.Size(424, 260);
            this.lsvSearch.TabIndex = 2;
            this.lsvSearch.UseCompatibleStateImageBehavior = false;
            this.lsvSearch.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkName);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnResetSearch);
            this.groupBox1.Controls.Add(this.txtPricePerServing);
            this.groupBox1.Controls.Add(this.txtServingSize);
            this.groupBox1.Controls.Add(this.txtTags);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.chkPrice);
            this.groupBox1.Controls.Add(this.chkSvSize);
            this.groupBox1.Controls.Add(this.chkTags);
            this.groupBox1.Location = new System.Drawing.Point(34, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 269);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // chkName
            // 
            this.chkName.AutoSize = true;
            this.chkName.Location = new System.Drawing.Point(96, 37);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(91, 17);
            this.chkName.TabIndex = 25;
            this.chkName.Text = "Recipe Name";
            this.chkName.UseVisualStyleBackColor = true;
            this.chkName.CheckedChanged += new System.EventHandler(this.chkName_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Location = new System.Drawing.Point(7, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(83, 29);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 10);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(44, 17);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "And";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(48, 10);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(36, 17);
            this.radioButton4.TabIndex = 16;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Or";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Location = new System.Drawing.Point(6, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(83, 29);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "And";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(49, 10);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(36, 17);
            this.radioButton5.TabIndex = 16;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Or";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Location = new System.Drawing.Point(6, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(83, 29);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 10);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "And";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(48, 10);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(36, 17);
            this.radioButton6.TabIndex = 16;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Or";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 226);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 37);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.Location = new System.Drawing.Point(13, 19);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(64, 37);
            this.btnResetSearch.TabIndex = 4;
            this.btnResetSearch.Text = "Reset Fields";
            this.btnResetSearch.UseVisualStyleBackColor = true;
            this.btnResetSearch.Click += new System.EventHandler(this.btnResetSearch_Click);
            // 
            // txtPricePerServing
            // 
            this.txtPricePerServing.Location = new System.Drawing.Point(96, 196);
            this.txtPricePerServing.Name = "txtPricePerServing";
            this.txtPricePerServing.Size = new System.Drawing.Size(100, 20);
            this.txtPricePerServing.TabIndex = 10;
            // 
            // txtServingSize
            // 
            this.txtServingSize.Location = new System.Drawing.Point(96, 147);
            this.txtServingSize.Name = "txtServingSize";
            this.txtServingSize.Size = new System.Drawing.Size(100, 20);
            this.txtServingSize.TabIndex = 9;
            // 
            // txtTags
            // 
            this.txtTags.Location = new System.Drawing.Point(96, 103);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(100, 20);
            this.txtTags.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // chkPrice
            // 
            this.chkPrice.AutoSize = true;
            this.chkPrice.Location = new System.Drawing.Point(96, 173);
            this.chkPrice.Name = "chkPrice";
            this.chkPrice.Size = new System.Drawing.Size(108, 17);
            this.chkPrice.TabIndex = 5;
            this.chkPrice.Text = "Price Per Serving";
            this.chkPrice.UseVisualStyleBackColor = true;
            // 
            // chkSvSize
            // 
            this.chkSvSize.AutoSize = true;
            this.chkSvSize.Location = new System.Drawing.Point(96, 129);
            this.chkSvSize.Name = "chkSvSize";
            this.chkSvSize.Size = new System.Drawing.Size(85, 17);
            this.chkSvSize.TabIndex = 4;
            this.chkSvSize.Text = "Serving Size";
            this.chkSvSize.UseVisualStyleBackColor = true;
            // 
            // chkTags
            // 
            this.chkTags.AutoSize = true;
            this.chkTags.Location = new System.Drawing.Point(96, 81);
            this.chkTags.Name = "chkTags";
            this.chkTags.Size = new System.Drawing.Size(50, 17);
            this.chkTags.TabIndex = 3;
            this.chkTags.Text = "Tags";
            this.chkTags.UseVisualStyleBackColor = true;
            // 
            // btnDisplayRecipe
            // 
            this.btnDisplayRecipe.Location = new System.Drawing.Point(613, 320);
            this.btnDisplayRecipe.Name = "btnDisplayRecipe";
            this.btnDisplayRecipe.Size = new System.Drawing.Size(83, 37);
            this.btnDisplayRecipe.TabIndex = 6;
            this.btnDisplayRecipe.Text = "Display Recipe";
            this.btnDisplayRecipe.UseVisualStyleBackColor = true;
            this.btnDisplayRecipe.Click += new System.EventHandler(this.btnDisplayRecipe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "To search the catalog of recipes, please use the filers below";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 320);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 37);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Back To Main Menu";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSearchRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 369);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisplayRecipe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsvSearch);
            this.Name = "frmSearchRecipes";
            this.Text = "Search Recipes";
            this.Load += new System.EventHandler(this.frmSearchRecipes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResetSearch;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtPricePerServing;
        private System.Windows.Forms.TextBox txtServingSize;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkPrice;
        private System.Windows.Forms.CheckBox chkSvSize;
        private System.Windows.Forms.CheckBox chkTags;
        private System.Windows.Forms.Button btnDisplayRecipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.CheckBox chkName;
        private System.Windows.Forms.Button btnClose;
    }
}