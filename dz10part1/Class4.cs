using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz10part1
{
    public class Task4<T>
    {
        private class Node
        {
            public T Value { get; }
            public Node Next { get; set; }

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }

        private Node head;
        private Node tail;

        public int count { get; private set; }

        public Task4()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void AddFirst(T value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }

            count++;
        }

        public void AddLast(T value)
        {
            Node newNode = new Node(value);

            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }

            count++;
        }

        public void RemoveFirst()
        {
            if (head == null)
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
                head = head.Next;
            }

            count--;
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
                Node currentNode = head;
                while (currentNode.Next != tail)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = null;
                tail = currentNode;
            }

            count--;
        }

        public void Print()
        {
            Node current = head;

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}
