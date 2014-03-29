namespace GradeACatering
{
    partial class frmTest
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTestItem = new System.Windows.Forms.Label();
            this.cboTags = new System.Windows.Forms.ComboBox();
            this.txtSourceFraction = new System.Windows.Forms.TextBox();
            this.lblConversionOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.lblDecToFrac = new System.Windows.Forms.Label();
            this.btnConvertDecToFrac = new System.Windows.Forms.Button();
            this.btnTestInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxBOM = new System.Windows.Forms.GroupBox();
            this.btnCommitRecipes = new System.Windows.Forms.Button();
            this.btnRecipeRemove = new System.Windows.Forms.Button();
            this.btnRecipeAdd = new System.Windows.Forms.Button();
            this.lbxRecipeList = new System.Windows.Forms.ListView();
            this.lvcRecipeMakes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcRecipeMadeOf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcRecipeQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcRecipeUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtRecipeUnit = new System.Windows.Forms.TextBox();
            this.txtRecipeQty = new System.Windows.Forms.TextBox();
            this.txtRecipeMadeOf = new System.Windows.Forms.TextBox();
            this.txtRecipeMakes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxBOM.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(365, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTestItem
            // 
            this.lblTestItem.AutoSize = true;
            this.lblTestItem.Location = new System.Drawing.Point(12, 17);
            this.lblTestItem.Name = "lblTestItem";
            this.lblTestItem.Size = new System.Drawing.Size(35, 13);
            this.lblTestItem.TabIndex = 1;
            this.lblTestItem.Text = "label1";
            // 
            // cboTags
            // 
            this.cboTags.FormattingEnabled = true;
            this.cboTags.Location = new System.Drawing.Point(229, 14);
            this.cboTags.Name = "cboTags";
            this.cboTags.Size = new System.Drawing.Size(121, 21);
            this.cboTags.TabIndex = 2;
            // 
            // txtSourceFraction
            // 
            this.txtSourceFraction.Location = new System.Drawing.Point(229, 75);
            this.txtSourceFraction.Name = "txtSourceFraction";
            this.txtSourceFraction.Size = new System.Drawing.Size(100, 20);
            this.txtSourceFraction.TabIndex = 3;
            // 
            // lblConversionOutput
            // 
            this.lblConversionOutput.AutoSize = true;
            this.lblConversionOutput.Location = new System.Drawing.Point(415, 81);
            this.lblConversionOutput.Name = "lblConversionOutput";
            this.lblConversionOutput.Size = new System.Drawing.Size(0, 13);
            this.lblConversionOutput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fractional string to decimal";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(229, 102);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Decimal to fraction";
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(229, 161);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 8;
            // 
            // lblDecToFrac
            // 
            this.lblDecToFrac.AutoSize = true;
            this.lblDecToFrac.Location = new System.Drawing.Point(418, 167);
            this.lblDecToFrac.Name = "lblDecToFrac";
            this.lblDecToFrac.Size = new System.Drawing.Size(0, 13);
            this.lblDecToFrac.TabIndex = 9;
            // 
            // btnConvertDecToFrac
            // 
            this.btnConvertDecToFrac.Location = new System.Drawing.Point(227, 188);
            this.btnConvertDecToFrac.Name = "btnConvertDecToFrac";
            this.btnConvertDecToFrac.Size = new System.Drawing.Size(75, 23);
            this.btnConvertDecToFrac.TabIndex = 10;
            this.btnConvertDecToFrac.Text = "Convert";
            this.btnConvertDecToFrac.UseVisualStyleBackColor = true;
            this.btnConvertDecToFrac.Click += new System.EventHandler(this.btnConvertDecToFrac_Click);
            // 
            // btnTestInsert
            // 
            this.btnTestInsert.Location = new System.Drawing.Point(333, 226);
            this.btnTestInsert.Name = "btnTestInsert";
            this.btnTestInsert.Size = new System.Drawing.Size(75, 38);
            this.btnTestInsert.TabIndex = 11;
            this.btnTestInsert.Text = "Test Connection";
            this.btnTestInsert.UseVisualStyleBackColor = true;
            this.btnTestInsert.Click += new System.EventHandler(this.btnTestInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Will insert fractional string textbox and decimal textbox contents\r\nif there is t" +
    "ext in them, otherwise returns contents of Testing table.";
            // 
            // gbxBOM
            // 
            this.gbxBOM.Controls.Add(this.btnCommitRecipes);
            this.gbxBOM.Controls.Add(this.btnRecipeRemove);
            this.gbxBOM.Controls.Add(this.btnRecipeAdd);
            this.gbxBOM.Controls.Add(this.lbxRecipeList);
            this.gbxBOM.Controls.Add(this.txtRecipeUnit);
            this.gbxBOM.Controls.Add(this.txtRecipeQty);
            this.gbxBOM.Controls.Add(this.txtRecipeMadeOf);
            this.gbxBOM.Controls.Add(this.txtRecipeMakes);
            this.gbxBOM.Controls.Add(this.label7);
            this.gbxBOM.Controls.Add(this.label6);
            this.gbxBOM.Controls.Add(this.label5);
            this.gbxBOM.Controls.Add(this.label4);
            this.gbxBOM.Location = new System.Drawing.Point(529, 75);
            this.gbxBOM.Name = "gbxBOM";
            this.gbxBOM.Size = new System.Drawing.Size(287, 416);
            this.gbxBOM.TabIndex = 13;
            this.gbxBOM.TabStop = false;
            this.gbxBOM.Text = "Bill of Materials items";
            // 
            // btnCommitRecipes
            // 
            this.btnCommitRecipes.Location = new System.Drawing.Point(206, 371);
            this.btnCommitRecipes.Name = "btnCommitRecipes";
            this.btnCommitRecipes.Size = new System.Drawing.Size(75, 23);
            this.btnCommitRecipes.TabIndex = 11;
            this.btnCommitRecipes.Text = "Save...";
            this.btnCommitRecipes.UseVisualStyleBackColor = true;
            this.btnCommitRecipes.Click += new System.EventHandler(this.btnCommitRecipes_Click);
            // 
            // btnRecipeRemove
            // 
            this.btnRecipeRemove.Location = new System.Drawing.Point(6, 365);
            this.btnRecipeRemove.Name = "btnRecipeRemove";
            this.btnRecipeRemove.Size = new System.Drawing.Size(75, 34);
            this.btnRecipeRemove.TabIndex = 10;
            this.btnRecipeRemove.Text = "Remove Selected";
            this.btnRecipeRemove.UseVisualStyleBackColor = true;
            this.btnRecipeRemove.Click += new System.EventHandler(this.btnRecipeRemove_Click);
            // 
            // btnRecipeAdd
            // 
            this.btnRecipeAdd.Location = new System.Drawing.Point(129, 141);
            this.btnRecipeAdd.Name = "btnRecipeAdd";
            this.btnRecipeAdd.Size = new System.Drawing.Size(75, 23);
            this.btnRecipeAdd.TabIndex = 9;
            this.btnRecipeAdd.Text = "Add";
            this.btnRecipeAdd.UseVisualStyleBackColor = true;
            this.btnRecipeAdd.Click += new System.EventHandler(this.btnRecipeAdd_Click);
            // 
            // lbxRecipeList
            // 
            this.lbxRecipeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvcRecipeMakes,
            this.lvcRecipeMadeOf,
            this.lvcRecipeQty,
            this.lvcRecipeUnit});
            this.lbxRecipeList.FullRowSelect = true;
            this.lbxRecipeList.Location = new System.Drawing.Point(6, 173);
            this.lbxRecipeList.Name = "lbxRecipeList";
            this.lbxRecipeList.Size = new System.Drawing.Size(275, 186);
            this.lbxRecipeList.TabIndex = 8;
            this.lbxRecipeList.UseCompatibleStateImageBehavior = false;
            this.lbxRecipeList.View = System.Windows.Forms.View.Details;
            // 
            // lvcRecipeMakes
            // 
            this.lvcRecipeMakes.Text = "Makes";
            // 
            // lvcRecipeMadeOf
            // 
            this.lvcRecipeMadeOf.Text = "Made Of";
            // 
            // lvcRecipeQty
            // 
            this.lvcRecipeQty.Text = "Quantity";
            // 
            // lvcRecipeUnit
            // 
            this.lvcRecipeUnit.Text = "Unit";
            // 
            // txtRecipeUnit
            // 
            this.txtRecipeUnit.Location = new System.Drawing.Point(104, 110);
            this.txtRecipeUnit.Name = "txtRecipeUnit";
            this.txtRecipeUnit.Size = new System.Drawing.Size(100, 20);
            this.txtRecipeUnit.TabIndex = 7;
            // 
            // txtRecipeQty
            // 
            this.txtRecipeQty.Location = new System.Drawing.Point(104, 83);
            this.txtRecipeQty.Name = "txtRecipeQty";
            this.txtRecipeQty.Size = new System.Drawing.Size(100, 20);
            this.txtRecipeQty.TabIndex = 6;
            // 
            // txtRecipeMadeOf
            // 
            this.txtRecipeMadeOf.Location = new System.Drawing.Point(104, 56);
            this.txtRecipeMadeOf.Name = "txtRecipeMadeOf";
            this.txtRecipeMadeOf.Size = new System.Drawing.Size(100, 20);
            this.txtRecipeMadeOf.TabIndex = 5;
            // 
            // txtRecipeMakes
            // 
            this.txtRecipeMakes.Location = new System.Drawing.Point(104, 29);
            this.txtRecipeMakes.Name = "txtRecipeMakes";
            this.txtRecipeMakes.Size = new System.Drawing.Size(100, 20);
            this.txtRecipeMakes.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Unit";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Quantity";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Made Of";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Makes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 703);
            this.Controls.Add(this.gbxBOM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTestInsert);
            this.Controls.Add(this.btnConvertDecToFrac);
            this.Controls.Add(this.lblDecToFrac);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblConversionOutput);
            this.Controls.Add(this.txtSourceFraction);
            this.Controls.Add(this.cboTags);
            this.Controls.Add(this.lblTestItem);
            this.Controls.Add(this.btnExit);
            this.Name = "frmTest";
            this.Text = "Test Form!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxBOM.ResumeLayout(false);
            this.gbxBOM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTestItem;
        private System.Windows.Forms.ComboBox cboTags;
        private System.Windows.Forms.TextBox txtSourceFraction;
        private System.Windows.Forms.Label lblConversionOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Label lblDecToFrac;
        private System.Windows.Forms.Button btnConvertDecToFrac;
        private System.Windows.Forms.Button btnTestInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxBOM;
        private System.Windows.Forms.Button btnCommitRecipes;
        private System.Windows.Forms.Button btnRecipeRemove;
        private System.Windows.Forms.Button btnRecipeAdd;
        private System.Windows.Forms.ListView lbxRecipeList;
        private System.Windows.Forms.ColumnHeader lvcRecipeMakes;
        private System.Windows.Forms.ColumnHeader lvcRecipeMadeOf;
        private System.Windows.Forms.ColumnHeader lvcRecipeQty;
        private System.Windows.Forms.ColumnHeader lvcRecipeUnit;
        private System.Windows.Forms.TextBox txtRecipeUnit;
        private System.Windows.Forms.TextBox txtRecipeQty;
        private System.Windows.Forms.TextBox txtRecipeMadeOf;
        private System.Windows.Forms.TextBox txtRecipeMakes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

