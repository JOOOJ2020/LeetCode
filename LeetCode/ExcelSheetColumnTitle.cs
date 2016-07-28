using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    /* https://leetcode.com/problems/excel-sheet-column-title/
     * 168. Excel Sheet Column Title
        Total Accepted: 68457
        Total Submissions: 301414
        Difficulty: Easy
        Given a positive integer, return its corresponding column title as appear in an Excel sheet.

        For example:

            1 -> A
            2 -> B
            3 -> C
            ...
            26 -> Z
            27 -> AA
            28 -> AB 
     */
    internal class ExcelSheetColumnTitle
    {
        public string ConvertToTitle(int n)
        {
            //suppose you have excel title 52 = AZ = A * 26 + Z * 1, where A = 1, Z = 26.
            // Now you shift each digit down i.e.A' = 0, and Z' = 25.
            // Then 52 = AZ = (A' + 1) * 26 + (Z' + 1) *1.

            // So now you need to find A' and Z'.Z' = (52 - 1) % 26 = 25, which is (n-1)%26 in the code.
            //Now get A' + 1 from 26 * (A' + 1) +(Z' + 1)
            //If  do n /= 26, Z' + 1 will give additional 1. So you will get n = 2 instead of n = 1.
            //To avoid this you do n = (n - 1) / 26
            char[] array = Enumerable.Range('A', 26).Select(t => (char)t).ToArray();
            //The result need reverse, so use stack to store the result.
            Stack<char> stack = new Stack<char>();
            int x = 0;
            while (n != 0)
            {
                x = (n - 1) % 26;
                stack.Push(array[x]);
                n = (n - 1) / 26;
            }

            return new string(stack.ToArray());
        }
    }
}
