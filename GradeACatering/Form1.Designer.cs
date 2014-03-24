namespace GradeACatering
{
    partial class Form1
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
            this.txtSourceFraction.Location = new System.Drawing.Point(15, 218);
            this.txtSourceFraction.Name = "txtSourceFraction";
            this.txtSourceFraction.Size = new System.Drawing.Size(100, 20);
            this.txtSourceFraction.TabIndex = 3;
            // 
            // lblConversionOutput
            // 
            this.lblConversionOutput.AutoSize = true;
            this.lblConversionOutput.Location = new System.Drawing.Point(201, 224);
            this.lblConversionOutput.Name = "lblConversionOutput";
            this.lblConversionOutput.Size = new System.Drawing.Size(0, 13);
            this.lblConversionOutput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fractional string to decimal";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(15, 245);
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
            this.label1.Location = new System.Drawing.Point(96, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Decimal to fraction";
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(15, 325);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 8;
            // 
            // lblDecToFrac
            // 
            this.lblDecToFrac.AutoSize = true;
            this.lblDecToFrac.Location = new System.Drawing.Point(204, 331);
            this.lblDecToFrac.Name = "lblDecToFrac";
            this.lblDecToFrac.Size = new System.Drawing.Size(0, 13);
            this.lblDecToFrac.TabIndex = 9;
            // 
            // btnConvertDecToFrac
            // 
            this.btnConvertDecToFrac.Location = new System.Drawing.Point(13, 352);
            this.btnConvertDecToFrac.Name = "btnConvertDecToFrac";
            this.btnConvertDecToFrac.Size = new System.Drawing.Size(75, 23);
            this.btnConvertDecToFrac.TabIndex = 10;
            this.btnConvertDecToFrac.Text = "Convert";
            this.btnConvertDecToFrac.UseVisualStyleBackColor = true;
            this.btnConvertDecToFrac.Click += new System.EventHandler(this.btnConvertDecToFrac_Click);
            // 
            // btnTestInsert
            // 
            this.btnTestInsert.Location = new System.Drawing.Point(15, 404);
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
            this.label3.Location = new System.Drawing.Point(110, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Will insert fractional string textbox and decimal textbox contents\r\nif there is t" +
    "ext in them, otherwise returns contents of Testing table.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 515);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

