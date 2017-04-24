using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Partition
    {
        public int Part(int[] array, int start, int end)
        {
            // avoid if duplicated items in the array. if i=start and j=end, the loop will never break when array contains duplicate items.
            int i = start - 1, j = end + 1;
            int mid = array[(end - start) / 2 + start];
            while (i < j)
            {
                while (array[++i] < mid) ;

                while (array[--j] > mid) ;

                if (i < j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            return j;
        }

        public int Part2(int[] array, int start, int end)
        {
            int pivot = array[start];
            //int i = start;
            int pos = start;
            for (int j = start + 1; j < end; j++)
            {
                if (array[j] <= pivot)
                {
                    pos++;
                    int temp = array[pos];
                    array[pos] = array[j];
                    array[j] = temp;
                }
            }
            int t = array[start];
            array[start] = array[pos];
            array[pos] = t;
            return pos;
        }

        public void QuickSort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }
            QSort(array, 0, array.Length - 1);
        }

        private void QSort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pos = Part(array, start, end);
            if (start < pos)
            {
                QSort(array, start, pos);
            }
            if (pos + 1 < end)
            {
                QSort(array, pos + 1, end);
            }
        }

        public int FindKNumber(int[] array, int k)
        {
            if (array == null || array.Length == 0 || k >= array.Length)
            {
                throw new ArgumentNullException();
            }
            return FindK(array, 0, array.Length - 1, k);
        }

        private int FindK(int[] array, int start, int end, int k)
        {

            int target = 0;
            while (start < end)
            {
                int pos = Part(array, start, end);
                if (pos == k - 1)
                {
                    target = array[pos];
                    break;
                }
                else if (pos > k - 1)
                {
                    end = pos;
                }
                else
                {
                    start = pos + 1;
                }
            }
            return target;
        }

        /// <summary>
        /// If we need partition three parts, one is less than target, one equal the target and the last one is greater then target.
        /// we have three color balls, red,yellow and blue. We need order all balls with red,yellow and blue.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        public void ThreePointPartition(int[] array, int target)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException();
            }
            int i = 0, pos = 0, j = array.Length - 1;
            while (pos <= j)
            {
                if (array[pos] < target)
                {
                    Swap(array, i, pos);
                    i++;
                    pos++;
                }
                else if (array[pos] > target)
                {
                    Swap(array, pos, j);
                    j--;
                }
                else
                {
                    pos++;
                }
            }
        }

        private void Swap(int[] array, int start, int end)
        {
            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;
        }
    }
}
