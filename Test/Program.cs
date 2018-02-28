using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //fib(5);

            Console.ReadKey();
        }

        static void fib(int m)
        {
            int n = 0;
            if (m == 0) return;
            n++;
            fib(-m);
            Console.WriteLine(m.ToString(), n.ToString());
        }
    }


    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }
    }

    public class LinkedList
    {
        Node head;
        Node current;

        public void Append(int data)
        {
            if(head == null)
            {
                head = new Node(data);
                current = head;
                return;
            }
            Node newNode = new Node(data);
            current.next = newNode;
            current = newNode;
        }

        public void Prepend(int data)
        {
            Node newHead = new Node(data);
            newHead.next = head;
            head = newHead;
        }

        public void DeleteWithValue(int data)
        {
            if (head == null) return;

            if(head.data == data)
            {
                head = head.next;
                return;
            }

            Node current = head;
            while(current.next !=null)
            {
                if(current.next.data == data)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
        }
    }
}
