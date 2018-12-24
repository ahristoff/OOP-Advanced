using System;
using System.Collections.Generic;
using System.Linq;

namespace _7_Custom_List
{
    public class Box<T>
    where T : IComparable<T>
    {
        private List<T> boxValue;
        private int count;

        public Box()
        {
            boxValue = new List<T>();
        }

        public void AddElement(T element)
        {
            boxValue.Add(element);
        }

        public void RemoveElement(int index)
        {
            boxValue.RemoveAt(index);
        }

        public void ContainElement(T element)
        {
            if (boxValue.Contains(element))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public void SwapElement(int index1, int index2)
        {
            var element = boxValue[index1];
            boxValue[index1] = boxValue[index2];
            boxValue[index2] = element;
        }
        public void GreaterElement(T baseElement)
        {
            count = 0;

            foreach (var x in boxValue)
            {
                if (baseElement.CompareTo(x) < 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        public void MaxElement()
        {
            var max = boxValue.Max(b => b);
            Console.WriteLine(max);
        }

        public void MinElement()
        {
            var min = boxValue.Min(b => b);
            Console.WriteLine(min);
        }

        public void PrintElements()
        {
            Console.WriteLine(string.Join("\n", boxValue));
        }
    }
}
