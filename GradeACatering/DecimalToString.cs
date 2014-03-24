using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace GradeACatering
{
    class DecimalToString
    {/*
        public static void DecimalToFraction(decimal value, ref decimal sign, ref decimal numerator, ref decimal denominator)
        {
            const decimal maxValue = decimal.MaxValue / 10.0M;

            // e.g. .25/1 = (.25 * 100)/(1 * 100) = 25/100 = 1/4
            var tmpSign = value < decimal.Zero ? -1 : 1;
            var tmpNumerator = Math.Abs(value);
            var tmpDenominator = decimal.One;

            // While numerator has a decimal value
            while ((tmpNumerator - Math.Truncate(tmpNumerator)) > 0 &&
                tmpNumerator < maxValue && tmpDenominator < maxValue)
            {
                tmpNumerator = tmpNumerator * 10;
                tmpDenominator = tmpDenominator * 10;
            }

            tmpNumerator = Math.Truncate(tmpNumerator); // Just in case maxValue boundary was reached.
            ReduceFraction(ref tmpNumerator, ref tmpDenominator);
            sign = tmpSign;
            numerator = tmpNumerator;
            denominator = tmpDenominator;
        }

        public static string DecimalToFraction(decimal value)
        {
            var sign = decimal.One;
            var numerator = decimal.One;
            var denominator = decimal.One;
            DecimalToFraction(value, ref sign, ref numerator, ref denominator);
            return string.Format("{0}/{1}", (sign * numerator).ToString().TruncateDecimal(),
                denominator.ToString().TruncateDecimal());
        }

        static readonly Regex FractionalExpression = new Regex(@"^(?<sign>[-])?(?<numerator>\d+)(/(?<denominator>\d+))?$");
        public static decimal? FractionToDecimal(string fraction)
        {
            var match = FractionalExpression.Match(fraction);
            if (match.Success)
            {
                // var sign = Int32.Parse(match.Groups["sign"].Value + "1");
                var numerator = Int32.Parse(match.Groups["sign"].Value + match.Groups["numerator"].Value);
                int denominator;
                if (Int32.TryParse(match.Groups["denominator"].Value, out denominator))
                    return denominator == 0 ? (decimal?)null : (decimal)numerator / denominator;
                if (numerator == 0 || numerator == 1)
                    return numerator;
            }
            return null;*/
        }
    }

