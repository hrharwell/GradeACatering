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
    public partial class frmTest : Form
    {
        private FoodStuff fsTestItem;
        private List<Recipe> lstRecipes = new List<Recipe>();

        public frmTest()
        {
            InitializeComponent();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit program?", "Dummy program", MessageBoxButtons.YesNo) == DialogResult.Yes)
             {
                 this.Close();
             }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fsTestItem = new FoodStuff();
            lblTestItem.Text = fsTestItem.ToString();
            
            string[] strTagList = fsTestItem.GetTags().Split(',');
            foreach(string element in strTagList)
                cboTags.Items.Add(element);

            lstRecipes = DataConnection.ListOfIngredients();
            foreach (Recipe r in lstRecipes)
            {
                ListViewItem lvi = new ListViewItem(r.Makes);
                lvi.SubItems.Add(r.MadeOf);
                lvi.SubItems.Add(r.FractionAmount());
                lvi.SubItems.Add(r.Unit);
                lbxRecipeList.Items.Add(lvi);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            lblConversionOutput.Text = Convert.ToString(Conversions.FractionToDecimal(txtSourceFraction.Text));
        }

        private void btnConvertDecToFrac_Click(object sender, EventArgs e)
        {
            lblDecToFrac.Text = Conversions.DecimalToFraction(Convert.ToDouble(txtDecimal.Text));
            
        }

        private void btnTestInsert_Click(object sender, EventArgs e)
        {
            string insertResults;
            //DataConnection dc = new DataConnection();
            if (txtSourceFraction.Text != string.Empty && txtDecimal.Text != string.Empty)
            {            
                insertResults = DataConnection.TestInsert(txtSourceFraction.Text, txtDecimal.Text);
            }
            else
            {
                insertResults = "No records added.";
            }
                string results = string.Empty;
                foreach(string s in DataConnection.TestSelectAll())
                {
                     results += s + "\n";
                }
                
                MessageBox.Show(results+"\n"+insertResults);
            }

        private void btnRecipeAdd_Click(object sender, EventArgs e)
        {
            if (txtRecipeMakes.Text == string.Empty || txtRecipeMadeOf.Text == string.Empty)
            {
                MessageBox.Show("Makes and MadeOf IDs cannot be blank.");
            }
            else
            {
                if (txtRecipeQty.Text == string.Empty)
                {
                    txtRecipeQty.Text = "NULL"; //null entries in the database are entirely okay
                }
                if (txtRecipeUnit.Text == string.Empty)
                {
                    txtRecipeUnit.Text = "NULL"; //base ingredients won't need quantity or units since they just refer to themselves
                }
                
                lstRecipes.Add(new Recipe(txtRecipeMakes.Text, txtRecipeMadeOf.Text, txtRecipeQty.Text, txtRecipeUnit.Text));
                ListViewItem lvi = new ListViewItem(lstRecipes.Last<Recipe>().Makes);
                lvi.SubItems.Add(lstRecipes.Last<Recipe>().MadeOf);
                lvi.SubItems.Add(lstRecipes.Last<Recipe>().FractionAmount());
                lvi.SubItems.Add(lstRecipes.Last<Recipe>().Unit);

                lbxRecipeList.Items.Add(lvi);
                

                foreach(Control ctrl in gbxBOM.Controls)
                {
                    if (ctrl is TextBox)
                        ((TextBox)ctrl).Clear();
                }

            }
        }

        private void btnRecipeRemove_Click(object sender, EventArgs e)
        {
            DialogResult ConfirmRemoval = MessageBox.Show("Do you really want to remove these items?", "Confirm", MessageBoxButtons.YesNo);
            if(ConfirmRemoval == DialogResult.Yes)
            {
                if (lbxRecipeList.SelectedIndices.Count == lbxRecipeList.Items.Count)
                {
                    lbxRecipeList.Items.Clear();
                    lstRecipes.Clear();
                }
                else
                {
                    foreach (int i in lbxRecipeList.SelectedIndices)
                    {
                        lstRecipes.RemoveAt(i);
                        lbxRecipeList.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void btnCommitRecipes_Click(object sender, EventArgs e)
        {
            foreach (Recipe r in lstRecipes)
            {
                DataConnection.AddRecipeItem(r);
            }
        }



    }
      

}

