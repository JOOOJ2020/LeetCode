using System;
using System.Collections.Generic;

namespace LeetCode
{
    internal class LongestCommenSequence
    {
        public int LCSLength(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                return 0;
            }
            int[,] c = GenerateLCSTable(a, b);
            return c[c.GetLength(0) - 1, c.GetLength(1)];
        }

        public void PrintAllLCS(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                return;
            }
            int[,] c = GenerateLCSTable(a, b);
            List<string> list = FullLCS(c, a, b);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private int[,] GenerateLCSTable(string a, string b)
        {
            int[,] table = new int[a.Length + 1, b.Length + 1];
            for (int i = 1; i < a.Length + 1; i++)
            {
                for (int j = 1; j < b.Length + 1; j++)
                {
                    if (a[i - 1] == b[j - 1])
                    {
                        table[i, j] = table[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        table[i, j] = Math.Max(table[i - 1, j], table[i, j - 1]);
                    }
                }
            }
            return table;
        }

        private List<string> FullLCS(int[,] lcsTable, string a, string b)
        {
            LCSItem item = new LCSItem() { CurChar = new List<char>(), CurX = lcsTable.GetLength(0) - 1, CurY = lcsTable.GetLength(1) - 1 };
            Stack<LCSItem> stack = new Stack<LCSItem>();
            List<string> list = new List<string>();
            stack.Push(item);
            while (stack.Count > 0)
            {
                LCSItem lcs = stack.Pop();
                if (lcsTable[lcs.CurX, lcs.CurY] == 0)
                {
                    lcs.CurChar.Reverse();
                    list.Add(new string(lcs.CurChar.ToArray()));
                    continue;
                }
                if (a[lcs.CurX - 1] == b[lcs.CurY - 1])
                {
                    lcs.CurChar.Add(a[lcs.CurX - 1]);
                    lcs.CurX--;
                    lcs.CurY--;
                    stack.Push(lcs);
                }
                else
                {
                    if (lcsTable[lcs.CurX - 1, lcs.CurY] > lcsTable[lcs.CurX, lcs.CurY - 1])
                    {
                        LCSItem temp = new LCSItem() { CurChar = new List<char>(lcs.CurChar), CurX = lcs.CurX - 1, CurY = lcs.CurY };
                        stack.Push(temp);
                    }
                    else if (lcsTable[lcs.CurX - 1, lcs.CurY] < lcsTable[lcs.CurX, lcs.CurY - 1])
                    {
                        LCSItem temp = new LCSItem() { CurChar = new List<char>(lcs.CurChar), CurX = lcs.CurX, CurY = lcs.CurY - 1 };
                        stack.Push(temp);
                    }
                    else
                    {
                        LCSItem temp1 = new LCSItem() { CurChar = new List<char>(lcs.CurChar), CurX = lcs.CurX - 1, CurY = lcs.CurY };
                        LCSItem temp2 = new LCSItem() { CurChar = new List<char>(lcs.CurChar), CurX = lcs.CurX, CurY = lcs.CurY - 1 };
                        stack.Push(temp1);
                        stack.Push(temp2);
                    }
                }
            }
            return list;
        }
    }

    internal class LCSItem
    {
        public List<char> CurChar { get; set; }
        public int CurX { get; set; }
        public int CurY { get; set; }
    }
}
