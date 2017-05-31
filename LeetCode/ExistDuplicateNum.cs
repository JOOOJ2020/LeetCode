using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// MS interview: an array : 1 - n, check duplicate items in this array, array length = n
    /// </summary>
    public class ExistDuplicateNum
    {
        // n[i] xor (index+1)
        // 连续的数字
        public bool IsExistDupNum(int[] n)
        {
            if (n == null || n.Length == 0)
            {
                return false;
            }
            int re = 0;
            for (int i = 0; i < n.Length; i++)
            {
                re = re ^ n[i] ^ (i + 1);
            }
            return re == 0 ? true : false;
        }

        /// <summary>
        /// n[i] position and index 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsExistDupNum2(int[] n)
        {
            if (n == null || n.Length == 0)
            {
                return false;
            }
            int i = 0;
            while (i < n.Length)
            {
                if (n[i] == i + 1)
                {
                    i++;
                }
                else
                {
                    int x = n[i] - 1;
                    if (n[x] != n[i])
                    {                     
                        int temp = n[i];
                        n[i] = n[x];
                        n[x] = temp;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
