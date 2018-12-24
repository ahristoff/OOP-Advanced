using System;

namespace _3_Generic_Scale
{
    public class Scale<T>
        where T : IComparable<T>
    {
        private T left;
        private T right;

        public Scale(T left, T right)
        {
            this.right = right;
            this.left = left;
        }

        public T GetHeavier()
        {
            if (left.CompareTo(right) > 0)
            {
                return left;
            }

            else if (left.CompareTo(right) < 0)
            {
                return right;
            }

            else
            {
                return default(T);
            }
        }
    }
}

