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
    public partial class frmDisplayRecipe : Form
    {
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
            txtCookDir.Enabled = true;
            txtPrepDir.Enabled = true;
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
                txtCookDir.Enabled = false;
                txtPrepDir.Enabled = false;
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

        private void btnDeleteIng_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in lsvIngredients.SelectedItems)
            {
                lsvIngredients.Items.Remove(eachItem);
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
