namespace GradeACatering
{
    partial class frmDisplayRecipe
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRemoveSelectedTag = new System.Windows.Forms.Button();
            this.btnAddToTagList = new System.Windows.Forms.Button();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.lbxTags = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCookDir = new System.Windows.Forms.TextBox();
            this.txtPrepDir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnEditRecipe = new System.Windows.Forms.Button();
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
            this.lsvIngredients = new System.Windows.Forms.ListView();
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
            this.lblComingSoon = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(40, 332);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 45);
            this.btnPrint.TabIndex = 29;
            this.btnPrint.Text = "Print Recipe";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRemoveSelectedTag);
            this.groupBox4.Controls.Add(this.btnAddToTagList);
            this.groupBox4.Controls.Add(this.txtTags);
            this.groupBox4.Controls.Add(this.lbxTags);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(384, 332);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 164);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Categorize";
            // 
            // btnRemoveSelectedTag
            // 
            this.btnRemoveSelectedTag.Location = new System.Drawing.Point(235, 121);
            this.btnRemoveSelectedTag.Name = "btnRemoveSelectedTag";
            this.btnRemoveSelectedTag.Size = new System.Drawing.Size(59, 34);
            this.btnRemoveSelectedTag.TabIndex = 16;
            this.btnRemoveSelectedTag.Text = "Remove\r\nSelected";
            this.btnRemoveSelectedTag.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedTag.Click += new System.EventHandler(this.btnRemoveSelectedTag_Click);
            // 
            // btnAddToTagList
            // 
            this.btnAddToTagList.Location = new System.Drawing.Point(163, 32);
            this.btnAddToTagList.Name = "btnAddToTagList";
            this.btnAddToTagList.Size = new System.Drawing.Size(62, 23);
            this.btnAddToTagList.TabIndex = 15;
            this.btnAddToTagList.Text = "Add Tag";
            this.btnAddToTagList.UseVisualStyleBackColor = true;
            this.btnAddToTagList.Click += new System.EventHandler(this.btnAddToTagList_Click);
            // 
            // txtTags
            // 
            this.txtTags.Location = new System.Drawing.Point(18, 34);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(139, 20);
            this.txtTags.TabIndex = 14;
            // 
            // lbxTags
            // 
            this.lbxTags.FormattingEnabled = true;
            this.lbxTags.Location = new System.Drawing.Point(18, 60);
            this.lbxTags.Name = "lbxTags";
            this.lbxTags.Size = new System.Drawing.Size(211, 95);
            this.lbxTags.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Tags (Ex. #Jon Doe\'s#Favorite Pie)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCookDir);
            this.groupBox2.Controls.Add(this.txtPrepDir);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(561, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 284);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Directions";
            // 
            // txtCookDir
            // 
            this.txtCookDir.Location = new System.Drawing.Point(18, 166);
            this.txtCookDir.Multiline = true;
            this.txtCookDir.Name = "txtCookDir";
            this.txtCookDir.Size = new System.Drawing.Size(213, 110);
            this.txtCookDir.TabIndex = 8;
            // 
            // txtPrepDir
            // 
            this.txtPrepDir.Location = new System.Drawing.Point(18, 38);
            this.txtPrepDir.Multiline = true;
            this.txtPrepDir.Name = "txtPrepDir";
            this.txtPrepDir.Size = new System.Drawing.Size(213, 110);
            this.txtPrepDir.TabIndex = 7;
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
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(45, 435);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 45);
            this.btnReturn.TabIndex = 26;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnEditRecipe
            // 
            this.btnEditRecipe.Location = new System.Drawing.Point(145, 332);
            this.btnEditRecipe.Name = "btnEditRecipe";
            this.btnEditRecipe.Size = new System.Drawing.Size(90, 45);
            this.btnEditRecipe.TabIndex = 25;
            this.btnEditRecipe.Text = "Edit Recipe";
            this.btnEditRecipe.UseVisualStyleBackColor = true;
            this.btnEditRecipe.Click += new System.EventHandler(this.btnEditRecipe_Click);
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
            this.groupBox3.Controls.Add(this.lsvIngredients);
            this.groupBox3.Location = new System.Drawing.Point(287, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 284);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Made of Ingredients";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(176, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Define Item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Qty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Name";
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(148, 248);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(31, 20);
            this.txtQty.TabIndex = 37;
            // 
            // cboUnit
            // 
            this.cboUnit.Enabled = false;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Items.AddRange(new object[] {
            "lb",
            "oz"});
            this.cboUnit.Location = new System.Drawing.Point(185, 248);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(66, 21);
            this.cboUnit.TabIndex = 36;
            // 
            // cboIng
            // 
            this.cboIng.Enabled = false;
            this.cboIng.FormattingEnabled = true;
            this.cboIng.Location = new System.Drawing.Point(18, 248);
            this.cboIng.Name = "cboIng";
            this.cboIng.Size = new System.Drawing.Size(121, 21);
            this.cboIng.TabIndex = 35;
            // 
            // btnEditIng
            // 
            this.btnEditIng.Enabled = false;
            this.btnEditIng.Location = new System.Drawing.Point(60, 191);
            this.btnEditIng.Name = "btnEditIng";
            this.btnEditIng.Size = new System.Drawing.Size(45, 23);
            this.btnEditIng.TabIndex = 34;
            this.btnEditIng.Text = "Edit";
            this.btnEditIng.UseVisualStyleBackColor = true;
            this.btnEditIng.Click += new System.EventHandler(this.btnEditIng_Click);
            // 
            // btnDeleteIng
            // 
            this.btnDeleteIng.Enabled = false;
            this.btnDeleteIng.Location = new System.Drawing.Point(111, 191);
            this.btnDeleteIng.Name = "btnDeleteIng";
            this.btnDeleteIng.Size = new System.Drawing.Size(46, 23);
            this.btnDeleteIng.TabIndex = 33;
            this.btnDeleteIng.Text = "Delete";
            this.btnDeleteIng.UseVisualStyleBackColor = true;
            this.btnDeleteIng.Click += new System.EventHandler(this.btnDeleteIng_Click);
            // 
            // btnAddIng
            // 
            this.btnAddIng.Enabled = false;
            this.btnAddIng.Location = new System.Drawing.Point(18, 191);
            this.btnAddIng.Name = "btnAddIng";
            this.btnAddIng.Size = new System.Drawing.Size(36, 23);
            this.btnAddIng.TabIndex = 32;
            this.btnAddIng.Text = "Add";
            this.btnAddIng.UseVisualStyleBackColor = true;
            this.btnAddIng.Click += new System.EventHandler(this.btnAddIng_Click);
            // 
            // lsvIngredients
            // 
            this.lsvIngredients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvIngredients.FullRowSelect = true;
            this.lsvIngredients.Location = new System.Drawing.Point(18, 19);
            this.lsvIngredients.Name = "lsvIngredients";
            this.lsvIngredients.Size = new System.Drawing.Size(229, 166);
            this.lsvIngredients.TabIndex = 8;
            this.lsvIngredients.UseCompatibleStateImageBehavior = false;
            this.lsvIngredients.View = System.Windows.Forms.View.Details;
            this.lsvIngredients.SelectedIndexChanged += new System.EventHandler(this.lsvIngredients_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qty";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.groupBox1.Location = new System.Drawing.Point(35, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 245);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Info";
            // 
            // txtServingSize
            // 
            this.txtServingSize.Enabled = false;
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
            this.txtCookTime.Enabled = false;
            this.txtCookTime.Location = new System.Drawing.Point(131, 113);
            this.txtCookTime.Name = "txtCookTime";
            this.txtCookTime.Size = new System.Drawing.Size(54, 20);
            this.txtCookTime.TabIndex = 8;
            // 
            // txtPrepTime
            // 
            this.txtPrepTime.Enabled = false;
            this.txtPrepTime.Location = new System.Drawing.Point(131, 88);
            this.txtPrepTime.Name = "txtPrepTime";
            this.txtPrepTime.Size = new System.Drawing.Size(54, 20);
            this.txtPrepTime.TabIndex = 7;
            // 
            // txtPriceSold
            // 
            this.txtPriceSold.Enabled = false;
            this.txtPriceSold.Location = new System.Drawing.Point(131, 64);
            this.txtPriceSold.Name = "txtPriceSold";
            this.txtPriceSold.Size = new System.Drawing.Size(54, 20);
            this.txtPriceSold.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(70, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(115, 20);
            this.txtName.TabIndex = 5;
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
            // lblComingSoon
            // 
            this.lblComingSoon.AutoSize = true;
            this.lblComingSoon.Location = new System.Drawing.Point(32, 392);
            this.lblComingSoon.Name = "lblComingSoon";
            this.lblComingSoon.Size = new System.Drawing.Size(140, 13);
            this.lblComingSoon.TabIndex = 30;
            this.lblComingSoon.Text = "* Print Feature Coming Soon";
            this.lblComingSoon.Visible = false;
            // 
            // frmDisplayRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 538);
            this.Controls.Add(this.lblComingSoon);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnEditRecipe);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDisplayRecipe";
            this.Text = "Recipe Display View";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCookDir;
        private System.Windows.Forms.TextBox txtPrepDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnEditRecipe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lsvIngredients;
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
        private System.Windows.Forms.Button btnRemoveSelectedTag;
        private System.Windows.Forms.Button btnAddToTagList;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.ListBox lbxTags;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblComingSoon;

    }
}