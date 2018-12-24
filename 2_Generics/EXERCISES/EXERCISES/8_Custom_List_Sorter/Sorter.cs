using System;
using System.Linq;

namespace _8_Custom_List_Sorter
{
    public class Sorter
    {
        public Box<T> Sort<T>(Box<T> list)
                where T : IComparable
        {
            var sortedList = list.Elements.OrderBy(l => l).ToList();

            return new Box<T>(sortedList);
        }
    }
}
