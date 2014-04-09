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
    public partial class frmAllIngredients : Form
    {
        public frmAllIngredients()
        {
            InitializeComponent();
        }

        private void frmAllIngredients_Load(object sender, EventArgs e)
        {
           
            foreach (FoodStuff fs in  DataConnection.ListAllFoodstuffs())
            {
                //parse them out into listviewitem objects
                //then insert listviewitems in the listview
                ListViewItem lvi = new ListViewItem();
                lvi.Text = fs.Name;
                lvi.SubItems.Add(fs.Servings.ToString());
                lvi.SubItems.Add(fs.Cost.ToString());
                lvi.SubItems.Add(fs.CostPerServing().ToString());
                lvi.SubItems.Add(fs.PrepTime.ToString());
                lvi.SubItems.Add(fs.CookTime.ToString());
                //and so on, ordered however the columns are in the listview
                lsvAllRecipes.Items.Add(lvi);
            }
        }
    }
}
