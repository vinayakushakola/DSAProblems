namespace Searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================== Searching ===================");
            #region Input
            int[,] mat = {  { 2, 4, 7, 10 },
                            { 12, 24, 37, 39 },
                            { 42, 44, 47, 49 },
                            { 52, 74, 87, 99 }  
                         };
            int k = 44;
            Console.WriteLine("Search of {0} at index {1}", k, SearchingProblems.SearchOfK(mat, k));
            #endregion
        }
    }
}