using System;
using System.Collections.Generic;

namespace CollectionList
{
    class Inventory<T> : IEnumerable<T>
    {
        T[] items = new T[10];
        int count = 0;

        public void AddJersey(T item)
        {
            if (count == (items.Length / 2))
            {
                T[] newArray = new T[items.Length * 2];

                for (int i = 0; i < items.Length; i++)
                {
                    newArray[i] = items[i];
                }

                items = newArray;

            }
            items[count] = item;


            count++;
        }

        public void RemoveJersey(T item)
        {
            int j = 0;
            T[] newArray = new T[items.Length / 2];
            for (int i = 0; i < items.Length; i++)
            {
                if (!item.Equals(items[j]))
                {
                    if (j > count) return;
                    newArray[i] = items[j];
                    j++;
                }
                else
                {
                    j++;
                }
            }

            public IEnumerator<T> GetEnumerator()
            {
                for (int i = 0; i < count; i++)
                {
                    yield return items[i];
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
                {
                return GetEnumerator();
            }
        }

        internal object Remove(int input)
        {
            throw new NotImplementedException();
        }

        internal void Add(object p)
        {
            throw new NotImplementedException();
        }
    }
}