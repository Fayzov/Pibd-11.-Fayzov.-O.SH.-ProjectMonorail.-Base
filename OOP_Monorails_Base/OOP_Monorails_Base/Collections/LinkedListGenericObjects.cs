using System;
using System.Collections.Generic;

namespace OOP_Monorails_Base.Collections
{
    /// <summary>
    /// Параметризованный набор объектов на базе связанного списка LinkedList
    /// </summary>
    public class LinkedListGenericObjects<T> : ICollectionGenericObjects<T> where T : class
    {
        private readonly LinkedList<T> _collection;
        private int _maxCount;

        public LinkedListGenericObjects()
        {
            _collection = new LinkedList<T>();
        }

        public int CountObjects => _collection.Count;

        public int MaxCount
        {
            set { if (value > 0) _maxCount = value; }
        }

        public T? GetObject(int position)
        {
            if (position < 0 || position >= _collection.Count) return null;
            var curr = _collection.First;
            for (int i = 0; i < position; i++) curr = curr?.Next;
            return curr?.Value;
        }

        public bool InsertObject(T obj)
        {
            if (_collection.Count >= _maxCount) return false;
            _collection.AddLast(obj);
            return true;
        }

        public bool InsertObject(T obj, int position)
        {
            if (position < 0 || position > _collection.Count || _collection.Count >= _maxCount) return false;
            if (position == _collection.Count) return InsertObject(obj);

            var curr = _collection.First;
            for (int i = 0; i < position; i++) curr = curr?.Next;

            if (curr != null) _collection.AddBefore(curr, obj);
            return true;
        }

        public bool RemoveObject(int position)
        {
            if (position < 0 || position >= _collection.Count) return false;
            var curr = _collection.First;
            for (int i = 0; i < position; i++) curr = curr?.Next;

            if (curr != null) _collection.Remove(curr);
            return true;
        }
    }
}
