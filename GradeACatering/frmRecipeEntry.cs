using System;
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
                int intI = lsvIngredients.Items.Count;
                lsvIngredients.Items.Add(cboIng.Text);
                lsvIngredients.Items[intI].SubItems.Add(txtQty.Text);
                lsvIngredients.Items[intI].SubItems.Add(cboUnit.Text);
                cboIng.Text = "";
                txtQty.Text = "";
                cboUnit.Text = "";

            }
            else
            {
                string ErrMessage = "Please Enter an Ingredient";
                MessageBox.Show(ErrMessage);
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
            var cntrlCollections = GetAll(this,typeof(TextBox));

            foreach (Control ctrl in cntrlCollections )
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = string.Empty;
                }
            }
        }

        private void btnDeleteIng_Click(object sender, EventArgs e)
        {
            if (lsvIngredients.SelectedIndices.Count > 0)
            {
                lsvIngredients.Items.RemoveAt(lsvIngredients.SelectedIndices[0]);
            }
            else if (lsvIngredients.Items.Count > 0)
            {
                string ErrMessage = "Please select an Item";
                MessageBox.Show(ErrMessage);
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
                        for (int i = 0; i <= lbxTags.Items.Count; i++)
                        {
                            newTags.Add(lbxTags.Items[i].ToString());
                        }
                    }
                    //temp fix for blank textboxes so the foodstuff constructor doesn't error out with a blank string
                    if (txtPrepTime.Text == "")
                        txtPrepTime.Text = "-1";
                    if (txtCookTime.Text == "")
                        txtCookTime.Text = "-1";
                    if (txtServingSize.Text == "")
                        txtServingSize.Text = "-1";
                    if (txtPriceSold.Text == "")
                        txtPriceSold.Text = "-1.0";

                    FoodStuff newFS = new FoodStuff(newID, txtName.Text, txtPrepDirections.Text + "\n\n" + txtCookDirections.Text,
                                                    Convert.ToInt32(txtPrepTime.Text), Convert.ToInt32(txtCookTime.Text), Convert.ToDouble(txtPriceSold.Text),
                                                    Convert.ToInt32(txtServingSize.Text), newTags);
                    List<Recipe> newItemIngredients = new List<Recipe>();
                    if(lsvIngredients.Items.Count == 0)
                    {
                        //no ingredients listed, so treat this as an atomic item?
                        //which kind of defeats the purpose of the separate ingredient entry but whatever
                        //FIX IT LATER                     
                        
                        newItemIngredients.Add(new Recipe(newID, newID));
                        //atomic items have the same Makes and MadeOf IDs. (i.e. all-purpose flour is made of itself)
                    }
                    else
                    {
                        foreach(ListViewItem lvi in lsvIngredients.Items)
                        {
                            //check to see whether the item exists or not.
                            if (DataConnection.FindFoodstuffsNamed(lvi.SubItems[0].Text).Count > 0)
                            {
                               newItemIngredients.Add(new Recipe(newID, (DataConnection.FindFoodstuffsNamed(lvi.SubItems[0].Text)[0].ID),
                                                       lvi.SubItems[1].Text, lvi.SubItems[2].Text));
                            }
                            else
                            {
                                //Did not find a match...
                                //making dummy entries

                                string newPHID = lvi.SubItems[0].Text.Substring(0, Math.Min(lvi.SubItems[0].Text.Split(' ')[0].Length, 4));//grab the first up to 4 characters of the name
                                newPHID += (DataConnection.NumFoodstuffs()+1).ToString("0000#");
                                FoodStuff fsPlaceholder = new FoodStuff(newPHID, lvi.SubItems[0].Text);
                                DataConnection.AddFoodStuff(fsPlaceholder, new Recipe(newPHID, newPHID));

                                newItemIngredients.Add(new Recipe(newFS.ID, newPHID, lvi.SubItems[1].Text, lvi.SubItems[2].Text));
                                
                            }
			            }
                    }
                  
                    DataConnection.AddFoodStuff(newFS, newItemIngredients);
                }

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
           
            DialogResult button = MessageBox.Show("Unsaved data will be lost, are you sure you want to leave?", "Unsaved Recipe", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            ActiveForm.Close();
           
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
            
            lbxTags.Items.Add(txtTags.Text);
        }

        private void btnRemoveSelectedTag_Click(object sender, EventArgs e)
        {

            for (int i = lbxTags.SelectedIndices.Count -1 ; i >= 0;  i++)
            {
                lbxTags.Items.RemoveAt(lbxTags.SelectedIndices[i]);
            }
        }

        private void btnAddIng_Click_1(object sender, EventArgs e)
        {
            if (cboIng.Text != "" && txtQty.Text != "" && cboUnit.Text != "")
            {
                int intI = lsvIngredients.Items.Count;
                lsvIngredients.Items.Add(cboIng.Text);
                lsvIngredients.Items[intI].SubItems.Add(txtQty.Text);
                lsvIngredients.Items[intI].SubItems.Add(cboUnit.Text);
                cboIng.Text = "";
                txtQty.Text = "";
                cboUnit.Text = "";

            }
            else
            {
                ErrMessage = "Please Enter an Ingredient";
                MessageBox.Show(ErrMessage);
            }   
        }

        private void btnDeleteIng_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in lsvIngredients.SelectedItems)
            {
                lsvIngredients.Items.Remove(eachItem);
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
       
    }
}
