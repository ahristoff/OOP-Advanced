using System;
using System.Collections.Generic;

namespace _5_Generic_Count_Method_Strings
{
    public class Box<T>
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

        public void Compare<T>(T baseElement, List<T> boxValue)
            where T : IComparable<T>
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