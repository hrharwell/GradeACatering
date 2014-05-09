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
    public partial class frmDisplayRecipe : Form
    {
        private FoodStuff fstoUpdate;

        public void LoadFoodstuff(FoodStuff inFS)
        {
            //fill out controls based on what inFS contains
            fstoUpdate = inFS;
            txtName.Text = inFS.Name;
            txtServingSize.Text = inFS.Servings.ToString();
            txtPriceSold.Text = inFS.Cost.ToString();
            txtPrepTime.Text = inFS.PrepTime.ToString();
            txtCookTime.Text = inFS.CookTime.ToString();
            txtDirections.Text = inFS.Directions;
            foreach (string s in inFS.ReturnTagList())
            {
                lbxTags.Items.Add(s);
            }

            //get recipematerials for it...
            List<Recipe> inFSmats = DataConnection.ListOfIngredients(inFS.ID);
            foreach (Recipe r in inFSmats)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = r.FractionAmount();
                lvi.SubItems.Add(r.Unit);
                lvi.SubItems.Add(DataConnection.GetFoodstuffWithID(r.MadeOf).Name);

                lsvIngredients.Items.Add(lvi);
            }
        }

        public frmDisplayRecipe()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnEditRecipe_Click(object sender, EventArgs e)
        {
            if (btnEditRecipe.Text == "Edit Recipe")
            {
             //Switches the form into a editable state
                txtName.Enabled = true;
                txtPriceSold.Enabled = true;
                txtPrepTime.Enabled = true;
                txtCookTime.Enabled = true;
                txtDirections.Enabled = true;
                txtDirections.ReadOnly = false;
                txtTags.Enabled = true;
                txtServingSize.Enabled = true;
                cboIng.Enabled = true;
                cboUnit.Enabled = true;
                txtQty.Enabled = true;
                btnAddIng.Enabled = true;
                btnEditIng.Enabled = true;
                btnDeleteIng.Enabled = true;
                btnAddToTagList.Enabled = true;
            btnRemoveSelectedTag.Enabled = true;
            btnEditRecipe.Text = "Save Updates";
            lsvIngredients.Enabled = true;
            lbxTags.Enabled = true;
            btnPrint.Visible = true;

            }
            else
            {
                //Save Data...Hunter's version of what dustin did on the Entry page
                DialogResult button = MessageBox.Show("Are you sure you want to overwrite the previous data?", "Save Edited Recipe", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (button == DialogResult.Yes)
                {

                    //Basically, create brand new foodstuff from all the parameters here, getting the old FSID
                    //then remove the old foodstuff's recipematerial entries that don't match the new one's
                    string strID = fstoUpdate.ID;

                    string strName = fstoUpdate.Name;
                    if (txtName.Text != strName)
                        strName = txtName.Text;

                    int intPrepTime = fstoUpdate.PrepTime;
                    if (txtPrepTime.Text == "")
                        txtPrepTime.Text = "-1";
                    else if (txtPrepTime.Text != intPrepTime.ToString())
                        if (!int.TryParse(txtPrepTime.Text, out intPrepTime))
                        {
                            MessageBox.Show("Error converting new prep time value.  Did you enter it correctly?");
                            return;
                        }

                    int intCookTime = fstoUpdate.CookTime;
                    if (txtCookTime.Text == "")
                        txtCookTime.Text = "-1";
                    else if (txtCookTime.Text != intCookTime.ToString())
                        if (!int.TryParse(txtCookTime.Text, out intCookTime))
                        {
                            MessageBox.Show("Error converting new cook time value.  Did you enter it correctly?");
                            return;
                        }

                    int intServings = fstoUpdate.Servings;
                    if (txtServingSize.Text == "")
                        txtServingSize.Text = "-1";
                    else if (txtServingSize.Text != intServings.ToString())
                        if (!int.TryParse(txtServingSize.Text, out intServings))
                        {
                            MessageBox.Show("Error converting new serving size value.  Did you enter it correctly?");
                            return;
                        }

                    double dblCost = fstoUpdate.Cost;
                    if (txtPriceSold.Text == "")
                        txtPriceSold.Text = "-1.0";
                    else if (txtPriceSold.Text != dblCost.ToString())
                        if (!Double.TryParse(txtPriceSold.Text, out dblCost))
                        {
                            MessageBox.Show("Error converting new price value.  Did you enter it correctly?");
                            return;
                        }

                    string strDirections = fstoUpdate.Directions;
                    if (txtDirections.Text == "")
                        strDirections = txtDirections.Text;
                    else if (txtDirections.Text != strDirections)
                        strDirections = txtDirections.Text;

                    List<string> newTags = new List<string>();
                    if (lbxTags.Items.Count > 0)
                    {
                        for (int i = 0; i < lbxTags.Items.Count; i++)
                        {
                            newTags.Add(lbxTags.Items[i].ToString());
                        }
                    }

                    //

                    //if item in list but not fs's list, add it, then add as its own foodstuff
                    //if item matches, check unit and quantity
                    //if different, update from ingredient list
                    //if item in fs's list is not in ingredient list, remove it
                    List<Recipe> newIngrList = new List<Recipe>();


                    if (lsvIngredients.Items.Count > 0)
                    {
                        foreach (ListViewItem lvi in lsvIngredients.Items)
                        {
                            //check to see whether the item exists or not by matching name, which is the third column of the listview.
                            if (DataConnection.FindFoodstuffsNamed(lvi.SubItems[2].Text).Count > 0)
                            {
                                //this is supposed to return true if a name match is found
                                //and add it to the new food's ingredient list
                                newIngrList.Add(new Recipe(strID, (DataConnection.FindFoodstuffsNamed(lvi.SubItems[2].Text)[0].ID),
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
                                newIngrList.Add(new Recipe(strID, newPHID, lvi.SubItems[0].Text, lvi.SubItems[1].Text));

                            }
                        }
                    }
                    //now update it!
                    DataConnection.UpdateFoodstuff(new FoodStuff(strID, strName, strDirections, intPrepTime, intCookTime, dblCost, intServings, newTags, newIngrList));
                }


                //List<Recipe> newItemIngredients = new List<Recipe>();
                //if (lsvIngredients.Items.Count == 0)
                //{
                //    //Not sure if this will need to change for updating...We only need the new ingredients
                //    newItemIngredients.Add(new Recipe(newFS.ID, fstoUpdate.ID));
                //}
                //else
                //{
                //   foreach(ListViewItem lvi in lsvIngredients.Items)
                //    if(DataConnection.FindFoodstuffsNamed(lvi.SubItems[0].Text).Count > 0 )
                //    {
                //        newItemIngredients.Add(new Recipe(fstoUpdate.ID, (DataConnection.FindFoodstuffsNamed(lvi.SubItems[0].Text)[0].ID),
                //                                   lvi.SubItems[1].Text, lvi.SubItems[2].Text));
                //    } 
                //    else
                //    {
                //         //Did not find a match...Dustin Dummy entries

                //         string newPHID = lvi.SubItems[0].Text.Substring(0, Math.Min(lvi.SubItems[0].Text.Split(' ')[0].Length, 4));//grab the first up to 4 characters of the name
                //         newPHID += (DataConnection.NumFoodstuffs()+1).ToString("0000#");
                //         FoodStuff fsPlaceholder = new FoodStuff(newPHID, lvi.SubItems[0].Text);
                //         DataConnection.AddFoodStuff(fsPlaceholder, new Recipe(newPHID, newPHID));

                //         newItemIngredients.Add(new Recipe(newFS.ID, newPHID, lvi.SubItems[1].Text, lvi.SubItems[2].Text));
                //   }

                //}	

                    //then reset the form back into a readonly state
                btnEditRecipe.Text = "Edit Recipe";
                txtName.Enabled = false;
                txtPriceSold.Enabled = false;
                txtPrepTime.Enabled = false;
                txtCookTime.Enabled = false;
                txtDirections.Enabled = false;
                txtTags.Enabled = false;
                txtServingSize.Enabled = false;
                cboIng.Enabled = false;
                cboUnit.Enabled = false;
                txtQty.Enabled = false;
                btnAddIng.Enabled = false;
                btnEditIng.Enabled = false;
                btnDeleteIng.Enabled = false;
                btnAddToTagList.Enabled = false;
                btnRemoveSelectedTag.Enabled = false;
                txtDirections.ReadOnly = true;
                lblMessage.Text = "Data edit saved";
                timer1.Start();
                    lsvIngredients.Enabled = false;
                    lbxTags.Enabled = false;
            }
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
                else if (System.Text.RegularExpressions.Regex.IsMatch(txtQty.Text, @"[1-9]?\w{0,1}[\d/\d]?"))
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
                MessageBox.Show( "Please Enter an Ingredient");
            }
            //if (cboIng.Text != "" && txtQty.Text != "" && cboUnit.Text != "")
            //{
            //    double dblQty;
            //    if (cboIng.Text != "" && txtQty.Text != "" && cboUnit.Text != "")
            //    {
            //        if (double.TryParse(txtQty.Text, out dblQty))
            //        {
            //            //int intI = lsvIngredients.Items.Count;
            //            //lsvIngredients.Items.Add(cboIng.Text);
            //            //lsvIngredients.Items[intI].SubItems.Add(dblQty.ToString());
            //            //lsvIngredients.Items[intI].SubItems.Add(cboUnit.Text);

            //            //how dustin does it
            //            ListViewItem lvi = new ListViewItem();
            //            //make a listview item, fill it with your parameters
            //            lvi.Text = dblQty.ToString();
            //            lvi.SubItems.Add(cboUnit.Text);
            //            lvi.SubItems.Add(cboIng.Text);
            //            //then add it to the listview items collection.
            //            lsvIngredients.Items.Add(lvi);

            //            cboIng.Text = "";
            //            txtQty.Text = "";
            //            cboUnit.Text = "";
            //        }
            //        else
            //        {
            //            MessageBox.Show("Please enter a numeric value");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please Enter an Ingredient");
            //    }
            //}
        }

        private void btnDeleteIng_Click(object sender, EventArgs e)
        {
            //foreach (ListViewItem eachItem in lsvIngredients.SelectedItems)
            //{
            //    lsvIngredients.Items.Remove(eachItem);
            //}
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

        private void btnAddToTagList_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtTags.Text, @"^\s*$"))
                lbxTags.Items.Add(txtTags.Text);

            txtTags.Text = "";
            txtTags.Focus();
        }

        private void btnRemoveSelectedTag_Click(object sender, EventArgs e)
        {
            if (lbxTags.SelectedIndices.Count > 0)
            {
                for (int index = lbxTags.SelectedIndices.Count - 1; index >= 0; index--)
                {
                    lbxTags.Items.RemoveAt(lbxTags.SelectedIndices[index]);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
         //   lblMessage.Text = "* Print Feature Coming Soon";

            //Changed this to cancel button...simple returns everything back to a readonly state
            
            btnEditRecipe.Text = "Edit Recipe";
            txtName.Enabled = false;
            txtPriceSold.Enabled = false;
            txtPrepTime.Enabled = false;
            txtCookTime.Enabled = false;
            txtDirections.Enabled = false;
            txtTags.Enabled = false;
            txtServingSize.Enabled = false;
            cboIng.Enabled = false;
            cboUnit.Enabled = false;
            txtQty.Enabled = false;
            btnAddIng.Enabled = false;
            btnEditIng.Enabled = false;
            btnDeleteIng.Enabled = false;
            btnAddToTagList.Enabled = false;
            btnRemoveSelectedTag.Enabled = false;
            txtDirections.ReadOnly = true;
            lsvIngredients.Enabled = false;
            lbxTags.Enabled = false;
            btnPrint.Visible = false;
            lbxTags.Enabled = false;
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

        private void btnEditIng_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem eachItem in lsvIngredients.SelectedItems)
            {
                txtQty.Text = eachItem.SubItems[0].Text;
                cboIng.Text = eachItem.SubItems[2].Text;
                cboUnit.Text = eachItem.SubItems[1].Text;
                lsvIngredients.Items.Remove(eachItem);
            }
        }

        private void frmDisplayRecipe_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            timer1.Stop();
        }
        //Another Hunter Epic Fail... All I wanted to do was Loop throught the textboxes and Make them Readonly like the VB version
        /*
         *   Private Sub TB_ReadOnly(ByVal blnRO As Boolean)
         *      Dim ctrl As Control
         *        For Each ctrl In Controls
         *        If TypeOf ctrl Is TextBox Then
         *            CType(ctrl, TextBox).ReadOnly = blnRO
         *         End If
         *        Next
         *      End Sub
         */


        //Boolean TB_ReadOnly() {
        //    Boolean blnRO;
        //    Control ctrl;
        //    foreach (Control ctrl in Controls)
        //    {
        //        if (typeof(Control) == TextBox)
        //        {

        //        }
        //    }

        //    return blnRO;
        // }
    }
}
