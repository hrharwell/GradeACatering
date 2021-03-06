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
    public partial class frmRecipeEntry : Form
    {
        string ErrMessage;

        public frmRecipeEntry()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNewIngredient NewIngrFrm = new frmNewIngredient();
            NewIngrFrm.ShowDialog();
        }

        private void btnAddIng_Click(object sender, EventArgs e)
        {
            if (cboIng.Text != "" && txtQty.Text != "" && cboUnit.Text != "")
            {
                double dblQty;
                if (double.TryParse(txtQty.Text, out dblQty))
                {
                    //order in listview is quanity | unit | item name
                    int intI = lsvIngredients.Items.Count;
                    lsvIngredients.Items.Add(dblQty.ToString());
                    lsvIngredients.Items[intI].SubItems.Add(cboUnit.Text);
                    lsvIngredients.Items[intI].SubItems.Add(cboIng.Text);
                    cboIng.Text = "";
                    txtQty.Text = "";
                    cboUnit.Text = "";

                }                                                               //this gibberish should match a mixed number or fraction, like "2 1/3" or "3/4"
                else if(System.Text.RegularExpressions.Regex.IsMatch(txtQty.Text,@"[1-9]?\w{0,1}[\d/\d]?")) 
                {
                    int intI = lsvIngredients.Items.Count;
                    lsvIngredients.Items.Add(txtQty.Text);
                    lsvIngredients.Items[intI].SubItems.Add(cboUnit.Text);
                    lsvIngredients.Items[intI].SubItems.Add(cboIng.Text);
                    cboIng.Text = "";
                    txtQty.Text = "";
                    cboUnit.Text = "";
                }
                else
                {

                    MessageBox.Show("Please enter a numeric value");
                }
            
            }
            else
            {
                MessageBox.Show("Please Enter an Ingredient");
            }
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where
                   (c => c.GetType() == type);
        }

        private void btnNewFrm_Click(object sender, EventArgs e)
        {
           //Clear the form....
            var cntrlCollections = GetAll(this, typeof(TextBox));

            foreach (Control ctrl in cntrlCollections)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = string.Empty;
                }
            }
            lsvIngredients.Items.Clear();
            lbxTags.Items.Clear();
        }

        private void btnDeleteIng_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in lsvIngredients.SelectedItems)
            {
                if (lsvIngredients.SelectedIndices.Count > 0)
                {
                    lsvIngredients.Items.Remove(eachItem);
                    //    lsvIngredients.Items.RemoveAt(lsvIngredients.SelectedIndices[0]);
                }
                else if (lsvIngredients.Items.Count > 0)
                {
                    string ErrMessage = "Please select an Item";
                    MessageBox.Show(ErrMessage);
                }
                else
                {
                    MessageBox.Show("List is empty, please at an item.");
                }
            }
        }

        private void btnSaveRecipe_Click(object sender, EventArgs e)
        {
            /*
             * Here's what this is needing to do:
             * Validate the various fields on the form:
             *      Name must exist
             *      Rest are optional but if they do exist:
             *          PriceSold is a double
             *          ServingSize, PrepTime, CookTime are integers
             *      Check if entries in the ingredients list (which are matched to foodstuffs) exist
             *      in the foodstuff master list.
             *          If they do exist, get their IDs and generate Recipe items to link this new item to them.
             *          If they do NOT exist, prompt user whether to make generic entries for them
             *              (i.e. ID and Name, rest being null)
             *              Then make Recipe entries from these new foodstuffs we just made.
             *      Once that's done, we can push to database...I think...
             *          -Dustin
             */
            
            if (blnValidate()) //really this is the level you'd do validation at
            {
                DialogResult button = MessageBox.Show("Are you sure you want to save this data?", "Save Recipe", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (button == DialogResult.Yes)
                {
                    //they clicked yes, go about adding it
                    //generate the id
                    string newID = txtName.Text.Substring(0, Math.Min(txtName.Text.Split(' ')[0].Length,4));//grab the first up to 4 characters of the name
                    //get the item count and add one.
                    newID += (DataConnection.NumFoodstuffs() + 1).ToString("0000#");
                    
                    List<string> newTags = new List<String>();
                    if (lbxTags.Items.Count > 0)
                    {
                        for (int i = 0; i < lbxTags.Items.Count; i++)
                        {
                            newTags.Add(lbxTags.Items[i].ToString());
                        }
                    }
                    //temp fix for blank textboxes so the foodstuff constructor doesn't error out with a blank string
                    
                    if (txtPrepTime.Text == "")
                        
                        //convert to a double
                        txtPrepTime.Text = "-1";
                        
                    if (txtCookTime.Text == "")
                        txtCookTime.Text = "-1";
                    if (txtServingSize.Text == "")
                        txtServingSize.Text = "-1";
                    if (txtPriceSold.Text == "")
                        txtPriceSold.Text = "-1.0";

                    List<Recipe> newItemIngredients = new List<Recipe>();
                    //if lsvIngredients is empty...atomic ingredient?  Don't hand the list to the constructor.
                    if (lsvIngredients.Items.Count > 0)
                    {
                        foreach (ListViewItem lvi in lsvIngredients.Items)
                        {
                            //check to see whether the item exists or not by matching name, which is the third column of the listview.
                            if (DataConnection.FindFoodstuffsNamed(lvi.SubItems[2].Text).Count > 0)
                            {
                                //this is supposed to return true if a name match is found
                                //and add it to the new food's ingredient list
                                newItemIngredients.Add(new Recipe(newID, (DataConnection.FindFoodstuffsNamed(lvi.SubItems[2].Text)[0].ID),
                                                        lvi.SubItems[0].Text, lvi.SubItems[1].Text));
                            }
                            else
                            {
                                //Did not find a match...
                                //making dummy entries

                                //grab the first up to 4 characters of the name
                               string newPHID = lvi.SubItems[2].Text.Substring(0, Math.Min(lvi.SubItems[2].Text.Split(' ')[0].Length, 4));
                                 
                                newPHID += (DataConnection.NumFoodstuffs() + 1).ToString("0000#");
                                
                                //new placeholder ID, name from listview's name column
                                FoodStuff fsPlaceholder = new FoodStuff(newPHID, lvi.SubItems[2].Text);
                                //should automatically generate the self-referencing RecipeMaterial stub...
                                DataConnection.AddFoodStuff(fsPlaceholder);
                                //then put this in the list for the actual food we're going to add
                                newItemIngredients.Add(new Recipe(newID, newPHID, lvi.SubItems[0].Text, lvi.SubItems[1].Text));

                            }
                        }
                    }
                    //build the new foodstuff we're adding
                    FoodStuff newFS = new FoodStuff(newID, txtName.Text, txtDirections.Text,
                                                    Convert.ToInt32(txtPrepTime.Text), Convert.ToInt32(txtCookTime.Text), Convert.ToDouble(txtPriceSold.Text),
                                                    Convert.ToInt32(txtServingSize.Text), newTags, newItemIngredients);
                    //send to database
                   DataConnection.AddFoodStuff(newFS);
                }

                //Then Clear the form and show a message stating the info was saved
                lblSaved.Text = "Recipe was saved. Please enter new recipe";
                var cntrlCollections = GetAll(this, typeof(TextBox));

                foreach (Control ctrl in cntrlCollections)
                {
                    if (ctrl is TextBox)
                    {
                        ctrl.Text = string.Empty;
                    }
                }
                lsvIngredients.Items.Clear();
                lbxTags.Items.Clear();
                timer1.Start();

            }
            else
            {
                MessageBox.Show(ErrMessage);
            }
            //    FoodStuff fs = new FoodStuff(txtName.Text,
    //        if (blnValid = true)
    //{
    //    Add stuff into food stuff class and into database
    //}
	{
		 
	}
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (lblSaved.Text == "")
            {
                 DialogResult button = MessageBox.Show("Unsaved data will be lost, are you sure you want to leave?", "Unsaved Recipe", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                 if (button == DialogResult.Yes)
                 { 
                  ActiveForm.Close();
                 }

            }
           
           
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //take this out later
            /*
            int intI = DataConnection.ListOfIngredients().Count;
            for (int i = 0; i < intI; i++)
            {
                if (txtName.Text == "Something in the Database")
                {
                    frmStart.fsMasterList.Count();
                    //Create unique Id with name and autogenerated number
                    //Enable all txt boxes in form to be filled
                    
                }
            }*/
            
        }

       public Boolean blnValidate()
       {
            Boolean blnValid = true;
       
       
       if (txtName.Text == "" )
       {
         blnValid = false;
         if (txtPriceSold.Text != "")
         {
             string Str = txtPriceSold.Text.Trim();
             double Num;
             double MaxNum = 100000;
             
             if (double.TryParse(Str, out Num))
             {
                 if (Num > MaxNum)
                 {
                     blnValid = false;
                     ErrMessage = "Invalid number";
                 }
             }
             else
             {
                 blnValid = false;
                 ErrMessage = "Please enter a numerical price";
             }
          }
        
        }  
       return blnValid;
             
    }

        private void btnAddToTagList_Click(object sender, EventArgs e)
        {
           // if(txtTags.Text != "")
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtTags.Text, @"^\s*$"))
                   lbxTags.Items.Add(txtTags.Text);
                             
            txtTags.Text = "";
            txtTags.Focus();
        }

        private void btnRemoveSelectedTag_Click(object sender, EventArgs e)
        {
            if (lbxTags.SelectedIndices.Count > 0)
            {
                for (int index = lbxTags.SelectedIndices.Count-1; index >= 0; index--)
                {
                    lbxTags.Items.RemoveAt(lbxTags.SelectedIndices[index]);
                }
            }
        }


        private void btnEditIng_Click(object sender, EventArgs e)
        {
            
           /*Adds the names of the items to the cbo.text
            * 
            * The deletes the old ingredient from the lsvView
            * 
            * 
            foreach (ListViewItem eachItem in lsvIngredients.SelectedItems)
            {
                lsvIngredients.Items.Remove(eachItem);
            } */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //  Create new Ingredient Form


            frmNewIngredient NewIngrFrm = new frmNewIngredient();

            // Add the name and qty and unit type to new form then open it

            NewIngrFrm.ShowDialog();
        }

        private void lsvIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvIngredients.SelectedIndices.Count > 1)
            {
                btnEditIng.Enabled = false;
            }
            else
            {
                btnEditIng.Enabled = true;
            }
        }

        private void btnDefineItem_Click(object sender, EventArgs e)
        {
            frmNewIngredient NewIngrFrm = new frmNewIngredient();
            NewIngrFrm.ShowDialog();
        }

        private void frmRecipeEntry_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaved.Text = "";
            timer1.Stop();
        }

        private void btnEditIng_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in lsvIngredients.SelectedItems)
            {
                txtQty.Text = eachItem.SubItems[0].Text;
                cboIng.Text = eachItem.SubItems[2].Text;
                cboUnit.Text = eachItem.SubItems[1].Text;
                lsvIngredients.Items.Remove(eachItem);
            }
        }


        //private void btnAddIng_Click_2(object sender, EventArgs e)
        //{
        //    if (cboIng.Text != "" && txtQty.Text != "" && cboUnit.Text != "")
        //    {
        //        double dblQty;
        //        if (cboIng.Text != "" && txtQty.Text != "" && cboUnit.Text != "")
        //        {
        //            if (double.TryParse(txtQty.Text, out dblQty))
        //            {
        //                //int intI = lsvIngredients.Items.Count;
        //                //lsvIngredients.Items.Add(cboIng.Text);
        //                //lsvIngredients.Items[intI].SubItems.Add(dblQty.ToString());
        //                //lsvIngredients.Items[intI].SubItems.Add(cboUnit.Text);

        //                //how dustin does it
        //                ListViewItem lvi = new ListViewItem();
        //                //make a listview item, fill it with your parameters
        //                lvi.Text = dblQty.ToString();
        //                lvi.SubItems.Add(cboUnit.Text);
        //                lvi.SubItems.Add(cboIng.Text);
        //                //then add it to the listview items collection.
        //                lsvIngredients.Items.Add(lvi);

        //                cboIng.Text = "";
        //                txtQty.Text = "";
        //                cboUnit.Text = "";
        //            }
        //        }
        //            }
                
        //            }
    }
}
