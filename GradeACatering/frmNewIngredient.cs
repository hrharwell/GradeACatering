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
    double dblQty;
    string ErrMessage = "";
    if (cboIng.Text != "" && txtQty.Text != "" && cboUnit.Text != "")
{       
        if (double.TryParse(txtQty.Text, out dblQty))
    {
       
                int intI = lsvIngredients.Items.Count;
                lsvIngredients.Items.Add(cboIng.Text);  
                lsvIngredients.Items[intI].SubItems.Add(dblQty.ToString());  
                lsvIngredients.Items[intI].SubItems.Add(cboUnit.Text);
                cboIng.Text = "";
                txtQty.Text = "";
                cboUnit.Text = "";
        
        }
        else
        {
           
            MessageBox.Show(  "Please enter a numeric value" );
        }
            
}
    else
    {
        ErrMessage += "Please Enter an Ingredient";
        MessageBox.Show(ErrMessage);
    }
           
}

private void textBox1_TextChanged(object sender, EventArgs e)
{
    
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

private void btnReturn_Click(object sender, EventArgs e)
{
    ActiveForm.Close();
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
    // Open Another Item Form
}

private void btnReturn_Click_1(object sender, EventArgs e)
{
    ActiveForm.Close();
}


}
}
