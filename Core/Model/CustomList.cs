using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class CustomList<T>
    {
        private T[] items;
        private int _count;
        private int _capacity;

        public T this[int index] => items[index];
        public int Count => _count;
        public int Capacity => _capacity;


        public void Add(T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (_count == _capacity)
                {
                    _capacity *= 2;
                }
                    

                Array.Resize(ref items, items.Length + 1);
                items[items.Length] = item;
            }
        }
        
        public T Find(Predicate<T> method)
        {
            foreach (T item in items)
            {
                if (method(item))
                    return item;
            }
            return default;
        }

        public List<T> FindAll(Predicate<T> match)
        {
            List<T> foundItems = new List<T>();
            foreach (T item in items)
            {
                if (match(item))
                    foundItems.Add(item);
            }
            return foundItems;
        }

        public void RemoveAll(Predicate<T> match)
        {
            for (int i = 0; i < _count; i++)
            {
                if (match(items[i]))
                {

                    i--;
                }
            }
        }

        

        public void ForEach(Action<T> action)
        {
            foreach (T item in items)
            {
                action(item);
            }
        }

    }
    
}
