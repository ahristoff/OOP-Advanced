using System;
using System.Linq;

namespace _9_Custom_List_Iterator
{
    public class Sorter
    {
        public static Box<T> Sort<T>(Box<T> list)
            where T : IComparable
        {
            var sortedList = list.Elements
                                 .OrderBy(e => e)
                                 .ToList();
            return new Box<T>(sortedList);
        }
    }
}