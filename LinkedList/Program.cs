namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Problems");

            Node output = LinkedListProblems.ReverseLinkedList(NodeHandler.GetEvenNoOfNodes());
            //Node output2 = LinkedListProblems.DeleteMiddleNode(NodeHandler.GetOddNoOfNodes());

        }
    }
}