﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeACatering
{
    public partial class frmSearchRecipes : Form
    {
        public frmSearchRecipes()
        {
            InitializeComponent();
        }
        private List<FoodStuff> fsMasterlist;
        private List<FoodStuff> fsFilteredNamelist;

        private void frmSearchRecipes_Load(object sender, EventArgs e)
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

        private void btnDisplayRecipe_Click(object sender, EventArgs e)
        {
            if (lsvSearch.SelectedItems.Count > 0)
            {
                frmDisplayRecipe displayRecipe = new frmDisplayRecipe();
                displayRecipe.LoadFoodstuff(fsMasterlist[lsvSearch.SelectedIndices[0]]);
                displayRecipe.ShowDialog();
            }
            else
            {
                //message stating an item needs to be selected first...
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Clear past entry...
            lsvSearch.Items.Clear();
            // Apply the filters
            string strFilterName = txtName.Text;
           // int intFilterPrice =  Convert.ToInt32(txtPricePerServing.Text);
           // int intFilterServingSize = Convert.ToInt32(txtServingSize.Text);
           // string strTags = txtTags.Text;

            if (chkName.Checked == true)
            {
                fsFilteredNamelist = DataConnection.FindFoodstuffsNamed(txtName.Text);
                
            }
            else
            {
                fsFilteredNamelist = fsMasterlist;
            }
         

            // Then repopulate the listview
            foreach (FoodStuff filtFS in fsFilteredNamelist)
            {
                ListViewItem lsvItem = new ListViewItem(filtFS.Name);
                
                lsvItem.SubItems.Add(filtFS.CostPerServing().ToString("C"));
                lsvItem.SubItems.Add(filtFS.Cost.ToString("C"));
                lsvItem.SubItems.Add(filtFS.PrepTime.ToString() + " mins");
                lsvItem.SubItems.Add(filtFS.CookTime.ToString() + " mins");
                lsvItem.SubItems.Add(filtFS.ID.ToString());
                lsvSearch.Items.Add(lsvItem);
               
            }
            

        }

     

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            lsvSearch.Items.Clear();
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


        private void btnClose_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void chkName_CheckedChanged(object sender, EventArgs e)
        {
            // Search using Name as filter
            
        }

        private void chkTags_CheckedChanged(object sender, EventArgs e)
        {
         foreach (RadioButton rdo in gbRadTags.Controls)
	{
       
	}  
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

       

       

      

       
    }
}
