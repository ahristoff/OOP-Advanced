namespace _Iterator_Test
{
    using System;
    using System.Collections.Generic;

    public class ListIterator
    {
        private string[] collection;
        private int currentIndex = 0;

        public ListIterator(string[] collection)
        {
            this.NullValidation(collection);
            this.collection = collection;
        }

        private void NullValidation(IList<string> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }
        }

        public bool Move() => this.currentIndex++ < this.collection.Length - 1;

        public bool HasNext() => this.currentIndex < this.collection.Length - 1;

        public string Print()
        {
            if (this.collection.Length == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            return this.collection[this.currentIndex];
        }
    }
}
