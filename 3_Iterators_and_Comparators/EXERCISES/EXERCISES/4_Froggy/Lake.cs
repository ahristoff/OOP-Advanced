using System.Collections;
using System.Collections.Generic;

namespace _4_Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> list;

        public Lake(IList<int> list)
        {
            this.list = new List<int>(list);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i += 2)
            {
                yield return list[i];
            }

            if (list.Count % 2 == 0)
            {
                for (int i = list.Count - 1; i > 0; i -= 2)
                {
                    yield return list[i];
                }
            }

            else
            {
                for (int i = list.Count - 2; i > 0; i -= 2)
                {
                    yield return list[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

