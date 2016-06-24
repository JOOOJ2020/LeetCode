using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /*  https://leetcode.com/problems/string-to-integer-atoi/
     * 	4. 8.String to integer (atoi)
	
	Implement atoi to convert a string to an integer.
	Hint: Carefully consider all possible input cases. If you want a challenge, please do not see below and ask yourself what are the possible input cases.
	Notes: It is intended for this problem to be specified vaguely (ie, no given input specs). 
    You are responsible to gather all the input requirements up front.
	Requirements for atoi:
	The function first discards as many whitespace characters as necessary until the first non-whitespace character is found. 
    Then, starting from this character, takes an optional initial plus or minus sign followed by as many numerical digits as possible, 
    and interprets them as a numerical value.
	The string can contain additional characters after those that form the integral number, which are ignored and have no effect on the behavior of this function.
	If the first sequence of non-whitespace characters in str is not a valid integral number, 
    or if no such sequence exists because either str is empty or it contains only whitespace characters, no conversion is performed.
	If no valid conversion could be performed, a zero value is returned. 
    If the correct value is out of the range of representable values, INT_MAX (2147483647) or INT_MIN (-2147483648) is returned.
     */
    internal class StringToInteger
    {
        public int Solution(string str)
        {
            if(string.IsNullOrEmpty(str))
            {
                return 0;
            }
            int result = 0;
            bool IsNegative = false,isFirst=true;
            str = str.TrimStart();
            char[] array = str.ToCharArray();
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if(i==0)
                    {
                        if(array[i]=='-')
                        {
                            IsNegative = true;
                        }
                    }
                    else
                    {
                        if(array[i]>='0' && array[i]<='9')
                        {
                            int temp = (int)(array[i] - '0');
                            checked
                            {                                                                                            
                                if(isFirst && IsNegative)
                                {
                                    result = (result * 10 + temp)*-1;
                                    isFirst = false;
                                }
                                else if(IsNegative)
                                {
                                    result = result * 10 - temp;
                                }
                                else
                                {
                                    result = result * 10 + temp;
                                }
                            }
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            
            catch (Exception)
            {
                return IsNegative ? int.MinValue : int.MaxValue;                
            }
            return result;
        }
    }
}
