using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Collections;

namespace GradeACatering
{
    public partial class frmNewSearch : Form
    {
        public frmNewSearch()
        {
            InitializeComponent();
        }
        private enum FilterType { Name, Tag, NumServings, PricePerServing }//and so on, can add more of these.
        //these correspond to the selectedindex of the filter type combo boxes in the dynamic panels


        private static int px = 3;
        private static int py = 3;
        private static int dynPanelHeight = 85;
        private static int dynPanelWidth = 170;
        private static int dynPanelVerticalSpace = dynPanelHeight + 6;

        private List<FoodStuff> fsMasterlist;
        private List<FoodStuff> fsFilteredlist; //Needs to have stuff added that meets criteria 
        List<ComboBox> lstDynCBOs = new List<ComboBox>();
        List<Button> lstDynAndOrBtns = new List<Button>();

        string[] strFilterTypes = { "Name", "Tag", "Serving Size", "Price Per Serving" };
        string[] strCboOperators = { "<", "<=", "=", "=>", ">", "<>" };
        string[] strNumericCompareNoUnicode = { ">", ">=", "=", "<=", "<" };
        string[] strNumericCompareWords = { "greater than", "greater than or equal to", "equal to", "less than or equal to", "less than" };


        private void btnDelFilter_Click(object sender, EventArgs e)
        {
            if (pnlMain.Controls.Count > 0)
            {
                pnlMain.Controls.RemoveAt(pnlMain.Controls.Count - 1);
                py -= dynPanelVerticalSpace;
            }
        }
        private Panel NewSearchPanel()
        {
            var dynPanel = new Panel();

            dynPanel.AutoSize = false;
            dynPanel.Name = "pnl ";
            dynPanel.Size = new System.Drawing.Size(dynPanelWidth, dynPanelHeight);
            dynPanel.BorderStyle = BorderStyle.FixedSingle;
            dynPanel.Location = new Point(px, py);

            if (pnlMain.Controls.Count > 0)
            {
                Button btn = new Button();
                btn.Text = "And";
                btn.AutoSize = false;
                btn.Size = new System.Drawing.Size(36, 23);
                btn.Location = new Point(3, 3);
                btn.TextAlign = ContentAlignment.TopCenter;
                btn.Click += new System.EventHandler(this.btn_Click);
                dynPanel.Controls.Add(btn);
                lstDynAndOrBtns.Add(btn);
            }

            Label lblType = new Label();
            lblType.Text = "Filter Type:";
            lblType.Location = new Point(80, 7);

            ComboBox cboType = new ComboBox();
            cboType.Size = new System.Drawing.Size(160, 20);
            cboType.Location = new Point(3, 30);
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_changed);
            cboType.Items.AddRange(strFilterTypes);

            dynPanel.Controls.Add(lblType);
            dynPanel.Controls.Add(cboType);
            lstDynCBOs.Add(cboType);

            // Adds new Generated Filter
            py += dynPanelVerticalSpace;

            //Then Chose Type of filter

