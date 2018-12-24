using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Database
{
    public class DataBase
    {
        private const int MaxCapacity = 16;

        private List<int> collection;
        private int count;

        public DataBase(params int[] elements)
        {
            Collection = new List<int>(elements);
            Count = Collection.Count;
        }
        public int Count
        {
            get { return count; }
            set
            {
                if (value > MaxCapacity)
                {
                    throw new InvalidOperationException($"Collection capacity cannot exceed {MaxCapacity}!");
                }
                else if (value <= 0)
                {
                    throw new InvalidOperationException("Collection capacity cannot be null");
                }
                count = value;
            }
        }

        public List<int> Collection
        {
            get { return collection; }
            set { collection = value; }
        }

        public void Add(int element)
        {
            if (Count >= 16)
            {
                throw new InvalidOperationException($"Cannot add more than 16 elements to the collection!");
            }

            Collection.Add(element);
            Count++;
        }

        public void Remove()
        {

            if (Count == 0)
            {
                throw new InvalidOperationException("Cannot remove an element from an empty collection!");
            }

            Collection.RemoveAt(collection.Count - 1);
            Count--;
        }

        public int[] Fetch()
        {

            if (Count == 0)
            {
                return new int[0];
            }

            return Collection.ToArray();
        }
    }
}