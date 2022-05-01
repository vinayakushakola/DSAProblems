using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class MoreArrayProblems
    {
        // Given a Binary string atmost replace one zero with 1. Find the max consecutive ones
        public static int MaxConsecutiveOne(string str)
        {
            #region Input 
            //string str = "11010110";
            //int output = MoreArrayProblems.MaxConsecutiveOne(str);
            //Console.WriteLine("Max consecutive ones {0}", output);
            #endregion 
            // TC - O(N)
            int ans = 0, size = str.Length;
            for (int i = 0; i < size; i++)
            {
                if (str[i] == '0')
                {
                    int l = 0, r = 0;
                    for (int j = i-1; j >= 0; j--)
                    {
                        if (str[j] == '1') l++;
                        else break;
                    }
                    for (int j = i + 1; j < size; j++)
                    {
                        if (str[j] == '1') r++;
                        else break;
                    }
                    ans = Math.Max(ans, l + r + 1);
                }
            }
            return ans == 0 ? size : ans;
        }

        // Given a binary string swap 1 with any existing 1. Find the max consecutive ones
        public static int MaxConsecutiveOneSwap(string S)
        {
            int size = S.Length;
            int ans = 0, len = 0, one_count = 0;
            for (int i = 0; i<size; i++)
                if (S[i] == '1') one_count++;
            for (int i = 0; i<size; i++)
            {
                if (S[i] == '0')
                {
                    int l = 0, r = 0;
                    for (int j = i-1; j>=0; j--)
                    {
                        if (S[j] == '1') l++;
                        else break;
                    }
                    for (int j = i+1; j<size; j++)
                    {
                        if (S[j] == '1') r++;
                        else break;
                    }
                    if (l + r < one_count)
                        len = l + r + 1;
                    else
                        len = l + r;
                    ans = Math.Max(ans, len);
                }
            }
            return ans == 0 ? size : ans;
        }

        // Find the count of no of triplets i < j < k and A[i] < A[j] < A[k]
        public static int TripletsCount(int[] A)
        {
            int size = A.Length;
            int count = 0;
            #region Brute Force TC - O(N^3)
            //for (int i = 0; i < size - 2; i++)
            //{
            //    for (int j = i+1; j < size - 1; j++)
            //    {
            //        for (int k = j+1; k<size; k++)
            //        {
            //            if (A[i] < A[j] && A[j] < A[k])
            //                count++;  
            //        }
            //    }
            //}
            #endregion

            #region Optimized approach
            for (int i = 0; i<size; i++)
            {
                int l = 0, r = 0;
                for (int j = i - 1; j>=0; j--) 
                {
                    if (A[j] < A[i]) l++;
                }
                for (int j = i+1; j < size; j++)
                {
                    if (A[j] > A[i]) r++;
                }
                count = count + (l * r);
            }
            #endregion

            return count;
        }
    }
}
