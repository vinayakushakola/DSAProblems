namespace LinkedList
{
    public class LinkedListProblems
    {
        public static Node DeleteMiddleNode(Node head)
        {
            #region Input
            //Node output = LinkedListProblems.DeleteMiddleNode(null); // zero nodes
            //Node output1 = LinkedListProblems.DeleteMiddleNode(new Node(1)); // only 1 Node
            //Node output2 = LinkedListProblems.DeleteMiddleNode(NodeHandler.GetTwoNodes()); // 2 Nodes
            //Node output3 = LinkedListProblems.DeleteMiddleNode(NodeHandler.GetEvenNoOfNodes());
            //Node output4 = LinkedListProblems.DeleteMiddleNode(NodeHandler.GetOddNoOfNodes());
            #endregion
            if (head == null || head.next == null)
            {
                head = null;
                return head;
            }
            int k = Size(head) / 2;
            Node temp = head;
            for (int i = 1; i < k; i++)
            {
                temp = temp.next;
            }
            temp.next = temp.next.next;
            return head;
        }

        public static Node KReverseLL(Node head, int k)
        {
            #region Input
            /*
                Node input = NodeHandler.GetEvenNoOfNodes();
                NodeHandler.PrintNodes(input);
                Node output = LinkedListProblems.KReverseLL(input, 3);
                NodeHandler.PrintNodes(output);
             */
            #endregion
            Node prev = null;
            Node curr = head;
            Node nxt = null;
            int cnt = 0;
            while (curr != null && cnt < k)
            {
                nxt = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nxt;
                cnt++;
            }
            if (nxt != null)
                head.next = KReverseLL(nxt, k);
            return prev;
        }

        public static int MiddleElementOfNodes(Node head)
        {
            #region
            //Node input = NodeHandler.GetEvenNoOfNodes();
            //NodeHandler.PrintNodes(input);
            //int output = LinkedListProblems.MiddleElementOfNodes(input);
            //Console.WriteLine("Middle Element of the List = {0}", output);
            #endregion

            #region Approach 1
            //if (head == null) return -1;
            //else if (head.next == null) return head.data;
            //int k = Size(head) / 2;
            //for (int i = 1; i <= k; i++)
            //{
            //    head = head.next;
            //}
            //return head.data;
            #endregion

            #region Approach 2
            Node slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow.data;
            #endregion
        }

        public static Node ReverseList(Node head)
        {
            Node prev = null;
            Node curr = head;
            while (curr != null)
            {
                Node nxt = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nxt;
            }
            return prev;
        }

        public static int Size(Node head) 
        {
            // TC - O(N) | SC - O(1)
            int count = 0;
            Node currNode = head;
            while (currNode != null)
            {
                count++;
                currNode = currNode.next;
            }
            return count;
        }
    }
}
