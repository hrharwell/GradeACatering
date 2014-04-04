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
    public partial class frmSearchRecipes : Form
    {
        public frmSearchRecipes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            ActiveForm.Close();
        }

        private void frmSearchRecipes_Load(object sender, EventArgs e)
        {

        }

        private void btnDisplayRecipe_Click(object sender, EventArgs e)
        {
            frmDisplayRecipe DisplayRecipe = new frmDisplayRecipe();
            DisplayRecipe.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

      

       
    }
}
