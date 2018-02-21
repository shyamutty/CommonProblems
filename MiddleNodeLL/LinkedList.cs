using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleNodeLL
{
    public class Node
    {
        public Node Next;
        public object Value;
    }

    public class LinkedList
    {
        private Node head; // Head node
        private Node current; // Latest node
        public int count;

        public LinkedList()
        {
            head = new Node();
            current = head; // Initially current = head
        }

        public void AddAtLast(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            current.Next = newNode; // current.next is now new node
            current = newNode; //  current is now new node
            count++;
        }

        public void AddAtStart(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            newNode.Next = head.Next; //new node will have reference of head's next reference
            head.Next = newNode; // and now head will refer to new node
            count++;
        }

        public void RemoveFromStart()
        {
            if (count > 0)
            {
                head.Next = head.Next.Next;
                count--;
            }
            else
            {
                Console.WriteLine("No element exist in this linked list.");
            }
        }

    }
}
