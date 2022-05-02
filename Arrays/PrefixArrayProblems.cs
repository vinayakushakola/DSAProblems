using System;
using System.Collections.Generic;

namespace Arrays
{
    class PrefixArrayProblems
    {
        // Equilirbium Index
        // An index is said to be an equilibrium index 
        // Sum of all elements to its left == Sum of all elements to its right
        // Return the count of equilibrium index
        public static int EquilibriumIndex(int[] arr)
        {
            List<char> lst = new List<char> { 'e', 'a' };
            #region Approach 
            int size = arr.Length;
            int[] pfArr = GetPrefixArray(arr, size);
            for (int i = 0; i < size; i++)
            {
                int leftSum = i == 0 ? 0 : pfArr[size - 1];
                int rightSum = pfArr[size - 1] - pfArr[i];
                if (leftSum == rightSum)
                    return i;
            }
            return -1;
            #endregion
        }

        // Special Index
        // Sum of all even indice values =  Sum of all odd indice values
        public static int SpecialIndex(int[] arr)
        {
            int size = arr.Length, count = 0;
            int[] evenPf, oddPf;
            GetEvenOddPrefixArray(arr, size, out evenPf, out oddPf);
            for (int i = 0; i<size; i++)
            {
                int evenSum = i == 0 ? oddPf[size - 1]: evenPf[i-1] + (oddPf[size-1] - oddPf[i]);
                int oddSum = i == 0 ? evenPf[size - 1]: oddPf[i-1] + (evenPf[size-1] - evenPf[i]);
                if (evenSum == oddSum)
                    count++;
            }
            return count;
        }

        // Pick from both sides
        // From start or from end or some ele from start & some from end
        // Return the max sum of elements in given array
        public static int PickFromSides(int[] A, int B)
        {
            #region Approach 1
            //int maxSum = 0, size = A.Length, currSum = 0;
            //for (int i = 0; i < B; i++)
            //    currSum += A[i];
            //maxSum = currSum;
            //int inc = size - 1, exc = B - 1;
            //while(inc>=0 && exc >= 0)
            //{
            //    currSum += A[inc--];
            //    currSum -= A[exc--];
            //    maxSum = Math.Max(maxSum, currSum);
            //}
            //return maxSum;
            #endregion
            #region Approach 2 - Prefix Array
            int size = A.Length, maxSum = int.MinValue;
            int[] pfArr = GetPrefixArray(A, size);
            int currSum = 0, ele = 0;
            if (size == B)
                maxSum = pfArr[size - 1];
            else
            {
                for (int i = 0; i <= B; i++)
                {
                    ele = B - i;
                    if (i == 0)
                        currSum = pfArr[size - 1] - pfArr[size - ele - 1];
                    else
                        currSum = pfArr[i - 1] + (pfArr[size - 1] - pfArr[size - ele - 1]);
                }
                maxSum = Math.Max(maxSum, currSum);
            }
            return maxSum;
            #endregion
        }

        // Range Sum Query
        // For each query, you have to find the sum of all elements from L to R 
        public static List<long> RangeSum(List<int> A, List<List<int>> B)
        {
            List<long> pfArr = new List<long>();
            pfArr.Add(A[0]);
            for (int i = 1; i < A.Count; i++)
                pfArr.Add(pfArr[i - 1] + (long)A[i]);
            List<long> lstRes = new List<long>();
            foreach (var lst in B)
            {
                int L = lst[0] - 1;
                int R = lst[1] - 1;
                long sum = (long)(L == 0 ? pfArr[R] : pfArr[R] - pfArr[L - 1]);
                lstRes.Add(sum);
            }
            return lstRes;
        }

        // Time to equality
        // In one second, you can increase the value of one element by 1
        // Find the minimum time in seconds to make all elements of the array equal
        public int TimeToEquality(List<int> A)
        {
            int maxEle = A[0];
            int sum = 0;
            for (int j = 0; j < A.Count; j++)
            {
                if (maxEle < A[j])
                    maxEle = A[j];
                sum += A[j];
            }
            // Len of array  * max element = total len of the array 
            // Sum will give actual sum of the array
            return A.Count * maxEle - sum;
        }

