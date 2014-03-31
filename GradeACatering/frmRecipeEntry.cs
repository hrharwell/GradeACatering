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
        Boolean blnValid = false;

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

            }
            else
            {
                string ErrMessage = "Please Enter an Ingredient";
                MessageBox.Show(ErrMessage);
            }
        }

        private void btnNewFrm_Click(object sender, EventArgs e)
        {
           //Clear the form....
           
            
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
            if (true) //really this is the level you'd do validation at
            {
                DialogResult button = MessageBox.Show("Are you sure you want to save this data?", "Save Recipe", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (button == DialogResult.Yes)
                {
                    //they clicked yes, go about adding it
                    //generate the id
                    string newID = txtName.Text.Substring(0, 4);//grab the first 3 or 4 characters of the name
                    newID += (frmStart.fsMasterList.Count()+1).ToString("0000#");
                    List<string> newTags = new List<String>();
                    if (lbxTags.Items.Count > 0)
                    {
                        for (int i = 0; i <= lbxTags.Items.Count; i++)
                        {
                            newTags.Add(lbxTags.Items[i].ToString());
                        }
                    }
                    FoodStuff newFS = new FoodStuff(newID, txtName.Text, txtPrepDirections.Text + "\n\n" + txtCookDirections.Text,
                                                    Convert.ToInt32(txtPrepTime.Text), Convert.ToInt32(txtCookTime.Text), Convert.ToDouble(txtPrepTime.Text),
                                                    Convert.ToInt32(txtServingSize.Text), newTags);
                    List<Recipe> newItemIngredients = new List<Recipe>();
                    if(lsvIngredients.Items.Count == 0)
                    {
                        //no ingredients listed, so treat this as an atomic item?
                        //which kind of defeats the purpose of the separate ingredient entry but whatever
                        //FIX IT LATER
                        newItemIngredients.Add(new Recipe(newID, newID,"",""));
                        //atomic items have the same Makes and MadeOf IDs. (i.e. all-purpose flour is made of itself)
                    }
                    else
                    {
                        foreach(ListViewItem lvi in lsvIngredients.Items)
                        {
                            //check to see whether the item exists or not.
                            //preferably in the master list on frmStart...
                            if (frmStart.fsMasterList.Exists(Foodstuff => Foodstuff.Name == lvi.SubItems[0].Text))
                            {
                                newItemIngredients.Add(new Recipe(newID, (frmStart.fsMasterList.Find(FoodStuff => FoodStuff.Name == lvi.SubItems[0].Text)).ID,
                                                       lvi.SubItems[1].Text, lvi.SubItems[2].Text));
                            }
                            else
                            {
                                //Did not find a match...
                                //Complain that items don't exist or are undefined?
                                //make dummy entries?
                                //what do we want to do?

                                //maybe prompt them for whether they want to go ahead and make a blank entry?
                                MessageBox.Show("One or more of these ingredients couldn't be found.  Would you like to add them?", "", MessageBoxButtons.YesNoCancel);
                            }
			            }
                    }
                    
                    frmStart.fsMasterList.Add(newFS);


                    DataConnection.AddFoodStuff(newFS, newItemIngredients);
                }

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
    }
}
