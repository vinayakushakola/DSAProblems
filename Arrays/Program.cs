using System;


namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Input 
            int num = 153;
            if (BasicArrayProblems.ArmstrongNumber(num))
                Console.WriteLine(num + " is an Armstrong No");
            else
                Console.WriteLine(num + " is a not an Armstrong No");
            #endregion        
        }
    }
}
