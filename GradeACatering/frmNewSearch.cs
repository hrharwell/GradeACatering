﻿using System;
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

private static int px = 3;
private static int py = 3;
private static int dynPanelHeight = 85;
private static int dynPanelWidth = 170;
private static int dynPanelVerticalSpace = dynPanelHeight + 6;
private List<FoodStuff> fsMasterlist;

List<ComboBox> lstDynCBOs = new List<ComboBox>();
List<Button> lstDynAndOrBtns = new List<Button>();

string[] strFilterTypes = { "Name", "Tag", "Serving Size", "Price Per Serving" };
string[] strCboOperators = { "<", "<=", "=", "=>", ">", "<>" };
        

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
ComboBox cboType = (ComboBox)sender;
Panel dynPanel = (Panel)cboType.Parent;
for (int i = dynPanel.Controls.Count-1; i > 3; i--)
{
dynPanel.Controls.RemoveAt(i);
}

if (cboType.SelectedIndex == 0)
{

TextBox tb = new TextBox();
tb.Name = "txtName" ;
tb.Location = new Point(3, 60);
tb.Size = new System.Drawing.Size(160, 20);

                
dynPanel.Controls.Add(tb);

}
else if (cboType.SelectedIndex == 1)
{
               
TextBox tb = new TextBox();
tb.Name = "txtTag";
tb.Size = new System.Drawing.Size(160, 20);
tb.Location = new Point(3, 60);
    dynPanel.Controls.Add(tb);

}
else if (cboType.SelectedIndex == 2)
{
               
ComboBox cbo = new ComboBox();
cbo.Name = "cboServSize";
cbo.Size = new System.Drawing.Size(70, 20);
cbo.Location = new Point(3,60);
cbo.DropDownStyle = ComboBoxStyle.DropDownList;
cbo.Items.AddRange(strCboOperators);
dynPanel.Controls.Add(cbo);

TextBox tb = new TextBox();
tb.Name = "txtServSize";
tb.Size = new System.Drawing.Size(80, 20);
tb.Location = new Point(80, 60);
dynPanel.Controls.Add(tb);

}
else if (cboType.SelectedIndex == 3)
{
ComboBox cboCompare = new ComboBox();
cboCompare.Name = "cboPrice";
cboCompare.Size = new System.Drawing.Size(70, 20);
cboCompare.Location = new Point(3, 60);
cboCompare.DropDownStyle = ComboBoxStyle.DropDownList;
cboCompare.Items.AddRange(strCboOperators);
cboCompare.Tag = "Compare";
cboCompare.Controls.Add(cboCompare);

TextBox tb = new TextBox();
tb.Name = "txtPrice";
tb.Size = new System.Drawing.Size(80, 20);
tb.Location = new Point(80, 60);
dynPanel.Controls.Add(tb);
}
}

private void btnApply_Click(object sender, EventArgs e)
{
//First thing: have for loop looking at arraylist of comboboxes and see what filter type is and the combobox index:
// Ex. if 0 do the name search if 1 do the tag search etc.
//Need list of things we are searching for...

lsvSearch.Items.Clear();// Clear Unfiltered list


//===============================================================================================
// Hunter - It's late and I have now clue what i'm doing...Little Looping IF you know what I mean
// 4/30/2014 : 1:10 AM
//===============================================================================================

          
Int32 intNumOfPnls = pnlMain.Controls.Count;
if (intNumOfPnls > 1)
	{
        for (int i = 0; i < lstDynCBOs.Count; i++)
        {
            if (lstDynCBOs[i].SelectedIndex == 0)
            {
                foreach (Control ctrl in pnlMain.Controls[i].Controls)
                {
                    string txtValue = "";
                    string strCompare = "LIKE";
                    string strAndOR = "AND";

                       
                    if(ctrl is Button) 
                    {
                        ctrl.Text = strAndOR;
                        if (ctrl is TextBox)
                        {
                        ctrl.Text = txtValue;
                            if (ctrl is ComboBox)
                             {
                             if (ctrl.Tag == "Compare")
                                {
                                 ctrl.Text = strCompare;
                                 }
                            FilteringElement Filter = new FilteringElement(lstDynCBOs[i].Text,txtValue,strAndOR,strCompare);
                            }

                    }
                      
                           
                    }

                      
                }
                  
            }
	
                     
        }
    }

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
        
}

private void frmNewSearch_Load(object sender, EventArgs e)
{
fsMasterlist = DataConnection.ListAllFoodstuffs();
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

      
}
}
