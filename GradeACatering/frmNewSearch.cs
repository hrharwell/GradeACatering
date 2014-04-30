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

        private void btnAddFilter_Click(object sender, EventArgs e)
        {
            var dynPanel = new Panel();


            dynPanel.AutoSize = false;
            dynPanel.Name = "pnl ";  
            dynPanel.Size = new System.Drawing.Size(dynPanelWidth, dynPanelHeight);
            dynPanel.BorderStyle = BorderStyle.FixedSingle;
            dynPanel.Location = new Point(px, py);

            //CheckBox chk = new CheckBox();
            //chk.Text = "And";
            //chk.AutoSize = false;
            //chk.Appearance = Appearance.Button;
            //chk.Size = new System.Drawing.Size(36, 23);
            //chk.Location = new Point(3, 3);
            //chk.TextAlign = ContentAlignment.TopCenter;
            //dynPanel.Controls.Add(chk);


            Button btn = new Button();
            btn.Text = "And";
            btn.AutoSize = false;
            btn.Size = new System.Drawing.Size(36, 23);
            btn.Location = new Point(3, 3);
            btn.TextAlign = ContentAlignment.TopCenter;
            btn.Click += new System.EventHandler(this.btn_Click);
            dynPanel.Controls.Add(btn);
            lstDynAndOrBtns.Add(btn);

            Label lblType = new Label();
            lblType.Text = "Filter Type:";
            lblType.Location = new Point(80, 7);

            ComboBox cboType = new ComboBox();
            cboType.Size = new System.Drawing.Size(160, 20);
            cboType.Location = new Point(6, 30);
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_changed);
            
            cboType.Items.AddRange(strFilterTypes);

            

            dynPanel.Controls.Add(lblType);
            dynPanel.Controls.Add(cboType);
            lstDynCBOs.Add(cboType);

            // Adds new Generated Filter
            pnlMain.Controls.Add(dynPanel);
            py += dynPanelVerticalSpace; 
            
            //Then Chose Type of filter



           

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
                tb.Location = new Point(6, 60);
                tb.Size = new System.Drawing.Size(160, 20);

                
                dynPanel.Controls.Add(tb);

            }
            else if (cboType.SelectedIndex == 1)
            {
               
                TextBox tb = new TextBox();
                tb.Name = "txtTag";
                tb.Size = new System.Drawing.Size(160, 20);
                tb.Location = new Point(6, 60);
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
                ComboBox cbo = new ComboBox();
                cbo.Name = "cboPrice";
                cbo.Size = new System.Drawing.Size(70, 20);
                cbo.Location = new Point(3,60);
                cbo.DropDownStyle = ComboBoxStyle.DropDownList;
                cbo.Items.AddRange(strCboOperators);
                cbo.Tag = "Compare";
                dynPanel.Controls.Add(cbo);

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
            for (int i = 0; i < strFilterTypes.Length; i++)
            {
                if(lstDynCBOs[i].SelectedIndex == 0)
                {
                    //And/or determination
                    
                    //Filter as name
                    foreach(Control ctrl in pnlMain.Controls[i].Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            
                        }
                    }

                }
                else if (lstDynCBOs[i].SelectedIndex == 1)
                {
                   //Filter as Tag 
                }
                else if (lstDynCBOs[i].SelectedIndex == 2)
                {
                    //Filter by Serving Size
                }
                else
                {
                    //Filter by Price per serving
                    //look for combobox's tag, if tag is "Compare" then that's the one we need to use
                    //then grab the symbol from it (text) to use in the filter expression
                    foreach (Control ctrl in pnlMain.Controls[i].Controls)
                    {
                        if (ctrl is ComboBox) {
                            if (ctrl.Tag == "Compare")
                            {
                            // "Put text in filter type things"- Dustin's actual words  -->  ctrl.Text = "FilterTypeThing"
                            }
                            
                            }
                    }
                }

            }
        
        }

        private void frmNewSearch_Load(object sender, EventArgs e)
        {
            fsMasterlist = DataConnection.ListAllFoodstuffs();
            foreach (FoodStuff fs in fsMasterlist)
            {
                ListViewItem lsvItem = new ListViewItem(fs.Name.ToString());
                lsvItem.SubItems.Add(fs.Servings.ToString());
                lsvItem.SubItems.Add(fs.Cost.ToString("C"));
                lsvItem.SubItems.Add(fs.CostPerServing().ToString("C"));
                lsvItem.SubItems.Add(fs.PrepTime.ToString() + " mins");
                lsvItem.SubItems.Add(fs.CookTime.ToString() + " mins");
                lsvItem.SubItems.Add(fs.ID.ToString());
                lsvSearch.Items.Add(lsvItem);
            }
         
        }

        private void lsvSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
