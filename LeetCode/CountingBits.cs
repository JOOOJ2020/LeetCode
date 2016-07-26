namespace LeetCode
{
    /* https://leetcode.com/problems/counting-bits/
     * 338. Counting Bits
        Total Accepted: 34841
        Total Submissions: 60482
        Difficulty: Medium
        Given a non negative integer number num. For every numbers i in the range 0 ≤ i ≤ num calculate the number of 1's in their binary representation and return them as an array.

        Example:
        For num = 5 you should return [0,1,1,2,1,2].

        Follow up:

        It is very easy to come up with a solution with run time O(n*sizeof(integer)). But can you do it in linear time O(n) /possibly in a single pass?
        Space complexity should be O(n).
        Can you do it like a boss? Do it without using any builtin function like __builtin_popcount in c++ or in any other language.
        Hint:

        You should make use of what you have produced already.
        Divide the numbers in ranges like [2-3], [4-7], [8-15] and so on. And try to generate new range from previous.
        Or does the odd/even status of the number help you in calculating the number of 1s?
     */
    internal class CountingBits
    {
        public int[] Solution(int num)
        {
            int[] array = new int[num + 1];
            for (int i = 0; i < num+1; i++)
            {
                array[i] = BitNum(i);
            }
            return array;
        }

        private int BitNum(int num)
        {
            int count = 0;
            while(num!=0)
            {
                count++;
                num = num & (num - 1);
            }
            return count;
        }

        /// <summary>
        /// 1 是0的1的个数加上1，2是0的个数加上1，因为2是2的1次方。这个时候数组回到的起点位置。
        /// 4-7 的1个数是0-3的1的个数加上1，同理8-15是0-7的1个数加上1
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int[] Solution2(int num)
        {
            int t = 0,pow=1;
            int[] array = new int[num + 1];
            array[0] = 0;
            for (int i = 1; i < num+1; i++)
            {
                if(pow==i)
                {
                    pow *= 2;
                    t = 0;
                }
                array[i] = array[t] + 1;
                t++;
            }
            return array;
        }
    }
}
