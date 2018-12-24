using System;
using System.Collections.Generic;

namespace _3_Generic_Swap_Method_Strings
{
    public class Box<T>
    {
        private List<T> boxValue;

        public Box()
        {
            this.boxValue = new List<T>();
        }

        public void AddElement(T element)
        {
            boxValue.Add(element);
        }

        public void SwapElement(int index1, int index2)
        {
            var elem = boxValue[index1];
            boxValue[index1] = boxValue[index2];
            boxValue[index2] = elem;
        }

        public void PrintElements()
        {
            foreach (var x in this.boxValue)
            {
                Console.WriteLine($"{x.GetType().FullName}: {x}");
            }
        }
    }
}

