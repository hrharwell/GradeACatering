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
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnSearchfrm_Click(object sender, EventArgs e)
        {
            frmSearch Search = new frmSearch();
            Search.ShowDialog();
        }

        private void btnTestfrm_Click(object sender, EventArgs e)
        {
           Form1 Testform = new Form1();
           Testform.ShowDialog();
        }

     

        private void btnNewMeal_Click(object sender, EventArgs e)
        {
            frmMealCreate MealCreate = new frmMealCreate();
            MealCreate.ShowDialog();
        }

        private void btnNewRecipe_Click(object sender, EventArgs e)
        {
            frmRecipeEntry RecipeEntry = new frmRecipeEntry();
            RecipeEntry.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNewIngredient NewIngredient = new frmNewIngredient();
            NewIngredient.Show();
        }
    }
}