            return dynPanel;

        }
        private void btnAddFilter_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Add(NewSearchPanel());
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Panel dynPanel = (Panel)btn.Parent;
            if (btn.Text == "And")
            {
                btn.Text = "Or";
            }
            else if (btn.Text == "Or")
            {
                btn.Text = "And";
            }
        }

        private void cboType_changed(object sender, EventArgs e)
        {
            try
            {
                ComboBox cboType = (ComboBox)sender;
                Panel dynPanel = (Panel)cboType.Parent;

                int ClearStop;
                if (pnlMain.Controls.IndexOf(dynPanel) == 0)
                    ClearStop = 2;
                else
                    ClearStop = 3;

                for (int i = dynPanel.Controls.Count - 1; i >= ClearStop; i--)
                {
                    dynPanel.Controls.RemoveAt(i);
                }

                if (cboType.SelectedIndex == 0)
                {   //Name filter
                    TextBox tb = new TextBox();
                    tb.Name = "txtName";
                    tb.Location = new Point(3, 60);
                    tb.Size = new System.Drawing.Size(160, 20);

                    dynPanel.Controls.Add(tb);

                }
                else if (cboType.SelectedIndex == 1)
                {
                    //Tag filter
                    TextBox tb = new TextBox();
                    tb.Name = "txtTag";
                    tb.Location = new Point(3, 60);
                    tb.Size = new System.Drawing.Size(160, 20);

                    dynPanel.Controls.Add(tb);

                }
                else if (cboType.SelectedIndex == 2)
                {
                    //number of servings
                    ComboBox cbo = new ComboBox();
                    cbo.Name = "cboComparators";
                    cbo.Size = new System.Drawing.Size(70, 20);
                    cbo.Location = new Point(3, 60);
                    cbo.DropDownStyle = ComboBoxStyle.DropDownList;
                    cbo.Items.AddRange(strCboOperators);

                    TextBox tb = new TextBox();
                    tb.Name = "txtServSize";
                    tb.Location = new Point(80, 60);
                    tb.Size = new System.Drawing.Size(80, 20);

                    dynPanel.Controls.Add(cbo);
                    dynPanel.Controls.Add(tb);

                }
                else if (cboType.SelectedIndex == 3)
                {
                    //price per serving
                    ComboBox cbo = new ComboBox();
                    cbo.Name = "cboPrice";
                    cbo.Size = new System.Drawing.Size(70, 20);
                    cbo.Location = new Point(3, 60);
                    cbo.DropDownStyle = ComboBoxStyle.DropDownList;
                    cbo.Items.AddRange(strCboOperators);
                    cbo.Tag = "Compare";

                    TextBox tb = new TextBox();
                    tb.Name = "txtPrice";
                    tb.Size = new System.Drawing.Size(80, 20);
                    tb.Location = new Point(80, 60);

                    dynPanel.Controls.Add(tb);
                    dynPanel.Controls.Add(cbo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //First thing: have for loop looking at arraylist of comboboxes and see what filter type is and the combobox index:
            // Ex. if 0 do the name search if 1 do the tag search etc.
            //Need list of things we are searching for...

            
            if (pnlMain.Controls.Count > 0)
            {
                for (int i = 0; i < lstDynCBOs.Count - 1; i++)
                {
                    Panel dyn = (Panel)pnlMain.Controls[i];//ugly hack, if anything but panels are in pnlMain this WILL EXPLODE...
                    string txtAndOr = "";
                    foreach (Control ctrl in dyn.Controls)
                        if (ctrl is Button)
                            txtAndOr = ctrl.Text.ToUpper();

                    if (lstDynCBOs[i].SelectedIndex == (int)FilterType.Name)
                    {
                        //is it the first item in the panel list?  won't have an and/or toggle, so always match it
                        if (i == 0||txtAndOr.Contains("AND")) //or button is and...
                        {
                            //get contents of text box in dynamic panel
                            //but need the dynamic panel itself...
                            
                            //now loop thru to find textbox
                            foreach (Control ctrl in dyn.Controls)
                            {
                                if (ctrl is TextBox)
                                {
                                    foreach (FoodStuff fs in fsMasterlist)
                                    {
                                        if(fs.Name.Contains(ctrl.Text))
                                            fsFilteredlist.Add(fs);
                                    }
                                }
                            }
                        }
                        else
                        {
                            //if button is or

                        
                        }
                    }
                    else if (lstDynCBOs[i].SelectedIndex == (int)FilterType.Tag)
                    {

                    }
                    else if (lstDynCBOs[i].SelectedIndex == (int)FilterType.NumServings)
                    {

                    }
                    else if (lstDynCBOs[i].SelectedIndex == (int)FilterType.PricePerServing)
                    {

                    }
                    //append additional filters here
                    else
                    {
                        fsFilteredlist = fsMasterlist;
                    }
                    lsvSearch.Items.Clear();// Clear Unfiltered list
                    PopulateListView(fsFilteredlist);
                }
            }
        }

        private void frmNewSearch_Load(object sender, EventArgs e)
        {
            fsMasterlist = DataConnection.ListAllFoodstuffs();
            PopulateListView(fsMasterlist);
            py = 3;

        }

        private void PopulateListView(List<FoodStuff> lstFs)
        {
            foreach (FoodStuff fs in lstFs)
            {
                ListViewItem lsvItem = new ListViewItem(fs.Name.ToString());
                lsvItem.SubItems.Add(fs.Servings.ToString());
                lsvItem.SubItems.Add(fs.Cost.ToString("C"));
                lsvItem.SubItems.Add(fs.CostPerServing().ToString("C") + " Each");
                lsvItem.SubItems.Add(fs.PrepTime.ToString() + " mins");
                lsvItem.SubItems.Add(fs.CookTime.ToString() + " mins");
                lsvItem.SubItems.Add(fs.ID.ToString());
                lsvSearch.Items.Add(lsvItem);
            }
        }

        private void lsvSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsvSearch.Items.Clear();
            foreach (FoodStuff fs in fsMasterlist)
            {
                ListViewItem lsvItem = new ListViewItem(fs.Name.ToString());
                lsvItem.SubItems.Add(fs.Servings.ToString());
                lsvItem.SubItems.Add(fs.Cost.ToString("C"));
                lsvItem.SubItems.Add(fs.CostPerServing().ToString("C") + " Each");
                lsvItem.SubItems.Add(fs.PrepTime.ToString() + " mins");
                lsvItem.SubItems.Add(fs.CookTime.ToString() + " mins");
                lsvItem.SubItems.Add(fs.ID.ToString());
                lsvSearch.Items.Add(lsvItem);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }


    }
}

//var dynPanel = new Panel();


//dynPanel.AutoSize = false;
//dynPanel.Name = "pnl ";  
//dynPanel.Size = new System.Drawing.Size(dynPanelWidth, dynPanelHeight);
//dynPanel.BorderStyle = BorderStyle.FixedSingle;
//dynPanel.Location = new Point(px, py);

//CheckBox chk = new CheckBox();
//chk.Text = "And";
//chk.AutoSize = false;
//chk.Appearance = Appearance.Button;
//chk.Size = new System.Drawing.Size(36, 23);
//chk.Location = new Point(3, 3);
//chk.TextAlign = ContentAlignment.TopCenter;
//dynPanel.Controls.Add(chk);

//==================Changing Location==================//
//======Needs to be added if there is more than one====//
//Button btn = new Button();
//btn.Text = "And";
//btn.AutoSize = false;
//btn.Size = new System.Drawing.Size(36, 23);
//btn.Location = new Point(3, 3);
//btn.TextAlign = ContentAlignment.TopCenter;
//btn.Click += new System.EventHandler(this.btn_Click);
//dynPanel.Controls.Add(btn);
//lstDynAndOrBtns.Add(btn);
//=====================================================//


//Label lblType = new Label();
//lblType.Text = "Filter Type:";
//lblType.Location = new Point(80, 7);

//ComboBox cboType = new ComboBox();
//cboType.Size = new System.Drawing.Size(160, 20);
//cboType.Location = new Point(6, 30);
//cboType.DropDownStyle = ComboBoxStyle.DropDownList;
//cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_changed);

//cboType.Items.AddRange(strFilterTypes);



//dynPanel.Controls.Add(lblType);
//dynPanel.Controls.Add(cboType);
//lstDynCBOs.Add(cboType);

//// Adds new Generated Filter
//pnlMain.Controls.Add(dynPanel);
//py += dynPanelVerticalSpace; 

////Then Chose Type of filter



//We have to use and/or button and pieces together a list






//if (ctrlP is Panel)
//{
//    if (ctrlP = 
//    {

//    }
//    if (ctrl.Tag != "compare")
//    {
//        foreach (ComboBox cbo in lstDynCBOs)
//        {
//            if (cbo.SelectedIndex == 0)
//            {

//            }
//        }
//    }
//}
//    }

//foreach (ComboBox cbo in lstDynCBOs)
//{
//  for (int i = 0; i < strFilterTypes.Length; i++)
//        {
//           if(cbo.SelectedIndex == 0)
//            {
//        //And/or determination    
//        //Filter as Name
//            foreach(Control ctrl in pnlMain.Controls[i].Controls)
//               {
//                  if (ctrl is TextBox)
//                  //Hunter's Best guess at how to filter by this
//                  {
//                  if (ctrl.Text == fsMasterlist[i].Name)
//                    {
//                         foreach (FoodStuff fs in fsMasterlist)
//                    {
//                        if (fs.Name == ctrl.Text)
//                        {
//                            ListViewItem lsvItem = new ListViewItem(fs.Name.ToString());
//                            lsvItem.SubItems.Add(fs.Servings.ToString());
//                            lsvItem.SubItems.Add(fs.Cost.ToString("C"));
//                            lsvItem.SubItems.Add(fs.CostPerServing().ToString("C") + " Each");
//                            lsvItem.SubItems.Add(fs.PrepTime.ToString() + " mins");
//                            lsvItem.SubItems.Add(fs.CookTime.ToString() + " mins");
//                            lsvItem.SubItems.Add(fs.ID.ToString());
//                            lsvSearch.Items.Add(lsvItem);

//                        }
//                    }
//                }

//            }


//  }
//    }
//    else if (cbo.SelectedIndex == 1)
//    {
//       //Filter as Tag 
//    }
//    else if (cbo.SelectedIndex == 2)
//    {
//        //Filter by Serving Size
//    }
//    else
//    {
//        //Filter by Price per serving
//        //look for combobox's tag, if tag is "Compare" then that's the one we need to use
//        //then grab the symbol from it (text) to use in the filter expression
//        foreach (Control ctrl in pnlMain.Controls)
//        {
//            if (ctrl is ComboBox) {
//                if (ctrl.Tag == "Compare")
//                {
//                // "Put text in filter type things"- Dustin's actual words  -->  ctrl.Text = "FilterTypeThing"
//                }

//                }
//        }
//    }
//}
//================================================================
//================================================================


//}


