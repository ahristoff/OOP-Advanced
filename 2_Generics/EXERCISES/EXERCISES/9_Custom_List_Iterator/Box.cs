using System;
using System.Collections.Generic;
using System.Linq;

namespace _9_Custom_List_Iterator
{
    public class Box<T>
        where T : IComparable
    {
        private List<T> box;

        public Box()
            : this(new List<T>())
        {
        }

        public Box(List<T> list)
        {
            this.box = list;
        }

        private int Count => this.box.Count;

        private bool IsEmpty => this.Count == 0;

        public List<T> Elements => this.box;

        public void Add(T element)
        {
            this.box.Add(element);
        }

        public T Remove(int index)
        {
            if (this.IsEmpty)
            {
                throw new ArgumentException("Empty list!");
            }
            if (index < 0 || index > this.Count - 1)
            {
                throw new ArgumentException("Invalid index!");
            }

            var removedElement = this.box[index];
            this.box.RemoveAt(index);
            return removedElement;
        }

        public bool Contains(T element)
        {
            return this.box.Contains(element);
        }

        public void Swap(int index1, int index2)
        {
            if (index1 < 0 || index1 > this.Count - 1 ||
                index2 < 0 || index2 > this.Count - 1)
            {
                throw new ArgumentException("Invalid index!");
            }

            T swappedElement = this.box[index1];
            this.box[index1] = this.box[index2];
            this.box[index2] = swappedElement;
        }

        public int CountGreaterThan(T element)
        {
            return this.box.Count(e => e.CompareTo(element) > 0);
        }

        public T Max()
        {
            if (this.IsEmpty)
            {
                throw new ArgumentException("Empty list!");
            }

            return this.box.Max();
        }

        public T Min()
        {
            if (this.IsEmpty)
            {
                throw new ArgumentException("Empty list!");
            }

            return this.box.Min();
        }

        public void Print()
        {
            foreach (var element in this.box)
            {
                Console.WriteLine(element);
            }
        }
    }
}