namespace LeetCode
{
    internal class SearchRotateArray
    {
        public int SearchInRotateArray(int[] array, int target)
        {
            if (array == null || array.Length == 0)
            {
                return -1;
            }
            int i = 0, j = array.Length - 1;
            while (i <= j)
            {
                int mid = i + (j - i) / 2;
                if (array[mid] == target)
                {
                    return mid;
                }
                if (array[i] < array[mid])
                {
                    if ((array[i] <= target && target < array[mid]))
                    {
                        j = mid - 1;
                    }
                    else
                    {
                        i = mid + 1;
                    }
                }

                if (array[mid] < array[j])
                {
                    if (target <= array[j] && array[mid] < target)
                    {
                        i = mid + 1;
                    }
                    else
                    {
                        j = mid - 1;
                    }
                }


            }
            return -1;
        }
    }
}
