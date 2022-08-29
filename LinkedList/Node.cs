namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    public class NodeHandler
    {
        public static void PrintNodes(Node node)
        {
            Node temp = node;
            while(temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
            Console.Write("NULL\n");
        }

        public static Node GetTwoNodes()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            node1.next = node2;
            return node1;
        }

        public static Node GetEvenNoOfNodes()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);
            Node node7 = new Node(7);
            Node node8 = new Node(8);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node5.next = node6;
            node6.next = node7;
            node7.next = node8;
            return node1;
        }

        public static Node GetOddNoOfNodes()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            return node1;
        }
    }
}
