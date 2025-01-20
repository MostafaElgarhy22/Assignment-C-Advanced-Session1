using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C__Advanced_Session1.Q_5
{
    public class FixedSizeList<T>
    {
        public List<T> elements;
        public int capacity;

        public FixedSizeList(int capacity)
        {
            this.capacity = capacity;
            elements = new List<T>(capacity);
        }

        public void Add(T item)
        {
            if (elements.Count >= capacity)
            {
                Console.WriteLine("List is full of elements ");
                return;
            }

            elements.Add(item);
        }

        public T Get(int index)
        {
            return elements[index];
        }

        public int Count => elements.Count;

        public int Capacity => capacity;
    }

}
