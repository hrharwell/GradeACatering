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
            frmSearchRecipes Search = new frmSearchRecipes();
            Search.ShowDialog();
        }

        private void btnTestfrm_Click(object sender, EventArgs e)
        {
           frmTest Testform = new frmTest();
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
            NewIngredient.ShowDialog();
        }

        private void btnSeeAllRecipes_Click(object sender, EventArgs e)
        {
            frmShowAllRecipes ShowAllRecipes = new frmShowAllRecipes();
            ShowAllRecipes.ShowDialog();
        }

        //desginating these as public until we figure out a better way of granting
        //access without exposing them to the whole wide world
       public static List<FoodStuff> fsMasterList = new List<FoodStuff>();
       public static List<Recipe> recMasterList = new List<Recipe>();

        private void frmStart_Load(object sender, EventArgs e)
        {
           fsMasterList = DataConnection.ListAllFoodstuffs();
           recMasterList = DataConnection.ListOfIngredients();
        }
    }
}
