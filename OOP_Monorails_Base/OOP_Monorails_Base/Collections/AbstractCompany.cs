using System;
using System.Drawing;
using OOP_Monorails_Base.Drawnings;

namespace OOP_Monorails_Base.Collections
{
    /// <summary>
    /// Абстрактный класс описания компании (Депо)
    /// </summary>
    public abstract class AbstractCompany
    {
        // Размеры ячейки для одного монорельса
        protected readonly int _placeSizeWidth;
        protected readonly int _placeSizeHeight;

        // Размеры области рисования
        protected readonly int _pictureWidth;
        protected readonly int _pictureHeight;

        // Сама коллекция (связь через интерфейс - паттерн Мост)
        protected ICollectionGenericObjects<DrawingMonorail> _collection;

        public AbstractCompany(int pictureWidth, int pictureHeight, int placeSizeWidth, int placeSizeHeight, ICollectionGenericObjects<DrawingMonorail> collection)
        {
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
            _placeSizeWidth = placeSizeWidth;
            _placeSizeHeight = placeSizeHeight;
            _collection = collection;

            // Вычисляем, сколько монорельсов влезет в депо
            _collection.MaxCount = CalcMaxCount();
        }

        // Перегрузка оператора + для добавления монорельса
        public static bool operator +(AbstractCompany company, DrawingMonorail monorail)
        {
            return company._collection.InsertObject(monorail);
        }

        // Перегрузка оператора - для удаления по позиции
        public static bool operator -(AbstractCompany company, int position)
        {
            return company._collection.RemoveObject(position);
        }

        // Метод получения случайного монорельса из депо (для тестов)
        public DrawingMonorail? GetRandomObject()
        {
            Random random = new();
            int maxCount = CalcMaxCount();
            int counter = 500; // Попытки найти непустую ячейку

            while (counter > 0)
            {
                var obj = _collection.GetObject(random.Next(0, maxCount));
                if (obj != null) return obj;
                counter--;
            }
            return null;
        }

        // Метод отрисовки всего депо
        public Bitmap Show()
        {
            Bitmap bitmap = new(_pictureWidth, _pictureHeight);
            using Graphics g = Graphics.FromImage(bitmap);
            DrawBackground(g);
            DrawObjects(g);
            return bitmap;
        }

        // Абстрактные методы, которые реализует MonorailStation
        protected abstract void DrawBackground(Graphics g);
        protected abstract void DrawObjects(Graphics g);

        // Расчет максимального количества мест (сетка)
        private int CalcMaxCount() => (_pictureWidth / _placeSizeWidth) * (_pictureHeight / _placeSizeHeight);
    }
}