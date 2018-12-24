
namespace _2_Generic_Array_Creator
{
    public static class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            var items = new T[length];

            for (int i = 0; i < length; i++)
            {
                items[i] = item;
            }

            return items;
        }
    }
}
