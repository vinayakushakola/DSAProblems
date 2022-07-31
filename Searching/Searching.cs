namespace Searching
{
    internal class Searching
    {
        public static int LinearSearch(int[] arr, int k)
        {
            #region Input
            /*
            int[] arr = { 1, 22, 34, 56, 78 };
            int k = 56;
            int res = Searching.LinearSearch(arr, k);
             */
            #endregion
            // TC - O(N) | SC - O(1)
            int size = arr.Length;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == k) return i;
            }
            return int.MinValue; // default value if k not found
        }

        public static int BinarySearch(int[] arr, int k)
        {
            #region Input
            /*
            int[] arr = { 1, 22, 34, 56, 78 };
            int k = 56;
            int op = Searching.BinarySearch(arr, k);
             */
            #endregion
            // TC - O(logN) | SC - O(1)
            int lo = 0, hi = arr.Length-1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (arr[mid] > k)
                    hi = mid - 1;
                else if (arr[mid] < k)
                    lo = mid + 1;
                else if (arr[mid] == k)
                    return mid;
            }
            return int.MinValue; // default value if k not found
        }
    }
}
