using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.append(10);
            list.append(20);
            list.append(30);
            list.append(40);
            list.append(50);
            list.append(60);

            list.Print();

            Console.WriteLine("Prepend 5");

            list.prepend(5);

            list.Print();

            Console.WriteLine("Delete 40");

            list.deleteWithValue(40);

            list.Print();

            Console.ReadKey();
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
        public void append(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                current = head;
                return;
            }

            Node newNode = new Node(data);
            current.next = newNode;
            current = newNode;
        }

        public void prepend(int value)
        {
            Node newhead = new Node(value);
            newhead.next = head;
            head = newhead;
        }

        public void deleteWithValue(int data)
        {
            if (head == null) return;

            if (head.data == data)
            {
                head = head.next;
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                if (current.next.data == data)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
        }

        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
                
            }
        }
    }
}
