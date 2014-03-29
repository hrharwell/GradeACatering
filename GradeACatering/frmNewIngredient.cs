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
}
}
