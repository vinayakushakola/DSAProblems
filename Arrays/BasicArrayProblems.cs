using System;
using System.Collections.Generic;

namespace Arrays
{
    public class BasicArrayProblems
    {
        #region Number Probelms
        // To check a number is prime number or not
        // A number is said to be a prime number if it is divisible by 1 & itself
        public static bool IsPrimeNumber(int N)
        {
            #region Input 
            //int num = 99;
            //if (BasicArrayProblems.IsPrimeNumber(num))
            //    Console.WriteLine(num + " is a Prime No");
            //else
            //    Console.WriteLine(num + " is a not a Prime No");
            #endregion

            #region Brute Force: TC - O(n) | SC - O(1)
            //int count = 0;
            //for (int i = 1; i <= N; i++)
            //{
            //    if (N % i == 0)
            //        count++;
            //}
            //if (count == 2) return true;
            //return false;
            #endregion

            #region TC - O(n/2) | SC - O(1)
            //int count = 0;
            //for (int i = 1; i <= N/2; i++)
            //{
            //    if (N % i == 0)
            //        count++;
            //}
            //if (count == 1) return true;
            //return false;
            #endregion

            #region Optimized Approach: TC - O(sqrt(n)) | SC - O(1)
            for (int i = 2; i * i <= N; i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
            #endregion
        }

        // To check a number is perfect number or not
        // A number is said to be a perfect number if the number is equal to its sum of proper divisors
        public static bool IsPerfectNo(int N)
        {
            #region Input 
            //int num = 496;
            //if (BasicArrayProblems.IsPerfectNo(num))
            //    Console.WriteLine(num + " is a Perfect No");
            //else
            //    Console.WriteLine(num + " is a not a Perfect No");
            #endregion

            #region Brute Force: TC - O(n) | SC - O(1)
            //int sum = 0;
            //for (int i = 1; i < N; i++)
            //{
            //    if (N % i == 0)
            //        sum += i;
            //}
            //return sum == N;
            #endregion

            #region TC - O(n/2) | SC - O(1)
            //int sum = 0;
            //for (int i = 1; i <= N / 2; i++)
            //{
            //    if (N % i == 0)
            //        sum += i;
            //}
            //return sum == N;
            #endregion

            #region Optimized Approach: TC - O() | SC - O(1)
            int sum = 1;
            for (int i = 2; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    if (i * i == N)
                        sum += i; 
                    else
                        sum += i + N / i;
                }
            }
            return sum == N;
            #endregion
        }

        // Square root of a number 
        // Return square root of the number if it is perfect square otherwise return -1
        public static int Sqrt(int N)
        {
            #region Input 
            //int num = 1065024;
            //int res = BasicArrayProblems.Sqrt(num);
            //if (res > 0)
            //    Console.WriteLine("Square root of {0} is {1}", num, res);
            #endregion

            #region Brute Force TC - O(N/2) | SC - O(1)
            for (int i = 1; i < N / 2; i++)
            {
                if (i * i == N)
                    return i;
            }
            return -1;
            #endregion

            #region Binary Search Approach TC - O(logn) | SC - O(1) || Logic not  working
            //int l = 1, r = N;
            //while (l <= r)
            //{
            //    int mid = (l + r) / 2;
            //    long sqRt = mid * mid;
            //    if (sqRt == N)
            //        return mid;
            //    else if (sqRt > N)
            //        r = mid - 1;
            //    else 
            //        l = mid + 1;
            //}
            //return -1;
            #endregion
        }

        // Armstrong Number
        // If sum of cubes of each digit of the number is equal to the number itself, then the number
        // is called an Armstrong number.
        public static bool ArmstrongNumber(int N)
        {
            #region Input 
            //int num = 153;
            //if (BasicArrayProblems.ArmstrongNumber(num))
            //    Console.WriteLine(num + " is an Armstrong No");
            //else
            //    Console.WriteLine(num + " is a not an Armstrong No");
            #endregion        

            #region Brute Force TC - O() | SC - O(1)
            int sum = 0, temp = N;
            while (N > 0)
            {
                int remainder = N % 10;
                sum += (int)Math.Pow(remainder, 3);
                N = N / 10;
            }
            return sum == temp;
            #endregion
        }

        #endregion

        // Reverse an Array
        public static void ReverseArray(int[] arr)
        {
            #region Input 
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(" Before");
            //foreach (int ele in arr)
            //{
            //    Console.Write(" " + ele);
            //}
            //Console.WriteLine();
            //BasicArrayProblems.ReverseArray(arr);
            //Console.WriteLine(" After");
            //foreach (int ele in arr)
            //{
            //    Console.Write(" " + ele);
            //}
            #endregion
            // TC - O(N/2) | SC - O(1)
            int i = 0, j = arr.Length-1;
            while (i < j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;j--;
            }
        }

