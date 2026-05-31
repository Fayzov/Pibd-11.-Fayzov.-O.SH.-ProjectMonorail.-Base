using System;
using System.Collections.Generic;

namespace OOP_Monorails_Base.Collections
{
    /// <summary>
    /// Параметризованный набор объектов на базе списка List
    /// </summary>
    public class ListGenericObjects<T> : ICollectionGenericObjects<T> where T : class
    {
        private readonly List<T> _collection;
        private int _maxCount;

        public ListGenericObjects()
        {
            _collection = new List<T>();
        }

        public int CountObjects => _collection.Count;

        public int MaxCount
        {
            set { if (value > 0) _maxCount = value; }
        }

        public T? GetObject(int position)
        {
            if (position < 0 || position >= _collection.Count) return null;
            return _collection[position];
        }

        public bool InsertObject(T obj)
        {
            if (_collection.Count >= _maxCount) return false;
            _collection.Add(obj);
            return true;
        }

        public bool InsertObject(T obj, int position)
        {
            if (position < 0 || position > _collection.Count || _collection.Count >= _maxCount) return false;
            _collection.Insert(position, obj);
            return true;
        }

        public bool RemoveObject(int position)
        {
            if (position < 0 || position >= _collection.Count) return false;
            _collection.RemoveAt(position);
            return true;
        }
    }
}