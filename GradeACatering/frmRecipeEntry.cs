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
        public frmRecipeEntry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNewIngredient efNewIngr = new frmNewIngredient();
            efNewIngr.ShowDialog();
        }

        private void btnAddIng_Click(object sender, EventArgs e)
        {
            if (cboIng.Text != "" && txtQty.Text != "" && cboUnit.Text != "")
            {
                int intI = lsvIngrediants.Items.Count;
                lsvIngrediants.Items.Add(cboIng.Text);
                lsvIngrediants.Items[intI].SubItems.Add(txtQty.Text);
                lsvIngrediants.Items[intI].SubItems.Add(cboUnit.Text);

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
            //if (lsvIngrediants.SelectedIndices )
            //{
              
            //}
        }

        private void btnSaveRecipe_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Are you sure you want to save this data?", "Save Recipe", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
