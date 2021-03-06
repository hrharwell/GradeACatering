﻿//Ingredient class for Grade A Catering Recipe manager

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeACatering
{
    public class FoodStuff
    {
        private string strFSID, strName, strDirections;//, strUnit;
     
        // disabled until we figure out what form the tagging system needs to take
        private List<string> lstTags; //or would this be better as just a long, #-delineated string?...    
        private int intPrepTime, intCookTime, intServings; //in minutes
        private double dblCost;  //cost of the whole recipe

        //-------------------------------
        private List<Recipe> lstIngredients;
        //-------------------------------

        //possible todo:
        //new fields for Category (breakfast, lunch, dinner, dessert)
        //               Cookbook (which book it came from?)
        //               Author (of cookbook?)
       
        public FoodStuff()
        {
            //default constructor
            //for testing only
            //Pregenerated testing stuff...
            strFSID = "Item01";
            strName = "Test Item";
            strDirections = "1) Gather Things\n2) ???\n3) Profit (maybe)";
            //strUnit = "Instance";
            intPrepTime = 30;
            intCookTime = 20;
            intServings = 1;
            dblCost = 9.95;

            
            lstTags = new List<string>();
            lstTags.Add("TestItem");
            lstTags.Add("PleaseIgnore");
            lstTags.Add("NotForResale");
            
        }

        public FoodStuff(string inID, string inName, string inDirections = "", int inPrep = -1, int inCook = -1,
                         double inCost = -1.0, int inServing = -1, List<string> inTags = null, List<Recipe> inIngredients = null)
        {
            //This is a constructor for generating a placeholder item: basically just a name and ID
            strFSID = inID;
            strName = inName;
            strDirections = inDirections;
            dblCost = inCost;
            intPrepTime = inPrep;
            intCookTime = inCook;
            intServings = inServing;

            if (inTags == null)
                lstTags = new List<string>();
            else
                lstTags = inTags;

            if (inIngredients == null)
            {   //If no list of ingredients passed in, assume this is an atomic ingredient
                //and create a self-referencing RecipeMaterial entry.
                lstIngredients = new List<Recipe>();
                lstIngredients.Add(new Recipe(inID,inID));
            }
            else
                lstIngredients = inIngredients;
        }
        

        public override string ToString()
        {
            string strOut = String.Concat("ID Number: ", ID, "\n",
                                          "Item Name: ", Name, "\n",
                                          "Directions: ", Directions, "\n",
                                          //"Unit: ", Unit, "\n",
                                          "Prep Time: ", PrepTime, "\n",
                                          "Cook Time: ", CookTime, "\n",
                                          "Cost: $", Cost, "\n",
                                          "Servings: ", Servings, "\n",
                                          "Cost per Serving: $", CostPerServing(), "\n",
                                          "Tags: ");

             strOut = String.Concat(strOut,GetTags()); 
            
            return strOut;
        }

        public string ID
        {
            get{ return strFSID; }
        }
        
        public string Name
        {
            get { return strName; }
            //same as ID, only set during object creation
        }

        public string Directions
        {
            get { return strDirections; }
            //on the off-chance they find a better way of making something, this lets the directions be updatable.
            set { strDirections = value; }
        }

        public double Cost
        {
            //needs a means of updating price values
            get { return dblCost; }
            set { dblCost = value; }
        }

        public int PrepTime
        {
            get { return intPrepTime; }
            set { intPrepTime = value; }
        }

        public int CookTime
        {
            get { return intCookTime; }
            set { intCookTime = value; }
        }

        public int Servings
        {
            get { return intServings; }
            set { intServings = value; }
        }
        public double CostPerServing()
        {
            return Math.Round(Cost / Servings,2);
        }
       
        //tag-related functions for reading, adding, and checking to see if a tag is present.
        public string GetTags(int index = -1)
        {
            if (lstTags == null)
                return ""; //firstly, if it's null spit out an empty string            
            //returns a tag based on its index value.  -1 will return the entire list of tags.
            else if (index == -1)
            {
                string output = string.Empty;
                for(int i = 0; i <= lstTags.Count-1; i++)
                {
                    output += String.Concat(lstTags.ElementAt<string>(i), ",");
                    //when splitting this string back into individual tags, use "," as the demarcation
                }
                return output;
            }
            else
                return lstTags.ElementAt<string>(index);
        }

        

        public int HasTag(string tagtofind)
        {
            //Iterate through the list of tags, returns 0-based index in list if a string matches, else returns -1.
            int isFound = -1;
            for (int i = 0; 
                (i <= lstTags.Count - 1) & isFound == -1; 
                i++)
            {
                if (tagtofind == lstTags.ElementAt<string>(i))
                    isFound = i;
            }
            return isFound;
        }

        public bool AddTag(string tagtoadd)
        {
            //Returns true if tag was added successfully, false if tag already exists.
            bool success = false;
            if (HasTag(tagtoadd) == -1)
            {
                lstTags.Add(tagtoadd);
                success = true;
            }
            return success;
        }


        public bool RemoveTag(string tag)
        {         
            //Returns true if tag was found and removed successfully, false if tag doesn't exist.
            bool success = false;
            int targetIndex = HasTag(tag);
            if (targetIndex >= 0)
            {
                lstTags.RemoveAt(targetIndex);
                success = true;
            }
            return success;
        }

        public List<string> ReturnTagList()
        {
            return lstTags;
        }

        public void AddIngredient(Recipe r)
        {
            lstIngredients.Add(r);
        }

        public void RemoveIngredient(Recipe r)
        {
            foreach (Recipe rec in lstIngredients)
                if (rec == r)
                    lstIngredients.Remove(rec);
        }

        public void RemoveIngredientWithID(string rID)
        {
            foreach (Recipe rec in lstIngredients)
                if (rec.MadeOf == rID)
                    lstIngredients.Remove(rec);
        }

        public Recipe ReturnIngredientWithID(string rID)
        {
            Recipe value = null;

            foreach (Recipe r in lstIngredients)
                if (r.MadeOf == rID)
                    value = r;

            return value;
        }

        public List<Recipe> ReturnIngredientsList()
        {
            return lstIngredients;
        }

        public void UpdateIngredientQuantity(string rID, string rFracValue)
        {
            foreach (Recipe r in lstIngredients)
                if (r.MadeOf == rID)
                    r.UpdateQuantity(rFracValue);
        }

        public void UpdateIngredientUnit(string rID, string rUnit)
        {
            foreach (Recipe r in lstIngredients)
                if (r.MadeOf == rID)
                    r.Unit = rUnit;
        }
    }
}
