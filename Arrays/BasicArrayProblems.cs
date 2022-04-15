using System;

namespace Arrays
{
    public class BasicArrayProblems
    {
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
    }
}
