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
        private enum NumericCompareType { LessThan, LessThanOrEqual, Equal, GreaterThanOrEqual, GreaterThan, NotEqual }

        private bool MatchAnything = false;
        private static int px = 3;
        private static int py = 3;
        private static int dynPanelHeight = 85;
        private static int dynPanelWidth = 170;
        private static int dynPanelVerticalSpace = dynPanelHeight + 6;

        private List<FoodStuff> fsMasterlist;
        private List<FoodStuff> fsFilteredlist; //Needs to have stuff added that meets criteria 
        List<ComboBox> lstDynCBOs = new List<ComboBox>();
        //List<Button> lstDynAndOrBtns = new List<Button>();

        string[] strFilterTypes = { "Name", "Tag", "Serving Size", "Price Per Serving" };
        string[] strCboOperators = { "<", "<=", "=", "=>", ">", "<>" };
        string[] strNumericCompareNoUnicode = { ">", ">=", "=", "<=", "<" };
        string[] strNumericCompareWords = { "greater than", "greater than or equal to", "equal to", "less than or equal to", "less than" };


        private void btnDelFilter_Click(object sender, EventArgs e)
        {
            if (pnlMain.Controls.Count > 0)
            {
                int RemoveIndex = pnlMain.Controls.Count - 1;
                pnlMain.Controls.RemoveAt(RemoveIndex);
                lstDynCBOs.RemoveAt(RemoveIndex);
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
                btn.Visible = false;
                dynPanel.Controls.Add(btn);
                //  lstDynAndOrBtns.Add(btn);

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
            if (pnlMain.Controls.Count > 0)
            {
                fsFilteredlist.Clear();
                foreach (FoodStuff fs in fsMasterlist)
                {
                    List<bool> matches = new List<bool>();
                    for (int i = 0; i <= lstDynCBOs.Count - 1; i++)
                    {
                        Panel dyn = (Panel)pnlMain.Controls[i];
                        switch (lstDynCBOs[i].SelectedIndex)
                        {
                            case (int)FilterType.Name:
                                foreach (Control ctrl in dyn.Controls)
                                {
                                    if (ctrl is TextBox)
                                    {
                                        if (fs.Name.ToUpper().Contains(ctrl.Text.ToUpper())) //REALLY need to use the culture settings I think...
                                            matches.Add(true);
                                        else
                                            matches.Add(false);
                                    }
                                }
                                break;

                            case (int)FilterType.Tag:
                                foreach (Control ctrl in dyn.Controls)
                                {
                                    if (ctrl is TextBox)
                                    {
                                        if (fs.GetTags().Contains(ctrl.Text))
                                            matches.Add(true);
                                        else
                                            matches.Add(false);
                                    }
                                }
                                break;

                            case (int)FilterType.NumServings:
                                {
                                    int ComparatorIndex = -1;
                                    int Qty = 0;
                                    foreach (Control ctrl in dyn.Controls)
                                    {
                                        //need comparator
                                        if (ctrl is ComboBox && strCboOperators.Contains<string>(ctrl.Text))
                                        {
                                            ComparatorIndex = ((ComboBox)ctrl).SelectedIndex;
                                        }
                                        else if (ctrl is TextBox)
                                        {
                                            if (int.TryParse(((TextBox)ctrl).Text, out Qty))
                                            {
                                                switch (ComparatorIndex)
                                                {
                                                    case (int)NumericCompareType.LessThan:
                                                        if (fs.Servings < Qty)
                                                            matches.Add(true);
                                                        else
                                                            matches.Add(false);
                                                        break;
                                                    case (int)NumericCompareType.LessThanOrEqual:
                                                        if (fs.Servings <= Qty)
                                                            matches.Add(true);
                                                        else
                                                            matches.Add(false);
                                                        break;
                                                    case (int)NumericCompareType.Equal:
                                                        if (fs.Servings == Qty)
                                                            matches.Add(true);
                                                        else
                                                            matches.Add(false);
                                                        break;
                                                    case (int)NumericCompareType.GreaterThanOrEqual:
                                                        if (fs.Servings >= Qty)
                                                            matches.Add(true);
                                                        else
                                                            matches.Add(false);
                                                        break;
                                                    case (int)NumericCompareType.GreaterThan:
                                                        if (fs.Servings > Qty)
                                                            matches.Add(true);
                                                        else
                                                            matches.Add(false);
                                                        break;
                                                    case (int)NumericCompareType.NotEqual:
                                                        if (fs.Servings != Qty)
                                                            matches.Add(true);
                                                        else
                                                            matches.Add(false);
                                                        break;
                                                    default:
                                                        MessageBox.Show("Error reading value comparison.  Did you select one?");
                                                        break;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error reading quantity for filter (did you enter a number?)", "Filter Error");
                                                return; //exits method on error
                                            }
                                        }
                                    }
                                }
                                break;

                            case (int)FilterType.PricePerServing:
                                {
                                    int ComparatorIndex = -1;
                                    double PerServingPrice = 0.0;
                                    foreach (Control ctrl in dyn.Controls)
                                    {
                                        if (ctrl is ComboBox && (string)ctrl.Tag == "Compare")
                                        {
                                            ComparatorIndex = ((ComboBox)ctrl).SelectedIndex;
                                        }
                                        else if (ctrl is TextBox)
                                        {
                                            if (double.TryParse(ctrl.Text, out PerServingPrice))
                                            {
                                                switch (ComparatorIndex)
                                                {
                                                    case (int)NumericCompareType.LessThan:
                                                        if (fs.CostPerServing() < PerServingPrice)
                                                            matches.Add(true);
                                                        else
                                                            matches.Add(false);
                                                        break;
                                                    case (int)NumericCompareType.LessThanOrEqual:
                                                        if (fs.CostPerServing() <= PerServingPrice)
                                                            matches.Add(true);
                                                        else
                                                            matches.Add(false);
                                                        break;
                                                    case (int)NumericCompareType.Equal:
                                                        if (fs.CostPerServing() == PerServingPrice)
                                                            matches.Add(true);
                                                        else
                                                            matches.Add(false);
                                                        break;
                                                    case (int)NumericCompareType.GreaterThanOrEqual:
                                                        if (fs.CostPerServing() >= PerServingPrice)
                                                            matches.Add(true);
                                                        else
                                                            matches.Add(false);
                                                        break;
                                                    case (int)NumericCompareType.GreaterThan:
                                                        if (fs.CostPerServing() > PerServingPrice)
                                                            matches.Add(true);
                                                        else
                                                            matches.Add(false);
                                                        break;
                                                    case (int)NumericCompareType.NotEqual:
                                                        if (fs.CostPerServing() != PerServingPrice)
                                                            matches.Add(true);
                                                        else
                                                            matches.Add(false);
                                                        break;
                                                    default:
                                                        MessageBox.Show("Error reading value comparison.  Did you select one?");
                                                        break;
                                                }
                                            }
                                        }
                                    }
                                    break;
                                }
                            default:
                                MessageBox.Show("Invalid filter type selected.");
                                break;
                        }
                    }
                    //if and is set, see that all items in matches are true
                    //if true, add item to filteredlist
                    if (!chkAndOr.Checked) //or flag is false, basically, or and flag is true...which way to read this?
                    {
                        bool FullMatch = true;
                        foreach (bool b in matches)
                            if (!b)
                                FullMatch = false;

                        if (FullMatch)
                            AddItemToList<FoodStuff>(fsFilteredlist, fs);
                    }
                    else
                    {
                        //if or is set, see that at least one item in matches is true
                        //if true, add item to filteredlist
                        bool PartialMatch = false;
                        foreach (bool b in matches)
                            if (b)
                                PartialMatch = true;

                        if (PartialMatch)
                            AddItemToList<FoodStuff>(fsFilteredlist, fs);
                    }

                }
                if (fsFilteredlist.Count > 0)
                {
                    lsvSearch.Items.Clear();// Clear Unfiltered list
                    PopulateListView(fsFilteredlist);
                }
                else
                    MessageBox.Show("No items found that match your search.");
            }
        }

        private void AddItemToList<T>(List<T> TargetList, Object obj)
        {
            if (obj is T)
                if (!TargetList.Contains((T)obj))
                    TargetList.Add((T)obj);
        }

        private void frmNewSearch_Load(object sender, EventArgs e)
        {
            fsMasterlist = DataConnection.ListAllFoodstuffs();
            PopulateListView(fsMasterlist);
            fsFilteredlist = new List<FoodStuff>();
            py = 3;
            //        //if (/*Passes filter rule.*/)
            //        //{
            //        //    //Then adds the items returned to listview
            //        //     
            //        //}

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
            if (lsvSearch.SelectedIndices.Count > 0)
            {
                deleteRecipeToolStripMenuItem.Enabled = true;
            }
            else
            {
                deleteRecipeToolStripMenuItem.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fsFilteredlist.Clear();
            pnlMain.Controls.Clear();
            lsvSearch.Items.Clear();
            //lstDynAndOrBtns.Clear();
            lstDynCBOs.Clear();
            py = 3;

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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnAndOr_Click(object sender, EventArgs e)
        {
            if (MatchAnything)
                MatchAnything = false;
            else
                MatchAnything = true;
        }

        private void lsvSearch_DoubleClick(object sender, EventArgs e)
        {
            btnDisplay_Click(sender, e);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (lsvSearch.SelectedIndices.Count > 0)
            {
                frmDisplayRecipe displayRecipe = new frmDisplayRecipe();
                displayRecipe.LoadFoodstuff(fsMasterlist[lsvSearch.SelectedIndices[0]]);
                displayRecipe.ShowDialog();
            }
        }

        private void addNewRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecipeEntry RecipeEntry = new frmRecipeEntry();
            RecipeEntry.ShowDialog();
            lsvSearch.Items.Clear();
            frmNewSearch_Load(sender, e);
        }

        private void sOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Opens SOP file
            System.Diagnostics.Process.Start(@"C:\Users\Hunter\Desktop\\Grade A SOP.pdf");
        }

        private void deleteRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsvSearch.SelectedIndices.Count > 0)
            {
                deleteRecipeToolStripMenuItem.Enabled = true;
                DialogResult confirm = MessageBox.Show("Do you really want to do this?  Deletion is irreversible!", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    //delete it!  DELETE IT AALLLLL!!!  MUAHAAHAHHAHA
                    //is filteredlist loaded with anything?
                    if (fsFilteredlist.Count > 0 && fsFilteredlist != null)
                    {
                        //something's in it, look at selectedindex of listview and delete that index's ID number
                        DataConnection.DeleteFoodstuff((fsFilteredlist[lsvSearch.SelectedIndices[0]]).ID);
                    }
                    else
                    {
                        //filteredlist is empty or null, which means master is being displayed
                        DataConnection.DeleteFoodstuff((fsMasterlist[lsvSearch.SelectedIndices[0]]).ID);
                    }
                    //then reload the foodstuffs to reflect the new listing
                    lsvSearch.Items.Clear();
                    btnClear_Click(sender, e);
                    frmNewSearch_Load(sender, e);
                }

            }
        }

        private void chkAndOr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAndOr.Checked)
            {
                chkAndOr.Text = "and/OR";
            }
            else
            {
                chkAndOr.Text = "AND/or";
            }
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
//First thing: have for loop looking at arraylist of comboboxes and see what filter type is and the combobox index:
// Ex. if 0 do the name search if 1 do the tag search etc.
//Need list of things we are searching for...

