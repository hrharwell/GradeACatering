﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeACatering
{
    public class Recipe
    {
        private struct Quantity
        {
            //to avoid all the code needed to convert fractions to decimals and back again
            //I'm going to save the quantities as fractions and mixed numbers instead of decimals
            public int whole;
            public int numerator;
            public int denominator;
        }

        private string strMakes, strMadeOf, strUnit;
        Quantity qAmount;

        public Recipe() //default constructor used for testing purposes only, may want to comment out or remove later on.
        {
            Makes = string.Empty;
            MadeOf = string.Empty;
            qAmount.whole = 0;
            qAmount.numerator = 0;
            qAmount.denominator = 1;
            strUnit = "tsp";
            
        }

        public Recipe(string inMakes, string inMadeOf)
        {
            //constructor for making self-reference entries (for atomic items i.e. base ingredients)
            Makes = inMakes;
            MadeOf = inMadeOf;
            strUnit = "";
            qAmount.whole = 0;
            qAmount.numerator = 0;
            qAmount.denominator = 0;
        }

        public Recipe(string inMakes, string inMadeOf, string inAmount, string inUnit)
        {
            Makes = inMakes;
            MadeOf = inMadeOf;
            Unit = inUnit;

            string[] split = inAmount.Split(' ');

            //look to see if we have one or two substrings
            if (split.Length == 1)//only one substring
            {
                if (split[0].Contains('/'))//is it a fraction?
                {
                    string[] frac = split[0].Split('/');
                    int.TryParse(frac[0], out qAmount.numerator);
                    int.TryParse(frac[1], out qAmount.denominator);
                }
                else //no fraction
                {
                    int.TryParse(split[0], out qAmount.whole);
                }
            }
            else if(split.Length > 1) //more than one substring indicates a whole number came first...or they typed something in wrong...
            {
                int.TryParse(split[0], out qAmount.whole);
                string[] frac = split[0].Split('/');
                int.TryParse(frac[0], out qAmount.numerator);
                int.TryParse(frac[1], out qAmount.denominator);
            }
        }
                
        public string Makes
        {
            get { return strMakes; }
            set { strMakes = value; }
        }

        public string MadeOf
        {
            get { return strMadeOf; }
            set { strMadeOf = value; }
        }

        public string Unit
        {
            get { return strUnit; }
            set { strUnit = value; }
        }

        public string Amount()
        {
            return FractionAmount() + " " + Unit;
        }       

        public string FractionAmount()
        {
            if (qAmount.whole == 0 && qAmount.numerator == 0 && qAmount.denominator == 0)
            {
                return DBNull.Value.ToString();
            }
            else
            {
                string returnstring = "";
                if(qAmount.whole != 0)
                {
                    returnstring += qAmount.whole.ToString();
                }

                if(qAmount.whole != 0 && qAmount.numerator != 0 && qAmount.denominator != 0)
                {
                    returnstring += " ";
                }
                if(qAmount.numerator != 0 && qAmount.denominator != 0)
                {
                     returnstring += qAmount.numerator.ToString() + "/" + qAmount.denominator.ToString();
                }

                return returnstring;
            }
                
        } 
        
        public double DecimalAmount() //may not be needed but it's here
        {
            return (double)qAmount.whole + ((double)(qAmount.numerator) / (double)(qAmount.denominator));
        }

        public void UpdateQuantity(string inAmount)
        {
            string[] split = inAmount.Split(' ');

            //look to see if we have one or two substrings
            if (split.Length == 1)//only one substring
            {
                if (split[0].Contains('/'))//is it a fraction?
                {
                    string[] frac = split[0].Split('/');
                    int.TryParse(frac[0], out qAmount.numerator);
                    int.TryParse(frac[1], out qAmount.denominator);
                }
                else //no fraction
                {
                    int.TryParse(split[0], out qAmount.whole);
                }
            }
          }

        //overrides to allow comparison between objects.
        //I don't even pretend to know what half of this stuff actually does
        //thanks to StackOverflow for a guide though...
        public override bool Equals(object obj)
        {
            //if parameter is null return false
            if(obj == null)
                return false;

            //if parameter can't be cast to a Recipe object return false
            Recipe p = obj as Recipe;
            if((System.Object)p == null)
                return false;

            //compare contents of each parameter to see if they line up
            bool match = true;
            if (strMakes != p.Makes)
                match = false;
            if (strMadeOf != p.MadeOf)
                match = false;
            if (strUnit != p.Unit)
                match = false;
            if (FractionAmount() != p.FractionAmount())
                match = false;

            return match;

        }

        public static bool operator ==(Recipe r1, Recipe r2)
        {
            return r1.Equals(r2);
        }

        public static bool operator !=(Recipe r1, Recipe r2)
        {
            return !r1.Equals(r2);
        }

        public override int GetHashCode()
        {
            string hashable = this.Makes + " " + this.MadeOf + " " + this.Unit + " " + this.FractionAmount();
            return hashable.GetHashCode();
        }
    }
}
