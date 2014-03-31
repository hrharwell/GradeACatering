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
public partial class frmNewIngredient : Form
{
    public frmNewIngredient()
    {
        InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        ActiveForm.Close();      
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

private void textBox1_TextChanged(object sender, EventArgs e)
{
    
}

private void btnDeleteIng_Click(object sender, EventArgs e)
{
    if (lsvIngredients.SelectedIndices.Count > 0 )
    {
        lsvIngredients.Items.RemoveAt(lsvIngredients.SelectedIndices[0]);
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

private void btnReturn_Click(object sender, EventArgs e)
{
    ActiveForm.Close();
}
}
}
