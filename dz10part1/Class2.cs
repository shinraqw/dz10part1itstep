using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz10part1
{
    public class Task2<T>
    {
        public List<T> element;
        public Func<T, T, int> com;

        public int Count_element { get { return element.Count; } }

        public Task2()
        {
            element = new List<T>();
        }

        public Task2(Func<T, T, int> comparison) : this()
        {
            this.com = comparison;
        }

        public void Enqueue(T item)
        {
            element.Add(item);
            int currentIndex = Count_element - 1;

            while (currentIndex > 0)
            {
                int mainIndex = (currentIndex - 1) / 2;

                if (com(element[currentIndex], element[mainIndex]) >= 0)
                    break;

                Swap(currentIndex, mainIndex);
                currentIndex = mainIndex;
            }
        }

        public T Dequeue()
        {
            if (Count_element == 0)
            {
                Console.WriteLine("The queue is empty");
                Environment.Exit(0);
            }

            T frontElement = element[0];
            int lastIndex = Count_element - 1;
            element[0] = element[lastIndex];
            element.RemoveAt(lastIndex);

            int currentIndex = 0;
            while (true)
            {
                int leftIndex = 2 * currentIndex + 1;
                int rightIndex = 2 * currentIndex + 2;
                int smallIndex = currentIndex;

                if (leftIndex < Count_element && com(element[leftIndex], element[smallIndex]) < 0)
                    smallIndex = leftIndex;

                if (rightIndex < Count_element && com(element[rightIndex], element[smallIndex]) < 0)
                    smallIndex = rightIndex;

                if (smallIndex == currentIndex)
                    break;

                Swap(currentIndex, smallIndex);
                currentIndex = smallIndex;
            }
            return frontElement;
        }

        public T Peek()
        {
            if (Count_element == 0)
            {
                Console.WriteLine("queue is empty");
                Environment.Exit(0);
            }
            return element[0];
        }

        private void Swap(int index_1, int index_2)
        {
            T t = element[index_1];
            element[index_1] = element[index_2];
            element[index_2] = t;
        }
    }
}
