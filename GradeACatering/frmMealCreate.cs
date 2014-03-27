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
    public partial class frmMealCreate : Form
    {
        public frmMealCreate()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsvMealItems.Items.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if and item is selected then at the items to the Meal Listview
        //    if ()
        //    {
        //        lsvRecipes.ItemActivate = lsvRecipes.Items.Add;
        //    }
        }
    }
}
