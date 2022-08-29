namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Problems");

            Node input = NodeHandler.GetEvenNoOfNodes();
            NodeHandler.PrintNodes(input);
            int output = LinkedListProblems.MiddleElementOfNodes(input);
            Console.WriteLine("Middle Element of the List = {0}", output);
        }
    }
}