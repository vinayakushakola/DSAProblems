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
        */
        static void Main(string[] args)
        {
            #region Input 
            List<int> A = new List<int>{ 1, 2, 3, 9};
            List<int> B = new List<int>{ 4, 5, 6, 9};
            List<int> C = new List<int>{ 7, 8, 9, 10};
            List<List<int>> mat = new List<List<int>>();
            mat.Add(A);
            mat.Add(B);
            mat.Add(C);
            TwoDMatrices.PrintDiagonalsFromRToL(mat);
            #endregion        
        }
    }
}
