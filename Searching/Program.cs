namespace Searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================== Searching ===================");
            #region Input
            int[] R1 = { 2, 4, 7, 10 };
            int[] R2 = { 12, 24, 27, 30 };
            int[] R3 = { 35, 38, 44, 49 };
            int[] R4 = { 52, 54, 67, 90 };
            int[][] mat = { R1, R2, R3, R4 };
            int k = 44;
            Console.WriteLine("Is {0} present ? \nAns: {1}", k, SearchingProblems.SearchOfK(mat, k) == 1 ? "Yes":"No");
            #endregion
        }
    }
}