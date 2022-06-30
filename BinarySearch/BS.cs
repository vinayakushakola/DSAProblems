namespace BinarySearch
{
    internal class BS
    {
        public static int SearchInsertPos(List<int> lst, int searchItem)
        {
            int start = 0, end = lst.Count - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (lst[mid] == searchItem)
                    return mid;
                else if (lst[mid] < searchItem)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return end + 1; // returns the index position where we can insert the new element
        }

        public static int SearchMatrix(List<List<int>> lst, int searchItem) 
        {
            int row = 0, col = lst[0].Count - 1;
            while(row < lst.Count && col >= 0)
            {
                if (lst[row][col] == searchItem)
                    return 1;
                else if (lst[row][col] < searchItem)
                    row++;
                else
                    col++;
            }
            return 0;
        }
    }
}
