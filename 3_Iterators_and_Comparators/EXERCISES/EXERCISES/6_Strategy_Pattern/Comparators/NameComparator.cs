using System.Collections.Generic;

namespace _6_Strategy_Pattern.Comparators
{
    public class NameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Name.Length != y.Name.Length)
            {
                return x.Name.Length - y.Name.Length;
            }

            if (x.Name[0].ToString().ToUpper() != y.Name[0].ToString().ToUpper())
            {
                return x.Name[0].ToString().ToUpper().CompareTo(y.Name[0].ToString().ToUpper());
            }

            return 0;
        }
    }
}

