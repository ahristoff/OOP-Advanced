using System;
using System.Collections;
using System.Collections.Generic;

namespace _3_Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> list;

        public CustomStack()
        {
            list = new List<T>();
        }

        public void Push(List<T> elements)
        {

            for (int i = 0; i < elements.Count; i++)
            {
                list.Add(elements[i]);
            }
        }

        public void Pop()
        {

            if (this.list.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            list.RemoveAt(list.Count - 1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = list.Count - 1; i >= 0; i--)
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
