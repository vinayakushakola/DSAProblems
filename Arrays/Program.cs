using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        /* Arrays
           0. Two Pointers
           1. Prefix Sum (Range Sum Queries)
           2. Carry Forward Technique
           3. Sliding Window Technique (Length K)
           4. Contribution Technique
           5. Kadane's Algorithm 
        */
        static void Main(string[] args)
        {
            #region Input 
            int[] A = { 4, 1, 2, 6, 9, 7 };
            SubarrayProblems.MaxSubarraySum(A);
            #endregion        
        }
    }
}
