using System;
using System.Collections.Generic;

namespace Arrays
{
    class TwoDMatrices
    {
        public static void PrintRowSumOfMatrix(List<List<int>> mat)
        {
            #region Input 
            //List<int> A = new List<int> { 1, 2, 3 };
            //List<int> B = new List<int> { 4, 5, 6 };
            //List<int> C = new List<int> { 7, 8, 9 };
            //List<List<int>> mat = new List<List<int>>();
            //mat.Add(A);
            //mat.Add(B);
            //mat.Add(C);
            //TwoDMatrices.PrintRowSumOfMatrix(mat);
            #endregion
            int row = mat.Count;
            int col = mat[0].Count;
            for (int i = 0; i < row; i++)
            {
                int row_sum = 0;
                for (int j = 0; j < col; j++)
                {
                    row_sum += mat[i][j];
                }
                Console.WriteLine("{0} - row sum = {1}", i, row_sum);
            }
        }

        public static void PrintColSumOfMatrix(List<List<int>> mat)
        {
            #region Input 
            //List<int> A = new List<int> { 1, 2, 3 };
            //List<int> B = new List<int> { 4, 5, 6 };
            //List<int> C = new List<int> { 7, 8, 9 };
            //List<List<int>> mat = new List<List<int>>();
            //mat.Add(A);
            //mat.Add(B);
            //mat.Add(C);
            //TwoDMatrices.PrintColSumOfMatrix(mat);
            #endregion
            int row = mat.Count;
            int col = mat[0].Count;
            for (int i = 0; i < row; i++)
            {
                int row_sum = 0;
                for (int j = 0; j < col; j++)
                {
                    row_sum += mat[j][i];
                }
                Console.WriteLine("{0} - column sum = {1}", i, row_sum);
            }
        }

        // Given a square matrix print diagonals
        public static void PrintDiagonalsOfMat(List<List<int>> mat)
        {
            int N = mat.Count;
            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        if (i == j) Console.WriteLine(mat[i][j]);
            //    }
            //}
            Console.WriteLine("1st Diagonal");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(mat[i][i]);
            }
            int x = 0, y = N - 1;
            Console.WriteLine("2nd Diagonal");

            while (x < N && y >= 0)
            {
                Console.WriteLine(mat[x][y]);
                x++; y--;
            }
        }

        // Given a rectangular matrix, print all the diagonals going from right to left
        public static void PrintDiagonalsFromRToL(List<List<int>> mat)
        {
            int row = mat.Count;
            int col = mat[0].Count;
            for (int i = 0; i < col; i++)
            {
                int x = 0, y = i;
                while (x < row && y >= 0)
                {
                    Console.Write(mat[x][y]);
                    x++; y--;
                }
                Console.WriteLine();
            }
            for (int i = 1; i < row; i++)
            {
                int x = i, y = col - 1;
                while (x < row && y >= 0)
                {
                    Console.Write(mat[x][y]);
                    x++; y--;
                }
                Console.WriteLine();
            }
        }

        // Given a square matrix perfrom of transpose of matrix
        public static void TransposeMatrix(List<List<int>> mat)
        {
            #region Input 
            //List<int> A = new List<int> { 1, 2, 3 };
            //List<int> B = new List<int> { 4, 5, 6 };
            //List<int> C = new List<int> { 7, 8, 9 };
            //List<List<int>> mat = new List<List<int>>();
            //mat.Add(A);
            //mat.Add(B);
            //mat.Add(C);
            //Console.WriteLine("Before");
            //foreach (var it in mat)
            //{
            //    foreach (int ele in it)
            //    {
            //        Console.Write(ele + " ");
            //    }
            //    Console.WriteLine();
            //}
            //TwoDMatrices.TransposeMatrix(mat);
            //Console.WriteLine("After");
            //foreach (var it in mat)
            //{
            //    foreach (int ele in it)
            //    {
            //        Console.Write(ele + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion 
            int size = mat.Count;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    int temp = mat[i][j];
                    mat[i][j] = mat[j][i];
                    mat[j][i] = temp;
                }
            }
        }

        // Given a square matrix rotate matrix by 90 deg
        public static void RotateMatrixBy90Deg(List<List<int>> mat)
        {
            TransposeMatrix(mat);
            foreach (List<int> lst in mat)
            {
                BasicArrayProblems.ReverseArray(lst);
            }
        }

        // Given a square matrix print in a spiral form
        public static void PrintSpiralMatrix(List<List<int>> mat)
        {
            int size = mat.Count;
            int i = 0, j = 0;
            while (size > 1)
            {
                for (int x = 1; x < size; x++)
                {
                    Console.Write(mat[i][j] + " ");
                    j++;
                }
                Console.WriteLine();
                for (int x = 1; x < size; x++)
                {
                    Console.Write(mat[i][j] + " ");
                    i++;
                }
                Console.WriteLine();
                for (int x = 1; x < size; x++)
                {
                    Console.Write(mat[i][j] + " ");
                    j--;
                }
                Console.WriteLine();
                for (int x = 1; x < size; x++)
                {
                    Console.Write(mat[i][j] + " ");
                    i--;
                }
                Console.WriteLine();
                size = size - 2;
                i++; j++;
            }
            if (size == 1)
                Console.WriteLine(mat[i][j]);
        }

        // ====================== Advanced Problems ==================
        // Beggars Outside Temple
        public static List<int> BeggarsPotCount(int A, List<List<int>> B)
        {
            #region Input 
            //int A = 5;
            //List<List<int>> mat = new List<List<int>>()
            //{
            //    new List<int>() { 1, 2, 10 },
            //    new List<int>() { 2, 3, 20 },
            //    new List<int>() { 2, 5, 25 }
            //};
            //List<int> output = TwoDMatrices.BeggarsPotCount(A, mat);
            //foreach (int ele in output)
            //    Console.Write(ele + " ");
            #endregion        

            int[] beggarsPot = new int[A];
            int size = B.Count;

            for (int i = 0; i < size; i++)
            {
                int start = B[i][0] - 1;
                int end = B[i][1];
                int money = B[i][2];

                beggarsPot[start] += money;
                if (end < A)
                    beggarsPot[end] += (-1 * money);
            }
            List<int> pfLst = PrefixArrayProblems.GetPrefixLst(beggarsPot, A);
            return pfLst;
        }
    }
}