        // Product of array except self
        public static List<int> ProductArray(List<int> A)
        {
            #region Brute Force TC - O(N^2) | SC- O(1)
            //int size = A.Count;
            //List<int> output = new List<int>();
            //for (int i = 0; i<size; i++)
            //{
            //    int product2 = 1;
            //    if (i != 0)
            //    {
            //        for (int j = 0; j < i; j++)
            //            product2 *= A[j];
            //    }
            //    for (int j = size-1; j > i; j--)
            //        product2 *= A[j];
            //    output.Add(product2);
            //}
            //return output;
            #endregion

            #region Approach 2 
            //int product = 1, size = A.Count;
            //for (int i = 0; i<size; i++)
            //    product *= A[i];
            //List<int> output = new List<int>();
            //for (int i = 0; i < size; i++)
            //{
            //    output.Add(product/A[i]);
            //}
            //return output;
            #endregion

            #region Approach 3 - TC - O(N) | SC - O(N)
            //List<int> pfArr = GetPrefixProductList(A);
            //List<int> productLst = new List<int>();
            //for (int i = 0; i < A.Count; i++)
            //{
            //    int product = pfArr[A.Count - 1] / A[i];
            //    productLst.Add(product);
            //}
            //return productLst;
            #endregion

            #region Optimized Approach 4 - TC- O (N) | SC - O(1)
            int size = A.Count;
            List<int> cummLst = GetPrefixProductList(A, size);
            int product = 1;
            for (int i = size - 1; i > 0; --i)
            {
                cummLst[i] = cummLst[i - 1] * product;
                product *= A[i];
            }
            cummLst[0] = product;
            return cummLst;
            #endregion
        }

        public static List<int> GetPrefixProductList(List<int> A, int size)
        {
            List<int> pfArr = new List<int>();
            pfArr.Add(A[0]);
            for (int i = 1; i < size; i++)
                pfArr.Add(pfArr[i - 1] * A[i]);
            return pfArr;
        }

        public static void GetEvenOddPrefixArray(int[] arr, int size, out int[] evenPf, out int[] oddPf)
        {
            int[] even_Pf = new int[size];
            int[] odd_Pf = new int[size];
            even_Pf[0] = arr[0];
            odd_Pf[0] = 0;
            for (int i = 1; i<size; i++)
            {
                if (i % 2 == 0)
                {
                    even_Pf[i] = even_Pf[i - 1] + arr[i];
                    odd_Pf[i] = odd_Pf[i - 1];
                }
                else
                {
                    odd_Pf[i] = odd_Pf[i - 1] + arr[i];
                    even_Pf[i] = even_Pf[i - 1];
                }
            }
            evenPf = even_Pf;
            oddPf = odd_Pf;
        }

        public static int[] GetPrefixArray(int[] arr, int size)
        {
            int[] pfArr = new int[size];
            pfArr[0] = arr[0];
            for (int i = 1; i < size; i++)
                pfArr[i] = pfArr[i - 1] + arr[i];
            return pfArr;
        }

        public static List<int> GetPrefixLst(List<int> lst, int size)
        {
            List<int> pfLst = new List<int>();
            pfLst.Add(lst[0]);
            for (int i = 1; i < size; i++)
                pfLst[i] = pfLst[i - 1] + lst[i];
            return pfLst;
        }

        public static List<int> GetPrefixLst(int[] arr, int size)
        {
            List<int> pfLst = new List<int>();
            pfLst.Add(arr[0]);
            for (int i = 1; i < size; i++)
                pfLst.Add(pfLst[i - 1] + arr[i]);
            return pfLst;
        }

        public static int[] GetPrefixArray(List<int> arr, int size)
        {
            int[] pfArr = new int[size];
            pfArr[0] = arr[0];
            for (int i = 1; i < size; i++)
                pfArr[i] = pfArr[i - 1] + arr[i];
            return pfArr;
        }
    }
}
