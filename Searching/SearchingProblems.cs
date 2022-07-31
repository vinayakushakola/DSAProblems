namespace Searching
{
    public class SearchingProblems
    {
        // Q1. Sorted array. Find the floor of element K (floor = {greatest element <= K})
        public static int FloorOfEleK(int[] arr, int k)
        {
            int lo = 0, hi = arr.Length - 1;
            int ans = int.MinValue;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (arr[mid] > k)
                {
                    hi = mid - 1;
                }
                else if (arr[mid] < k)
                {
                    lo = mid + 1;
                    ans = arr[mid];
                }
                else if (arr[mid] == k)
                {
                    ans = arr[mid];
                    break;
                }
            }
            return ans;
        }

        // Q2. Sorted array. Find the 1st occurence of an element K (Return index)
        public static int FirstOccurence(int[] arr, int k)
        {
            #region Input
            // index -    0,1,2,3,4,5,6,7,8
            /*
            int[] arr = { 1, 2, 3, 4, 5, 5, 5, 6, 7 };
            int k = 5;
            int res = SearchingProblems.FirstOccurence(arr, k);
            int op = SearchingProblems.LastOccurence(arr, k);
            */
            #endregion
            int lo = 0, hi = arr.Length - 1;
            int ans = int.MinValue;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (arr[mid] > k)
                    hi = mid - 1;
                else if (arr[mid] < k)
                    lo = mid + 1;
                else if (arr[mid] == k)
                {
                    ans = mid;
                    hi = mid - 1;
                }
            }
            return ans;
        }

        // Q3. Sorted array. Find the last occurenc of K (Return index)
        public static int LastOccurence(int[] arr, int k)
        {
            #region Input
            // index -    0,1,2,3,4,5,6,7,8
            /*
            int[] arr = { 1, 2, 3, 4, 5, 5, 5, 6, 7 };
            int k = 5;
            int op = SearchingProblems.LastOccurence(arr, k);
            */
            #endregion
            int lo = 0, hi = arr.Length - 1;
            int ans = int.MinValue;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (arr[mid] > k)
                    hi = mid - 1; // ignore right side
                else if (arr[mid] < k)
                    lo = mid + 1; // ignore left side
                else if (arr[mid] == k)
                {
                    ans = mid;
                    lo = mid + 1;
                }
            }
            return ans;
        }

        // Q4. Sorted array. Find the 1st element (ceil of element) such that >= K (lower_bound)
        public static int LowerBound(int[] arr, int k)
        {
            #region Input
            // index -    0, 1,  2,  3,  4
            /*
            int[] arr = { 2, 5, 10, 16, 20 };
            int[] kArr = { 5, 9, -1, 50 }; // input array
            foreach (int k in kArr)
            {
                Console.WriteLine("Lower Bound of {0} = {1}", k, SearchingProblems.LowerBound(arr, k));
            }
            */
            #endregion
            int lo = 0, hi = arr.Length - 1;
            int ans = hi + 1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (arr[mid] > k)
                {
                    hi = mid - 1; // Ignore righten size
                    ans = mid;
                }
                else if (arr[mid] < k)
                    lo = mid + 1;
                else if (arr[mid] == k)
                {
                    ans = mid;
                    break;
                }
            }
            return ans;
        }

        // Q5. Sorted array. Find the 1st element (ceil of element) such that > K (upper_bound)
        public static int UpperBound(int[] arr, int k)
        {
            #region Input
            // index -    0, 1,  2,  3,  4
            /*
            int[] arr = { 2, 5, 10, 16, 20 };
            int[] kArr = { 5, 9, -1, 50 }; // input array
            foreach (int k in kArr)
            {
                Console.WriteLine("Upper Bound of {0} = {1}", k, SearchingProblems.UpperBound(arr, k));
            }
            */
            #endregion
            int lo = 0, hi = arr.Length - 1;
            int ans = hi + 1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (arr[mid] > k)
                {
                    hi = mid - 1;
                    ans = mid;
                }
                else if (arr[mid] < k)
                {
                    lo = mid + 1;
                }
                else if (arr[mid] == k)
                {
                    lo = mid + 1; 
                }
            }
            return ans;
        }
 
        // Q6. Sorted array. Find the number of occurence of k
        public static int OccOfK(int[] arr, int k)
        {
            #region Input
            /*
            int[] arr = { -1, -1, 0, 2, 2, 5, 5, 5, 7, 8, 8 };
            int k = 5;
            Console.WriteLine("Occurence of {0} = {1}", k, SearchingProblems.OccOfK(arr, k));
            */
            #endregion
            int lo = 0, hi = arr.Length - 1;
            int lower = LowerBound(arr, k);
            int upper = UpperBound(arr, k);
            return upper - lower;
        }

        // Q7. Sorted Matrix Search for K (Incomplete)
        public static int SearchOfK(int[,] mat, int k)
        {
            int size = (int)Math.Sqrt(mat.Length);
            #region Approach 1
            /*
            int[] flattenArr = new int[size];
            size = (int)Math.Sqrt(size);
            int idx = 0;
            for (int i = 0; i<size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    flattenArr[idx] = mat[i,j];
                    idx++;
                }
            }
            return Searching.BinarySearch(flattenArr, k);
            */
            #endregion
            int col = size - 1;
            int[] arr = new int[size];
            for (int i=0; i<size; i++)
            {
                arr[i] = mat[i, col];
            }
            int lower = LowerBound(arr, k);
            
            for (int i = 0; i<size; i++)
            {
                //if (mat[i,j] == lower)
                //{

                //}
            }
            return -1;
        }

        // Q8. Find the peak element. An array element is peak if it is NOT smaller than its neighbors
        public static int GetPeakElement(int[] arr)
        {
            int start = 0, end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] > arr[mid + 1]) // search on LHS for possible highest element
                    // you are in dec part of array
                    // this may be the ans, but look at left
                    // this is why end != mid - 1
                    end = mid;
                else
                    // you are in asc part of array- because we know mid+1 element > mid element
                    start = mid + 1;
            }
            return arr[start];
        }
    }
}
