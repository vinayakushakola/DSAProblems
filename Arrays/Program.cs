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
            int A = 5;
            List<List<int>> mat = new List<List<int>>()
            {
                new List<int>() { 1, 2, 10 },
                new List<int>() { 2, 3, 20 },
                new List<int>() { 2, 5, 25 }
            };
            List<int> output = TwoDMatrices.BeggarsPotCount(A, mat);
            foreach(int ele in output)
                Console.Write(ele + " ");
            #endregion        
        }
    }
}
