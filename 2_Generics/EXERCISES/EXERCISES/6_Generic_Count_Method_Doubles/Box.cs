using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Generic_Count_Method_Doubles
{
    public class Box<T>
    where T : IComparable<T>
    {
        private List<T> boxValue;
        private int count;

        public Box()
        {
            this.boxValue = new List<T>();
        }

        public void AddElement(T element)
        {
            boxValue.Add(element);
        }

        public void Compare(T baseElement, List<T> boxValue)
        {
            foreach (var x in boxValue)
            {
                if (baseElement.CompareTo(x) < 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}