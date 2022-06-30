using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class AdvanceArrayProblems
    {
        // Rain Water Trapped
        public static int WaterTrap(List<int> A)
        {
            #region Input 
            //AdvanceArrayProblems.WaterTrap(new List<int> { 4, 2, 5, 7, 4, 2, 3, 6, 8, 2, 3 });
            #endregion

            #region Brute Force TLE
            //int ans = 0, size = A.Count;
            //for (int i = 0; i < size; i++)
            //{
            //    int left_max = 0, right_max = 0;
            //    if (i > 0)
            //    {
            //        for (int j = i - 1; j >= 0; j--)
            //        {
            //            left_max = Math.Max(left_max, A[j]);
            //        }
            //    }
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        right_max = Math.Max(right_max, A[j]);
            //    }
            //    int val = Math.Min(left_max, right_max) - A[i];
            //    if (val < 0) val = 0;
            //    ans += val;
            //}
            //return ans;
            #endregion

            int size = A.Count, water_trapped = 0;
            int[] leftMax = new int[size];
            leftMax[0] = 0;
            for (int i = 1; i < size; i++)
            {
                leftMax[i] = Math.Max(A[i - 1], leftMax[i - 1]);
            }
            int[] rightMax = new int[size];
            rightMax[size - 1] = 0;
            for (int i = size - 2; i >= 0; i--)
            {
                rightMax[i] = Math.Max(A[i + 1], rightMax[i + 1]);
            }
            for (int i = 0; i < size; i++)
            {
                int val = Math.Min(leftMax[i], rightMax[i]) - A[i];
                if (val > 0)
                    water_trapped += val;
            }
            return water_trapped;

            //int size = A.Count;
            //int left = 0; int right = size - 1;
            //int ans = 0;
            //int maxLeft = 0, maxRight = 0;
            //while (left <= right)
            //{
            //    // When height of left side is lower, calculate height of water trapped in left bin else calculate for right bin
            //    if (A[left] <= A[right])
            //    {
            //        if (A[left] >= maxLeft) maxLeft = A[left];
            //        else ans += maxLeft - A[left];
            //        left++;
            //    }
            //    else
            //    {
            //        if (A[right] >= maxRight) maxRight = A[right];
            //        else ans += maxRight - A[right];
            //        right--;
            //    }
            //}
            //return ans;
        }

        // Beggars Outside Temple
        public static List<int> BeggarsOutsideTemple(int A, List<List<int>> B)
        {
            #region Input 
            //List<int> R1 = new List<int>() { 1, 2, 10 };
            //List<int> R2 = new List<int>() { 2, 3, 20 };
            //List<int> R3 = new List<int>() { 2, 5, 25 };
            //List<List<int>> mat = new List<List<int>>();
            //mat.Add(R1);
            //mat.Add(R2);
            //mat.Add(R3);
            //AdvanceArrayProblems.BeggarsOutsideTemple(mat.Count, mat);
            #endregion

            List<int> lst = new List<int>();
            for (int i = 0; i < A; i++)
            {
                int start = B[i][0];
                int end = B[i][1];
                int money = B[i][2];

                lst[start] = money;
                if (end < A)
                    lst[end + 1] = -1 * money;
            }
            List<int> PfLst = new List<int>();
            PfLst.Add(lst[0]);
            for (int i = 1; i < A; i++)
            {
                PfLst.Add(PfLst[i - 1] - lst[i]);
            }
            return PfLst;
        }

        // Add Plus one
        public static List<int> AddPlusOne(List<int> A)
        {
            // take dynamic list as size of the final array can vary based on input
            List<int> list = new List<int>();
            int carry = 1;

            // perform addition from last
            for (int i = A.Count - 1; i >= 0; i--)
            {

                int sum = A[i] + carry;
                int digit = sum % 10;
                carry = sum / 10;
                list.Add(digit);
            }
            // add extra carry if any
            if (carry == 1)
            {
                list.Add(carry);
            }

            // list will contain the answer in reverse direction
            // remove 0s from last [leading 0's in answer]
            int ind = list.Count - 1;
            while (list[ind] == 0)
            {
                list.Remove(ind);
                ind--;
            }

            // build answer array from list
            List<int> result = new List<int>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                result.Add(list[i]);
            }
            return result;
        }

        public List<int> maxset(List<int> A)
        {
            List<int> outputLst = new List<int>();
            int size = A.Count;

            long curr_sum = 0;
            long max_sum = 0;
            int idx = 0;
            int sIdx = 0;
            int eIdx = 0;
            // 1, 2, 5, -7, 2, 3
            for (int i = 0; i < size; i++) // 0      | 1     | 2     | 3     | 4     | 5
            {
                if ((curr_sum + A[i]) > max_sum) // 0+1>0 | 1+2>1 | 3+5>3 | 8-7>8 | 0+2>8 | 2+3 > 8
                {
                    sIdx = idx;        // 0       | 0     | 0     | False |
                    eIdx = i + 1;      // 1       | 2     | 3     |       |
                    max_sum = curr_sum + A[i]; // 0+1=1   | 1+2=3 | 3+5=8 |    |
                    curr_sum = curr_sum + A[i];  // 0+1=1   | 1+2=3 | 3+5=8 |       |
                }
                else if ((curr_sum + A[i]) == max_sum && (eIdx - sIdx) < (i - idx + 1)) // 8-7 == 8 && (3-0) < (3-0+1)
                {                                                                  // 0+2 == 8 && (3-0) < (4-4+1)
                                                                                   // 2+3 == 8 && (3-0) < (5-4+1)
                    sIdx = idx;
                    eIdx = i + 1;
                }
                else if (A[i] < 0) // -7<0 | 2 < 0 | 3 < 0
                {
                    curr_sum = 0;       // 0
                    idx = i + 1;   // 3+1=4 |
                }
                else
                {
                    curr_sum += A[i]; // 2 | 2+3 = 5
                }
            }
            for (int i = sIdx; i < eIdx; i++) // sIdx = 0 & eIdx = 3
            {
                outputLst.Add(A[i]);
            }
            return outputLst;
        }

        public static int MaxMod(List<int> A)
        {
            int size = A.Count;
            if (A.Count <= 1) return 0;
            int max = A[0];
            int secMax = int.MinValue;
            for (int i = 1; i < size; i++)
            {
                if (max < A[i])
                {
                    secMax = max;
                    max = A[i];
                }
                else if (max != A[i] && secMax < A[i])
                    secMax = A[i];
            }
            int ans = secMax % max;
            return ans < 0 ? 0 : ans;
        }
    }
}
