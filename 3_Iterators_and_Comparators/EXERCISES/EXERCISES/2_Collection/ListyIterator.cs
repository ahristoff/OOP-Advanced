using System;
using System.Collections;
using System.Collections.Generic;

namespace _2_Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly List<T> list;
        private int currElement;

        public ListyIterator()
        {
            this.list = new List<T>();
            currElement = 0;
        }

        public void Create(List<T> elements)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                list.Add(elements[i]);
            }
        }

        public bool Move()
        {
            var canMove = currElement < list.Count - 1;

            if (canMove)
            {
                currElement++;
            }

            return canMove;
        }

        public bool HasNext()
        {
            return currElement < list.Count - 1;
        }

        public void Print()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(list[currElement]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

