using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeACatering
{
    static class Conversions
    {
        // I think a lot of this entire class will be unnecessary in the long run...

        public static double FractionToDecimal(string strFraction)
        {
            double dblValue = 0.0;
            //look at the string, split on spaces, look for integer component, look for fraction component
            //first, compact whitespaces
            StringBuilder sb = new StringBuilder(strFraction);
            CompactWhitespaces(sb);

            string[] strComponent = strFraction.Split(' ');
            if (strComponent[0].Contains<char>('/'))
            {  //it contains a backslash so must be a fraction, try to parse into a decimal.
                string[] strSubComponents = strComponent[0].Split('/');
                dblValue += (Convert.ToDouble(strSubComponents[0]) / Convert.ToDouble(strSubComponents[1]));
            }
            else
            {   //no slash, leading number is an integer
                dblValue += Convert.ToDouble(strComponent[0]);
                //now use recursion to try and get to the fraction
                dblValue += FractionToDecimal(strComponent[1]);
            }
            return dblValue;
        }

        public static string DecimalToFraction(double dblInDec)
        {
            //first, get the whole number value, if any
            double dblWhole = Math.Truncate(dblInDec);
            //then get the fractional component
            double dblFrac = dblInDec - dblWhole;
            //numerator and denominators next
            uint numerator = 0;
            uint denominator = 1;

            //is it an actual fraction?
            if (dblFrac > 0.0)
            {
                //figure out how many decimal places there are, easiest to do as a string
                string strFrac = dblFrac.ToString().Remove(0, 2);//this removes the first two characters, the "0."
                //number of decimal places
                uint intFracLength = (uint)strFrac.Length;

                //numerator now needs the proper number of zeroes
                numerator = (uint)Math.Pow(10, intFracLength);

                //parse fraction value to an integer equaling (fraction value)x10^(# decimals)
                uint.TryParse(strFrac, out denominator);

                //next, get greatest common divisor for both numbers
                uint gcd = GreatestCommonDivisor(numerator, denominator);

                //divide numerator and denominator by gcd
                numerator = numerator / gcd;
                denominator = denominator / gcd;          
            }

            //using a stringbuilder to make the fraction
            StringBuilder sb = new StringBuilder();

            //add the whole number, if >0
            if(dblWhole > 0.0)
                sb.Append(dblWhole);
            //add fraction if greater than 0
            if(dblFrac > 0.0)
            {
                if(sb.Length > 0)
                    sb.Append(" ");
                sb.Append(denominator + "/" + numerator); //this...doesn't look right....
            }

            return sb.ToString();
        }

        private static String CompactWhitespaces(String s)
        {
            StringBuilder sb = new StringBuilder(s);

            CompactWhitespaces(sb);

            return sb.ToString();
        }

        private static void CompactWhitespaces(StringBuilder sb)
        {
            if (sb.Length == 0)
                return;

            // set [start] to first not-whitespace char or to sb.Length

            int start = 0;

            while (start < sb.Length)
            {
                if (Char.IsWhiteSpace(sb[start]))
                    start++;
                else
                    break;
            }

            // if [sb] has only whitespaces, then return empty string

            if (start == sb.Length)
            {
                sb.Length = 0;
                return;
            }

            // set [end] to last not-whitespace char

            int end = sb.Length - 1;

            while (end >= 0)
            {
                if (Char.IsWhiteSpace(sb[end]))
                    end--;
                else
                    break;
            }

            // compact string

            int dest = 0;
            bool previousIsWhitespace = false;

            for (int i = start; i <= end; i++)
            {
                if (Char.IsWhiteSpace(sb[i]))
                {
                    if (!previousIsWhitespace)
                    {
                        previousIsWhitespace = true;
                        sb[dest] = ' ';
                        dest++;
                    }
                }
                else
                {
                    previousIsWhitespace = false;
                    sb[dest] = sb[i];
                    dest++;
                }
            }

            sb.Length = dest;
        }

        private static uint GreatestCommonDivisor(uint valA, uint valB)
        {
            //return 0 if both are 0
            if (valA == 0 && valB == 0)
                return 0;
            //return b if only a == 0
            else if (valA == 0 && valB != 0)
                return valB;
            //return a if only b == 0
            else if (valA != 0 && valB == 0)
                return valA;
            //else actually find the gcd
            else
            {
                uint first = valA;
                uint second = valB;

                while (first != second)
                {
                    if (first > second)
                        first = first - second;
                    else
                        second = second - first;
                }
                return first;
            }
        }
    }

}
