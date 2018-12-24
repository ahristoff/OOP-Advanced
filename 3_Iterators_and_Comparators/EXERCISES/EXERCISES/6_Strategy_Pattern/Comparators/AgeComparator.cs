using System.Collections.Generic;

namespace _6_Strategy_Pattern.Comparators
{
    public class AgeComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Age != y.Age)
            {
                return x.Age - y.Age;
            }

            return 0;
        }
    }
}