//if (pnlMain.Controls.Count > 0)
//{
//    //after first pass, if fsFilterdList count > 0, run filters on it
//    //else go thru master again.
//    List<FoodStuff> fsWorkingList = new List<FoodStuff>();
//    List<FoodStuff> fsSourceList = new List<FoodStuff>();

//    for (int i = 0; i <= lstDynCBOs.Count - 1; i++)
//    {
//        Panel dyn = (Panel)pnlMain.Controls[i];//ugly hack, if anything but panels are in pnlMain this WILL EXPLODE...

//        if (i >= 1 && fsFilteredlist.Count > 0)
//            fsSourceList = fsFilteredlist;
//        else
//            fsSourceList = fsMasterlist;

//        if (lstDynCBOs[i].SelectedIndex == (int)FilterType.Name)
//        {
//            foreach (Control ctrl in dyn.Controls)
//            {
//                if (ctrl is TextBox)
//                {
//                    foreach (FoodStuff fs in fsSourceList)
//                    {
//                        if (fs.Name.ToUpper().Contains(ctrl.Text.ToUpper())) //REALLY need to use the culture settings I think...
//                            AddItemToList<FoodStuff>(fsWorkingList, fs);
//                    }
//                }
//            }
//        }
//        else if (lstDynCBOs[i].SelectedIndex == (int)FilterType.Tag)
//        {
//            foreach (Control ctrl in dyn.Controls)
//            {
//                if (ctrl is TextBox)
//                {
//                    foreach (FoodStuff fs in fsSourceList)
//                    {
//                        if (fs.GetTags().Contains(ctrl.Text))
//                            AddItemToList<FoodStuff>(fsWorkingList, fs);
//                    }
//                }
//            }
//        }
//        else if (lstDynCBOs[i].SelectedIndex == (int)FilterType.NumServings)
//        {
//            int ComparatorIndex = -1;
//            foreach (Control ctrl in dyn.Controls)
//            {
//                //need comparator
//                if (ctrl is ComboBox && strCboOperators.Contains<string>(ctrl.Text))
//                {
//                    ComparatorIndex = ((ComboBox)ctrl).SelectedIndex;
//                }
//            }
//            foreach (Control ctrl in dyn.Controls)
//            {
//                if (ctrl is TextBox)
//                {
//                    int qty = 0;
//                    if (int.TryParse(ctrl.Text, out qty))
//                    {
//                        foreach (FoodStuff fs in fsSourceList)
//                        {
//                            if (ComparatorIndex == 0)
//                            {   //less than
//                                if (fs.Servings < qty)
//                                    AddItemToList<FoodStuff>(fsWorkingList, fs);
//                            }
//                            else if (ComparatorIndex == 1)
//                            {   //less than or equal to
//                                if (fs.Servings <= qty)
//                                    AddItemToList<FoodStuff>(fsWorkingList, fs);
//                            }
//                            else if (ComparatorIndex == 2)
//                            {   //equal to
//                                if (fs.Servings == qty)
//                                    AddItemToList<FoodStuff>(fsWorkingList, fs);
//                            }
//                            else if (ComparatorIndex == 3)
//                            {   //greater than or equal to
//                                if (fs.Servings >= qty)
//                                    AddItemToList<FoodStuff>(fsWorkingList, fs);
//                            }
//                            else if (ComparatorIndex == 4)
//                            {   //greater than
//                                if (fs.Servings > qty)
//                                    AddItemToList<FoodStuff>(fsWorkingList, fs);
//                            }
//                            else if (ComparatorIndex == 5)
//                            {   //not equal to
//                                if (fs.Servings != qty)
//                                    AddItemToList<FoodStuff>(fsWorkingList, fs);
//                            }
//                        }
//                    }
//                    else
//                    {
//                        MessageBox.Show("Error reading quantity for filter (did you enter a number?)", "Filter Error");
//                        return; //exits method on error
//                    }
//                }
//            }
//        }
//        else if (lstDynCBOs[i].SelectedIndex == (int)FilterType.PricePerServing)
//        {
//            foreach (Control ctrl in dyn.Controls)
//            {
//                int ComparatorIndex = -1;
//                //need comparator
//                if (ctrl is ComboBox && (string)ctrl.Tag == "Compare")
//                {
//                    ComparatorIndex = ((ComboBox)ctrl).SelectedIndex;
//                }
//                if (ctrl is TextBox)
//                {
//                    double ServingPrice = 0;
//                    if (double.TryParse(ctrl.Text, out ServingPrice))
//                    {
//                        foreach (FoodStuff fs in fsSourceList)
//                        {
//                            if (ComparatorIndex == 0)
//                            {   //less than
//                                if (ServingPrice < fs.CostPerServing())
//                                    AddItemToList<FoodStuff>(fsWorkingList, fs);
//                            }
//                            else if (ComparatorIndex == 1)
//                            {   //less than or equal to
//                                if (ServingPrice <= fs.CostPerServing())
//                                    AddItemToList<FoodStuff>(fsWorkingList, fs);
//                            }
//                            else if (ComparatorIndex == 2)
//                            {   //equal to
//                                if (ServingPrice == fs.CostPerServing())
//                                    AddItemToList<FoodStuff>(fsWorkingList, fs);
//                            }
//                            else if (ComparatorIndex == 3)
//                            {   //greater than or equal to
//                                if (ServingPrice >= fs.CostPerServing())
//                                    AddItemToList<FoodStuff>(fsWorkingList, fs);
//                            }
//                            else if (ComparatorIndex == 4)
//                            {   //greater than
//                                if (ServingPrice > fs.CostPerServing())
//                                    AddItemToList<FoodStuff>(fsWorkingList, fs);
//                            }
//                            else if (ComparatorIndex == 5)
//                            {   //not equal to
//                                if (ServingPrice != fs.CostPerServing())
//                                    AddItemToList<FoodStuff>(fsWorkingList, fs);
//                            }
//                        }
//                    }
//                    else
//                    {
//                        MessageBox.Show("Error reading price for filter (did you enter a number?)", "Filter Error");
//                        return; //exits method on error
//                    }

//                }
//            }
//        }
//        //append additional filters here
//        else
//        {
//            //no filters matched anything?
//            fsFilteredlist = fsMasterlist;
//        }
//        if (fsWorkingList.Count > 0)
//            fsFilteredlist = fsWorkingList;
//    }

//    lsvSearch.Items.Clear();// Clear Unfiltered list
//    PopulateListView(fsFilteredlist);
//}


