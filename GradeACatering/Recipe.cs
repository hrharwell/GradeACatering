using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeACatering
{
    class Recipe
    {
        private struct Quantity
        {
            public int whole;
            public int numerator;
            public int denominator;
            public string unit;
        }

        private string strMakes, strMadeOf;
        Quantity qAmount;

        public Recipe()
        {
            Makes = string.Empty;
            MadeOf = string.Empty;
            qAmount.whole = 0;
            qAmount.numerator = 0;
            qAmount.denominator = 1;
            
        }

        public Recipe(string inMakes, string inMadeOf, string inAmount, string inUnit)
        {
            Makes = inMakes;
            MadeOf = inMadeOf;

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
            else if(split.Length > 1) //more than one substring
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
            get { return qAmount.unit; }
            set { qAmount.unit = value; }
        }

        public double DecimalAmount()
        {
            return (double)qAmount.whole + ((double)(qAmount.numerator) / (double)(qAmount.denominator));
        }

        public string FractionalAmount()
        {
            return (qAmount.whole.ToString() + " " + qAmount.numerator.ToString() + "/" + qAmount.denominator.ToString());
        }
    }
}
