using System;
using System.Collections.Generic;

namespace _1_ListyIterator
{
    public class ListyIterator<T>
    {
        private readonly List<T> list;
        private int currElement;

        public ListyIterator()
        {
            this.list = new List<T>();
            currElement = 0;
        }

        public void Create(List<T> element)
        {
            for (int i = 0; i < element.Count; i++)
            {
                list.Add(element[i]);
            }
        }

        public void Move()
        {
            var canMove = currElement < list.Count - 1;

            if (canMove)
            {
                currElement++;
                Console.WriteLine(canMove);
                return;
            }

            Console.WriteLine(canMove);
        }

        public void HasNext()
        {
            bool x = currElement < list.Count - 1;

            Console.WriteLine(x);
        }

        public void Print()
        {

            if (list.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(list[currElement]);
        }
    }
}

