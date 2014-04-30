namespace GradeACatering
{
    partial class frmNewSearch
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
            this.btnDelFilter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnAddFilter = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.pnlDynSearchText = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdoPnlTextOr = new System.Windows.Forms.RadioButton();
            this.rdoPnlTextAnd = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFilterType = new System.Windows.Forms.ComboBox();
            this.pnlDynSearchNumeric = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboComparison = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rdoPnlNumericOr = new System.Windows.Forms.RadioButton();
            this.rdoPnlNumericAnd = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pnlDynSearchText.SuspendLayout();
            this.pnlDynSearchNumeric.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelFilter
            // 
            this.btnDelFilter.Location = new System.Drawing.Point(118, 26);
            this.btnDelFilter.Name = "btnDelFilter";
            this.btnDelFilter.Size = new System.Drawing.Size(75, 23);
            this.btnDelFilter.TabIndex = 7;
            this.btnDelFilter.Text = "Delete Last";
            this.btnDelFilter.UseVisualStyleBackColor = true;
            this.btnDelFilter.Click += new System.EventHandler(this.btnDelFilter_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(17, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 355);
            this.panel1.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(448, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(423, 398);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.Location = new System.Drawing.Point(17, 26);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(75, 23);
            this.btnAddFilter.TabIndex = 8;
            this.btnAddFilter.Text = "Add Another";
            this.btnAddFilter.UseVisualStyleBackColor = true;
            this.btnAddFilter.Click += new System.EventHandler(this.btnAddFilter_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(245, 416);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "Apply Filter";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // pnlDynSearchText
            // 
            this.pnlDynSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDynSearchText.Controls.Add(this.txtName);
            this.pnlDynSearchText.Controls.Add(this.rdoPnlTextOr);
            this.pnlDynSearchText.Controls.Add(this.rdoPnlTextAnd);
            this.pnlDynSearchText.Controls.Add(this.label1);
            this.pnlDynSearchText.Controls.Add(this.cboFilterType);
            this.pnlDynSearchText.Location = new System.Drawing.Point(271, 55);
            this.pnlDynSearchText.Name = "pnlDynSearchText";
            this.pnlDynSearchText.Size = new System.Drawing.Size(170, 85);
            this.pnlDynSearchText.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 20);
            this.txtName.TabIndex = 8;
            // 
            // rdoPnlTextOr
            // 
            this.rdoPnlTextOr.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoPnlTextOr.AutoSize = true;
            this.rdoPnlTextOr.Location = new System.Drawing.Point(45, 3);
            this.rdoPnlTextOr.Name = "rdoPnlTextOr";
            this.rdoPnlTextOr.Size = new System.Drawing.Size(28, 23);
            this.rdoPnlTextOr.TabIndex = 6;
            this.rdoPnlTextOr.TabStop = true;
            this.rdoPnlTextOr.Text = "Or";
            this.rdoPnlTextOr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rdoPnlTextOr.UseVisualStyleBackColor = true;
            // 
            // rdoPnlTextAnd
            // 
            this.rdoPnlTextAnd.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoPnlTextAnd.AutoSize = true;
            this.rdoPnlTextAnd.Location = new System.Drawing.Point(3, 3);
            this.rdoPnlTextAnd.Name = "rdoPnlTextAnd";
            this.rdoPnlTextAnd.Size = new System.Drawing.Size(36, 23);
            this.rdoPnlTextAnd.TabIndex = 5;
            this.rdoPnlTextAnd.TabStop = true;
            this.rdoPnlTextAnd.Text = "And";
            this.rdoPnlTextAnd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rdoPnlTextAnd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter by";
            // 
            // cboFilterType
            // 
            this.cboFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterType.FormattingEnabled = true;
            this.cboFilterType.Location = new System.Drawing.Point(6, 32);
            this.cboFilterType.Name = "cboFilterType";
            this.cboFilterType.Size = new System.Drawing.Size(157, 21);
            this.cboFilterType.TabIndex = 0;
            // 
            // pnlDynSearchNumeric
            // 
            this.pnlDynSearchNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDynSearchNumeric.Controls.Add(this.label2);
            this.pnlDynSearchNumeric.Controls.Add(this.cboComparison);
            this.pnlDynSearchNumeric.Controls.Add(this.textBox2);
            this.pnlDynSearchNumeric.Controls.Add(this.rdoPnlNumericOr);
            this.pnlDynSearchNumeric.Controls.Add(this.rdoPnlNumericAnd);
            this.pnlDynSearchNumeric.Controls.Add(this.comboBox2);
            this.pnlDynSearchNumeric.Location = new System.Drawing.Point(271, 146);
            this.pnlDynSearchNumeric.Name = "pnlDynSearchNumeric";
            this.pnlDynSearchNumeric.Size = new System.Drawing.Size(171, 85);
            this.pnlDynSearchNumeric.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filter by";
            // 
            // cboComparison
            // 
            this.cboComparison.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComparison.FormattingEnabled = true;
            this.cboComparison.Items.AddRange(new object[] {
            ">",
            "≥",
            "=",
            "≤",
            "<"});
            this.cboComparison.Location = new System.Drawing.Point(3, 59);
            this.cboComparison.Name = "cboComparison";
            this.cboComparison.Size = new System.Drawing.Size(70, 21);
            this.cboComparison.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 20);
            this.textBox2.TabIndex = 8;
            // 
            // rdoPnlNumericOr
            // 
            this.rdoPnlNumericOr.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoPnlNumericOr.AutoSize = true;
            this.rdoPnlNumericOr.Location = new System.Drawing.Point(45, 3);
            this.rdoPnlNumericOr.Name = "rdoPnlNumericOr";
            this.rdoPnlNumericOr.Size = new System.Drawing.Size(28, 23);
            this.rdoPnlNumericOr.TabIndex = 6;
            this.rdoPnlNumericOr.TabStop = true;
            this.rdoPnlNumericOr.Text = "Or";
            this.rdoPnlNumericOr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rdoPnlNumericOr.UseVisualStyleBackColor = true;
            // 
            // rdoPnlNumericAnd
            // 
            this.rdoPnlNumericAnd.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoPnlNumericAnd.AutoSize = true;
            this.rdoPnlNumericAnd.Location = new System.Drawing.Point(3, 3);
            this.rdoPnlNumericAnd.Name = "rdoPnlNumericAnd";
            this.rdoPnlNumericAnd.Size = new System.Drawing.Size(36, 23);
            this.rdoPnlNumericAnd.TabIndex = 5;
            this.rdoPnlNumericAnd.TabStop = true;
            this.rdoPnlNumericAnd.Text = "And";
            this.rdoPnlNumericAnd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rdoPnlNumericAnd.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // frmNewSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 446);
            this.Controls.Add(this.pnlDynSearchText);
            this.Controls.Add(this.pnlDynSearchNumeric);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnAddFilter);
            this.Controls.Add(this.btnDelFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "frmNewSearch";
            this.Text = "frmNewSearch";
            this.pnlDynSearchText.ResumeLayout(false);
            this.pnlDynSearchText.PerformLayout();
            this.pnlDynSearchNumeric.ResumeLayout(false);
            this.pnlDynSearchNumeric.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnAddFilter;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel pnlDynSearchText;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rdoPnlTextOr;
        private System.Windows.Forms.RadioButton rdoPnlTextAnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFilterType;
        private System.Windows.Forms.Panel pnlDynSearchNumeric;
        private System.Windows.Forms.ComboBox cboComparison;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rdoPnlNumericOr;
        private System.Windows.Forms.RadioButton rdoPnlNumericAnd;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
    }
}