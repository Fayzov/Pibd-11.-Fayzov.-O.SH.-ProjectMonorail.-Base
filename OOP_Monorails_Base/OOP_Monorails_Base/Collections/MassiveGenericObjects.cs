using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Monorails_Base.Collections
{
    /// <summary>
    /// Параметризованный набор объектов, реализованный на массиве
    /// </summary>
    /// <typeparam name="T">Ограничение - ссылочный тип</typeparam>
    public class MassiveGenericObjects<T> : ICollectionGenericObjects<T> where T : class
    {
        // Массив объектов, которые храним
        private T?[] _collection;

        // Конструктор: инициализируем пустой массив
        public MassiveGenericObjects()
        {
            _collection = Array.Empty<T>();
        }

        // Свойство: установка максимального размера хранилища
        public int MaxCount
        {
            set
            {
                if (value > 0)
                {
                    Array.Resize(ref _collection, value);
                }
            }
        }

        // Свойство: подсчет только не-null объектов в массиве
        public int CountObjects
        {
            get
            {
                int count = 0;
                foreach (var item in _collection)
                {
                    if (item is not null) count++;
                }
                return count;
            }
        }

        // Получение объекта по индексу с проверкой границ
        public T? GetObject(int position)
        {
            if (position < 0 || position >= _collection.Length) return null;
            return _collection[position];
        }

        // Вставка в начало (по умолчанию)
        public bool InsertObject(T obj) => InsertObject(obj, 0);

        // Реализация сложной логики вставки (поиск ближайшего места)
        public bool InsertObject(T obj, int position)
        {
            if (position < 0 || position >= _collection.Length) return false;

            // 1. Если место свободно - занимаем
            if (_collection[position] == null)
            {
                _collection[position] = obj;
                return true;
            }

            // 2. Ищем свободное место СПРАВА
            for (int i = position + 1; i < _collection.Length; i++)
            {
                if (_collection[i] == null)
                {
                    _collection[i] = obj;
                    return true;
                }
            }

            // 3. Ищем свободное место СЛЕВА
            for (int i = position - 1; i >= 0; i--)
            {
                if (_collection[i] == null)
                {
                    _collection[i] = obj;
                    return true;
                }
            }

            // Если свободных мест нет вообще
            return false;
        }

        // Удаление объекта (просто зануляем ячейку)
        public bool RemoveObject(int position)
        {
            if (position < 0 || position >= _collection.Length || _collection[position] == null)
            {
                return false;
            }
            _collection[position] = null;
            return true;
        }
    }
}