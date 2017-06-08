using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PermutationCombination
    {
        // no duplication items
        public void Permutation(char[] chars)
        {
            if (chars == null || chars.Length == 1)
            {
                return;
            }
            AllRange(chars, 0, chars.Length - 1);
        }

        //字典排序法
        public void Permutation3(char[] chars)
        {
            Array.Sort(chars);
            Console.WriteLine(new string(chars));
            while (NextPermutation(chars))
            {
                Console.WriteLine(new string(chars));
            }
        }

        private void AllRange(char[] chars, int start, int end)
        {
            if (start == end)
            {
                Console.WriteLine(new string(chars));
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    Swap(chars, i, start);
                    AllRange(chars, start + 1, end);
                    Swap(chars, start, i);
                }
            }
        }
       
        private bool NextPermutation(char[] chars)
        {
            bool find = false;
            int p1 = 0, p2 = 0;
            for (int i = chars.Length - 2; i >= 0; i--)
            {
                if (chars[i] < chars[i + 1])
                {
                    p1 = i;
                    find = true;
                    break;
                }
            }
            if (!find)
            {
                return false;
            }
            char min = chars[p1 + 1];
            p2 = p1 + 1;
            for (int i = p1 + 1; i < chars.Length; i++)
            {
                if (chars[i] > chars[p1] && chars[i] < min)
                {
                    min = chars[i];
                    p2 = i;
                }
            }
            Swap(chars, p1, p2);
            Revert(chars, p1 + 1, chars.Length - 1);
            return true;
        }

        private void Swap(char[] chars, int start, int end)
        {
            char c = chars[start];
            chars[start] = chars[end];
            chars[end] = c;
        }

        private void Revert(char[] chars, int start, int end)
        {
            while (start < end)
            {
                char c = chars[start];
                chars[start] = chars[end];
                chars[end] = c;
                start++;
                end--;
            }
        }

        //via binary 0,1 to generate combination
        public void Combination(char[] chars)
        {
            //比如有3个字母，那么组合中3个都全在的是111，所以是2的n次方减去1
            int m = 1 << chars.Length;
            for (int i = 0; i < m; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < chars.Length; j++)
                {
                    if ((i & (1 << j)) != 0)
                    {
                        sb.Append(chars[j]);
                    }
                }
                Console.WriteLine(sb.ToString());
            }
        }
        /* https://leetcode.com/problems/letter-combinations-of-a-phone-number/#/description
         * 17. Letter Combinations of a Phone Number
         * Given a digit string, return all possible letter combinations that the number could represent.
           A mapping of digit to letters (just like on the telephone buttons) is given below.
           Input:Digit string "23"
           Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
         */
        public IList<string> LetterCombinations(string digits)
        {
            Queue<string> queue = new Queue<string>();
            string[] maps = new string[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            for (int i = 0; i < digits.Length; i++)
            {
                int x = int.Parse(digits[i].ToString());
                string s = maps[x];
                if(queue.Count==0)
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        queue.Enqueue(s[j].ToString());
                    }
                }
                else
                {
                    int count = queue.Count;
                    while (count > 0)
                    {
                        string temp = queue.Dequeue();
                        for (int j = 0; j < s.Length; j++)
                        {
                            queue.Enqueue(temp + s[j].ToString());
                        }
                        count--;
                    }
                }
            }
            return queue.ToList();
        }
    }
}
