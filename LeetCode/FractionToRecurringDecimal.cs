using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /* https://leetcode.com/problems/fraction-to-recurring-decimal/#/description
     * 166. Fraction to Recurring Decimal Add to List
        DescriptionHintsSubmissionsSolutions
        Total Accepted: 49229
        Total Submissions: 286526
        Difficulty: Medium
        Contributor: LeetCode
        Given two integers representing the numerator and denominator of a fraction, return the fraction in string format.

        If the fractional part is repeating, enclose the repeating part in parentheses.

        For example,

        Given numerator = 1, denominator = 2, return "0.5".
        Given numerator = 2, denominator = 1, return "2".
        Given numerator = 2, denominator = 3, return "0.(6)".
     */
    internal class FractionToRecurringDecimal
    {
        public string FractionToDecimal(int numerator, int denominator)
        {
            if (numerator == 0)
            {
                return "0";
            }
            if (denominator == 0)
            {
                return null;
            }
            long x = Math.Abs((long)numerator);
            long y = Math.Abs((long)denominator);
            StringBuilder sb = new StringBuilder();
            string s = (numerator > 0) ^ (denominator > 0) ? "-" : "";
            sb.Append(s);
            sb.Append((x / y).ToString());
            x %= y;
            if(x==0)
            {
                return sb.ToString();
            }
            sb.Append(".");
            // Dictionary, key = Remainder, value = sb.length 
            Dictionary<long, int> dict = new Dictionary<long, int>();
            while(x!=0)
            {
                x *= 10;
                if(dict.ContainsKey(x))
                {
                    int index = dict[x];
                    sb.Insert(index, "(");
                    sb.Append(")");
                    return sb.ToString();
                }
                else
                {
                    dict.Add(x, sb.Length);
                    sb.Append(x/y);
                }
                x %= y;
            }
            return sb.ToString();
        }
    }
}
