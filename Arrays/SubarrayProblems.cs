using System;

namespace Arrays
{
    class SubarrayProblems
    {
        // Print all subarrays sum
        public static void PrintSubarraySum(int[] A)
        {
            int size = A.Length;
            int subarrayCnt = 0;
            for (int i = 0; i<size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    int sum = 0;
                    for (int k = i; k<=j; k++)
                    {
                        sum += A[k];
                    }
                    subarrayCnt++;
                    Console.WriteLine(subarrayCnt +". "+ sum);
                }
            }
        } 

        // Print Max Subarray Sum
        public static void MaxSubarraySum(int[] A)
        {
            // Carry Forward Technique TC - O(N^2) | SC - O(1)
            int size = A.Length;
            int max_sum = int.MinValue;
            for (int i = 0; i<size; i++)
            {
                int sum = 0;
                for (int j=i; j<size; j++)
                {
                    sum += A[j];
                    max_sum = Math.Max(max_sum, sum);
                }
            }
            Console.WriteLine("Max Subarray Sum = " + max_sum);
        }

        // Print Max Subaaray Sum with Length K
        public static void MaxSubarraySumWithK(int[] A, int k)
        {
            #region Brute Force TC - O(N^2) SC - O(1)
            //int max_sum = int.MinValue;
            //int size = A.Length;
            //for(int i=0; i<=size-k; i++)
            //{
            //    int x = i + k - 1;
            //    int sum = 0;
            //    for (int j = i; j <= x; j++)
            //    {
            //        sum += A[j];
            //    }
            //    max_sum = Math.Max(max_sum, sum);
            //}
            //Console.WriteLine("Max Sum = " + max_sum);
            #endregion
            #region Sliding Window Technique TC - O(N) | SC - O(1)
            int size = A.Length;
            int max_sum = 0, sum = 0;
            for (int  i = 0; i<k; i++)
            {
                sum += A[i];
            }
            max_sum = sum;
            for (int i = 1; i <size; i++)
            {
                sum -= A[i - k];
                sum += A[i];
                max_sum = Math.Max(max_sum, sum);
            }
            #endregion
        }

        // Sum of all subarray sum - Google|Bloomberg|Amazon
        public static void SumOfAllSubarrays(int[] A)
        {
            int sum = 0, size = A.Length;
            for(int i = 0; i<size; i++)
            {
                int appears = (i + 1) * (size - i);
                int contribution = A[i] * appears;
                sum += contribution;
            }
            Console.WriteLine("Sum of all Subarrays = "+sum);
        }
    }
}
