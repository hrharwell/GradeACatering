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
            txtNotes.Enabled = true;
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
                txtNotes.Enabled = false;
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
    }
}
