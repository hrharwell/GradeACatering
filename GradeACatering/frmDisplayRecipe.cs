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
            btnRemoveSelectedTag.Enabled = false;
            btnEditRecipe.Text = "Save";
            
            }
            else
            {
                //Save Data...Hunter's version of what dustin did on the Entry page
                DialogResult button = MessageBox.Show("Are you sure you want to overwrite the previous data?", "Save Edited Recipe", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (button == DialogResult.Yes)
                {
                    // FInd existing ID
                    


                    List<string> newTags = new List<string>();
                    if (lbxTags.Items.Count > 0)
                    {
                        for (int i = 0; i < lbxTags.Items.Count; i++)
                        {
                            newTags.Add(lbxTags.Items[i].ToString());
                        }
                    }
                    //COPY PASTE OF DUSTINS WORK -hunter
                    //temp fix for blank textboxes so the foodstuff constructor doesn't error out with a blank string
                    string strName = fstoUpdate.Name;
                    int intPrepTime = fstoUpdate.PrepTime;
                    int intCookTime = fstoUpdate.CookTime;
                    int intServings = fstoUpdate.Servings;
                    double dblCost  = fstoUpdate.Cost;

                    if (txtName.Text != strName)
                        strName = txtName.Text;

                    if (txtPrepTime.Text == "")
                        txtPrepTime.Text = "-1";
                    else if (txtPrepTime.Text != intPrepTime.ToString())
                        int.TryParse(txtPrepTime.Text, out intPrepTime);

                    
                    if (txtCookTime.Text == "")
                        txtCookTime.Text = "-1";
                    else if (txtCookTime.Text != intCookTime.ToString())
                        int.TryParse(txtCookTime.Text, out intCookTime);
                                        
                    if (txtServingSize.Text == "")
                        txtServingSize.Text = "-1";
                    else if (txtServingSize.Text != intServings.ToString())
                        int.TryParse(txtServingSize.Text, out intServings);
                  
                    if (txtPriceSold.Text == "")
                        txtPriceSold.Text = "-1.0";
                    else if (txtPriceSold.Text != dblCost.ToString())
                        Double.TryParse(txtPriceSold.Text, out dblCost);
                  
                    //if item in list but not fs's list, add it, then add as its own foodstuff
                    //if item matches, check unit and quantity
                        //if different, update from ingredient list
                    //if item in fs's list is not in ingredient list, remove it

                    foreach (ListViewItem lvi in lsvIngredients.Items)
                    {
                        
                        //look in the database to see if the ingredient in question already exists
                        FoodStuff foundfs = DataConnection.FindFoodstuffsNamed(lvi.SubItems[2].Text)[0];
                        string newIngrID = foundfs.ID;//in theory only one match if the name fits...

                        if (newIngrID == "") //item wasn't found, must be new
                        {
                            newIngrID = lvi.SubItems[0].Text.Substring(0, Math.Min(lvi.SubItems[0].Text.Split(' ')[0].Length, 4)) +
                                                                   (DataConnection.NumFoodstuffs() + 1).ToString("0000#"); //add up to 1st 4 chars of name + # of foodstuffs to make id
                            fstoUpdate.AddIngredient(new Recipe(fstoUpdate.ID, //current food id
                                                                newIngrID, //new ingredient ID
                                                                lvi.SubItems[0].Text,//quantity
                                                                lvi.SubItems[1].Text));//unit
                            //now add the new recipe as its own foodstuff
                            DataConnection.AddFoodStuff(new FoodStuff(newIngrID, lvi.SubItems[2].Text));
                        }
                        else  //found a matching existing ingredient in Foodstuffs
                        {   
                            //determine if the item does or doesn't exist in the ingredient list 
                         
                            Recipe recTestForExists;
                           // bool matchFound = false;
                            foreach (Recipe existing_r in fstoUpdate.ReturnIngredientsList())
                            {
                                recTestForExists = existing_r;
                                //make sure the existing and item to update are the same
                                if (existing_r.MadeOf == newIngrID)
                                {   
                                    //matchFound = true;
                                    //look to see if the values are the same
                                    //compare quantity first
                                    if (existing_r.FractionAmount() != lvi.SubItems[0].Text) //quants are different
                                        fstoUpdate.UpdateIngredientQuantity(existing_r.MadeOf, lvi.SubItems[0].Text);//replace with new one

                                    //now compare unit
                                    if (existing_r.Unit != lvi.SubItems[1].Text) //units are different
                                        fstoUpdate.UpdateIngredientUnit(existing_r.MadeOf, lvi.SubItems[1].Text);//replace with new one
                                } 
                             //  if(!matchFound)
                                    fstoUpdate.RemoveIngredient(recTestForExists);
                            }
                            
                           
                            //item in fs's list isn't in ingredient list, so remove it
                            
                        }
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
                    //    }
                        
                    //}
	
	
	

                    //then
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
                }
            }
           
            //foreach (TextBox textbox in frmDisplayRecipe.);
            //{
                
            //}
        }

        private void btnAddIng_Click(object sender, EventArgs e)
        {
            if (cboIng.Text != "" && txtQty.Text != "" && cboUnit.Text != "")
            {
                double dblQty;
                if (cboIng.Text != "" && txtQty.Text != "" && cboUnit.Text != "")
                {
                    if (double.TryParse(txtQty.Text, out dblQty))
                    {
                        //int intI = lsvIngredients.Items.Count;
                        //lsvIngredients.Items.Add(cboIng.Text);
                        //lsvIngredients.Items[intI].SubItems.Add(dblQty.ToString());
                        //lsvIngredients.Items[intI].SubItems.Add(cboUnit.Text);

                        //how dustin does it
                        ListViewItem lvi = new ListViewItem();
                        //make a listview item, fill it with your parameters
                        lvi.Text = dblQty.ToString();
                        lvi.SubItems.Add(cboUnit.Text);
                        lvi.SubItems.Add(cboIng.Text);
                        //then add it to the listview items collection.
                        lsvIngredients.Items.Add(lvi);
                        
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
            lblMessage.Text = "* Print Feature Coming Soon";
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
