﻿namespace GradeACatering
{
    partial class frmNewIngredient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIngUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIngPrice = new System.Windows.Forms.TextBox();
            this.txtIngName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.btnSaveRecipe = new System.Windows.Forms.Button();
            this.btnDefineItem = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIngUnit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIngPrice);
            this.groupBox1.Controls.Add(this.txtIngName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 159);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Info";
            // 
            // txtIngUnit
            // 
            this.txtIngUnit.Location = new System.Drawing.Point(129, 109);
            this.txtIngUnit.Name = "txtIngUnit";
            this.txtIngUnit.Size = new System.Drawing.Size(54, 20);
            this.txtIngUnit.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unit Type";
            // 
            // txtIngPrice
            // 
            this.txtIngPrice.Location = new System.Drawing.Point(129, 83);
            this.txtIngPrice.Name = "txtIngPrice";
            this.txtIngPrice.Size = new System.Drawing.Size(54, 20);
            this.txtIngPrice.TabIndex = 6;
            // 
            // txtIngName
            // 
            this.txtIngName.Location = new System.Drawing.Point(68, 60);
            this.txtIngName.Name = "txtIngName";
            this.txtIngName.Size = new System.Drawing.Size(115, 20);
            this.txtIngName.TabIndex = 5;
            this.txtIngName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price Sold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDefineItem);
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
            this.groupBox3.Location = new System.Drawing.Point(267, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 288);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Made of Ingredients";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Qty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Name";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(148, 243);
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
            this.cboUnit.Location = new System.Drawing.Point(185, 243);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(66, 21);
            this.cboUnit.TabIndex = 13;
            // 
            // cboIng
            // 
            this.cboIng.FormattingEnabled = true;
            this.cboIng.Location = new System.Drawing.Point(18, 243);
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
            this.btnEditIng.Click += new System.EventHandler(this.btnEditIng_Click);
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
            // lsvIngredients
            // 
            this.lsvIngredients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvIngredients.FullRowSelect = true;
            this.lsvIngredients.Location = new System.Drawing.Point(18, 19);
            this.lsvIngredients.Name = "lsvIngredients";
            this.lsvIngredients.Size = new System.Drawing.Size(229, 159);
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
            this.columnHeader2.Width = 37;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit";
            // 
            // btnSaveRecipe
            // 
            this.btnSaveRecipe.Location = new System.Drawing.Point(157, 272);
            this.btnSaveRecipe.Name = "btnSaveRecipe";
            this.btnSaveRecipe.Size = new System.Drawing.Size(90, 45);
            this.btnSaveRecipe.TabIndex = 13;
            this.btnSaveRecipe.Text = "Save Item";
            this.btnSaveRecipe.UseVisualStyleBackColor = true;
            // 
            // btnDefineItem
            // 
            this.btnDefineItem.Location = new System.Drawing.Point(176, 182);
            this.btnDefineItem.Name = "btnDefineItem";
            this.btnDefineItem.Size = new System.Drawing.Size(71, 23);
            this.btnDefineItem.TabIndex = 22;
            this.btnDefineItem.Text = "Define Item";
            this.btnDefineItem.UseVisualStyleBackColor = true;
            this.btnDefineItem.Click += new System.EventHandler(this.btnDefineItem_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 272);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 45);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // frmNewIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 329);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSaveRecipe);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNewIngredient";
            this.Text = "New Ingredient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIngPrice;
        private System.Windows.Forms.TextBox txtIngName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.ComboBox cboIng;
        private System.Windows.Forms.Button btnEditIng;
        private System.Windows.Forms.Button btnDeleteIng;
        private System.Windows.Forms.Button btnAddIng;
        private System.Windows.Forms.ListView lsvIngredients;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSaveRecipe;
        private System.Windows.Forms.TextBox txtIngUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDefineItem;
        private System.Windows.Forms.Button btnReturn;
    }
}