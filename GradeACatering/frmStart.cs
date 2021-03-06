﻿using System;
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

        static int intFoodstuffCount;
        static int intRecipeMaterialCount;

        private void frmStart_Load(object sender, EventArgs e)
        {
            intFoodstuffCount = DataConnection.NumFoodstuffs();
            intRecipeMaterialCount = DataConnection.NumRecipeMaterials();
        }

        public int FoodstuffCount
        {
            get { return intFoodstuffCount; }
            set { intFoodstuffCount = value; }               
        }

        public int RecipeMaterialCount
        {
            get { return intRecipeMaterialCount; }
            set { intFoodstuffCount = value; }
        }

        private void btnSearchfrm_Click(object sender, EventArgs e)
        {
            frmNewSearch Search = new frmNewSearch();
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
        private void bbtnShowAllIngredient_Click(object sender, EventArgs e)
        {
            frmAllIngredients ShowAllIngredients = new frmAllIngredients();
            ShowAllIngredients.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

    }
}
