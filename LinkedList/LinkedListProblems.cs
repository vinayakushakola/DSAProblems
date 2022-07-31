namespace LinkedList
{
    public class LinkedListProblems
    {
        public static Node DeleteMiddleNode(Node head)
        {
            #region Input
            //Node output = LinkedListProblems.DeleteMiddleNode(NodeHandler.GetEvenNoOfNodes());
            //Node output2 = LinkedListProblems.DeleteMiddleNode(NodeHandler.GetOddNoOfNodes());
            #endregion

            if (head == null || head.next == null)
            {
                head = null;
                return head;
            }
            int size = Size(head); // O(N)
            Node currNode = head;
            //for (int i = 0; i < size/2; i++) // O(N/2) == O(N)
            //{
            //    if (i == size/2 - 1)
            //    {
            //        currNode.next = currNode.next.next;
            //        break;
            //    }
            //    currNode = currNode.next;
            //}
            int cnt = 0;
            while (currNode != null)
            {
                if (cnt == size/2 - 1)
                {
                    currNode.next = currNode.next.next;
                }
                currNode = currNode.next;
                cnt++;
            }

            return head;
        }

        public static int MiddleElementOfNodes(Node head)
        {
            #region Approach 1
            //int ans = -1;
            //if (head == null) return ans;
            //else if (head.next == null) return head.data;
            //int size = 1;
            //Node temp = head;
            //while (temp.next != null)
            //{
            //    temp = temp.next;
            //    size++;
            //}
            //temp = head;
            //for (int i = 0; i < size / 2; i++)
            //{
            //    if (i == size / 2 - 1)
            //    {
            //        ans = temp.next.data;
            //        break;
            //    }
            //    temp = temp.next;
            //}
            //return ans;
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

        public static Node ReverseLinkedList(Node head)
        {
            if (head == null || head.next == null) return head;

            Node prev = null, curr = head;
            while (curr != null)
            {
                Node nxt = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nxt;
            }
            head = prev;
            return head;
        }

        public Node ReverseList(Node head, int k)
        {
            if (k == 0 || k == 1) return head;
            Node prev = null;
            Node curr = head;
            Node oldTail = head;
            Node mainHead = null;
            Node oldTailNext = null;
            int operation = 0;
            while (curr != null)
            {
                ++operation;
                Node next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
                if (operation % k == 0)
                {
                    if (mainHead == null)
                    {
                        mainHead = prev;
                        oldTailNext = curr;
                    }
                    else
                    {
                        oldTail.next = prev;
                        oldTail = oldTailNext;
                        oldTailNext = curr;

                    }
                    prev = curr;
                    if (curr == null)
                    {
                        oldTail.next = null;
                        break;
                    }
                    curr = curr.next;
                    operation = 1;
                }
            }
            return mainHead;
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
