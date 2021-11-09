using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_8_Collections
{
    public class SortedList<T> : ICollection<T> where T : IComparable
    {
        public List<T> List { get; set; } = new List<T>();
        
        public IEnumerator<T> GetElementsReversed()
        {
            return new ReverseListEnumerator<T>(List);
        }

        public IEnumerator<T> GetElements(Predicate<T> f)
        {
            return new PredicateEnumerator<T>(List, f);
        }
        
        public int Count => ((ICollection<T>)List).Count;

        public bool IsReadOnly => ((ICollection<T>)List).IsReadOnly;

        public void Add(T item)
        {
            ((ICollection<T>)List).Add(item);
            List.Sort();
        }

        public void Clear()
        {
            ((ICollection<T>)List).Clear();
        }

        public bool Contains(T item)
        {
            return ((ICollection<T>)List).Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((ICollection<T>)List).CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return ((ICollection<T>)List).Remove(item);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)List).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)List).GetEnumerator();
        }
    }
}
