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
            int size = A.Count, ans = 0;
            List<int> leftMax = new List<int>();
            List<int> rightMax = new List<int>();
            leftMax.Add(A[0] > 0 ? A[0] : 0);
            rightMax.Add(A[size-1] > 0 ? A[size-1] : 0);
            for (int i = 1; i<size; i++)
            {
                leftMax.Add(Math.Max(A[i], leftMax[i - 1]));
            }
            for (int i = size-2; i >= 0; i--)
            {
                rightMax.Add(Math.Max(A[i], rightMax[i + 1]));
            }
            for (int i = 1; i < size - 1; i++)
            {
                int supp = Math.Min(leftMax[i - 1], rightMax[i + 1]);
                int water_trapped = supp - A[i];
                if (water_trapped > 0)
                    ans += water_trapped;        
            }
            return ans;

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
    }
}
