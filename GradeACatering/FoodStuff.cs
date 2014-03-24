//Ingredient class for Grade A Catering Recipe manager

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeACatering
{
    class FoodStuff
    {
        private string strFSID, strName, strDirections, strUnit;
     
        // disabled until we figure out what form the tagging system needs to take
        // private List<string> lstTags; //or would this be better as just a long, #-delineated string?...
        
        private double dblCost;
        private int intPrepTime, intCookTime, intServingSize; //in minutes

        public FoodStuff()
        {
            //empty constructor

            //Pregenerated testing stuff...
            strFSID = "Item01";
            strName = "Test Item";
            strDirections = "1) Gather Things\n2) ???\n3) Profit (maybe)";
            strUnit = "Instance";
            dblCost = 9.95;
            intPrepTime = 30;
            intCookTime = 20;
            intServingSize = 1;

            /*
            lstTags = new List<string>();
            lstTags.Add("TestItem");
            lstTags.Add("PleaseIgnore");
            lstTags.Add("NotForResale");
            */
        }

        public override string ToString()
        {
            string strOut = String.Concat("ID Number: ", ID, "\n",
                                          "Item Name: ", Name, "\n",
                                          "Directions: ", Directions, "\n",
                                          "Unit: ", Unit, "\n",
                                          "Cost: ", Cost, "\n",
                                          "Prep Time: ", PrepTime, "\n",
                                          "Cook Time: ", CookTime, "\n");//,
                                         // "Tags: ");

            // strOut = String.Concat(strOut,GetTags()); 
            
            return strOut;
        }

        public string ID
        {
            get{ return strFSID; }
            //no set since this is only set through the constructor
        }
        
        public string Name
        {
            get { return strName; }
            //same as ID, only set during object creation
        }

        public string Directions
        {
            get { return strDirections; }
            //same as ID, only set during object creation
        }

        public string Unit //Might be replacing this later, don't get too attached
        {
            get { return strUnit; }
            //same as ID, only set during object creation
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

        public int ServingSize
        {
            get { return intServingSize; }
            set { intServingSize = value; }
        }
        //tag-related functions for reading, adding, and checking to see if a tag is present.
        /*  Disabled until the tagging subsystem is better defined
        public string GetTags(int index = -1)
        { 
            if (index == -1)
            {
                string output = string.Empty;
                for(int i = 0; i <= lstTags.Count-1; i++)
                {
                    output += String.Concat("#",lstTags.ElementAt<string>(i), " ");
                }
                return output;
            }
            else
                return lstTags.ElementAt<string>(index);
        }

        public bool HasTag(string tagtofind)
        {
            //Iterate through the list of tags, returns true if a string matches, else returns false.
            bool isFound = false;
            for (int i = 0; (i <= lstTags.Count - 1) & !isFound; i++)
            {
                if (tagtofind == lstTags.ElementAt<string>(i))
                    isFound = true;
            }
            return isFound;
        }

        public bool AddTag(string tagtoadd)
        {
            bool success = false;
            if (HasTag(tagtoadd))
            {
                lstTags.Add(tagtoadd);
                success = true;
            }
            return success;
        }

        /*
        public bool RemoveTag(string tag)
        {
         
            bool success = false;
            if (HasTag("#"+tag)
            {
            }
        }
        */

    }
}
