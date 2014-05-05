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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lsvSearch = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddFilter = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAndOr = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelFilter
            // 
            this.btnDelFilter.Location = new System.Drawing.Point(142, 26);
            this.btnDelFilter.Name = "btnDelFilter";
            this.btnDelFilter.Size = new System.Drawing.Size(75, 23);
            this.btnDelFilter.TabIndex = 7;
            this.btnDelFilter.Text = "Delete Last";
            this.btnDelFilter.UseVisualStyleBackColor = true;
            this.btnDelFilter.Click += new System.EventHandler(this.btnDelFilter_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Location = new System.Drawing.Point(17, 55);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(200, 434);
            this.pnlMain.TabIndex = 6;
            // 
            // lsvSearch
            // 
            this.lsvSearch.AllowColumnReorder = true;
            this.lsvSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvSearch.FullRowSelect = true;
            this.lsvSearch.Location = new System.Drawing.Point(255, 26);
            this.lsvSearch.Name = "lsvSearch";
            this.lsvSearch.Size = new System.Drawing.Size(654, 463);
            this.lsvSearch.TabIndex = 4;
            this.lsvSearch.UseCompatibleStateImageBehavior = false;
            this.lsvSearch.View = System.Windows.Forms.View.Details;
            this.lsvSearch.SelectedIndexChanged += new System.EventHandler(this.lsvSearch_SelectedIndexChanged);
            this.lsvSearch.DoubleClick += new System.EventHandler(this.lsvSearch_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Serving Size";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price/Serving";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Prep Time";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cook Time";
            this.columnHeader6.Width = 100;
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.Location = new System.Drawing.Point(17, 26);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(75, 23);
            this.btnAddFilter.TabIndex = 8;
            this.btnAddFilter.Text = "Add Filter";
            this.btnAddFilter.UseVisualStyleBackColor = true;
            this.btnAddFilter.Click += new System.EventHandler(this.btnAddFilter_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(170, 495);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 39);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "Apply Filter";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(89, 495);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 39);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear Filters";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAndOr
            // 
            this.btnAndOr.Location = new System.Drawing.Point(98, 26);
            this.btnAndOr.Name = "btnAndOr";
            this.btnAndOr.Size = new System.Drawing.Size(35, 23);
            this.btnAndOr.TabIndex = 15;
            this.btnAndOr.Text = "And";
            this.btnAndOr.UseVisualStyleBackColor = true;
            this.btnAndOr.Click += new System.EventHandler(this.btnAndOr_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(834, 495);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 44);
            this.btnDisplay.TabIndex = 17;
            this.btnDisplay.Text = "Display Recipe";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRecipeToolStripMenuItem,
            this.deleteRecipeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addNewRecipeToolStripMenuItem
            // 
            this.addNewRecipeToolStripMenuItem.Name = "addNewRecipeToolStripMenuItem";
            this.addNewRecipeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addNewRecipeToolStripMenuItem.Text = "Add New Recipe";
            this.addNewRecipeToolStripMenuItem.Click += new System.EventHandler(this.addNewRecipeToolStripMenuItem_Click);
            // 
            // deleteRecipeToolStripMenuItem
            // 
            this.deleteRecipeToolStripMenuItem.Enabled = false;
            this.deleteRecipeToolStripMenuItem.Name = "deleteRecipeToolStripMenuItem";
            this.deleteRecipeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deleteRecipeToolStripMenuItem.Text = "Delete Recipe";
            this.deleteRecipeToolStripMenuItem.Click += new System.EventHandler(this.deleteRecipeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sOPToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // sOPToolStripMenuItem
            // 
            this.sOPToolStripMenuItem.Name = "sOPToolStripMenuItem";
            this.sOPToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sOPToolStripMenuItem.Text = "S.O.P.  Form";
            this.sOPToolStripMenuItem.Click += new System.EventHandler(this.sOPToolStripMenuItem_Click);
            // 
            // frmNewSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 546);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnAndOr);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnAddFilter);
            this.Controls.Add(this.btnDelFilter);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lsvSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNewSearch";
            this.Text = "frmNewSearch";
            this.Load += new System.EventHandler(this.frmNewSearch_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelFilter;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListView lsvSearch;
        private System.Windows.Forms.Button btnAddFilter;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAndOr;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOPToolStripMenuItem;
    }
}