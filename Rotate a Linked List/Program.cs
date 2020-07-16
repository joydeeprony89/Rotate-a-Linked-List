using System;

namespace Rotate_a_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);
            Console.WriteLine("no of position do you want to move ?");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before rotate");
            linkedList.Display();
            Console.WriteLine("After rotate");
            linkedList.Rotate(pos);
            linkedList.Display();
            Console.WriteLine("Hello World!");
        }
    }

    public class LinkedList
    {
        public Node head = null;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                next = null;
            }
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void Rotate(int pos)
        {
            if (pos == 0) return;
            int count = 1;
            Node current = head;
            while(count < pos)
            {
                current = current.next;
                count++;
            }
            Node breakPoint = current;
            while(current.next != null)
            {
                current = current.next;
            }

            current.next = head;
            head = breakPoint.next;
            breakPoint.next = null;
        }
    }
}
