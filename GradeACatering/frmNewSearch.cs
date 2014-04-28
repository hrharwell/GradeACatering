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

        private static int px = 20;
        private static int py = 10;
        private static int dynPanelHeight = 120;
        private static int dynPanelWidth = 350;
        private static int dynPanelVerticalSpace = dynPanelHeight + 10;

        ArrayList lstDynCBOs = new ArrayList();

        string[] strFilterTypes = { "Name", "Tag", "Serving Size", "Price Per Serving" };

        private void btnDelFilter_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(panel1.Controls.Count - 1);
                py -= dynPanelVerticalSpace;
            }
        }

        private void btnAddFilter_Click(object sender, EventArgs e)
        {
            var dynPanel = new Panel();


            dynPanel.AutoSize = false;
            dynPanel.Name = "pnl ";  
            dynPanel.Size = new System.Drawing.Size(dynPanelWidth, dynPanelHeight);
            dynPanel.BackColor = Color.White;
            dynPanel.Location = new Point(px, py);

            Label lblType = new Label();
            lblType.Text = "Choose Filter Type:";
            lblType.Location = new Point(10, 10);

            ComboBox cboType = new ComboBox();
            cboType.Location = new Point(120, 10);
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_changed);
            
            cboType.Items.AddRange(strFilterTypes);

            

            dynPanel.Controls.Add(lblType);
            dynPanel.Controls.Add(cboType);
            lstDynCBOs.Add(cboType);

            // Adds new Generated Filter
            panel1.Controls.Add(dynPanel);
            py += dynPanelVerticalSpace; 
            
            //Then Chose Type of filter



           

        }

        private void cboType_changed(object sender, EventArgs e)
        {
            ComboBox cboType = (ComboBox)sender;
            Panel dynPanel = (Panel)cboType.Parent;
            for (int i = dynPanel.Controls.Count-1; i > 1; i--)
            {
                dynPanel.Controls.RemoveAt(i);
            }

            if (cboType.SelectedIndex == 0)
            {
                Label lblName = new Label();
                lblName.Text = "Filter Name:";
                lblName.Location = new Point(10, 50);

                TextBox tb = new TextBox();
                tb.Text = "txt";
                tb.Location = new Point(100, 50);

                dynPanel.Controls.Add(lblName);
                dynPanel.Controls.Add(tb);

            }
            else if (cboType.SelectedIndex == 1)
            {
                Label lblName = new Label();
                lblName.Text = "Filter Tag:";
                lblName.Location = new Point(10, 50);
                dynPanel.Controls.Add(lblName);

            }
            else if (cboType.SelectedIndex == 2)
            {
                Label lblName = new Label();
                lblName.Text = "Filter Serving Size:";
                lblName.Location = new Point(10, 50);
                dynPanel.Controls.Add(lblName);
            }
            else if (cboType.SelectedIndex == 3)
            {
                Label lblName = new Label();
                lblName.Text = "work in progress";
                lblName.Location = new Point(10, 50);
                dynPanel.Controls.Add(lblName);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }

      
    }
}
