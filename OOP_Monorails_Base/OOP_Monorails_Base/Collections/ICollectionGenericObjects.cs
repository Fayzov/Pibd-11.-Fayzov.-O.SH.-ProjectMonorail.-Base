using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Monorails_Base.Collections
{
    /// <summary>
    /// Интерфейс описания действий для набора хранимых объектов
    /// </summary>
    /// <typeparam name="T">Параметр: ограничение - ссылочный тип</typeparam>
    public interface ICollectionGenericObjects<T> where T : class
    {
        /// <summary>
        /// Количество объектов в коллекции
        /// </summary>
        int CountObjects { get; }

        /// <summary>
        /// Установка максимального количества элементов в коллекции
        /// </summary>
        int MaxCount { set; }

        /// <summary>
        /// Получение объекта по позиции
        /// </summary>
        /// <param name="position">Позиция</param>
        /// <returns>Объект</returns>
        T? GetObject(int position);

        /// <summary>
        /// Добавление объекта в коллекцию (в начало или на свободное место)
        /// </summary>
        /// <param name="obj">Добавляемый объект</param>
        /// <returns>true - вставка прошла удачно</returns>
        bool InsertObject(T obj);

        /// <summary>
        /// Добавление объекта в коллекцию на конкретную позицию
        /// </summary>
        /// <param name="obj">Добавляемый объект</param>
        /// <param name="position">Позиция</param>
        /// <returns>true - вставка прошла удачно</returns>
        bool InsertObject(T obj, int position);

        /// <summary>
        /// Удаление объекта из коллекции с конкретной позиции
        /// </summary>
        /// <param name="position">Позиция</param>
        /// <returns>true - удаление прошло удачно</returns>
        bool RemoveObject(int position);
    }
}
