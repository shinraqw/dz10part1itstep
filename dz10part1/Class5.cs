using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz10part1
{
    public class Task5<T>
    {
        private class Node
        {
            public T Value { get; }
            public Node Previous { get; set; }
            public Node Next { get; set; }

            public Node(T value)
            {
                Value = value;
                Previous = null;
                Next = null;
            }
        }

        private Node head;
        private Node tail;

        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            Node newNode = new Node(item);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }

            Count++;
        }

        public void AddLast(T item)
        {
            Node newNode = new Node(item);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Previous = tail;
                tail.Next = newNode;
                tail = newNode;
            }

            Count++;
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
                Environment.Exit(0);
            }

            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.Next;
                head.Previous = null;
            }

            Count--;
        }

        public void RemoveLast()
        {
            if (tail == null)
            {
                Console.WriteLine(" list is empty");
                Environment.Exit(0);
            }

            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.Previous;
                tail.Next = null;
            }

            Count--;
        }

        public void PrintForward()
        {
            Node curr = head;

            while (curr != null)
            {
                Console.WriteLine(curr.Value);
                curr = curr.Next;
            }
        }

        public void PrintBackward()
        {
            Node curr = tail;

            while (curr != null)
            {
                Console.WriteLine(curr.Value);
                curr = curr.Previous;
            }
        }
    }
}
