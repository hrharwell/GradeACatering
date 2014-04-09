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
    public partial class frmShowAllRecipes : Form
    {
        private List<FoodStuff> fsMasterlist;
        public frmShowAllRecipes()
        {
            InitializeComponent();
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnOpenRecipe_Click(object sender, EventArgs e)
        {
            frmDisplayRecipe displayRecipe = new frmDisplayRecipe();
            displayRecipe.LoadFoodstuff(fsMasterlist[lsvAllRecipes.SelectedIndices[0]]);
            displayRecipe.ShowDialog();
        }

        private void btnEditRecipe_Click(object sender, EventArgs e)
        {
            // Open recipe entry with fill in data
        }

        private void frmShowAllRecipes_Load(object sender, EventArgs e)
        {

          // Imports all items from the recipes list into listview...
            fsMasterlist = DataConnection.ListAllFoodstuffs();
            foreach (FoodStuff fs in fsMasterlist)
            {
                ListViewItem lsvItem = new ListViewItem(fs.Name.ToString());
                lsvItem.SubItems.Add(fs.Servings.ToString());
                lsvItem.SubItems.Add(fs.Cost.ToString("C"));
                lsvItem.SubItems.Add(fs.CostPerServing().ToString("C"));
                lsvItem.SubItems.Add(fs.PrepTime.ToString() + " mins");
                lsvItem.SubItems.Add(fs.CookTime.ToString() + " mins");
                lsvItem.SubItems.Add(fs.ID.ToString());
                lsvAllRecipes.Items.Add(lsvItem);
            }
         
        }
    }
}
