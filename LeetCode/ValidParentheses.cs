using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /*https://leetcode.com/problems/valid-parentheses/
     * 	20.Valid parentheses  Total Accepted: 115074 Total Submissions: 384355 Difficulty: Easy
     * 	Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
	The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
     */
    internal class ValidParentheses
    {
        public bool Solution(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 0)
            {
                return false;
            }
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char temp = stack.Pop();
                    if ((temp == '(' && c == ')') || (temp == '[' && c == ']') || (temp == '{' && c == '}'))
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0 ? true : false;
        }
    }
}
