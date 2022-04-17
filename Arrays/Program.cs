using System;


namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Input 
            int[] arr = { 0, 2, 9 };
            int res = BasicArrayProblems.MinimumPicks(arr);
            Console.WriteLine("Ouput: " + res);
            #endregion        
        }
    }
}
