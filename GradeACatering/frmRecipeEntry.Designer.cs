namespace GradeACatering
{
    partial class frmRecipeEntry
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCookDirections = new System.Windows.Forms.TextBox();
            this.txtPrepDirections = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveRecipe = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.cboIng = new System.Windows.Forms.ComboBox();
            this.btnEditIng = new System.Windows.Forms.Button();
            this.btnDeleteIng = new System.Windows.Forms.Button();
            this.btnAddIng = new System.Windows.Forms.Button();
            this.lsvIngrediants = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtServingSize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCookTime = new System.Windows.Forms.TextBox();
            this.txtPrepTime = new System.Windows.Forms.TextBox();
            this.txtPriceSold = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lbxTags = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddToTagList = new System.Windows.Forms.Button();
            this.btnRemoveSelectedTag = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCookDirections);
            this.groupBox2.Controls.Add(this.txtPrepDirections);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(550, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 284);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Directions";
            // 
            // txtCookDirections
            // 
            this.txtCookDirections.Location = new System.Drawing.Point(18, 166);
            this.txtCookDirections.Multiline = true;
            this.txtCookDirections.Name = "txtCookDirections";
            this.txtCookDirections.Size = new System.Drawing.Size(213, 110);
            this.txtCookDirections.TabIndex = 8;
            // 
            // txtPrepDirections
            // 
            this.txtPrepDirections.Location = new System.Drawing.Point(18, 38);
            this.txtPrepDirections.Multiline = true;
            this.txtPrepDirections.Name = "txtPrepDirections";
            this.txtPrepDirections.Size = new System.Drawing.Size(213, 110);
            this.txtPrepDirections.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cooking Directions\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prep Directions\r\n";
            // 
            // btnSaveRecipe
            // 
            this.btnSaveRecipe.Location = new System.Drawing.Point(134, 314);
            this.btnSaveRecipe.Name = "btnSaveRecipe";
            this.btnSaveRecipe.Size = new System.Drawing.Size(90, 45);
            this.btnSaveRecipe.TabIndex = 18;
            this.btnSaveRecipe.Text = "Save Recipe";
            this.btnSaveRecipe.UseVisualStyleBackColor = true;
            this.btnSaveRecipe.Click += new System.EventHandler(this.btnSaveRecipe_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtQty);
            this.groupBox3.Controls.Add(this.cboUnit);
            this.groupBox3.Controls.Add(this.cboIng);
            this.groupBox3.Controls.Add(this.btnEditIng);
            this.groupBox3.Controls.Add(this.btnDeleteIng);
            this.groupBox3.Controls.Add(this.btnAddIng);
            this.groupBox3.Controls.Add(this.lsvIngrediants);
            this.groupBox3.Location = new System.Drawing.Point(276, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 284);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Made of Ingredients";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Define Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Qty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Name";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(148, 239);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(31, 20);
            this.txtQty.TabIndex = 15;
            // 
            // cboUnit
            // 
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Items.AddRange(new object[] {
            "lb",
            "oz"});
            this.cboUnit.Location = new System.Drawing.Point(185, 239);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(66, 21);
            this.cboUnit.TabIndex = 13;
            // 
            // cboIng
            // 
            this.cboIng.FormattingEnabled = true;
            this.cboIng.Location = new System.Drawing.Point(18, 239);
            this.cboIng.Name = "cboIng";
            this.cboIng.Size = new System.Drawing.Size(121, 21);
            this.cboIng.TabIndex = 12;
            // 
            // btnEditIng
            // 
            this.btnEditIng.Location = new System.Drawing.Point(60, 182);
            this.btnEditIng.Name = "btnEditIng";
            this.btnEditIng.Size = new System.Drawing.Size(45, 23);
            this.btnEditIng.TabIndex = 11;
            this.btnEditIng.Text = "Edit";
            this.btnEditIng.UseVisualStyleBackColor = true;
            // 
            // btnDeleteIng
            // 
            this.btnDeleteIng.Location = new System.Drawing.Point(111, 182);
            this.btnDeleteIng.Name = "btnDeleteIng";
            this.btnDeleteIng.Size = new System.Drawing.Size(46, 23);
            this.btnDeleteIng.TabIndex = 10;
            this.btnDeleteIng.Text = "Delete";
            this.btnDeleteIng.UseVisualStyleBackColor = true;
            this.btnDeleteIng.Click += new System.EventHandler(this.btnDeleteIng_Click);
            // 
            // btnAddIng
            // 
            this.btnAddIng.Location = new System.Drawing.Point(18, 182);
            this.btnAddIng.Name = "btnAddIng";
            this.btnAddIng.Size = new System.Drawing.Size(36, 23);
            this.btnAddIng.TabIndex = 9;
            this.btnAddIng.Text = "Add";
            this.btnAddIng.UseVisualStyleBackColor = true;
            this.btnAddIng.Click += new System.EventHandler(this.btnAddIng_Click);
            // 
            // lsvIngrediants
            // 
            this.lsvIngrediants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvIngrediants.Location = new System.Drawing.Point(18, 19);
            this.lsvIngrediants.Name = "lsvIngrediants";
            this.lsvIngrediants.Size = new System.Drawing.Size(229, 159);
            this.lsvIngrediants.TabIndex = 8;
            this.lsvIngrediants.UseCompatibleStateImageBehavior = false;
            this.lsvIngrediants.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qty";
            this.columnHeader2.Width = 37;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtServingSize);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCookTime);
            this.groupBox1.Controls.Add(this.txtPrepTime);
            this.groupBox1.Controls.Add(this.txtPriceSold);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 245);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Info";
            // 
            // txtServingSize
            // 
            this.txtServingSize.Location = new System.Drawing.Point(132, 135);
            this.txtServingSize.Name = "txtServingSize";
            this.txtServingSize.Size = new System.Drawing.Size(54, 20);
            this.txtServingSize.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Serving Size/unit";
            // 
            // txtCookTime
            // 
            this.txtCookTime.Location = new System.Drawing.Point(131, 113);
            this.txtCookTime.Name = "txtCookTime";
            this.txtCookTime.Size = new System.Drawing.Size(54, 20);
            this.txtCookTime.TabIndex = 8;
            // 
            // txtPrepTime
            // 
            this.txtPrepTime.Location = new System.Drawing.Point(131, 88);
            this.txtPrepTime.Name = "txtPrepTime";
            this.txtPrepTime.Size = new System.Drawing.Size(54, 20);
            this.txtPrepTime.TabIndex = 7;
            // 
            // txtPriceSold
            // 
            this.txtPriceSold.Location = new System.Drawing.Point(131, 64);
            this.txtPriceSold.Name = "txtPriceSold";
            this.txtPriceSold.Size = new System.Drawing.Size(54, 20);
            this.txtPriceSold.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.Location = new System.Drawing.Point(70, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(115, 20);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cook Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Prep Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price Sold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Number";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRemoveSelectedTag);
            this.groupBox4.Controls.Add(this.btnAddToTagList);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.lbxTags);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(298, 314);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(499, 164);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Categorize";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Tags (Ex. #Jon Doe\'s#Favorite Pie)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(243, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Additional Notes";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(29, 314);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 45);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear All Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnNewFrm_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(29, 417);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 45);
            this.btnReturn.TabIndex = 23;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lbxTags
            // 
            this.lbxTags.FormattingEnabled = true;
            this.lbxTags.Location = new System.Drawing.Point(18, 58);
            this.lbxTags.Name = "lbxTags";
            this.lbxTags.Size = new System.Drawing.Size(211, 95);
            this.lbxTags.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 8;
            // 
            // btnAddToTagList
            // 
            this.btnAddToTagList.Location = new System.Drawing.Point(163, 30);
            this.btnAddToTagList.Name = "btnAddToTagList";
            this.btnAddToTagList.Size = new System.Drawing.Size(62, 23);
            this.btnAddToTagList.TabIndex = 9;
            this.btnAddToTagList.Text = "Add Tag";
            this.btnAddToTagList.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSelectedTag
            // 
            this.btnRemoveSelectedTag.Location = new System.Drawing.Point(235, 119);
            this.btnRemoveSelectedTag.Name = "btnRemoveSelectedTag";
            this.btnRemoveSelectedTag.Size = new System.Drawing.Size(59, 34);
            this.btnRemoveSelectedTag.TabIndex = 10;
            this.btnRemoveSelectedTag.Text = "Remove\r\nSelected";
            this.btnRemoveSelectedTag.UseVisualStyleBackColor = true;
            // 
            // frmRecipeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 494);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSaveRecipe);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRecipeEntry";
            this.Text = "Enter A New Recipe or Edit An Existing Recipe";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCookDirections;
        private System.Windows.Forms.TextBox txtPrepDirections;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveRecipe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.ComboBox cboIng;
        private System.Windows.Forms.Button btnEditIng;
        private System.Windows.Forms.Button btnDeleteIng;
        private System.Windows.Forms.Button btnAddIng;
        private System.Windows.Forms.ListView lsvIngrediants;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtServingSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCookTime;
        private System.Windows.Forms.TextBox txtPrepTime;
        private System.Windows.Forms.TextBox txtPriceSold;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddToTagList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbxTags;
        private System.Windows.Forms.Button btnRemoveSelectedTag;
    }
}