using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Input 
            List<int> arr = new List<int>{ 1,2,3,4,5 };
            var res = PrefixArrayProblems.ProductArray(arr);
            #endregion        
        }
    }
}
