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
        public void LoadFoodstuff(FoodStuff inFS)
        {
            //fill out controls based on what inFS contains
            txtName.Text = inFS.Name;
            txtServingSize.Text = inFS.Servings.ToString();
            txtPriceSold.Text = inFS.Cost.ToString();
            txtPrepTime.Text = inFS.PrepTime.ToString();
            txtCookTime.Text = inFS.CookTime.ToString();
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
            txtTags.Enabled = true;
            txtServingSize.Enabled = true;
            cboIng.Enabled = true;
            cboUnit.Enabled = true;
            txtQty.Enabled = true;
            btnAddIng.Enabled = true;
            btnEditIng.Enabled = true;
            btnDeleteIng.Enabled = true;
            btnEditRecipe.Text = "Save";
  
            }
            else
            {
                //Save Data...once we figure out how

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
                cboUnit.Enabled =false;
                txtQty.Enabled = false;
                btnAddIng.Enabled = false;
                btnEditIng.Enabled = false;
                btnDeleteIng.Enabled = false;
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
            lbxTags.Items.Add(txtTags.Text);
        }

        private void btnRemoveSelectedTag_Click(object sender, EventArgs e)
        {
            for (int x = lbxTags.SelectedIndices.Count - 1; x >= 0; x--)
            {
                int idx = lbxTags.SelectedIndices[x];
                lbxTags.Items.RemoveAt(idx);
            } 
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            lblComingSoon.Visible = true;
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
               
                     cboIng.Text = eachItem.Text;
                     txtQty.Text = eachItem.SubItems[1].Text;
                     cboUnit.Text = eachItem.SubItems[2].Text;
                     lsvIngredients.Items.Remove(eachItem);
                    }
               
         

        }

        private void frmDisplayRecipe_Load(object sender, EventArgs e)
        {

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
