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
            frmSearch efSearch = new frmSearch();
            efSearch.ShowDialog();
        }

        private void btnTestfrm_Click(object sender, EventArgs e)
        {
           Form1 efTest = new Form1();
           efTest.ShowDialog();
        }

     

        private void btnNewMeal_Click(object sender, EventArgs e)
        {
            frmMealCreate efMealCreate = new frmMealCreate();
            efMealCreate.ShowDialog();
        }
    }
}
