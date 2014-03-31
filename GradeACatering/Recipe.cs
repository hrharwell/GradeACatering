using System;
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
                return "NULL";
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

        

    }
}
