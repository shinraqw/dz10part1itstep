using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dz10part1
{
    public class Task3<T>
    {
        private T[] elements;
        private int front;
        private int rear;
        private int count;

        public int Count { get { return count; } }
        public int Capacity { get { return elements.Length; } }
        public bool Empty { get { return count == 0; } }
        public bool Full { get { return count == elements.Length; } }

        public Task3(int cap)
        {
            if (cap <= 0)
            {
                Console.WriteLine("Error!");
                Environment.Exit(0);
            }
            elements = new T[cap];
            front = 0;
            rear = -1;
            count = 0;
        }

        public void Enqueue(T item)
        {
            if (Full)
            {
                Console.WriteLine(" queue is full");
                Environment.Exit(0);
            }
            rear = (rear + 1) % elements.Length;
            elements[rear] = item;
            count++;
        }

        public T Dequeue()
        {
            if (Empty)
            {
                Console.WriteLine(" queue is empty");
                Environment.Exit(0);
            }
            T dequeuedItem = elements[front];
            elements[front] = default(T);
            front = (front + 1) % elements.Length;
            count--;

            return dequeuedItem;
        }

        public T Peek()
        {
            if (Empty)
            {
                Console.WriteLine(" queue is empty");
                Environment.Exit(0);
            }
            return elements[front];
        }
    }
}
