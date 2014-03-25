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
    public partial class Form1 : Form
    {
        private FoodStuff fsTestItem;
        private List<Recipe> lstRecipes = new List<Recipe>();

        public Form1()
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
           /* 
            string[] strTagList = fsTestItem.GetTags().Split('#');
            foreach(string element in strTagList)
                cboTags.Items.Add(element);   
            */      
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
            DataConnection dc = new DataConnection();
            if (txtSourceFraction.Text != string.Empty && txtDecimal.Text != string.Empty)
            {            
                insertResults = dc.TestInsert(txtSourceFraction.Text, txtDecimal.Text);
            }
            else
            {
                insertResults = "No records added.";
            }
                string results = string.Empty;
                foreach(string s in dc.TestSelectAll())
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
                    txtRecipeQty.Text = "NULL";
                }
                if (txtRecipeUnit.Text == string.Empty)
                {
                    txtRecipeUnit.Text = "NULL";
                }
                
                lstRecipes.Add(new Recipe(txtRecipeMakes.Text, txtRecipeMadeOf.Text, txtRecipeQty.Text, txtRecipeUnit.Text));
                ListViewItem lvi = new ListViewItem(lstRecipes.Last<Recipe>().Makes);
                lvi.SubItems.Add(lstRecipes.Last<Recipe>().MadeOf);
                lvi.SubItems.Add(lstRecipes.Last<Recipe>().FractionAmount());
                lvi.SubItems.Add(lstRecipes.Last<Recipe>().Unit);

                lbxRecipeList.Items.Add(lvi);

                foreach(Control ctrl in gbxBOM.Controls)
                {
                    try
                    {
                        ((TextBox)ctrl).Clear();
                    }
                    catch (Exception ex) 
                    {

                    }
                }

            }
        }



        }
      

    }