        // Reverse an Array
        public static void ReverseArray(int[] arr, int i, int j)
        {
            #region Input 
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(" Before");
            //foreach (int ele in arr)
            //{
            //    Console.Write(" " + ele);
            //}
            //Console.WriteLine();
            //BasicArrayProblems.ReverseArray(arr, 0, arr.Length - 1);
            //Console.WriteLine(" After");
            //foreach (int ele in arr)
            //{
            //    Console.Write(" " + ele);
            //}
            #endregion 
            // TC - O(N/2) | SC - O(1)
            while (i < j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;j--;
            }
        }

        // Rotate an Array by k rotation from right side which is in clockwise direction
        public static void RotateAnArrayByk(int[] arr, int k)
        {
            #region Input 
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(" Before");
            //foreach (int ele in arr)
            //{
            //    Console.Write(" " + ele);
            //}
            //Console.WriteLine();
            //BasicArrayProblems.RotateAnArrayByk(arr, 2);
            //Console.WriteLine(" After");
            //foreach (int ele in arr)
            //{
            //    Console.Write(" " + ele);
            //}
            #endregion
            int size = arr.Length - 1;
            k = k % size;
            ReverseArray(arr);
            ReverseArray(arr, 0, k - 1);
            ReverseArray(arr, k, size);
        }

        // Rotate an Array by k rotation from left side which is in anti-clockwise direction
        public static void RotateAnArrayByk(int k, int[] arr)
        {
            #region Input 
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(" Before");
            //foreach (int ele in arr)
            //{
            //    Console.Write(" " + ele);
            //}
            //Console.WriteLine();
            //BasicArrayProblems.RotateAnArrayByk(2, arr);
            //Console.WriteLine(" After");
            //foreach (int ele in arr)
            //{
            //    Console.Write(" " + ele);
            //}
            #endregion
            // 1 2 3 4 5
            // 5 4 3 2 1 
            // 3 4 5 1 2
            int size = arr.Length - 1;
            k = k % size;
            ReverseArray(arr);
            ReverseArray(arr, 0, size - k);
            ReverseArray(arr, size - k + 1, size);
        }

        // Good Pair
        // A[i] + A[j] == B return true
        public static bool IsGoodPair(int[] arr, int B)
        {
            int size = arr.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = i+1; j<size; j++)
                {
                    if (arr[i] + arr[j] == B)
                        return true;
                }
            }
            return false;
        }

        // Max and Min of an Array
        public static int[] MaxMin(int[] arr)
        {
            #region Input 
            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(" Before");
            //foreach (int ele in arr)
            //{
            //    Console.Write(" " + ele);
            //}
            //Console.WriteLine();
            //int[] res = BasicArrayProblems.MaxMin(arr);
            //Console.WriteLine(" After");
            //foreach (int ele in res)
            //{
            //    Console.Write(" " + ele);
            //}
            #endregion 
            // TC - O(N) | SC - O(1)
            int size = arr.Length;
            int min_Ele = arr[0];
            int max_Ele = arr[0];
            for (int i = 1; i<size; i++)
            {
                if (min_Ele > arr[i])
                    min_Ele = arr[i];
                else if (max_Ele < arr[i])
                    max_Ele = arr[i];
            }
            return new int[2]{ min_Ele, max_Ele};
        }

        // Search Element in an Array
        public static bool SearchElement(int[] arr, int searchEle)
        {
            #region Input 
            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //int searhEle = 19;
            //if (BasicArrayProblems.SearchElement(arr, searhEle))
            //    Console.Write(searhEle + " is found in the array");
            //else
            //    Console.Write(searhEle + " is not found in the array");
            #endregion  

            int size = arr.Length;
            for (int i = 0; i<size; i++)
            {
                if (arr[i] == searchEle) return true;
            }
            return false;
        }

        // Second Largest element in an Array
        public static int SecondLargestElement(int[] arr)
        {
            #region Input 
            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //int res = BasicArrayProblems.SecondLargestElement(arr);
            //Console.WriteLine(res + " is the second largest element in the array");
            #endregion  
            int size = arr.Length;
            int max_Ele = arr[0];
            int sec_Max_Ele = int.MinValue;
            for (int i = 1; i<size; i++)
            {
                if (max_Ele < arr[i])
                {
                    sec_Max_Ele = max_Ele;
                    max_Ele = arr[i];
                }
                else if (sec_Max_Ele < arr[i])
                    sec_Max_Ele = arr[i];
            }
            return sec_Max_Ele;
        }

        // MINIMUM PICKS
        // Return Max of Even Element - Min of Odd Elemnt
        public static int MinimumPicks(int[] arr)
        {
            #region Input 
            //int[] arr = { 0, 2, 9 };
            //int res = BasicArrayProblems.MinimumPicks(arr);
            //Console.WriteLine("Ouput: " + res);
            #endregion 
            int size = arr.Length;
            int max_Even = int.MinValue, min_Odd = int.MaxValue;
            for (int i =0; i<size; i++)
            {
                if (arr[i] % 2 == 0 && max_Even < arr[i])
                    max_Even = arr[i];
                else if (arr[i] % 2 != 0 && min_Odd > arr[i])
                    min_Odd = arr[i];
            }
            return max_Even - min_Odd;
        }
    }
}
